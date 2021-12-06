using BobcatMonitor.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobcatMonitor
{
    public partial class BobcatWindowsMonitor : Form
    {       

        int gap = 0;
        bool monitoringStopped = false;
        public BobcatWindowsMonitor()
        {
            InitializeComponent();
            comboBoxResetOperation.SelectedIndex = 0;
            buttonStopMonitoring.Enabled = false;
            checkBoxArmed.Appearance = System.Windows.Forms.Appearance.Button;

            checkBoxArmed.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxArmed.MinimumSize = new Size(75, 25); //To prevent shrinkage!

            buttonResync.Enabled = false;
            buttonFastSync.Enabled = false;
            buttonReboot.Enabled = false;
            buttonReset.Enabled = false;

            this.Icon = ((System.Drawing.Icon)Resources.ResourceManager.GetObject("recycler_red"));
           // this.Icon = Resources.recycler_red;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SetRichTextBoxStatus("Refreshing data...");

            Task task = Task.Factory.StartNew(() =>
            {
                GetData();
                SetRichTextBoxStatus("Refreshed");
            });
            

        }

        delegate void SetTextCallback(string text, bool clear);
        delegate void setButtonEnabledCallback(bool enabled);

        bool GetData()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    var deserializedStatus = new Object();
                    var minerjson = wc.DownloadString("http://" + textBoxIpAddress.Text + "/miner.json");
                    var statusjson = wc.DownloadString("http://" + textBoxIpAddress.Text + "/status.json");

                    var miner = JsonConvert.DeserializeObject<dynamic>(minerjson);
                    var status = JsonConvert.DeserializeObject<dynamic>(statusjson);

                    try
                    {
                        gap = Convert.ToInt32(Convert.ToInt32(status.blockchain_height) - Convert.ToInt32(status.miner_height));
                        SetLabelGapResult(gap.ToString());
                    }
                    catch (Exception ex)
                    {
                        SetRichTextBoxStatus("Get data from miner - Gap: " + ex.Message);
                        SetLabelGapResult("-");
                    }

                    try
                    {
                        var minerHeight = Convert.ToString(status.miner_height);
                        SetLabelMinerHeight(minerHeight);
                    }
                    catch (Exception ex)
                    {
                        SetLabelMinerHeight("-");
                    }

                    try
                    {
                        var blockchainHeight = Convert.ToString(status.blockchain_height);
                        SetLabelBlockchainHeight(blockchainHeight);
                    }
                    catch (Exception ex)
                    {                        
                        SetLabelBlockchainHeight("-");
                    }


                    var lastUpdate = DateTime.Now.ToLongTimeString();
                    SetLabelLastUpdateResult(lastUpdate);

                    try
                    {
                        var temp0 = GetNumbers(Convert.ToString(miner.temp0));
                        SetLabelTemp0Result(temp0);
                    }
                    catch (Exception ex)
                    {
                        SetLabelTemp0Result("-");
                    }

                    try
                    {
                        var temp1 = GetNumbers(Convert.ToString(miner.temp1));
                        SetLabelTemp1Result(temp1);
                    }
                    catch (Exception ex)
                    {
                        SetLabelTemp1Result("-");
                    }

                    try
                    {
                        var animal = Convert.ToString(miner.animal);
                        SetLabelAnimal(animal);
                    }
                    catch (Exception ex)
                    {
                        // No need to do anything
                    }

                    try
                    {
                        var otaVersion = Convert.ToString(miner.ota_version);
                        SetLabelOtaVersionResult(otaVersion);
                    }
                    catch (Exception ex)
                    {
                        // No need to do anything
                    }

                    try
                    {
                        var minerState = Convert.ToString(miner.miner.State);
                        SetLabelStateResult(minerState);
                    }
                    catch (Exception ex)
                    {
                        SetLabelStateResult("-");
                    }

                    try
                    {
                        var minerStatus = Convert.ToString(miner.miner.Status);
                        SetLabelStatusResult(minerStatus);
                    }
                    catch (Exception ex)
                    {
                        SetLabelStatusResult("-");
                    }

                    try
                    {
                        var errors = Convert.ToString(miner.errors);
                        SetLabelErrorsResult(errors);
                    }
                    catch (Exception ex)
                    {
                        SetLabelErrorsResult("-");
                    }



                }

                return true;
            }

            catch (WebException ex)
            {
                SetRichTextBoxStatus("Get data from miner error:" + ex.Message);
                return false;               
            }

            catch (Exception ex)
            {

                SetRichTextBoxStatus("Get data from miner error:" + ex.Message);
                return false;               
            }
        }

      
        static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }


        private void SetRichTextBoxStatus(string text, bool clear = false)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBoxStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRichTextBoxStatus);
                this.Invoke(d, new object[] { text, false });
            }
            else
            {
                  if (clear)
                      this.richTextBoxStatus.Text = string.Empty;

                var longTimeString = DateTime.Now.ToLongTimeString();
                var shortDateString = DateTime.Now.ToShortDateString();

                this.richTextBoxStatus.Text += ("\n" + shortDateString + " " +longTimeString + "  " +  text);
            }
        }

        private void SetLabelGapResult(string text, bool clear = false)
        {
            if (this.labelGapResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelGapResult);
                this.Invoke(d, new object[] { text, false });
            }
            else
            {

                if (Convert.ToInt32(text) > 10)
                {
                    this.labelGapResult.ForeColor = Color.Red;                    
                    this.Icon = ((System.Drawing.Icon)Resources.ResourceManager.GetObject("recycler_red"));
                }
                else
                {
                    this.labelGapResult.ForeColor = Color.Green;
                    this.Icon = ((System.Drawing.Icon)Resources.ResourceManager.GetObject("recycler_green"));                    
                }

                this.labelGapResult.Text = text;
            }
        }


        private void SetLabelMinerHeight(string text, bool clear = false)
        {
            if (this.labelMinerHeightResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelMinerHeight);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelMinerHeightResult.Text = text;
            }
        }


        private void SetLabelBlockchainHeight(string text, bool clear = false)
        {
            if (this.labelBlockchainHeightResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelBlockchainHeight);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelBlockchainHeightResult.Text = text;
            }
        }



        private void SetLabelTemp0Result(string text, bool clear = false)
        {
            if (this.labelTemp0Result.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelTemp0Result);
                this.Invoke(d, new object[] { text, false });
            }
            else
            {

                if (Convert.ToInt32(text) > 70)
                {
                    this.labelTemp0Result.ForeColor = Color.DarkOrange;
                }
                else if (Convert.ToInt32(text) > 80)
                {
                    this.labelTemp0Result.ForeColor = Color.Red;
                }
                else 
                {
                    this.labelTemp0Result.ForeColor = Color.Black;
                }

                this.labelTemp0Result.Text = text;
            }
        }

        private void SetLabelTemp1Result(string text, bool clear = false)
        {
            if (this.labelTemp1Result.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelTemp1Result);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                if (Convert.ToInt32(text) > 70)
                {
                    this.labelTemp1Result.ForeColor = Color.DarkOrange;
                }
                else if (Convert.ToInt32(text) > 80)
                {
                    this.labelTemp1Result.ForeColor = Color.Red;
                }
                else
                {
                    this.labelTemp1Result.ForeColor = Color.Black;
                }

                this.labelTemp1Result.Text = text;
            }
        }

        private void SetLabelLastUpdateResult(string text, bool clear = false)
        {
            if (this.labelLastUpdateResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelLastUpdateResult);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelLastUpdateResult.Text = text;
            }
        }

        private void SetLabelAnimal(string text, bool clear = false)
        {
            if (this.labelAnimal.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelAnimal);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelAnimal.Text = text;
            }
        }

        private void SetLabelOtaVersionResult(string text, bool clear = false)
        {
            if (this.labelOtaVersionResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelOtaVersionResult);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelOtaVersionResult.Text = text;
            }
        }

        private void SetLabelStateResult(string text, bool clear = false)
        {
            if (this.labelStateResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelStateResult);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelStateResult.Text = text;
            }
        }

        private void SetLabelStatusResult(string text, bool clear = false)
        {
            if (this.labelStatusResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelStatusResult);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelStatusResult.Text = text;
            }
        }

        private void SetLabelErrorsResult(string text, bool clear = false)
        {
            if (this.labelErrorsResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelErrorsResult);
                this.Invoke(d, new object[] { text, clear });
            }
            else
            {
                this.labelErrorsResult.Text = text;
            }
        }


        private void SetStartButtonEnabled(bool enabled = true)
        {
            if (this.buttonStart.InvokeRequired)
            {
                setButtonEnabledCallback d = new setButtonEnabledCallback(SetStartButtonEnabled);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.buttonStart.Enabled = enabled;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxIpAddress.Text))
                    throw new Exception("Please enter your Bobcat miner valid IP adress in settings tab.");

                if (string.IsNullOrWhiteSpace(textBoxAuthorizationKey.Text) ||
                    string.IsNullOrWhiteSpace(textBoxRefreshInterval.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDelay.Text) ||
                    string.IsNullOrWhiteSpace(textBoxGap.Text) ||
                    string.IsNullOrWhiteSpace(textBoxWaitAfterCycle.Text) )
                    throw new Exception("Please fill all parameters in settings tab.");                    

                SetRichTextBoxStatus("Monitoring started.");

                buttonStart.Enabled = false;
                buttonStopMonitoring.Enabled = true;

                Task task = Task.Factory.StartNew(() =>
                {
                for (; ; )
                {
                    var getDataResult = GetData();

                        try
                        { 
                            int selectedOperation = 0;
                            comboBoxResetOperation.Invoke(new Action(() => selectedOperation = comboBoxResetOperation.SelectedIndex));


                            if (getDataResult && (gap >= Convert.ToInt32(textBoxGap.Text)) && selectedOperation > 0)
                            {
                                if (selectedOperation == 2)
                                {
                                    SetRichTextBoxStatus("Gap is " + gap + " !" + " Reseting miner... Waiting " + textBoxDelay.Text + " minutes.", false);
                                    reset();

                                    Thread.Sleep(Convert.ToInt32(textBoxDelay.Text) * 1000 * 60);
                                }

                                if ((selectedOperation == 1) || (selectedOperation == 2))
                                {
                                    SetRichTextBoxStatus("Resyncing miner... Waiting " + textBoxDelay.Text + " minutes.", false);
                                    resync();
                                    Thread.Sleep(Convert.ToInt32(textBoxDelay.Text) * 1000 * 60);
                                }


                                getDataResult = GetData();

                                if ((selectedOperation == 1) || (selectedOperation == 2) || (selectedOperation == 3))
                                {

                                    var fastSyncGapThreshold = Convert.ToInt32(textBoxFastSyncGapThreshold.Text);

                                    if (getDataResult && (gap <= fastSyncGapThreshold))
                                    {
                                        SetRichTextBoxStatus("No need to run Fast sync. Gap is lower than " + textBoxFastSyncGapThreshold.Text, false);
                                    }
                                    else if (getDataResult && (gap > 0))
                                    {
                                        SetRichTextBoxStatus("Fast syncing miner...", false);
                                        fastSync();
                                    }
                                    else
                                    {
                                        SetRichTextBoxStatus("Can't read the GAP. Fast sync will not run. You can run it manually later.", false);
                                    }
                                }

                                if (selectedOperation == 4)
                                {
                                    SetRichTextBoxStatus("Rebooting miner...", false);
                                    reboot();
                                }

                                var waitAfterCycle = Convert.ToInt32(textBoxWaitAfterCycle.Text) * 1000 * 60;

                                SetRichTextBoxStatus("Waiting " + textBoxWaitAfterCycle.Text + " minutes.", false);

                                Thread.Sleep(waitAfterCycle);
                            }


                            // I will devide sleep into 500 iterations, so I can finish thread much earlier in case Stop monitoring button is pressed
                            for (int i = 0; i < 500; i++)
                            {
                                Thread.Sleep(Convert.ToInt32(textBoxRefreshInterval.Text) * 60 * 2);

                                if (monitoringStopped)
                                {
                                    SetRichTextBoxStatus("Monitoring stopped.");
                                    monitoringStopped = false; // after stopping need to set this flag to false, otherwise monitoring can't be started
                                    buttonStopMonitoring.Enabled = false;
                                    SetStartButtonEnabled(true);
                                    return;
                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            SetRichTextBoxStatus("Monitoring error: " + ex.Message);
                            SetStartButtonEnabled(true);
                        }

                    }
                });

            }
            catch (Exception ex)
            {
                SetRichTextBoxStatus("Error: " + ex.Message);
            }
        }


        private void reboot()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + textBoxIpAddress.Text + "/admin/reboot");
                httpWebRequest.PreAuthenticate = true;
                //string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                httpWebRequest.Headers.Add("Authorization", "Basic " + textBoxAuthorizationKey.Text);
                httpWebRequest.Method = "post";
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                SetRichTextBoxStatus("Reboot status: " + response.StatusCode, false);
            }
            catch (Exception ex)
            {
             //  This will display only timeout operation, no need to display
                SetRichTextBoxStatus("Reboot status: " + ex.Message);
            }
        }

        private void reset()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + textBoxIpAddress.Text + "/admin/reset");
                httpWebRequest.PreAuthenticate = true;
                //string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                httpWebRequest.Headers.Add("Authorization", "Basic " + textBoxAuthorizationKey.Text);
                httpWebRequest.Method = "post";
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                SetRichTextBoxStatus("Reset status: " + response.StatusCode, false);
            }
            catch (Exception ex)
            {
                //  This will display only timeout operation, no need to display
                  SetRichTextBoxStatus("Reset error status: " + ex.Message);
            }
        }

        private void resync()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + textBoxIpAddress.Text + "/admin/resync");
                httpWebRequest.PreAuthenticate = true;
                //string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                httpWebRequest.Headers.Add("Authorization", "Basic " + textBoxAuthorizationKey.Text);
                httpWebRequest.Method = "post";
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                SetRichTextBoxStatus("Resync status: " + response.StatusCode, false);
            }
            catch (Exception ex)
            {
                //  This will display only timeout operation, no need to display
                  SetRichTextBoxStatus("Resync error status: " + ex.Message);
            }
        }

        private void fastSync()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + textBoxIpAddress.Text + "/admin/fastsync");
                httpWebRequest.PreAuthenticate = true;
                //string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                httpWebRequest.Headers.Add("Authorization", "Basic " + textBoxAuthorizationKey.Text);
                httpWebRequest.Method = "post";
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                SetRichTextBoxStatus("Fast sync status: " + response.StatusCode, false);
            }
            catch (Exception ex)
            {
                //  This will display only timeout operation, no need to display
                   SetRichTextBoxStatus("Fast sync error status: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void buttonResync_Click(object sender, EventArgs e)
        {
            SetRichTextBoxStatus("Resyncing...");
            resync();

        }

        private void buttonFastSync_Click(object sender, EventArgs e)
        {
            SetRichTextBoxStatus("Fast syncing...");
            fastSync();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var longTimeString = DateTime.Now.ToLongTimeString();
            SetRichTextBoxStatus("Reseting...");
            reset();

        }

        private void buttonReboot_Click(object sender, EventArgs e)
        {
            SetRichTextBoxStatus("Rebooting...");
            reboot();
        }

        private void buttonStopMonitoring_Click(object sender, EventArgs e)
        {
            monitoringStopped = true;
            SetRichTextBoxStatus("Stopping monitoring...");
            SetRichTextBoxStatus("Waiting for thread to finish. " + "Wait few seconds or close this app.");

            buttonStopMonitoring.Enabled = false;

        }

        private void tabPageSettings_Click(object sender, EventArgs e)
        {

        }

        private void labelDelay_Click(object sender, EventArgs e)
        {

        }

        private void labelWaitAfterCycle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAuthorizationKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRefreshInterval_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAboutHeliumAddress_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("13bqR1YiBVYqDf7dSD9TDR5qc3X9D4VcsZK7SyccVjezAYxRTeJ");
          
        }

        private void textBoxAboutHNTAddress_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("13bqR1YiBVYqDf7dSD9TDR5qc3X9D4VcsZK7SyccVjezAYxRTeJ");
        }

        private void buttonAboutCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("13bqR1YiBVYqDf7dSD9TDR5qc3X9D4VcsZK7SyccVjezAYxRTeJ");
        }

        private void tabPageAbout_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxStatus_TextChanged(object sender, EventArgs e)
        {
            richTextBoxStatus.SelectionStart = richTextBoxStatus.Text.Length;
            // scroll it automatically
            richTextBoxStatus.ScrollToCaret();
        }

        private void checkBoxArmed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArmed.Text == "UNARMED")
            {
               // checkBoxArmed.BackColor = Color.Yellow; //symbolizes light turned on
                checkBoxArmed.Text = "ARMED";

                buttonResync.Enabled = false;
                buttonFastSync.Enabled = false;
                buttonReboot.Enabled = false;
                buttonReset.Enabled = false;
            }

            else if (checkBoxArmed.Text == "ARMED")
            {
               // checkBoxArmed.BackColor = Color.Crimson; //symbolizes light turned off
                checkBoxArmed.Text = "UNARMED";

                buttonResync.Enabled = true;
                buttonFastSync.Enabled = true;
                buttonReboot.Enabled = true;
                buttonReset.Enabled = true;
            }
        }

        private void tabPageMonitoring_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelAbout1_Click(object sender, EventArgs e)
        {

        }

        private void labelAbout3_Click(object sender, EventArgs e)
        {

        }
    }
}

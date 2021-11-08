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

        string gap = string.Empty;
        bool monitoringStopped = false;
        public BobcatWindowsMonitor()
        {
            InitializeComponent();
            comboBoxResetOperation.SelectedIndex = 2;
            buttonStopMonitoring.Enabled = false;
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
                    var json = wc.DownloadString("http://" + textBoxIpAddress.Text + "/miner.json");
                    var miner = JsonConvert.DeserializeObject<dynamic>(json);

                    gap = Convert.ToString(Convert.ToInt32(miner.blockchain_height) - Convert.ToInt32(miner.miner_height));
                    SetLabelGapResult(gap);
                   
                    var lastUpdate = DateTime.Now.ToLongTimeString();
                    SetLabelLastUpdateResult(lastUpdate);
                    var temp0 = GetNumbers(Convert.ToString(miner.temp0));
                    SetLabelTemp0Result(temp0);
                    var temp1 = GetNumbers(Convert.ToString(miner.temp1));
                    SetLabelTemp1Result(temp1);
                    var animal = Convert.ToString(miner.animal);
                    SetLabelAnimal(animal);

                    var otaVersion = Convert.ToString(miner.ota_version);
                    SetLabelOtaVersionResult(otaVersion);
                    var state = Convert.ToString(miner.miner.State);
                    SetLabelStateResult(state);
                    var status = Convert.ToString(miner.miner.Status);
                    SetLabelStatusResult(status);
                }

                return true;

            }

            catch (WebException ex)
            {
                SetRichTextBoxStatus("Get data from miner:" + ex.Message);
                return false;               
            }

            catch (Exception ex)
            {

                SetRichTextBoxStatus("Get data from miner:" + ex.Message);
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
                }
                else
                {
                    this.labelGapResult.ForeColor = Color.Green;
                }

                this.labelGapResult.Text = text;
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
                    this.labelTemp0Result.ForeColor = Color.Orange;
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
                    this.labelTemp1Result.ForeColor = Color.Orange;
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
                            if (getDataResult && (Convert.ToInt32(gap) >= Convert.ToInt32(textBoxGap.Text)) && comboBoxResetOperation.SelectedIndex > 0)
                            {
                                if (comboBoxResetOperation.SelectedIndex == 1 || comboBoxResetOperation.SelectedIndex == 2)
                                {
                                    SetRichTextBoxStatus("Gap is " + gap + " !" + " Reseting miner... Waiting " + textBoxDelay.Text + " seconds.", false);
                                    reset();
                                    Thread.Sleep(Convert.ToInt32(textBoxDelay.Text) * 1000);
                                }

                                if (comboBoxResetOperation.SelectedIndex == 2)
                                {
                                    SetRichTextBoxStatus("Resyncing miner... Waiting " + textBoxDelay.Text + " seconds.", false);
                                    resync();
                                    Thread.Sleep(Convert.ToInt32(textBoxDelay.Text) * 1000);
                                }

                                SetRichTextBoxStatus("Fast syncing miner...", false);
                                fastSync();
                                var waitAfterCycle = Convert.ToInt32(textBoxWaitAfterCycle.Text) * 1000;

                                SetRichTextBoxStatus("Waiting " + waitAfterCycle / 1000 + " seconds.", false);

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
    }
}

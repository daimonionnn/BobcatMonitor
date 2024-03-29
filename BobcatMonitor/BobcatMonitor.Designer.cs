﻿
namespace BobcatMonitor
{
    partial class BobcatWindowsMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BobcatWindowsMonitor));
            this.tabControlAbout = new System.Windows.Forms.TabControl();
            this.tabPageMonitoring = new System.Windows.Forms.TabPage();
            this.groupBoxManualcontrols = new System.Windows.Forms.GroupBox();
            this.checkBoxArmed = new System.Windows.Forms.CheckBox();
            this.buttonResync = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFastSync = new System.Windows.Forms.Button();
            this.labelErrorsResult = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelMinerHeightResult = new System.Windows.Forms.Label();
            this.labelMinerHeight = new System.Windows.Forms.Label();
            this.labelBlockchainHeightResult = new System.Windows.Forms.Label();
            this.labelBlockchain_height = new System.Windows.Forms.Label();
            this.labelOtaVersionResult = new System.Windows.Forms.Label();
            this.labelOtaVersion = new System.Windows.Forms.Label();
            this.labelStateResult = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelStatusResult = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.buttonStopMonitoring = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTemp1Result = new System.Windows.Forms.Label();
            this.labelTemp0Result = new System.Windows.Forms.Label();
            this.labelLastUpdateResult = new System.Windows.Forms.Label();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.labelGapResult = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.labelGAP = new System.Windows.Forms.Label();
            this.labelTemp0 = new System.Windows.Forms.Label();
            this.labelStatusRichText = new System.Windows.Forms.Label();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSettingsComment3 = new System.Windows.Forms.Label();
            this.labelFastSyncTreshold = new System.Windows.Forms.Label();
            this.textBoxFastSyncGapThreshold = new System.Windows.Forms.TextBox();
            this.labelSettingsComment2 = new System.Windows.Forms.Label();
            this.labelSettingsComment1 = new System.Windows.Forms.Label();
            this.labelresetOperation = new System.Windows.Forms.Label();
            this.comboBoxResetOperation = new System.Windows.Forms.ComboBox();
            this.labelWaitAfterCycle = new System.Windows.Forms.Label();
            this.textBoxWaitAfterCycle = new System.Windows.Forms.TextBox();
            this.labelReshreshInterval = new System.Windows.Forms.Label();
            this.textBoxRefreshInterval = new System.Windows.Forms.TextBox();
            this.labelTrigger = new System.Windows.Forms.Label();
            this.textBoxGap = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.labelAuthorizationKey = new System.Windows.Forms.Label();
            this.textBoxAuthorizationKey = new System.Windows.Forms.TextBox();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelAbourQRCode = new System.Windows.Forms.Label();
            this.buttonAboutCopyToClipboard = new System.Windows.Forms.Button();
            this.labelAboutHeliumAddress = new System.Windows.Forms.Label();
            this.labelAbout5 = new System.Windows.Forms.Label();
            this.labelAbout4 = new System.Windows.Forms.Label();
            this.labelAbout3 = new System.Windows.Forms.Label();
            this.labelAbout2 = new System.Windows.Forms.Label();
            this.labelAbout1 = new System.Windows.Forms.Label();
            this.pictureBoxQRAddress = new System.Windows.Forms.PictureBox();
            this.tabControlAbout.SuspendLayout();
            this.tabPageMonitoring.SuspendLayout();
            this.groupBoxManualcontrols.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAbout
            // 
            this.tabControlAbout.Controls.Add(this.tabPageMonitoring);
            this.tabControlAbout.Controls.Add(this.tabPageSettings);
            this.tabControlAbout.Controls.Add(this.tabPageAbout);
            this.tabControlAbout.Location = new System.Drawing.Point(1, 0);
            this.tabControlAbout.Name = "tabControlAbout";
            this.tabControlAbout.SelectedIndex = 0;
            this.tabControlAbout.Size = new System.Drawing.Size(898, 556);
            this.tabControlAbout.TabIndex = 0;
            this.tabControlAbout.Tag = "About";
            // 
            // tabPageMonitoring
            // 
            this.tabPageMonitoring.Controls.Add(this.groupBoxManualcontrols);
            this.tabPageMonitoring.Controls.Add(this.labelErrorsResult);
            this.tabPageMonitoring.Controls.Add(this.labelError);
            this.tabPageMonitoring.Controls.Add(this.labelMinerHeightResult);
            this.tabPageMonitoring.Controls.Add(this.labelMinerHeight);
            this.tabPageMonitoring.Controls.Add(this.labelBlockchainHeightResult);
            this.tabPageMonitoring.Controls.Add(this.labelBlockchain_height);
            this.tabPageMonitoring.Controls.Add(this.labelOtaVersionResult);
            this.tabPageMonitoring.Controls.Add(this.labelOtaVersion);
            this.tabPageMonitoring.Controls.Add(this.labelStateResult);
            this.tabPageMonitoring.Controls.Add(this.labelState);
            this.tabPageMonitoring.Controls.Add(this.labelStatusResult);
            this.tabPageMonitoring.Controls.Add(this.labelStatus);
            this.tabPageMonitoring.Controls.Add(this.labelAnimal);
            this.tabPageMonitoring.Controls.Add(this.buttonStopMonitoring);
            this.tabPageMonitoring.Controls.Add(this.buttonStart);
            this.tabPageMonitoring.Controls.Add(this.labelTemp1Result);
            this.tabPageMonitoring.Controls.Add(this.labelTemp0Result);
            this.tabPageMonitoring.Controls.Add(this.labelLastUpdateResult);
            this.tabPageMonitoring.Controls.Add(this.labelLastUpdate);
            this.tabPageMonitoring.Controls.Add(this.labelGapResult);
            this.tabPageMonitoring.Controls.Add(this.buttonRefresh);
            this.tabPageMonitoring.Controls.Add(this.labelTemp1);
            this.tabPageMonitoring.Controls.Add(this.labelGAP);
            this.tabPageMonitoring.Controls.Add(this.labelTemp0);
            this.tabPageMonitoring.Controls.Add(this.labelStatusRichText);
            this.tabPageMonitoring.Controls.Add(this.richTextBoxStatus);
            this.tabPageMonitoring.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitoring.Name = "tabPageMonitoring";
            this.tabPageMonitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonitoring.Size = new System.Drawing.Size(890, 530);
            this.tabPageMonitoring.TabIndex = 0;
            this.tabPageMonitoring.Text = "Monitoring";
            this.tabPageMonitoring.UseVisualStyleBackColor = true;
            this.tabPageMonitoring.Click += new System.EventHandler(this.tabPageMonitoring_Click);
            // 
            // groupBoxManualcontrols
            // 
            this.groupBoxManualcontrols.Controls.Add(this.checkBoxArmed);
            this.groupBoxManualcontrols.Controls.Add(this.buttonResync);
            this.groupBoxManualcontrols.Controls.Add(this.buttonReboot);
            this.groupBoxManualcontrols.Controls.Add(this.buttonReset);
            this.groupBoxManualcontrols.Controls.Add(this.buttonFastSync);
            this.groupBoxManualcontrols.Location = new System.Drawing.Point(760, 25);
            this.groupBoxManualcontrols.Name = "groupBoxManualcontrols";
            this.groupBoxManualcontrols.Size = new System.Drawing.Size(105, 319);
            this.groupBoxManualcontrols.TabIndex = 33;
            this.groupBoxManualcontrols.TabStop = false;
            this.groupBoxManualcontrols.Text = "Manual controls";
            this.groupBoxManualcontrols.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxArmed
            // 
            this.checkBoxArmed.AutoSize = true;
            this.checkBoxArmed.Location = new System.Drawing.Point(12, 30);
            this.checkBoxArmed.Name = "checkBoxArmed";
            this.checkBoxArmed.Size = new System.Drawing.Size(83, 17);
            this.checkBoxArmed.TabIndex = 32;
            this.checkBoxArmed.Text = "DISARMED";
            this.checkBoxArmed.UseVisualStyleBackColor = true;
            this.checkBoxArmed.CheckedChanged += new System.EventHandler(this.checkBoxArmed_CheckedChanged);
            // 
            // buttonResync
            // 
            this.buttonResync.Location = new System.Drawing.Point(15, 109);
            this.buttonResync.Name = "buttonResync";
            this.buttonResync.Size = new System.Drawing.Size(75, 23);
            this.buttonResync.TabIndex = 2;
            this.buttonResync.Text = "Resync";
            this.buttonResync.UseVisualStyleBackColor = true;
            this.buttonResync.Click += new System.EventHandler(this.buttonResync_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(15, 222);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(75, 23);
            this.buttonReboot.TabIndex = 0;
            this.buttonReboot.Text = "Reboot";
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(15, 280);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFastSync
            // 
            this.buttonFastSync.Location = new System.Drawing.Point(15, 167);
            this.buttonFastSync.Name = "buttonFastSync";
            this.buttonFastSync.Size = new System.Drawing.Size(75, 23);
            this.buttonFastSync.TabIndex = 17;
            this.buttonFastSync.Text = "FastSync";
            this.buttonFastSync.UseVisualStyleBackColor = true;
            this.buttonFastSync.Click += new System.EventHandler(this.buttonFastSync_Click);
            // 
            // labelErrorsResult
            // 
            this.labelErrorsResult.AutoSize = true;
            this.labelErrorsResult.Location = new System.Drawing.Point(115, 246);
            this.labelErrorsResult.Name = "labelErrorsResult";
            this.labelErrorsResult.Size = new System.Drawing.Size(10, 13);
            this.labelErrorsResult.TabIndex = 31;
            this.labelErrorsResult.Text = "-";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(15, 246);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(37, 13);
            this.labelError.TabIndex = 30;
            this.labelError.Text = "Errors:";
            // 
            // labelMinerHeightResult
            // 
            this.labelMinerHeightResult.AutoSize = true;
            this.labelMinerHeightResult.Location = new System.Drawing.Point(114, 142);
            this.labelMinerHeightResult.Name = "labelMinerHeightResult";
            this.labelMinerHeightResult.Size = new System.Drawing.Size(10, 13);
            this.labelMinerHeightResult.TabIndex = 29;
            this.labelMinerHeightResult.Text = "-";
            // 
            // labelMinerHeight
            // 
            this.labelMinerHeight.AutoSize = true;
            this.labelMinerHeight.Location = new System.Drawing.Point(15, 142);
            this.labelMinerHeight.Name = "labelMinerHeight";
            this.labelMinerHeight.Size = new System.Drawing.Size(68, 13);
            this.labelMinerHeight.TabIndex = 28;
            this.labelMinerHeight.Text = "Miner height:";
            // 
            // labelBlockchainHeightResult
            // 
            this.labelBlockchainHeightResult.AutoSize = true;
            this.labelBlockchainHeightResult.Location = new System.Drawing.Point(114, 162);
            this.labelBlockchainHeightResult.Name = "labelBlockchainHeightResult";
            this.labelBlockchainHeightResult.Size = new System.Drawing.Size(10, 13);
            this.labelBlockchainHeightResult.TabIndex = 27;
            this.labelBlockchainHeightResult.Text = "-";
            // 
            // labelBlockchain_height
            // 
            this.labelBlockchain_height.AutoSize = true;
            this.labelBlockchain_height.Location = new System.Drawing.Point(15, 162);
            this.labelBlockchain_height.Name = "labelBlockchain_height";
            this.labelBlockchain_height.Size = new System.Drawing.Size(95, 13);
            this.labelBlockchain_height.TabIndex = 26;
            this.labelBlockchain_height.Text = "Blockchain height:";
            // 
            // labelOtaVersionResult
            // 
            this.labelOtaVersionResult.AutoSize = true;
            this.labelOtaVersionResult.Location = new System.Drawing.Point(115, 229);
            this.labelOtaVersionResult.Name = "labelOtaVersionResult";
            this.labelOtaVersionResult.Size = new System.Drawing.Size(10, 13);
            this.labelOtaVersionResult.TabIndex = 25;
            this.labelOtaVersionResult.Text = "-";
            // 
            // labelOtaVersion
            // 
            this.labelOtaVersion.AutoSize = true;
            this.labelOtaVersion.Location = new System.Drawing.Point(15, 229);
            this.labelOtaVersion.Name = "labelOtaVersion";
            this.labelOtaVersion.Size = new System.Drawing.Size(64, 13);
            this.labelOtaVersion.TabIndex = 24;
            this.labelOtaVersion.Text = "Ota version:";
            // 
            // labelStateResult
            // 
            this.labelStateResult.AutoSize = true;
            this.labelStateResult.Location = new System.Drawing.Point(115, 211);
            this.labelStateResult.Name = "labelStateResult";
            this.labelStateResult.Size = new System.Drawing.Size(10, 13);
            this.labelStateResult.TabIndex = 23;
            this.labelStateResult.Text = "-";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(15, 211);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 22;
            this.labelState.Text = "State:";
            // 
            // labelStatusResult
            // 
            this.labelStatusResult.AutoSize = true;
            this.labelStatusResult.Location = new System.Drawing.Point(115, 192);
            this.labelStatusResult.Name = "labelStatusResult";
            this.labelStatusResult.Size = new System.Drawing.Size(10, 13);
            this.labelStatusResult.TabIndex = 21;
            this.labelStatusResult.Text = "-";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(15, 192);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Status:";
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnimal.Location = new System.Drawing.Point(335, 13);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(21, 29);
            this.labelAnimal.TabIndex = 19;
            this.labelAnimal.Text = "-";
            // 
            // buttonStopMonitoring
            // 
            this.buttonStopMonitoring.Location = new System.Drawing.Point(150, 311);
            this.buttonStopMonitoring.Name = "buttonStopMonitoring";
            this.buttonStopMonitoring.Size = new System.Drawing.Size(105, 33);
            this.buttonStopMonitoring.TabIndex = 18;
            this.buttonStopMonitoring.Text = "Stop monitoring";
            this.buttonStopMonitoring.UseVisualStyleBackColor = true;
            this.buttonStopMonitoring.Click += new System.EventHandler(this.buttonStopMonitoring_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 311);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 33);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start monitoring";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTemp1Result
            // 
            this.labelTemp1Result.AutoSize = true;
            this.labelTemp1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp1Result.Location = new System.Drawing.Point(113, 108);
            this.labelTemp1Result.Name = "labelTemp1Result";
            this.labelTemp1Result.Size = new System.Drawing.Size(12, 16);
            this.labelTemp1Result.TabIndex = 15;
            this.labelTemp1Result.Text = "-";
            // 
            // labelTemp0Result
            // 
            this.labelTemp0Result.AutoSize = true;
            this.labelTemp0Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp0Result.Location = new System.Drawing.Point(113, 91);
            this.labelTemp0Result.Name = "labelTemp0Result";
            this.labelTemp0Result.Size = new System.Drawing.Size(12, 16);
            this.labelTemp0Result.TabIndex = 14;
            this.labelTemp0Result.Text = "-";
            // 
            // labelLastUpdateResult
            // 
            this.labelLastUpdateResult.AutoSize = true;
            this.labelLastUpdateResult.Location = new System.Drawing.Point(114, 279);
            this.labelLastUpdateResult.Name = "labelLastUpdateResult";
            this.labelLastUpdateResult.Size = new System.Drawing.Size(10, 13);
            this.labelLastUpdateResult.TabIndex = 13;
            this.labelLastUpdateResult.Text = "-";
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(14, 279);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(66, 13);
            this.labelLastUpdate.TabIndex = 12;
            this.labelLastUpdate.Text = "Last update:";
            // 
            // labelGapResult
            // 
            this.labelGapResult.AutoSize = true;
            this.labelGapResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGapResult.Location = new System.Drawing.Point(112, 55);
            this.labelGapResult.Name = "labelGapResult";
            this.labelGapResult.Size = new System.Drawing.Size(15, 20);
            this.labelGapResult.TabIndex = 11;
            this.labelGapResult.Text = "-";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(406, 311);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(105, 33);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Manual Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp1.Location = new System.Drawing.Point(13, 110);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(54, 16);
            this.labelTemp1.TabIndex = 9;
            this.labelTemp1.Text = "Temp1:";
            // 
            // labelGAP
            // 
            this.labelGAP.AutoSize = true;
            this.labelGAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGAP.Location = new System.Drawing.Point(13, 55);
            this.labelGAP.Name = "labelGAP";
            this.labelGAP.Size = new System.Drawing.Size(44, 20);
            this.labelGAP.TabIndex = 8;
            this.labelGAP.Text = "Gap:";
            // 
            // labelTemp0
            // 
            this.labelTemp0.AutoSize = true;
            this.labelTemp0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp0.Location = new System.Drawing.Point(13, 90);
            this.labelTemp0.Name = "labelTemp0";
            this.labelTemp0.Size = new System.Drawing.Size(54, 16);
            this.labelTemp0.TabIndex = 7;
            this.labelTemp0.Text = "Temp0:";
            // 
            // labelStatusRichText
            // 
            this.labelStatusRichText.AutoSize = true;
            this.labelStatusRichText.Location = new System.Drawing.Point(9, 356);
            this.labelStatusRichText.Name = "labelStatusRichText";
            this.labelStatusRichText.Size = new System.Drawing.Size(40, 13);
            this.labelStatusRichText.TabIndex = 5;
            this.labelStatusRichText.Text = "Status:";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.BackColor = System.Drawing.Color.White;
            this.richTextBoxStatus.Location = new System.Drawing.Point(8, 376);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            this.richTextBoxStatus.Size = new System.Drawing.Size(872, 146);
            this.richTextBoxStatus.TabIndex = 4;
            this.richTextBoxStatus.Text = "";
            this.richTextBoxStatus.TextChanged += new System.EventHandler(this.richTextBoxStatus_TextChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Controls.Add(this.labelSettingsComment3);
            this.tabPageSettings.Controls.Add(this.labelFastSyncTreshold);
            this.tabPageSettings.Controls.Add(this.textBoxFastSyncGapThreshold);
            this.tabPageSettings.Controls.Add(this.labelSettingsComment2);
            this.tabPageSettings.Controls.Add(this.labelSettingsComment1);
            this.tabPageSettings.Controls.Add(this.labelresetOperation);
            this.tabPageSettings.Controls.Add(this.comboBoxResetOperation);
            this.tabPageSettings.Controls.Add(this.labelWaitAfterCycle);
            this.tabPageSettings.Controls.Add(this.textBoxWaitAfterCycle);
            this.tabPageSettings.Controls.Add(this.labelReshreshInterval);
            this.tabPageSettings.Controls.Add(this.textBoxRefreshInterval);
            this.tabPageSettings.Controls.Add(this.labelTrigger);
            this.tabPageSettings.Controls.Add(this.textBoxGap);
            this.tabPageSettings.Controls.Add(this.labelDelay);
            this.tabPageSettings.Controls.Add(this.textBoxDelay);
            this.tabPageSettings.Controls.Add(this.labelAuthorizationKey);
            this.tabPageSettings.Controls.Add(this.textBoxAuthorizationKey);
            this.tabPageSettings.Controls.Add(this.labelIpAddress);
            this.tabPageSettings.Controls.Add(this.textBoxIpAddress);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(890, 530);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            this.tabPageSettings.Click += new System.EventHandler(this.tabPageSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Value lower than 400 should not trigger Fast sync (Bobcat settings).";
            // 
            // labelSettingsComment3
            // 
            this.labelSettingsComment3.AutoSize = true;
            this.labelSettingsComment3.Location = new System.Drawing.Point(21, 472);
            this.labelSettingsComment3.Name = "labelSettingsComment3";
            this.labelSettingsComment3.Size = new System.Drawing.Size(554, 13);
            this.labelSettingsComment3.TabIndex = 19;
            this.labelSettingsComment3.Text = "*** After Reset/Resync operation, Fast sync  will be run only if Gap is above thi" +
    "s value. This is default Bobcat value. ";
            // 
            // labelFastSyncTreshold
            // 
            this.labelFastSyncTreshold.AutoSize = true;
            this.labelFastSyncTreshold.Location = new System.Drawing.Point(20, 355);
            this.labelFastSyncTreshold.Name = "labelFastSyncTreshold";
            this.labelFastSyncTreshold.Size = new System.Drawing.Size(142, 13);
            this.labelFastSyncTreshold.TabIndex = 18;
            this.labelFastSyncTreshold.Text = "*** Fast sync Gap threshold :";
            // 
            // textBoxFastSyncGapThreshold
            // 
            this.textBoxFastSyncGapThreshold.Location = new System.Drawing.Point(291, 352);
            this.textBoxFastSyncGapThreshold.Name = "textBoxFastSyncGapThreshold";
            this.textBoxFastSyncGapThreshold.Size = new System.Drawing.Size(156, 20);
            this.textBoxFastSyncGapThreshold.TabIndex = 17;
            this.textBoxFastSyncGapThreshold.Text = "400";
            // 
            // labelSettingsComment2
            // 
            this.labelSettingsComment2.AutoSize = true;
            this.labelSettingsComment2.Location = new System.Drawing.Point(21, 441);
            this.labelSettingsComment2.Name = "labelSettingsComment2";
            this.labelSettingsComment2.Size = new System.Drawing.Size(517, 13);
            this.labelSettingsComment2.TabIndex = 16;
            this.labelSettingsComment2.Text = "** Increase pause or Gap threshold if your miner/internet is not fast enough to a" +
    "void infinite reset/resync loop";
            // 
            // labelSettingsComment1
            // 
            this.labelSettingsComment1.AutoSize = true;
            this.labelSettingsComment1.Location = new System.Drawing.Point(20, 422);
            this.labelSettingsComment1.Name = "labelSettingsComment1";
            this.labelSettingsComment1.Size = new System.Drawing.Size(269, 13);
            this.labelSettingsComment1.TabIndex = 15;
            this.labelSettingsComment1.Text = "* Increase delay if your miner/internet is not fast enough";
            // 
            // labelresetOperation
            // 
            this.labelresetOperation.AutoSize = true;
            this.labelresetOperation.Location = new System.Drawing.Point(20, 197);
            this.labelresetOperation.Name = "labelresetOperation";
            this.labelresetOperation.Size = new System.Drawing.Size(119, 13);
            this.labelresetOperation.TabIndex = 14;
            this.labelresetOperation.Text = "Type of reset operation:";
            // 
            // comboBoxResetOperation
            // 
            this.comboBoxResetOperation.FormattingEnabled = true;
            this.comboBoxResetOperation.Items.AddRange(new object[] {
            "Disabled",
            "Resync + Fast sync (default)",
            "Reset + Resync + Fast sync",
            "Fast sync",
            "Reboot"});
            this.comboBoxResetOperation.Location = new System.Drawing.Point(291, 190);
            this.comboBoxResetOperation.Name = "comboBoxResetOperation";
            this.comboBoxResetOperation.Size = new System.Drawing.Size(156, 21);
            this.comboBoxResetOperation.TabIndex = 13;
            // 
            // labelWaitAfterCycle
            // 
            this.labelWaitAfterCycle.AutoSize = true;
            this.labelWaitAfterCycle.Location = new System.Drawing.Point(20, 316);
            this.labelWaitAfterCycle.Name = "labelWaitAfterCycle";
            this.labelWaitAfterCycle.Size = new System.Drawing.Size(264, 13);
            this.labelWaitAfterCycle.TabIndex = 11;
            this.labelWaitAfterCycle.Text = "** Pause monitor after last RESET/SYNC for (minutes):";
            this.labelWaitAfterCycle.Click += new System.EventHandler(this.labelWaitAfterCycle_Click);
            // 
            // textBoxWaitAfterCycle
            // 
            this.textBoxWaitAfterCycle.Location = new System.Drawing.Point(291, 313);
            this.textBoxWaitAfterCycle.Name = "textBoxWaitAfterCycle";
            this.textBoxWaitAfterCycle.Size = new System.Drawing.Size(156, 20);
            this.textBoxWaitAfterCycle.TabIndex = 10;
            this.textBoxWaitAfterCycle.Text = "120";
            // 
            // labelReshreshInterval
            // 
            this.labelReshreshInterval.AutoSize = true;
            this.labelReshreshInterval.Location = new System.Drawing.Point(20, 102);
            this.labelReshreshInterval.Name = "labelReshreshInterval";
            this.labelReshreshInterval.Size = new System.Drawing.Size(132, 13);
            this.labelReshreshInterval.TabIndex = 9;
            this.labelReshreshInterval.Text = "Refresh interval (minutes) :";
            // 
            // textBoxRefreshInterval
            // 
            this.textBoxRefreshInterval.Location = new System.Drawing.Point(291, 99);
            this.textBoxRefreshInterval.Name = "textBoxRefreshInterval";
            this.textBoxRefreshInterval.Size = new System.Drawing.Size(156, 20);
            this.textBoxRefreshInterval.TabIndex = 8;
            this.textBoxRefreshInterval.Text = "10";
            this.textBoxRefreshInterval.TextChanged += new System.EventHandler(this.textBoxRefreshInterval_TextChanged);
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.Location = new System.Drawing.Point(20, 237);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(213, 13);
            this.labelTrigger.TabIndex = 7;
            this.labelTrigger.Text = "Gap threshold - cycle miner if gap is above :";
            // 
            // textBoxGap
            // 
            this.textBoxGap.Location = new System.Drawing.Point(291, 234);
            this.textBoxGap.Name = "textBoxGap";
            this.textBoxGap.Size = new System.Drawing.Size(156, 20);
            this.textBoxGap.TabIndex = 6;
            this.textBoxGap.Text = "50";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(17, 277);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(206, 13);
            this.labelDelay.TabIndex = 5;
            this.labelDelay.Text = "* Delay between RESET/SYNC (minutes):";
            this.labelDelay.Click += new System.EventHandler(this.labelDelay_Click);
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(291, 274);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(156, 20);
            this.textBoxDelay.TabIndex = 4;
            this.textBoxDelay.Text = "30";
            // 
            // labelAuthorizationKey
            // 
            this.labelAuthorizationKey.AutoSize = true;
            this.labelAuthorizationKey.Location = new System.Drawing.Point(19, 65);
            this.labelAuthorizationKey.Name = "labelAuthorizationKey";
            this.labelAuthorizationKey.Size = new System.Drawing.Size(91, 13);
            this.labelAuthorizationKey.TabIndex = 3;
            this.labelAuthorizationKey.Text = "Authorization key:";
            // 
            // textBoxAuthorizationKey
            // 
            this.textBoxAuthorizationKey.Location = new System.Drawing.Point(292, 62);
            this.textBoxAuthorizationKey.Name = "textBoxAuthorizationKey";
            this.textBoxAuthorizationKey.Size = new System.Drawing.Size(155, 20);
            this.textBoxAuthorizationKey.TabIndex = 2;
            this.textBoxAuthorizationKey.Text = "Ym9iY2F0Om1pbmVy";
            this.textBoxAuthorizationKey.TextChanged += new System.EventHandler(this.textBoxAuthorizationKey_TextChanged);
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Location = new System.Drawing.Point(19, 28);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(92, 13);
            this.labelIpAddress.TabIndex = 1;
            this.labelIpAddress.Text = "Bobcat IP Adress:";
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(291, 25);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(156, 20);
            this.textBoxIpAddress.TabIndex = 0;
            this.textBoxIpAddress.TextChanged += new System.EventHandler(this.textBoxIpAddress_TextChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.pictureBoxQRAddress);
            this.tabPageAbout.Controls.Add(this.labelAbourQRCode);
            this.tabPageAbout.Controls.Add(this.buttonAboutCopyToClipboard);
            this.tabPageAbout.Controls.Add(this.labelAboutHeliumAddress);
            this.tabPageAbout.Controls.Add(this.labelAbout5);
            this.tabPageAbout.Controls.Add(this.labelAbout4);
            this.tabPageAbout.Controls.Add(this.labelAbout3);
            this.tabPageAbout.Controls.Add(this.labelAbout2);
            this.tabPageAbout.Controls.Add(this.labelAbout1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(890, 530);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            this.tabPageAbout.Click += new System.EventHandler(this.tabPageAbout_Click);
            // 
            // labelAbourQRCode
            // 
            this.labelAbourQRCode.AutoSize = true;
            this.labelAbourQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbourQRCode.Location = new System.Drawing.Point(558, 264);
            this.labelAbourQRCode.Name = "labelAbourQRCode";
            this.labelAbourQRCode.Size = new System.Drawing.Size(294, 16);
            this.labelAbourQRCode.TabIndex = 7;
            this.labelAbourQRCode.Text = "Or you can scan QR code from your Helium app:";
            // 
            // buttonAboutCopyToClipboard
            // 
            this.buttonAboutCopyToClipboard.Location = new System.Drawing.Point(27, 295);
            this.buttonAboutCopyToClipboard.Name = "buttonAboutCopyToClipboard";
            this.buttonAboutCopyToClipboard.Size = new System.Drawing.Size(120, 23);
            this.buttonAboutCopyToClipboard.TabIndex = 6;
            this.buttonAboutCopyToClipboard.Text = "Copy to clipboard";
            this.buttonAboutCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonAboutCopyToClipboard.Click += new System.EventHandler(this.buttonAboutCopyToClipboard_Click);
            // 
            // labelAboutHeliumAddress
            // 
            this.labelAboutHeliumAddress.AutoSize = true;
            this.labelAboutHeliumAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAboutHeliumAddress.Location = new System.Drawing.Point(23, 266);
            this.labelAboutHeliumAddress.Name = "labelAboutHeliumAddress";
            this.labelAboutHeliumAddress.Size = new System.Drawing.Size(475, 16);
            this.labelAboutHeliumAddress.TabIndex = 5;
            this.labelAboutHeliumAddress.Text = "13dxLUHWhhxpNRjqLtmxF22ANeoLXPZe3c7JRCJjUJwKgiUJ6Z5                         ";
            this.labelAboutHeliumAddress.Click += new System.EventHandler(this.labelAboutHeliumAddress_Click);
            // 
            // labelAbout5
            // 
            this.labelAbout5.AutoSize = true;
            this.labelAbout5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbout5.Location = new System.Drawing.Point(26, 467);
            this.labelAbout5.Name = "labelAbout5";
            this.labelAbout5.Size = new System.Drawing.Size(73, 16);
            this.labelAbout5.TabIndex = 4;
            this.labelAbout5.Text = "Thank You";
            // 
            // labelAbout4
            // 
            this.labelAbout4.AutoSize = true;
            this.labelAbout4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbout4.Location = new System.Drawing.Point(23, 213);
            this.labelAbout4.Name = "labelAbout4";
            this.labelAbout4.Size = new System.Drawing.Size(814, 16);
            this.labelAbout4.TabIndex = 3;
            this.labelAbout4.Text = "If you like this app and would like to support further development (Linux version" +
    ", cmd version), you can donate some fraction of HNT here: ";
            // 
            // labelAbout3
            // 
            this.labelAbout3.AutoSize = true;
            this.labelAbout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbout3.Location = new System.Drawing.Point(26, 127);
            this.labelAbout3.Name = "labelAbout3";
            this.labelAbout3.Size = new System.Drawing.Size(553, 16);
            this.labelAbout3.TabIndex = 2;
            this.labelAbout3.Text = "If Gap goes above specified threshold, Bobcat will be cycled (default is Resync +" +
    " Fast sync).";
            this.labelAbout3.Click += new System.EventHandler(this.labelAbout3_Click);
            // 
            // labelAbout2
            // 
            this.labelAbout2.AutoSize = true;
            this.labelAbout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbout2.Location = new System.Drawing.Point(26, 93);
            this.labelAbout2.Name = "labelAbout2";
            this.labelAbout2.Size = new System.Drawing.Size(459, 16);
            this.labelAbout2.TabIndex = 1;
            this.labelAbout2.Text = "Bobcat Monitor and JumpStarter monitors miners Gap and other parameters.";
            // 
            // labelAbout1
            // 
            this.labelAbout1.AutoSize = true;
            this.labelAbout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbout1.Location = new System.Drawing.Point(185, 23);
            this.labelAbout1.Name = "labelAbout1";
            this.labelAbout1.Size = new System.Drawing.Size(498, 25);
            this.labelAbout1.TabIndex = 0;
            this.labelAbout1.Text = "Bobcat Monitor and JumpStarter for Windows v 0.7";
            this.labelAbout1.Click += new System.EventHandler(this.labelAbout1_Click);
            // 
            // pictureBoxQRAddress
            // 
            this.pictureBoxQRAddress.Image = global::BobcatMonitor.Properties.Resources.QR_receiving_address;
            this.pictureBoxQRAddress.Location = new System.Drawing.Point(602, 289);
            this.pictureBoxQRAddress.Name = "pictureBoxQRAddress";
            this.pictureBoxQRAddress.Size = new System.Drawing.Size(220, 220);
            this.pictureBoxQRAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRAddress.TabIndex = 8;
            this.pictureBoxQRAddress.TabStop = false;
            // 
            // BobcatWindowsMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 550);
            this.Controls.Add(this.tabControlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BobcatWindowsMonitor";
            this.Text = "Bobcat Monitor and JumpStarter";
            this.tabControlAbout.ResumeLayout(false);
            this.tabPageMonitoring.ResumeLayout(false);
            this.tabPageMonitoring.PerformLayout();
            this.groupBoxManualcontrols.ResumeLayout(false);
            this.groupBoxManualcontrols.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAbout;
        private System.Windows.Forms.TabPage tabPageMonitoring;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelTemp1;
        private System.Windows.Forms.Label labelGAP;
        private System.Windows.Forms.Label labelTemp0;
        private System.Windows.Forms.Label labelStatusRichText;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button buttonResync;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label labelTrigger;
        private System.Windows.Forms.TextBox textBoxGap;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label labelAuthorizationKey;
        private System.Windows.Forms.TextBox textBoxAuthorizationKey;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.Label labelGapResult;
        private System.Windows.Forms.Label labelReshreshInterval;
        private System.Windows.Forms.TextBox textBoxRefreshInterval;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.Label labelLastUpdateResult;
        private System.Windows.Forms.Label labelTemp1Result;
        private System.Windows.Forms.Label labelTemp0Result;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelAbout1;
        private System.Windows.Forms.Label labelAbout5;
        private System.Windows.Forms.Label labelAbout4;
        private System.Windows.Forms.Label labelAbout3;
        private System.Windows.Forms.Label labelAbout2;
        private System.Windows.Forms.Label labelWaitAfterCycle;
        private System.Windows.Forms.TextBox textBoxWaitAfterCycle;
        private System.Windows.Forms.Button buttonFastSync;
        private System.Windows.Forms.Button buttonStopMonitoring;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.Label labelStatusResult;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelOtaVersionResult;
        private System.Windows.Forms.Label labelOtaVersion;
        private System.Windows.Forms.Label labelStateResult;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxResetOperation;
        private System.Windows.Forms.Label labelresetOperation;
        private System.Windows.Forms.Label labelSettingsComment1;
        private System.Windows.Forms.Label labelSettingsComment2;
        private System.Windows.Forms.Button buttonAboutCopyToClipboard;
        private System.Windows.Forms.Label labelAboutHeliumAddress;
        private System.Windows.Forms.Label labelAbourQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQRAddress;
        private System.Windows.Forms.Label labelFastSyncTreshold;
        private System.Windows.Forms.TextBox textBoxFastSyncGapThreshold;
        private System.Windows.Forms.Label labelSettingsComment3;
        private System.Windows.Forms.Label labelMinerHeightResult;
        private System.Windows.Forms.Label labelMinerHeight;
        private System.Windows.Forms.Label labelBlockchainHeightResult;
        private System.Windows.Forms.Label labelBlockchain_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorsResult;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxArmed;
        private System.Windows.Forms.GroupBox groupBoxManualcontrols;
    }
}


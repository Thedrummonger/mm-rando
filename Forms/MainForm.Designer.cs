﻿using System;

namespace MMRando
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bopen = new System.Windows.Forms.Button();
            this.openROM = new System.Windows.Forms.OpenFileDialog();
            this.tROMName = new System.Windows.Forms.TextBox();
            this.cUserItems = new System.Windows.Forms.CheckBox();
            this.tSettings = new System.Windows.Forms.TabControl();
            this.tabROMSettings = new System.Windows.Forms.TabPage();
            this.cHTMLLog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cSpoiler = new System.Windows.Forms.CheckBox();
            this.cVC = new System.Windows.Forms.CheckBox();
            this.cN64 = new System.Windows.Forms.CheckBox();
            this.lOutput = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cAdditional = new System.Windows.Forms.CheckBox();
            this.cGossip = new System.Windows.Forms.CheckBox();
            this.cSoS = new System.Windows.Forms.CheckBox();
            this.cMixSongs = new System.Windows.Forms.CheckBox();
            this.cEnemy = new System.Windows.Forms.CheckBox();
            this.cDChests = new System.Windows.Forms.CheckBox();
            this.cBottled = new System.Windows.Forms.CheckBox();
            this.cDEnt = new System.Windows.Forms.CheckBox();
            this.cShop = new System.Windows.Forms.CheckBox();
            this.lMode = new System.Windows.Forms.Label();
            this.cMode = new System.Windows.Forms.ComboBox();
            this.tabGimmick = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lFloors = new System.Windows.Forms.Label();
            this.lGravity = new System.Windows.Forms.Label();
            this.lDType = new System.Windows.Forms.Label();
            this.lDMult = new System.Windows.Forms.Label();
            this.cFloors = new System.Windows.Forms.ComboBox();
            this.cDType = new System.Windows.Forms.ComboBox();
            this.cDMult = new System.Windows.Forms.ComboBox();
            this.cGravity = new System.Windows.Forms.ComboBox();
            this.tabComfort = new System.Windows.Forms.TabPage();
            this.cFreeHints = new System.Windows.Forms.CheckBox();
            this.cTatl = new System.Windows.Forms.ComboBox();
            this.cCutsc = new System.Windows.Forms.CheckBox();
            this.lTatl = new System.Windows.Forms.Label();
            this.cQText = new System.Windows.Forms.CheckBox();
            this.cLink = new System.Windows.Forms.ComboBox();
            this.lTunic = new System.Windows.Forms.Label();
            this.cBGM = new System.Windows.Forms.CheckBox();
            this.lLink = new System.Windows.Forms.Label();
            this.bTunic = new System.Windows.Forms.Button();
            this.saveROM = new System.Windows.Forms.SaveFileDialog();
            this.cTunic = new System.Windows.Forms.ColorDialog();
            this.bRandomise = new System.Windows.Forms.Button();
            this.saveWad = new System.Windows.Forms.SaveFileDialog();
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mCustomise = new System.Windows.Forms.ToolStripMenuItem();
            this.mLogicEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemIncl = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openBROM = new System.Windows.Forms.OpenFileDialog();
            this.openLogic = new System.Windows.Forms.OpenFileDialog();
            this.pProgress = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lStatus = new System.Windows.Forms.Label();
            this.tSeed = new System.Windows.Forms.TextBox();
            this.lSeed = new System.Windows.Forms.Label();
            this.tSString = new System.Windows.Forms.TextBox();
            this.lSString = new System.Windows.Forms.Label();
            this.cDummy = new System.Windows.Forms.CheckBox();
            this.lHrule = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cClockSpeed = new System.Windows.Forms.ComboBox();
            this.lClockSpeed = new System.Windows.Forms.Label();
            this.tSettings.SuspendLayout();
            this.tabROMSettings.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabGimmick.SuspendLayout();
            this.tabComfort.SuspendLayout();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bopen
            // 
            this.bopen.Location = new System.Drawing.Point(4, 46);
            this.bopen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bopen.Name = "bopen";
            this.bopen.Size = new System.Drawing.Size(137, 33);
            this.bopen.TabIndex = 0;
            this.bopen.Text = "Open ROM...";
            this.bopen.UseVisualStyleBackColor = true;
            this.bopen.Click += new System.EventHandler(this.bopen_Click);
            // 
            // openROM
            // 
            this.openROM.Filter = "ROM files|*.z64";
            // 
            // tROMName
            // 
            this.tROMName.Location = new System.Drawing.Point(145, 50);
            this.tROMName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tROMName.Name = "tROMName";
            this.tROMName.ReadOnly = true;
            this.tROMName.Size = new System.Drawing.Size(305, 22);
            this.tROMName.TabIndex = 1;
            // 
            // cUserItems
            // 
            this.cUserItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cUserItems.AutoSize = true;
            this.cUserItems.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cUserItems.Location = new System.Drawing.Point(253, 55);
            this.cUserItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cUserItems.Name = "cUserItems";
            this.cUserItems.Size = new System.Drawing.Size(155, 21);
            this.cUserItems.TabIndex = 11;
            this.cUserItems.Text = "Use custom item list";
            this.cUserItems.UseVisualStyleBackColor = true;
            this.cUserItems.CheckedChanged += new System.EventHandler(this.cUserItems_CheckedChanged);
            // 
            // tSettings
            // 
            this.tSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tSettings.Controls.Add(this.tabROMSettings);
            this.tSettings.Controls.Add(this.tabMain);
            this.tSettings.Controls.Add(this.tabGimmick);
            this.tSettings.Controls.Add(this.tabComfort);
            this.tSettings.Location = new System.Drawing.Point(0, 28);
            this.tSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tSettings.Name = "tSettings";
            this.tSettings.SelectedIndex = 0;
            this.tSettings.Size = new System.Drawing.Size(472, 367);
            this.tSettings.TabIndex = 10;
            // 
            // tabROMSettings
            // 
            this.tabROMSettings.Controls.Add(this.cHTMLLog);
            this.tabROMSettings.Controls.Add(this.label1);
            this.tabROMSettings.Controls.Add(this.cSpoiler);
            this.tabROMSettings.Controls.Add(this.tROMName);
            this.tabROMSettings.Controls.Add(this.bopen);
            this.tabROMSettings.Controls.Add(this.cVC);
            this.tabROMSettings.Controls.Add(this.cN64);
            this.tabROMSettings.Controls.Add(this.lOutput);
            this.tabROMSettings.Location = new System.Drawing.Point(4, 28);
            this.tabROMSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabROMSettings.Name = "tabROMSettings";
            this.tabROMSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabROMSettings.Size = new System.Drawing.Size(464, 335);
            this.tabROMSettings.TabIndex = 3;
            this.tabROMSettings.Text = "ROM Settings";
            this.tabROMSettings.UseVisualStyleBackColor = true;
            // 
            // cHTMLLog
            // 
            this.cHTMLLog.AutoSize = true;
            this.cHTMLLog.BackColor = System.Drawing.Color.Transparent;
            this.cHTMLLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cHTMLLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHTMLLog.ForeColor = System.Drawing.Color.Black;
            this.cHTMLLog.Location = new System.Drawing.Point(268, 114);
            this.cHTMLLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cHTMLLog.Name = "cHTMLLog";
            this.cHTMLLog.Size = new System.Drawing.Size(166, 21);
            this.cHTMLLog.TabIndex = 14;
            this.cHTMLLog.Text = "Use HTML spoiler log";
            this.cHTMLLog.UseVisualStyleBackColor = false;
            this.cHTMLLog.CheckedChanged += new System.EventHandler(this.cHTMLLog_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ROM must be Majora\'s Mask (U) ending with \".z64\"";
            // 
            // cSpoiler
            // 
            this.cSpoiler.AutoSize = true;
            this.cSpoiler.BackColor = System.Drawing.Color.Transparent;
            this.cSpoiler.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cSpoiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSpoiler.ForeColor = System.Drawing.Color.Black;
            this.cSpoiler.Location = new System.Drawing.Point(83, 114);
            this.cSpoiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cSpoiler.Name = "cSpoiler";
            this.cSpoiler.Size = new System.Drawing.Size(142, 21);
            this.cSpoiler.TabIndex = 8;
            this.cSpoiler.Text = "Output spoiler log";
            this.cSpoiler.UseVisualStyleBackColor = false;
            this.cSpoiler.CheckedChanged += new System.EventHandler(this.cSpoiler_CheckedChanged);
            // 
            // cVC
            // 
            this.cVC.AutoSize = true;
            this.cVC.BackColor = System.Drawing.Color.Transparent;
            this.cVC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cVC.ForeColor = System.Drawing.Color.Black;
            this.cVC.Location = new System.Drawing.Point(232, 86);
            this.cVC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cVC.Name = "cVC";
            this.cVC.Size = new System.Drawing.Size(202, 21);
            this.cVC.TabIndex = 9;
            this.cVC.Text = "Wii Virtual Console channel";
            this.cVC.UseVisualStyleBackColor = false;
            this.cVC.CheckedChanged += new System.EventHandler(this.cVC_CheckedChanged);
            // 
            // cN64
            // 
            this.cN64.AutoSize = true;
            this.cN64.BackColor = System.Drawing.Color.Transparent;
            this.cN64.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cN64.Checked = true;
            this.cN64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cN64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cN64.ForeColor = System.Drawing.Color.Black;
            this.cN64.Location = new System.Drawing.Point(128, 86);
            this.cN64.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cN64.Name = "cN64";
            this.cN64.Size = new System.Drawing.Size(92, 21);
            this.cN64.TabIndex = 10;
            this.cN64.Text = "N64 ROM";
            this.cN64.UseVisualStyleBackColor = false;
            this.cN64.CheckedChanged += new System.EventHandler(this.cN64_CheckedChanged);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(13, 86);
            this.lOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(93, 17);
            this.lOutput.TabIndex = 11;
            this.lOutput.Text = "Output types:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.cAdditional);
            this.tabMain.Controls.Add(this.cGossip);
            this.tabMain.Controls.Add(this.cSoS);
            this.tabMain.Controls.Add(this.cUserItems);
            this.tabMain.Controls.Add(this.cMixSongs);
            this.tabMain.Controls.Add(this.cEnemy);
            this.tabMain.Controls.Add(this.cDChests);
            this.tabMain.Controls.Add(this.cBottled);
            this.tabMain.Controls.Add(this.cDEnt);
            this.tabMain.Controls.Add(this.cShop);
            this.tabMain.Controls.Add(this.lMode);
            this.tabMain.Controls.Add(this.cMode);
            this.tabMain.Location = new System.Drawing.Point(4, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Size = new System.Drawing.Size(464, 335);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main Settings";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(136, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "BETA - Use at your own risk!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(13, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "_____________________________________________________";
            // 
            // cAdditional
            // 
            this.cAdditional.AutoSize = true;
            this.cAdditional.BackColor = System.Drawing.Color.Transparent;
            this.cAdditional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAdditional.ForeColor = System.Drawing.Color.Black;
            this.cAdditional.Location = new System.Drawing.Point(277, 181);
            this.cAdditional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cAdditional.Name = "cAdditional";
            this.cAdditional.Size = new System.Drawing.Size(127, 21);
            this.cAdditional.TabIndex = 12;
            this.cAdditional.Text = "Everything else";
            this.cAdditional.UseVisualStyleBackColor = false;
            this.cAdditional.CheckedChanged += new System.EventHandler(this.cAdditional_CheckedChanged);
            // 
            // cGossip
            // 
            this.cGossip.AutoSize = true;
            this.cGossip.BackColor = System.Drawing.Color.Transparent;
            this.cGossip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cGossip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGossip.ForeColor = System.Drawing.Color.Black;
            this.cGossip.Location = new System.Drawing.Point(259, 124);
            this.cGossip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cGossip.Name = "cGossip";
            this.cGossip.Size = new System.Drawing.Size(147, 21);
            this.cGossip.TabIndex = 11;
            this.cGossip.Text = "Gossip stone hints";
            this.cGossip.UseVisualStyleBackColor = false;
            this.cGossip.CheckedChanged += new System.EventHandler(this.cGossip_CheckedChanged);
            // 
            // cSoS
            // 
            this.cSoS.AutoSize = true;
            this.cSoS.BackColor = System.Drawing.Color.Transparent;
            this.cSoS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cSoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSoS.ForeColor = System.Drawing.Color.Black;
            this.cSoS.Location = new System.Drawing.Point(217, 96);
            this.cSoS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cSoS.Name = "cSoS";
            this.cSoS.Size = new System.Drawing.Size(185, 21);
            this.cSoS.TabIndex = 10;
            this.cSoS.Text = "Exclude Song of Soaring";
            this.cSoS.UseVisualStyleBackColor = false;
            this.cSoS.CheckedChanged += new System.EventHandler(this.cSoS_CheckedChanged);
            // 
            // cMixSongs
            // 
            this.cMixSongs.AutoSize = true;
            this.cMixSongs.BackColor = System.Drawing.Color.Transparent;
            this.cMixSongs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cMixSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMixSongs.ForeColor = System.Drawing.Color.Black;
            this.cMixSongs.Location = new System.Drawing.Point(27, 96);
            this.cMixSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cMixSongs.Name = "cMixSongs";
            this.cMixSongs.Size = new System.Drawing.Size(157, 21);
            this.cMixSongs.TabIndex = 3;
            this.cMixSongs.Text = "Mix songs with items";
            this.cMixSongs.UseVisualStyleBackColor = false;
            this.cMixSongs.CheckedChanged += new System.EventHandler(this.cMixSongs_CheckedChanged);
            // 
            // cEnemy
            // 
            this.cEnemy.AutoSize = true;
            this.cEnemy.BackColor = System.Drawing.Color.Transparent;
            this.cEnemy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEnemy.ForeColor = System.Drawing.Color.Black;
            this.cEnemy.Location = new System.Drawing.Point(188, 292);
            this.cEnemy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cEnemy.Name = "cEnemy";
            this.cEnemy.Size = new System.Drawing.Size(84, 21);
            this.cEnemy.TabIndex = 9;
            this.cEnemy.Text = "Enemies";
            this.cEnemy.UseVisualStyleBackColor = false;
            this.cEnemy.CheckedChanged += new System.EventHandler(this.cEnemy_CheckedChanged);
            // 
            // cDChests
            // 
            this.cDChests.AutoSize = true;
            this.cDChests.BackColor = System.Drawing.Color.Transparent;
            this.cDChests.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cDChests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDChests.ForeColor = System.Drawing.Color.Black;
            this.cDChests.Location = new System.Drawing.Point(60, 124);
            this.cDChests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cDChests.Name = "cDChests";
            this.cDChests.Size = new System.Drawing.Size(125, 21);
            this.cDChests.TabIndex = 4;
            this.cDChests.Text = "Dungeon items";
            this.cDChests.UseVisualStyleBackColor = false;
            this.cDChests.CheckedChanged += new System.EventHandler(this.cDChests_CheckedChanged);
            // 
            // cBottled
            // 
            this.cBottled.AutoSize = true;
            this.cBottled.BackColor = System.Drawing.Color.Transparent;
            this.cBottled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBottled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBottled.ForeColor = System.Drawing.Color.Black;
            this.cBottled.Location = new System.Drawing.Point(12, 181);
            this.cBottled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBottled.Name = "cBottled";
            this.cBottled.Size = new System.Drawing.Size(172, 21);
            this.cBottled.TabIndex = 5;
            this.cBottled.Text = "Caught bottle contents";
            this.cBottled.UseVisualStyleBackColor = false;
            this.cBottled.CheckedChanged += new System.EventHandler(this.cBottled_CheckedChanged);
            // 
            // cDEnt
            // 
            this.cDEnt.AutoSize = true;
            this.cDEnt.BackColor = System.Drawing.Color.Transparent;
            this.cDEnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cDEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDEnt.ForeColor = System.Drawing.Color.Black;
            this.cDEnt.Location = new System.Drawing.Point(248, 153);
            this.cDEnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cDEnt.Name = "cDEnt";
            this.cDEnt.Size = new System.Drawing.Size(155, 21);
            this.cDEnt.TabIndex = 7;
            this.cDEnt.Text = "Dungeon entrances";
            this.cDEnt.UseVisualStyleBackColor = false;
            this.cDEnt.CheckedChanged += new System.EventHandler(this.cDEnt_CheckedChanged);
            // 
            // cShop
            // 
            this.cShop.AutoSize = true;
            this.cShop.BackColor = System.Drawing.Color.Transparent;
            this.cShop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cShop.ForeColor = System.Drawing.Color.Black;
            this.cShop.Location = new System.Drawing.Point(85, 153);
            this.cShop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cShop.Name = "cShop";
            this.cShop.Size = new System.Drawing.Size(100, 21);
            this.cShop.TabIndex = 6;
            this.cShop.Text = "Shop items";
            this.cShop.UseVisualStyleBackColor = false;
            this.cShop.CheckedChanged += new System.EventHandler(this.cShop_CheckedChanged);
            // 
            // lMode
            // 
            this.lMode.AutoSize = true;
            this.lMode.BackColor = System.Drawing.Color.Transparent;
            this.lMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMode.ForeColor = System.Drawing.Color.Black;
            this.lMode.Location = new System.Drawing.Point(25, 27);
            this.lMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMode.Name = "lMode";
            this.lMode.Size = new System.Drawing.Size(85, 17);
            this.lMode.TabIndex = 0;
            this.lMode.Text = "Mode/Logic:";
            // 
            // cMode
            // 
            this.cMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMode.FormattingEnabled = true;
            this.cMode.Items.AddRange(new object[] {
            "Casual/Glitchless",
            "Using Glitches",
            "Vanilla Layout",
            "User Logic",
            "No Logic"});
            this.cMode.Location = new System.Drawing.Point(120, 22);
            this.cMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cMode.Name = "cMode";
            this.cMode.Size = new System.Drawing.Size(295, 24);
            this.cMode.TabIndex = 1;
            this.cMode.SelectedIndexChanged += new System.EventHandler(this.cMode_SelectedIndexChanged);
            // 
            // tabGimmick
            // 
            this.tabGimmick.Controls.Add(this.lClockSpeed);
            this.tabGimmick.Controls.Add(this.cClockSpeed);
            this.tabGimmick.Controls.Add(this.label4);
            this.tabGimmick.Controls.Add(this.lFloors);
            this.tabGimmick.Controls.Add(this.lGravity);
            this.tabGimmick.Controls.Add(this.lDType);
            this.tabGimmick.Controls.Add(this.lDMult);
            this.tabGimmick.Controls.Add(this.cFloors);
            this.tabGimmick.Controls.Add(this.cDType);
            this.tabGimmick.Controls.Add(this.cDMult);
            this.tabGimmick.Controls.Add(this.cGravity);
            this.tabGimmick.Location = new System.Drawing.Point(4, 28);
            this.tabGimmick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGimmick.Name = "tabGimmick";
            this.tabGimmick.Size = new System.Drawing.Size(464, 335);
            this.tabGimmick.TabIndex = 2;
            this.tabGimmick.Text = "Gimmicks";
            this.tabGimmick.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 68);
            this.label4.TabIndex = 14;
            this.label4.Text = "WARNING!\r\nThese settings are not considered in logic and some\r\ncan cause the seed" +
    " to be unbeatable.\r\nUse at your own risk!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFloors
            // 
            this.lFloors.AutoSize = true;
            this.lFloors.Location = new System.Drawing.Point(80, 187);
            this.lFloors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFloors.Name = "lFloors";
            this.lFloors.Size = new System.Drawing.Size(82, 17);
            this.lFloors.TabIndex = 1;
            this.lFloors.Text = "Floor types:";
            // 
            // lGravity
            // 
            this.lGravity.AutoSize = true;
            this.lGravity.Location = new System.Drawing.Point(81, 154);
            this.lGravity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGravity.Name = "lGravity";
            this.lGravity.Size = new System.Drawing.Size(77, 17);
            this.lGravity.TabIndex = 1;
            this.lGravity.Text = "Movement:";
            // 
            // lDType
            // 
            this.lDType.AutoSize = true;
            this.lDType.Location = new System.Drawing.Point(48, 121);
            this.lDType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDType.Name = "lDType";
            this.lDType.Size = new System.Drawing.Size(111, 17);
            this.lDType.TabIndex = 1;
            this.lDType.Text = "Damage effects:";
            // 
            // lDMult
            // 
            this.lDMult.AutoSize = true;
            this.lDMult.Location = new System.Drawing.Point(56, 87);
            this.lDMult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDMult.Name = "lDMult";
            this.lDMult.Size = new System.Drawing.Size(104, 17);
            this.lDMult.TabIndex = 1;
            this.lDMult.Text = "Damage mode:";
            // 
            // cFloors
            // 
            this.cFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFloors.FormattingEnabled = true;
            this.cFloors.Items.AddRange(new object[] {
            "Default",
            "Sand",
            "Ice",
            "Snow",
            "Random"});
            this.cFloors.Location = new System.Drawing.Point(169, 183);
            this.cFloors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cFloors.Name = "cFloors";
            this.cFloors.Size = new System.Drawing.Size(209, 24);
            this.cFloors.TabIndex = 0;
            this.cFloors.SelectedIndexChanged += new System.EventHandler(this.cFloors_SelectedIndexChanged);
            // 
            // cDType
            // 
            this.cDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDType.FormattingEnabled = true;
            this.cDType.Items.AddRange(new object[] {
            "Default",
            "Fire",
            "Ice",
            "Shock",
            "Knockdown",
            "Random"});
            this.cDType.Location = new System.Drawing.Point(169, 117);
            this.cDType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cDType.Name = "cDType";
            this.cDType.Size = new System.Drawing.Size(209, 24);
            this.cDType.TabIndex = 0;
            this.cDType.SelectedIndexChanged += new System.EventHandler(this.cDType_SelectedIndexChanged);
            // 
            // cDMult
            // 
            this.cDMult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDMult.FormattingEnabled = true;
            this.cDMult.Items.AddRange(new object[] {
            "Default",
            "2x",
            "4x",
            "1-hit KO",
            "Doom"});
            this.cDMult.Location = new System.Drawing.Point(169, 84);
            this.cDMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cDMult.Name = "cDMult";
            this.cDMult.Size = new System.Drawing.Size(209, 24);
            this.cDMult.TabIndex = 0;
            this.cDMult.SelectedIndexChanged += new System.EventHandler(this.cDMult_SelectedIndexChanged);
            // 
            // cGravity
            // 
            this.cGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGravity.FormattingEnabled = true;
            this.cGravity.Items.AddRange(new object[] {
            "Default",
            "High speed (many softlocks)",
            "Super low gravity",
            "Low gravity",
            "High gravity"});
            this.cGravity.Location = new System.Drawing.Point(169, 150);
            this.cGravity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cGravity.Name = "cGravity";
            this.cGravity.Size = new System.Drawing.Size(209, 24);
            this.cGravity.TabIndex = 0;
            this.cGravity.SelectedIndexChanged += new System.EventHandler(this.cGravity_SelectedIndexChanged);
            // 
            // tabComfort
            // 
            this.tabComfort.Controls.Add(this.cFreeHints);
            this.tabComfort.Controls.Add(this.cTatl);
            this.tabComfort.Controls.Add(this.cCutsc);
            this.tabComfort.Controls.Add(this.lTatl);
            this.tabComfort.Controls.Add(this.cQText);
            this.tabComfort.Controls.Add(this.cLink);
            this.tabComfort.Controls.Add(this.lTunic);
            this.tabComfort.Controls.Add(this.cBGM);
            this.tabComfort.Controls.Add(this.lLink);
            this.tabComfort.Controls.Add(this.bTunic);
            this.tabComfort.Location = new System.Drawing.Point(4, 28);
            this.tabComfort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabComfort.Name = "tabComfort";
            this.tabComfort.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabComfort.Size = new System.Drawing.Size(464, 335);
            this.tabComfort.TabIndex = 1;
            this.tabComfort.Text = "Comfort/Cosmetics";
            this.tabComfort.UseVisualStyleBackColor = true;
            // 
            // cFreeHints
            // 
            this.cFreeHints.AutoSize = true;
            this.cFreeHints.BackColor = System.Drawing.Color.Transparent;
            this.cFreeHints.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cFreeHints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFreeHints.ForeColor = System.Drawing.Color.Black;
            this.cFreeHints.Location = new System.Drawing.Point(69, 113);
            this.cFreeHints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cFreeHints.Name = "cFreeHints";
            this.cFreeHints.Size = new System.Drawing.Size(93, 21);
            this.cFreeHints.TabIndex = 15;
            this.cFreeHints.Text = "Free hints";
            this.cFreeHints.UseVisualStyleBackColor = false;
            this.cFreeHints.CheckedChanged += new System.EventHandler(this.cFreeHints_CheckedChanged);
            // 
            // cTatl
            // 
            this.cTatl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTatl.FormattingEnabled = true;
            this.cTatl.Items.AddRange(new object[] {
            "Default",
            "Dark",
            "Hot",
            "Cool",
            "Random",
            "Rainbow (cycle)"});
            this.cTatl.Location = new System.Drawing.Point(312, 101);
            this.cTatl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cTatl.Name = "cTatl";
            this.cTatl.Size = new System.Drawing.Size(140, 24);
            this.cTatl.TabIndex = 12;
            this.cTatl.SelectedIndexChanged += new System.EventHandler(this.cTatl_SelectedIndexChanged);
            // 
            // cCutsc
            // 
            this.cCutsc.AutoSize = true;
            this.cCutsc.BackColor = System.Drawing.Color.Transparent;
            this.cCutsc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cCutsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCutsc.ForeColor = System.Drawing.Color.Black;
            this.cCutsc.Location = new System.Drawing.Point(12, 28);
            this.cCutsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cCutsc.Name = "cCutsc";
            this.cCutsc.Size = new System.Drawing.Size(148, 21);
            this.cCutsc.TabIndex = 5;
            this.cCutsc.Text = "Shorten cutscenes";
            this.cCutsc.UseVisualStyleBackColor = false;
            this.cCutsc.CheckedChanged += new System.EventHandler(this.cCutsc_CheckedChanged);
            // 
            // lTatl
            // 
            this.lTatl.AutoSize = true;
            this.lTatl.BackColor = System.Drawing.Color.Transparent;
            this.lTatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTatl.ForeColor = System.Drawing.Color.Black;
            this.lTatl.Location = new System.Drawing.Point(179, 105);
            this.lTatl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTatl.Name = "lTatl";
            this.lTatl.Size = new System.Drawing.Size(124, 17);
            this.lTatl.TabIndex = 11;
            this.lTatl.Text = "Tatl color scheme:";
            // 
            // cQText
            // 
            this.cQText.AutoSize = true;
            this.cQText.BackColor = System.Drawing.Color.Transparent;
            this.cQText.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cQText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cQText.ForeColor = System.Drawing.Color.Black;
            this.cQText.Location = new System.Drawing.Point(67, 57);
            this.cQText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cQText.Name = "cQText";
            this.cQText.Size = new System.Drawing.Size(92, 21);
            this.cQText.TabIndex = 6;
            this.cQText.Text = "Quick text";
            this.cQText.UseVisualStyleBackColor = false;
            this.cQText.CheckedChanged += new System.EventHandler(this.cQText_CheckedChanged);
            // 
            // cLink
            // 
            this.cLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLink.FormattingEnabled = true;
            this.cLink.Items.AddRange(new object[] {
            "Link (MM)",
            "Link (OoT)",
            "Adult Link (Risky!)",
            "Kafei"});
            this.cLink.Location = new System.Drawing.Point(312, 68);
            this.cLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cLink.Name = "cLink";
            this.cLink.Size = new System.Drawing.Size(140, 24);
            this.cLink.TabIndex = 10;
            this.cLink.SelectedIndexChanged += new System.EventHandler(this.cLink_SelectedIndexChanged);
            // 
            // lTunic
            // 
            this.lTunic.AutoSize = true;
            this.lTunic.BackColor = System.Drawing.Color.Transparent;
            this.lTunic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTunic.ForeColor = System.Drawing.Color.Black;
            this.lTunic.Location = new System.Drawing.Point(220, 38);
            this.lTunic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTunic.Name = "lTunic";
            this.lTunic.Size = new System.Drawing.Size(82, 17);
            this.lTunic.TabIndex = 7;
            this.lTunic.Text = "Tunic color:";
            // 
            // cBGM
            // 
            this.cBGM.AutoSize = true;
            this.cBGM.BackColor = System.Drawing.Color.Transparent;
            this.cBGM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGM.ForeColor = System.Drawing.Color.Black;
            this.cBGM.Location = new System.Drawing.Point(20, 85);
            this.cBGM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBGM.Name = "cBGM";
            this.cBGM.Size = new System.Drawing.Size(141, 21);
            this.cBGM.TabIndex = 8;
            this.cBGM.Text = "Randomize music";
            this.cBGM.UseVisualStyleBackColor = false;
            this.cBGM.CheckedChanged += new System.EventHandler(this.cBGM_CheckedChanged);
            // 
            // lLink
            // 
            this.lLink.AutoSize = true;
            this.lLink.BackColor = System.Drawing.Color.Transparent;
            this.lLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLink.ForeColor = System.Drawing.Color.Black;
            this.lLink.Location = new System.Drawing.Point(211, 71);
            this.lLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLink.Name = "lLink";
            this.lLink.Size = new System.Drawing.Size(94, 17);
            this.lLink.TabIndex = 9;
            this.lLink.Text = "Player model:";
            // 
            // bTunic
            // 
            this.bTunic.BackColor = System.Drawing.Color.White;
            this.bTunic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTunic.Location = new System.Drawing.Point(312, 32);
            this.bTunic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTunic.Name = "bTunic";
            this.bTunic.Size = new System.Drawing.Size(141, 28);
            this.bTunic.TabIndex = 8;
            this.bTunic.UseVisualStyleBackColor = false;
            this.bTunic.Click += new System.EventHandler(this.bTunic_Click);
            // 
            // saveROM
            // 
            this.saveROM.DefaultExt = "z64";
            this.saveROM.Filter = "ROM files|*.z64";
            // 
            // cTunic
            // 
            this.cTunic.Color = System.Drawing.Color.ForestGreen;
            // 
            // bRandomise
            // 
            this.bRandomise.Location = new System.Drawing.Point(340, 425);
            this.bRandomise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRandomise.Name = "bRandomise";
            this.bRandomise.Size = new System.Drawing.Size(123, 62);
            this.bRandomise.TabIndex = 5;
            this.bRandomise.Text = "Randomize";
            this.bRandomise.UseVisualStyleBackColor = true;
            this.bRandomise.Click += new System.EventHandler(this.bRandomise_Click);
            // 
            // saveWad
            // 
            this.saveWad.DefaultExt = "wad";
            this.saveWad.Filter = "VC files|*.wad";
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mCustomise,
            this.mHelp});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mMenu.Size = new System.Drawing.Size(473, 28);
            this.mMenu.TabIndex = 12;
            this.mMenu.Text = "mMenu";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(44, 24);
            this.mFile.Text = "File";
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(161, 26);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mCustomise
            // 
            this.mCustomise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLogicEdit,
            this.mItemIncl});
            this.mCustomise.Name = "mCustomise";
            this.mCustomise.Size = new System.Drawing.Size(90, 24);
            this.mCustomise.Text = "Customize";
            // 
            // mLogicEdit
            // 
            this.mLogicEdit.Name = "mLogicEdit";
            this.mLogicEdit.Size = new System.Drawing.Size(181, 26);
            this.mLogicEdit.Text = "Logic editor";
            this.mLogicEdit.Click += new System.EventHandler(this.mLogicEdit_Click);
            // 
            // mItemIncl
            // 
            this.mItemIncl.Name = "mItemIncl";
            this.mItemIncl.Size = new System.Drawing.Size(181, 26);
            this.mItemIncl.Text = "Item list editor";
            this.mItemIncl.Click += new System.EventHandler(this.mItemIncl_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mManual,
            this.mSep1,
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(53, 24);
            this.mHelp.Text = "Help";
            // 
            // mManual
            // 
            this.mManual.Name = "mManual";
            this.mManual.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mManual.Size = new System.Drawing.Size(157, 26);
            this.mManual.Text = "Manual";
            this.mManual.Click += new System.EventHandler(this.mManual_Click);
            // 
            // mSep1
            // 
            this.mSep1.Name = "mSep1";
            this.mSep1.Size = new System.Drawing.Size(154, 6);
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(157, 26);
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // openBROM
            // 
            this.openBROM.Filter = "ROM files|*.z64;*.v64;*.n64";
            // 
            // pProgress
            // 
            this.pProgress.Location = new System.Drawing.Point(11, 522);
            this.pProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pProgress.Name = "pProgress";
            this.pProgress.Size = new System.Drawing.Size(452, 23);
            this.pProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pProgress.TabIndex = 13;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Transparent;
            this.lStatus.Location = new System.Drawing.Point(16, 498);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(61, 17);
            this.lStatus.TabIndex = 13;
            this.lStatus.Text = "Ready...";
            // 
            // tSeed
            // 
            this.tSeed.Location = new System.Drawing.Point(108, 428);
            this.tSeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tSeed.MaxLength = 10;
            this.tSeed.Name = "tSeed";
            this.tSeed.Size = new System.Drawing.Size(223, 22);
            this.tSeed.TabIndex = 2;
            this.tSeed.Enter += new System.EventHandler(this.tSeed_Enter);
            this.tSeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tSeed_KeyDown);
            this.tSeed.Leave += new System.EventHandler(this.tSeed_Leave);
            // 
            // lSeed
            // 
            this.lSeed.AutoSize = true;
            this.lSeed.BackColor = System.Drawing.Color.Transparent;
            this.lSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeed.ForeColor = System.Drawing.Color.Black;
            this.lSeed.Location = new System.Drawing.Point(7, 432);
            this.lSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeed.Name = "lSeed";
            this.lSeed.Size = new System.Drawing.Size(100, 17);
            this.lSeed.TabIndex = 3;
            this.lSeed.Text = "Random seed:";
            // 
            // tSString
            // 
            this.tSString.Location = new System.Drawing.Point(108, 459);
            this.tSString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tSString.Name = "tSString";
            this.tSString.Size = new System.Drawing.Size(223, 22);
            this.tSString.TabIndex = 6;
            this.tSString.Enter += new System.EventHandler(this.tSString_Enter);
            this.tSString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tSString_KeyDown);
            this.tSString.Leave += new System.EventHandler(this.tSString_Leave);
            // 
            // lSString
            // 
            this.lSString.AutoSize = true;
            this.lSString.BackColor = System.Drawing.Color.Transparent;
            this.lSString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSString.ForeColor = System.Drawing.Color.Black;
            this.lSString.Location = new System.Drawing.Point(7, 459);
            this.lSString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSString.Name = "lSString";
            this.lSString.Size = new System.Drawing.Size(102, 17);
            this.lSString.TabIndex = 7;
            this.lSString.Text = "Settings string:";
            // 
            // cDummy
            // 
            this.cDummy.AutoSize = true;
            this.cDummy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cDummy.Enabled = false;
            this.cDummy.Location = new System.Drawing.Point(349, 494);
            this.cDummy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cDummy.Name = "cDummy";
            this.cDummy.Size = new System.Drawing.Size(98, 21);
            this.cDummy.TabIndex = 9;
            this.cDummy.Text = "checkBox1";
            this.cDummy.UseVisualStyleBackColor = true;
            this.cDummy.Visible = false;
            // 
            // lHrule
            // 
            this.lHrule.AutoSize = true;
            this.lHrule.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lHrule.Location = new System.Drawing.Point(19, 399);
            this.lHrule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHrule.Name = "lHrule";
            this.lHrule.Size = new System.Drawing.Size(432, 17);
            this.lHrule.TabIndex = 12;
            this.lHrule.Text = "_____________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(19, 478);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "_____________________________________________________";
            // 
            // cClockSpeed
            // 
            this.cClockSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cClockSpeed.FormattingEnabled = true;
            this.cClockSpeed.Items.AddRange(new object[] {
            "Default",
            "Slow",
            "Super slow",
            "Fast",
            "Super fast (nope mode)"});
            this.cClockSpeed.Location = new System.Drawing.Point(169, 215);
            this.cClockSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cClockSpeed.Name = "cClockSpeed";
            this.cClockSpeed.Size = new System.Drawing.Size(209, 24);
            this.cClockSpeed.TabIndex = 15;
            this.cClockSpeed.SelectedIndexChanged += new System.EventHandler(this.cClockSpeed_SelectedIndexChanged);
            // 
            // lClockSpeed
            // 
            this.lClockSpeed.AutoSize = true;
            this.lClockSpeed.Location = new System.Drawing.Point(73, 218);
            this.lClockSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lClockSpeed.Name = "lClockSpeed";
            this.lClockSpeed.Size = new System.Drawing.Size(85, 17);
            this.lClockSpeed.TabIndex = 16;
            this.lClockSpeed.Text = "Clock speed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 556);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.cDummy);
            this.Controls.Add(this.pProgress);
            this.Controls.Add(this.lSString);
            this.Controls.Add(this.tSettings);
            this.Controls.Add(this.tSString);
            this.Controls.Add(this.lSeed);
            this.Controls.Add(this.tSeed);
            this.Controls.Add(this.bRandomise);
            this.Controls.Add(this.mMenu);
            this.Controls.Add(this.lHrule);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.mmrMain_Load);
            this.tSettings.ResumeLayout(false);
            this.tabROMSettings.ResumeLayout(false);
            this.tabROMSettings.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabGimmick.ResumeLayout(false);
            this.tabGimmick.PerformLayout();
            this.tabComfort.ResumeLayout(false);
            this.tabComfort.PerformLayout();
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bopen;
        private System.Windows.Forms.OpenFileDialog openROM;
        private System.Windows.Forms.TextBox tROMName;
        private System.Windows.Forms.ComboBox cMode;
        private System.Windows.Forms.Label lMode;
        private System.Windows.Forms.SaveFileDialog saveROM;
        private System.Windows.Forms.ComboBox cTatl;
        private System.Windows.Forms.Label lTatl;
        private System.Windows.Forms.ComboBox cLink;
        private System.Windows.Forms.Label lLink;
        private System.Windows.Forms.Button bTunic;
        private System.Windows.Forms.Label lTunic;
        private System.Windows.Forms.CheckBox cQText;
        private System.Windows.Forms.CheckBox cCutsc;
        private System.Windows.Forms.CheckBox cEnemy;
        private System.Windows.Forms.CheckBox cBGM;
        private System.Windows.Forms.CheckBox cDEnt;
        private System.Windows.Forms.CheckBox cShop;
        private System.Windows.Forms.CheckBox cBottled;
        private System.Windows.Forms.CheckBox cDChests;
        private System.Windows.Forms.CheckBox cMixSongs;
        private System.Windows.Forms.ColorDialog cTunic;
        private System.Windows.Forms.Button bRandomise;
        private System.Windows.Forms.CheckBox cSoS;
        private System.Windows.Forms.TabControl tSettings;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabComfort;
        private System.Windows.Forms.TabPage tabGimmick;
        private System.Windows.Forms.Label lFloors;
        private System.Windows.Forms.Label lGravity;
        private System.Windows.Forms.Label lDType;
        private System.Windows.Forms.Label lDMult;
        private System.Windows.Forms.ComboBox cFloors;
        private System.Windows.Forms.ComboBox cDType;
        private System.Windows.Forms.ComboBox cDMult;
        private System.Windows.Forms.ComboBox cGravity;
        private System.Windows.Forms.CheckBox cGossip;
        private System.Windows.Forms.SaveFileDialog saveWad;
        private System.Windows.Forms.CheckBox cVC;
        private System.Windows.Forms.CheckBox cN64;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mManual;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripSeparator mSep1;
        private System.Windows.Forms.OpenFileDialog openBROM;
        private System.Windows.Forms.CheckBox cAdditional;
        private System.Windows.Forms.ToolStripMenuItem mCustomise;
        private System.Windows.Forms.ToolStripMenuItem mLogicEdit;
        private System.Windows.Forms.ToolStripMenuItem mItemIncl;
        private System.Windows.Forms.CheckBox cUserItems;
        private System.Windows.Forms.OpenFileDialog openLogic;
        private System.Windows.Forms.ProgressBar pProgress;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TabPage tabROMSettings;
        private System.Windows.Forms.TextBox tSeed;
        private System.Windows.Forms.Label lSeed;
        private System.Windows.Forms.TextBox tSString;
        private System.Windows.Forms.Label lSString;
        private System.Windows.Forms.CheckBox cSpoiler;
        private System.Windows.Forms.CheckBox cDummy;
        private System.Windows.Forms.Label lHrule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cFreeHints;
        private System.Windows.Forms.CheckBox cHTMLLog;
        private System.Windows.Forms.Label lClockSpeed;
        private System.Windows.Forms.ComboBox cClockSpeed;
    }
}


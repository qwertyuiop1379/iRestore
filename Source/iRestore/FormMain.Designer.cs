namespace iRestore
{
    partial class FormMain
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
            this.LabelTop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextIPSW = new System.Windows.Forms.TextBox();
            this.ButtonIPSW = new System.Windows.Forms.Button();
            this.TextBlob = new System.Windows.Forms.TextBox();
            this.ButtonBlob = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelSupport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckSEP = new System.Windows.Forms.CheckBox();
            this.CheckBaseband = new System.Windows.Forms.CheckBox();
            this.ButtonSEP = new System.Windows.Forms.Button();
            this.TextSEP = new System.Windows.Forms.TextBox();
            this.ButtonBaseband = new System.Windows.Forms.Button();
            this.TextBaseband = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonRestore = new System.Windows.Forms.Button();
            this.CheckDebug = new System.Windows.Forms.CheckBox();
            this.CheckNoBaseband = new System.Windows.Forms.CheckBox();
            this.ButtonBManifest = new System.Windows.Forms.Button();
            this.TextBManifest = new System.Windows.Forms.TextBox();
            this.CheckUpdate = new System.Windows.Forms.CheckBox();
            this.CheckWait = new System.Windows.Forms.CheckBox();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTop
            // 
            this.LabelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.LabelTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTop.Location = new System.Drawing.Point(0, 0);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(714, 32);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTop_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "by qwertyuiop1379";
            // 
            // TextIPSW
            // 
            this.TextIPSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextIPSW.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIPSW.ForeColor = System.Drawing.Color.White;
            this.TextIPSW.Location = new System.Drawing.Point(12, 118);
            this.TextIPSW.Name = "TextIPSW";
            this.TextIPSW.ReadOnly = true;
            this.TextIPSW.Size = new System.Drawing.Size(226, 22);
            this.TextIPSW.TabIndex = 6;
            // 
            // ButtonIPSW
            // 
            this.ButtonIPSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonIPSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonIPSW.ForeColor = System.Drawing.Color.White;
            this.ButtonIPSW.Location = new System.Drawing.Point(12, 146);
            this.ButtonIPSW.Name = "ButtonIPSW";
            this.ButtonIPSW.Size = new System.Drawing.Size(226, 40);
            this.ButtonIPSW.TabIndex = 7;
            this.ButtonIPSW.Text = "Choose IPSW";
            this.ButtonIPSW.UseVisualStyleBackColor = false;
            this.ButtonIPSW.Click += new System.EventHandler(this.ButtonIPSW_Click);
            // 
            // TextBlob
            // 
            this.TextBlob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBlob.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBlob.ForeColor = System.Drawing.Color.White;
            this.TextBlob.Location = new System.Drawing.Point(12, 211);
            this.TextBlob.Name = "TextBlob";
            this.TextBlob.ReadOnly = true;
            this.TextBlob.Size = new System.Drawing.Size(226, 22);
            this.TextBlob.TabIndex = 8;
            // 
            // ButtonBlob
            // 
            this.ButtonBlob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonBlob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBlob.ForeColor = System.Drawing.Color.White;
            this.ButtonBlob.Location = new System.Drawing.Point(12, 239);
            this.ButtonBlob.Name = "ButtonBlob";
            this.ButtonBlob.Size = new System.Drawing.Size(226, 40);
            this.ButtonBlob.TabIndex = 9;
            this.ButtonBlob.Text = "Choose SHSH2 Blob";
            this.ButtonBlob.UseVisualStyleBackColor = false;
            this.ButtonBlob.Click += new System.EventHandler(this.ButtonBlob_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "If you like my work, please consider";
            // 
            // LabelSupport
            // 
            this.LabelSupport.AutoSize = true;
            this.LabelSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSupport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LabelSupport.Location = new System.Drawing.Point(197, 380);
            this.LabelSupport.Name = "LabelSupport";
            this.LabelSupport.Size = new System.Drawing.Size(86, 13);
            this.LabelSupport.TabIndex = 4;
            this.LabelSupport.Text = "supporting me.";
            this.LabelSupport.Click += new System.EventHandler(this.LabelSupport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(279, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "A lot of time goes in.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "iRestore";
            // 
            // CheckSEP
            // 
            this.CheckSEP.AutoSize = true;
            this.CheckSEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSEP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSEP.Location = new System.Drawing.Point(476, 236);
            this.CheckSEP.Name = "CheckSEP";
            this.CheckSEP.Size = new System.Drawing.Size(235, 17);
            this.CheckSEP.TabIndex = 12;
            this.CheckSEP.Text = "Use Latest SEP (reported to break restore)";
            this.CheckSEP.UseVisualStyleBackColor = true;
            this.CheckSEP.CheckedChanged += new System.EventHandler(this.CheckSEP_CheckedChanged);
            // 
            // CheckBaseband
            // 
            this.CheckBaseband.AutoSize = true;
            this.CheckBaseband.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBaseband.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBaseband.Location = new System.Drawing.Point(476, 259);
            this.CheckBaseband.Name = "CheckBaseband";
            this.CheckBaseband.Size = new System.Drawing.Size(239, 17);
            this.CheckBaseband.TabIndex = 13;
            this.CheckBaseband.Text = "Use Latest Baseband (might break restore)";
            this.CheckBaseband.UseVisualStyleBackColor = true;
            this.CheckBaseband.CheckedChanged += new System.EventHandler(this.CheckBaseband_CheckedChanged);
            // 
            // ButtonSEP
            // 
            this.ButtonSEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonSEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSEP.ForeColor = System.Drawing.Color.White;
            this.ButtonSEP.Location = new System.Drawing.Point(244, 146);
            this.ButtonSEP.Name = "ButtonSEP";
            this.ButtonSEP.Size = new System.Drawing.Size(226, 40);
            this.ButtonSEP.TabIndex = 15;
            this.ButtonSEP.Text = "Choose SEP";
            this.ButtonSEP.UseVisualStyleBackColor = false;
            this.ButtonSEP.Click += new System.EventHandler(this.ButtonSEP_Click);
            // 
            // TextSEP
            // 
            this.TextSEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextSEP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSEP.ForeColor = System.Drawing.Color.White;
            this.TextSEP.Location = new System.Drawing.Point(244, 118);
            this.TextSEP.Name = "TextSEP";
            this.TextSEP.ReadOnly = true;
            this.TextSEP.Size = new System.Drawing.Size(226, 22);
            this.TextSEP.TabIndex = 14;
            // 
            // ButtonBaseband
            // 
            this.ButtonBaseband.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonBaseband.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBaseband.ForeColor = System.Drawing.Color.White;
            this.ButtonBaseband.Location = new System.Drawing.Point(244, 239);
            this.ButtonBaseband.Name = "ButtonBaseband";
            this.ButtonBaseband.Size = new System.Drawing.Size(226, 40);
            this.ButtonBaseband.TabIndex = 17;
            this.ButtonBaseband.Text = "Choose Baseband";
            this.ButtonBaseband.UseVisualStyleBackColor = false;
            this.ButtonBaseband.Click += new System.EventHandler(this.ButtonBaseband_Click);
            // 
            // TextBaseband
            // 
            this.TextBaseband.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBaseband.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBaseband.ForeColor = System.Drawing.Color.White;
            this.TextBaseband.Location = new System.Drawing.Point(244, 211);
            this.TextBaseband.Name = "TextBaseband";
            this.TextBaseband.ReadOnly = true;
            this.TextBaseband.Size = new System.Drawing.Size(226, 22);
            this.TextBaseband.TabIndex = 16;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.Location = new System.Drawing.Point(686, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(24, 24);
            this.ButtonClose.TabIndex = 18;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.ButtonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRestore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestore.Location = new System.Drawing.Point(12, 292);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(570, 78);
            this.ButtonRestore.TabIndex = 19;
            this.ButtonRestore.Text = "Go!";
            this.ButtonRestore.UseVisualStyleBackColor = false;
            this.ButtonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // CheckDebug
            // 
            this.CheckDebug.AutoSize = true;
            this.CheckDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDebug.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDebug.Location = new System.Drawing.Point(524, 378);
            this.CheckDebug.Name = "CheckDebug";
            this.CheckDebug.Size = new System.Drawing.Size(58, 17);
            this.CheckDebug.TabIndex = 20;
            this.CheckDebug.Text = "Debug";
            this.CheckDebug.UseVisualStyleBackColor = true;
            // 
            // CheckNoBaseband
            // 
            this.CheckNoBaseband.AutoSize = true;
            this.CheckNoBaseband.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckNoBaseband.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNoBaseband.Location = new System.Drawing.Point(476, 213);
            this.CheckNoBaseband.Name = "CheckNoBaseband";
            this.CheckNoBaseband.Size = new System.Drawing.Size(92, 17);
            this.CheckNoBaseband.TabIndex = 21;
            this.CheckNoBaseband.Text = "No Baseband";
            this.CheckNoBaseband.UseVisualStyleBackColor = true;
            this.CheckNoBaseband.CheckedChanged += new System.EventHandler(this.CheckNoBaseband_CheckedChanged);
            // 
            // ButtonBManifest
            // 
            this.ButtonBManifest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonBManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBManifest.ForeColor = System.Drawing.Color.White;
            this.ButtonBManifest.Location = new System.Drawing.Point(476, 146);
            this.ButtonBManifest.Name = "ButtonBManifest";
            this.ButtonBManifest.Size = new System.Drawing.Size(226, 40);
            this.ButtonBManifest.TabIndex = 23;
            this.ButtonBManifest.Text = "Choose Build Manifest";
            this.ButtonBManifest.UseVisualStyleBackColor = false;
            this.ButtonBManifest.Click += new System.EventHandler(this.ButtonBManifest_Click);
            // 
            // TextBManifest
            // 
            this.TextBManifest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBManifest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBManifest.ForeColor = System.Drawing.Color.White;
            this.TextBManifest.Location = new System.Drawing.Point(476, 118);
            this.TextBManifest.Name = "TextBManifest";
            this.TextBManifest.ReadOnly = true;
            this.TextBManifest.Size = new System.Drawing.Size(226, 22);
            this.TextBManifest.TabIndex = 24;
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.AutoSize = true;
            this.CheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUpdate.Location = new System.Drawing.Point(588, 378);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(61, 17);
            this.CheckUpdate.TabIndex = 26;
            this.CheckUpdate.Text = "Update";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            // 
            // CheckWait
            // 
            this.CheckWait.AutoSize = true;
            this.CheckWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckWait.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckWait.Location = new System.Drawing.Point(655, 378);
            this.CheckWait.Name = "CheckWait";
            this.CheckWait.Size = new System.Drawing.Size(47, 17);
            this.CheckWait.TabIndex = 27;
            this.CheckWait.Text = "Wait";
            this.CheckWait.UseVisualStyleBackColor = true;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHelp.Location = new System.Drawing.Point(656, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(24, 24);
            this.ButtonHelp.TabIndex = 28;
            this.ButtonHelp.Text = "?";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(588, 292);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(114, 78);
            this.ButtonExit.TabIndex = 29;
            this.ButtonExit.Text = "Exit Recovery Mode";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(714, 402);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.CheckWait);
            this.Controls.Add(this.CheckUpdate);
            this.Controls.Add(this.TextBManifest);
            this.Controls.Add(this.ButtonBManifest);
            this.Controls.Add(this.CheckNoBaseband);
            this.Controls.Add(this.CheckDebug);
            this.Controls.Add(this.ButtonRestore);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonBaseband);
            this.Controls.Add(this.TextBaseband);
            this.Controls.Add(this.ButtonSEP);
            this.Controls.Add(this.TextSEP);
            this.Controls.Add(this.CheckBaseband);
            this.Controls.Add(this.CheckSEP);
            this.Controls.Add(this.ButtonBlob);
            this.Controls.Add(this.TextBlob);
            this.Controls.Add(this.ButtonIPSW);
            this.Controls.Add(this.TextIPSW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelSupport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "iRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextIPSW;
        private System.Windows.Forms.Button ButtonIPSW;
        private System.Windows.Forms.TextBox TextBlob;
        private System.Windows.Forms.Button ButtonBlob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelSupport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckSEP;
        private System.Windows.Forms.CheckBox CheckBaseband;
        private System.Windows.Forms.Button ButtonSEP;
        private System.Windows.Forms.TextBox TextSEP;
        private System.Windows.Forms.Button ButtonBaseband;
        private System.Windows.Forms.TextBox TextBaseband;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonRestore;
        private System.Windows.Forms.CheckBox CheckDebug;
        private System.Windows.Forms.CheckBox CheckNoBaseband;
        private System.Windows.Forms.Button ButtonBManifest;
        private System.Windows.Forms.TextBox TextBManifest;
        private System.Windows.Forms.CheckBox CheckUpdate;
        private System.Windows.Forms.CheckBox CheckWait;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonExit;
    }
}


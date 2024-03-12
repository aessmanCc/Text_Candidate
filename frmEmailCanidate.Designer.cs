
namespace Email_Canidates
{
    partial class frmEmailCanidate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcanidateName = new System.Windows.Forms.TextBox();
            this.txtcanidateNumber = new System.Windows.Forms.TextBox();
            this.txtuserMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboWirelessProvider = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcanidateName
            // 
            this.txtcanidateName.Location = new System.Drawing.Point(21, 41);
            this.txtcanidateName.Name = "txtcanidateName";
            this.txtcanidateName.Size = new System.Drawing.Size(92, 23);
            this.txtcanidateName.TabIndex = 0;
            this.txtcanidateName.Tag = "Canidate Name";
            // 
            // txtcanidateNumber
            // 
            this.txtcanidateNumber.Location = new System.Drawing.Point(142, 41);
            this.txtcanidateNumber.Name = "txtcanidateNumber";
            this.txtcanidateNumber.Size = new System.Drawing.Size(100, 23);
            this.txtcanidateNumber.TabIndex = 1;
            this.txtcanidateNumber.Tag = "Phone Number";
            // 
            // txtuserMessage
            // 
            this.txtuserMessage.Location = new System.Drawing.Point(21, 100);
            this.txtuserMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtuserMessage.Multiline = true;
            this.txtuserMessage.Name = "txtuserMessage";
            this.txtuserMessage.Size = new System.Drawing.Size(163, 109);
            this.txtuserMessage.TabIndex = 2;
            this.txtuserMessage.Tag = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(21, 225);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 28);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(123, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Canidate Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            // 
            // cboWirelessProvider
            // 
            this.cboWirelessProvider.FormattingEnabled = true;
            this.cboWirelessProvider.Items.AddRange(new object[] {
            "@message.alltel.com",
            "@txt.att.net",
            "@messaging.nextel.com",
            "@messaging.sprintpcs.com",
            "@tms.suncom.com",
            "@tmomail.net",
            "@voicestream.net",
            "@vtext.com"});
            this.cboWirelessProvider.Location = new System.Drawing.Point(260, 41);
            this.cboWirelessProvider.Name = "cboWirelessProvider";
            this.cboWirelessProvider.Size = new System.Drawing.Size(121, 23);
            this.cboWirelessProvider.TabIndex = 9;
            this.cboWirelessProvider.Tag = "Phone Provider";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Ext";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(227, 225);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(93, 28);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmEmailCanidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 277);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboWirelessProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtuserMessage);
            this.Controls.Add(this.txtcanidateNumber);
            this.Controls.Add(this.txtcanidateName);
            this.Name = "frmEmailCanidate";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcanidateName;
        private System.Windows.Forms.TextBox txtcanidateNumber;
        private System.Windows.Forms.TextBox txtuserMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWirelessProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSettings;
    }
}


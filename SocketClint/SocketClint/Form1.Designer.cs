
namespace SocketClint
{
    partial class Form1
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtAllMessages = new System.Windows.Forms.TextBox();
            this.lstAllUsers = new System.Windows.Forms.ListBox();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.numPort);
            this.gbLogin.Controls.Add(this.txtServer);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(764, 130);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(71, 80);
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(88, 23);
            this.numPort.TabIndex = 6;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(71, 53);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(553, 23);
            this.txtServer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server addr";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(630, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 54);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(71, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(553, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.txtMsg);
            this.gbMain.Controls.Add(this.txtAllMessages);
            this.gbMain.Controls.Add(this.lstAllUsers);
            this.gbMain.Location = new System.Drawing.Point(12, 148);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(764, 290);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(142, 252);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(616, 23);
            this.txtMsg.TabIndex = 2;
            // 
            // txtAllMessages
            // 
            this.txtAllMessages.Location = new System.Drawing.Point(142, 17);
            this.txtAllMessages.Multiline = true;
            this.txtAllMessages.Name = "txtAllMessages";
            this.txtAllMessages.ReadOnly = true;
            this.txtAllMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAllMessages.Size = new System.Drawing.Size(616, 229);
            this.txtAllMessages.TabIndex = 1;
            // 
            // lstAllUsers
            // 
            this.lstAllUsers.FormattingEnabled = true;
            this.lstAllUsers.ItemHeight = 15;
            this.lstAllUsers.Location = new System.Drawing.Point(6, 17);
            this.lstAllUsers.Name = "lstAllUsers";
            this.lstAllUsers.Size = new System.Drawing.Size(129, 259);
            this.lstAllUsers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtAllMessages;
        private System.Windows.Forms.ListBox lstAllUsers;
    }
}


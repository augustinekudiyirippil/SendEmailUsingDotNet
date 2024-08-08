namespace SendEmailUsingSMTP
{
    partial class frmSMTP
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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtError = new TextBox();
            txtEmailTarget = new TextBox();
            label7 = new Label();
            txtEmailHost = new TextBox();
            txtEmailPort = new TextBox();
            txtEmailMessage = new TextBox();
            txtEmailSubject = new TextBox();
            txtEmailTo = new TextBox();
            txtEmailPassword = new TextBox();
            txtEmailFrom = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSendEmail = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(171, 40);
            label12.Name = "label12";
            label12.Size = new Size(92, 19);
            label12.TabIndex = 47;
            label12.Text = "Email address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(486, 40);
            label11.Name = "label11";
            label11.Size = new Size(103, 19);
            label11.TabIndex = 46;
            label11.Text = "Email password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(497, 466);
            label10.Name = "label10";
            label10.Size = new Size(447, 15);
            label10.TabIndex = 45;
            label10.Text = "----------------------------------------------------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 466);
            label9.Name = "label9";
            label9.Size = new Size(447, 15);
            label9.TabIndex = 44;
            label9.Text = "----------------------------------------------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(53, 501);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 43;
            label8.Text = "Exception";
            // 
            // txtError
            // 
            txtError.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(162, 501);
            txtError.Multiline = true;
            txtError.Name = "txtError";
            txtError.ReadOnly = true;
            txtError.Size = new Size(540, 68);
            txtError.TabIndex = 42;
            txtError.Text = "Exception message";
            // 
            // txtEmailTarget
            // 
            txtEmailTarget.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailTarget.Location = new Point(171, 406);
            txtEmailTarget.Name = "txtEmailTarget";
            txtEmailTarget.Size = new Size(401, 29);
            txtEmailTarget.TabIndex = 41;
            txtEmailTarget.Text = "STARTTLS/  Provide outgoing email server name here";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(53, 406);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 40;
            label7.Text = "Target";
            // 
            // txtEmailHost
            // 
            txtEmailHost.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailHost.Location = new Point(171, 347);
            txtEmailHost.Name = "txtEmailHost";
            txtEmailHost.Size = new Size(401, 29);
            txtEmailHost.TabIndex = 39;
            txtEmailHost.Text = "Provide outgoing email server name here";
            // 
            // txtEmailPort
            // 
            txtEmailPort.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailPort.Location = new Point(171, 296);
            txtEmailPort.Name = "txtEmailPort";
            txtEmailPort.Size = new Size(401, 29);
            txtEmailPort.TabIndex = 38;
            txtEmailPort.Text = "Provide  outgoing email port number here";
            // 
            // txtEmailMessage
            // 
            txtEmailMessage.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailMessage.Location = new Point(171, 204);
            txtEmailMessage.Multiline = true;
            txtEmailMessage.Name = "txtEmailMessage";
            txtEmailMessage.Size = new Size(584, 68);
            txtEmailMessage.TabIndex = 37;
            txtEmailMessage.Text = "Provide email message here";
            // 
            // txtEmailSubject
            // 
            txtEmailSubject.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailSubject.Location = new Point(171, 154);
            txtEmailSubject.Name = "txtEmailSubject";
            txtEmailSubject.Size = new Size(299, 29);
            txtEmailSubject.TabIndex = 36;
            txtEmailSubject.Text = "Provide email subject here";
            // 
            // txtEmailTo
            // 
            txtEmailTo.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailTo.Location = new Point(171, 105);
            txtEmailTo.Name = "txtEmailTo";
            txtEmailTo.Size = new Size(299, 29);
            txtEmailTo.TabIndex = 35;
            txtEmailTo.Text = "Provide to email address here";
            // 
            // txtEmailPassword
            // 
            txtEmailPassword.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailPassword.Location = new Point(486, 64);
            txtEmailPassword.Name = "txtEmailPassword";
            txtEmailPassword.Size = new Size(269, 29);
            txtEmailPassword.TabIndex = 34;
            txtEmailPassword.Text = "Provide from email password here";
            // 
            // txtEmailFrom
            // 
            txtEmailFrom.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailFrom.Location = new Point(171, 64);
            txtEmailFrom.Name = "txtEmailFrom";
            txtEmailFrom.Size = new Size(299, 29);
            txtEmailFrom.TabIndex = 33;
            txtEmailFrom.Text = "Provide  from email address  here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 350);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 32;
            label6.Text = "Host";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 299);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 31;
            label5.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 204);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 30;
            label4.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 157);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 29;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 28;
            label2.Text = "Email To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 27;
            label1.Text = "Email From ";
            // 
            // btnSendEmail
            // 
            btnSendEmail.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendEmail.Location = new Point(810, 64);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(133, 101);
            btnSendEmail.TabIndex = 48;
            btnSendEmail.Text = "Send ";
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // frmSMTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 696);
            Controls.Add(btnSendEmail);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtError);
            Controls.Add(txtEmailTarget);
            Controls.Add(label7);
            Controls.Add(txtEmailHost);
            Controls.Add(txtEmailPort);
            Controls.Add(txtEmailMessage);
            Controls.Add(txtEmailSubject);
            Controls.Add(txtEmailTo);
            Controls.Add(txtEmailPassword);
            Controls.Add(txtEmailFrom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSMTP";
            Text = "Send email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtError;
        private TextBox txtEmailTarget;
        private Label label7;
        private TextBox txtEmailHost;
        private TextBox txtEmailPort;
        private TextBox txtEmailMessage;
        private TextBox txtEmailSubject;
        private TextBox txtEmailTo;
        private TextBox txtEmailPassword;
        private TextBox txtEmailFrom;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSendEmail;
    }
}
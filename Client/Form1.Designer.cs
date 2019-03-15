namespace Client
{
    partial class Form1
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkedListBoxClients = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.labelInvalideName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(255, 565);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 565);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // checkedListBoxClients
            // 
            this.checkedListBoxClients.FormattingEnabled = true;
            this.checkedListBoxClients.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxClients.Name = "checkedListBoxClients";
            this.checkedListBoxClients.Size = new System.Drawing.Size(173, 582);
            this.checkedListBoxClients.TabIndex = 2;
            this.checkedListBoxClients.Visible = false;
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Location = new System.Drawing.Point(220, 12);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(644, 535);
            this.richTextBoxMessages.TabIndex = 3;
            this.richTextBoxMessages.Text = "";
            this.richTextBoxMessages.Visible = false;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(390, 565);
            this.buttonSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(100, 28);
            this.buttonSendMessage.TabIndex = 4;
            this.buttonSendMessage.Text = "Send";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Visible = false;
            // 
            // labelInvalideName
            // 
            this.labelInvalideName.AutoSize = true;
            this.labelInvalideName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalideName.ForeColor = System.Drawing.Color.Red;
            this.labelInvalideName.Location = new System.Drawing.Point(25, 522);
            this.labelInvalideName.Name = "labelInvalideName";
            this.labelInvalideName.Size = new System.Drawing.Size(136, 25);
            this.labelInvalideName.TabIndex = 6;
            this.labelInvalideName.Text = "Invalide Name";
            this.labelInvalideName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 608);
            this.Controls.Add(this.labelInvalideName);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.checkedListBoxClients);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.CheckedListBox checkedListBoxClients;
        public System.Windows.Forms.RichTextBox richTextBoxMessages;
        public System.Windows.Forms.Button buttonSendMessage;
        public System.Windows.Forms.Label labelInvalideName;
    }
}


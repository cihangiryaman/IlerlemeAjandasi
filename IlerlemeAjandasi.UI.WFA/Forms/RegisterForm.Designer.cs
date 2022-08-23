namespace IlerlemeAjandasi.UI.WFA
{
    partial class RegisterForm
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
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.NickNametxt = new System.Windows.Forms.TextBox();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.PasswordVerifytxt = new System.Windows.Forms.TextBox();
            this.NickNameErrorlbl = new System.Windows.Forms.Label();
            this.PasswordErrorlbl = new System.Windows.Forms.Label();
            this.ConfirmPasswordErrorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(85, 100);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.PlaceholderText = "Şifre";
            this.Passwordtxt.Size = new System.Drawing.Size(302, 23);
            this.Passwordtxt.TabIndex = 10;
            // 
            // NickNametxt
            // 
            this.NickNametxt.Location = new System.Drawing.Point(85, 51);
            this.NickNametxt.Name = "NickNametxt";
            this.NickNametxt.PlaceholderText = "Kullanıcı Adı";
            this.NickNametxt.Size = new System.Drawing.Size(302, 23);
            this.NickNametxt.TabIndex = 9;
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(107, 210);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(257, 48);
            this.Registerbtn.TabIndex = 7;
            this.Registerbtn.Text = "Kayıt Ol";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // PasswordVerifytxt
            // 
            this.PasswordVerifytxt.Location = new System.Drawing.Point(84, 149);
            this.PasswordVerifytxt.Name = "PasswordVerifytxt";
            this.PasswordVerifytxt.PasswordChar = '*';
            this.PasswordVerifytxt.PlaceholderText = "Şifre Tekrar";
            this.PasswordVerifytxt.Size = new System.Drawing.Size(302, 23);
            this.PasswordVerifytxt.TabIndex = 12;
            // 
            // NickNameErrorlbl
            // 
            this.NickNameErrorlbl.AutoSize = true;
            this.NickNameErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.NickNameErrorlbl.Location = new System.Drawing.Point(85, 77);
            this.NickNameErrorlbl.Name = "NickNameErrorlbl";
            this.NickNameErrorlbl.Size = new System.Drawing.Size(38, 15);
            this.NickNameErrorlbl.TabIndex = 13;
            this.NickNameErrorlbl.Text = "label1";
            this.NickNameErrorlbl.Visible = false;
            // 
            // PasswordErrorlbl
            // 
            this.PasswordErrorlbl.AutoSize = true;
            this.PasswordErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorlbl.Location = new System.Drawing.Point(85, 126);
            this.PasswordErrorlbl.Name = "PasswordErrorlbl";
            this.PasswordErrorlbl.Size = new System.Drawing.Size(38, 15);
            this.PasswordErrorlbl.TabIndex = 14;
            this.PasswordErrorlbl.Text = "label2";
            this.PasswordErrorlbl.Visible = false;
            // 
            // ConfirmPasswordErrorlbl
            // 
            this.ConfirmPasswordErrorlbl.AutoSize = true;
            this.ConfirmPasswordErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.ConfirmPasswordErrorlbl.Location = new System.Drawing.Point(85, 175);
            this.ConfirmPasswordErrorlbl.Name = "ConfirmPasswordErrorlbl";
            this.ConfirmPasswordErrorlbl.Size = new System.Drawing.Size(38, 15);
            this.ConfirmPasswordErrorlbl.TabIndex = 15;
            this.ConfirmPasswordErrorlbl.Text = "label3";
            this.ConfirmPasswordErrorlbl.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 314);
            this.Controls.Add(this.ConfirmPasswordErrorlbl);
            this.Controls.Add(this.PasswordErrorlbl);
            this.Controls.Add(this.NickNameErrorlbl);
            this.Controls.Add(this.PasswordVerifytxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.NickNametxt);
            this.Controls.Add(this.Registerbtn);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Passwordtxt;
        private TextBox NickNametxt;
        private Button Registerbtn;
        private TextBox PasswordVerifytxt;
        private Label NickNameErrorlbl;
        private Label PasswordErrorlbl;
        private Label ConfirmPasswordErrorlbl;
    }
}
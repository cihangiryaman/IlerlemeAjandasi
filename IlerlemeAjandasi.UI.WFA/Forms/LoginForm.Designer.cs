namespace IlerlemeAjandasi.UI.WFA
{
    partial class LoginForm
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
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.Rememberchck = new System.Windows.Forms.CheckBox();
            this.NickNametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(74, 200);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(133, 48);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Giriş Yap";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(242, 200);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(133, 48);
            this.Registerbtn.TabIndex = 1;
            this.Registerbtn.Text = "Kayıt Ol";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Rememberchck
            // 
            this.Rememberchck.AutoSize = true;
            this.Rememberchck.Checked = true;
            this.Rememberchck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Rememberchck.Location = new System.Drawing.Point(76, 176);
            this.Rememberchck.Name = "Rememberchck";
            this.Rememberchck.Size = new System.Drawing.Size(87, 19);
            this.Rememberchck.TabIndex = 2;
            this.Rememberchck.Text = "Beni Hatırla";
            this.Rememberchck.UseVisualStyleBackColor = true;
            // 
            // NickNametxt
            // 
            this.NickNametxt.Location = new System.Drawing.Point(73, 67);
            this.NickNametxt.Name = "NickNametxt";
            this.NickNametxt.PlaceholderText = "Kullanıcı Adı";
            this.NickNametxt.Size = new System.Drawing.Size(302, 23);
            this.NickNametxt.TabIndex = 3;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(73, 114);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.PlaceholderText = "Şifre";
            this.Passwordtxt.Size = new System.Drawing.Size(302, 23);
            this.Passwordtxt.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 291);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.NickNametxt);
            this.Controls.Add(this.Rememberchck);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.Loginbtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Loginbtn;
        private Button Registerbtn;
        private CheckBox Rememberchck;
        private TextBox NickNametxt;
        private TextBox Passwordtxt;
    }
}
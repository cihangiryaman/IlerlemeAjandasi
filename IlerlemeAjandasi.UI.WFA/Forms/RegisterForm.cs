using IlerlemeAjandasi.BLL.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlerlemeAjandasi.UI.WFA
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        UserManager _userManager = new UserManager();

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            bool nickCount = false;
            bool passCount = false;
            _userManager.Register(NickNametxt.Text, Passwordtxt.Text, PasswordVerifytxt.Text);
            if (!_userManager.UserDTO.IsValid)
            {
                foreach (var error in _userManager.UserDTO.Errors)
                {
                    if (error.ErrorCode.StartsWith("USNI"))
                    {
                        NickNameErrorlbl.Text = error.ErrorMessage;
                        nickCount = true;
                    }
                    if (error.ErrorCode.StartsWith("USPA"))
                    {
                        PasswordErrorlbl.Text = error.ErrorMessage;
                        passCount = true;
                    }
                }
            }
            else
            {
                _userManager.Login(_userManager.UserDTO.NickName, _userManager.UserDTO.Password);
                this.Close();
            }
            if (nickCount)
            {
                NickNameErrorlbl.Visible = true;
                PasswordErrorlbl.Visible = false;
            }
            if (passCount)
            {
                NickNameErrorlbl.Visible = false;
                PasswordErrorlbl.Visible = true;
            }
            if (nickCount && passCount)
            {
                NickNameErrorlbl.Visible = true;  
                PasswordErrorlbl.Visible = true;
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = Application.OpenForms[0] as LoginForm;
            loginForm.Show();
        }
    }
}

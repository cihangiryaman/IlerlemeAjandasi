using IlerlemeAjandasi.BLL.Concrete;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uno.UI;

namespace IlerlemeAjandasi.UI.WFA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        UserManager _userManager = new UserManager();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userManager.Login(NickNametxt.Text,Passwordtxt.Text);
            if (_userManager.UserDTO.IsValid)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show(_userManager.UserDTO.Errors.Last().ErrorMessage);
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }
}

using Bss;
using Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadget
{
    public partial class Login : Form
    {
        #region Objects
        UserBss objectUser = new UserBss();
        UserEnt user = new UserEnt();
        #endregion
        #region Form
        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region buttonLogin
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionBss.test();
                user.USERNAME = usernameTextBox.Text.Trim();
                user.PASSWORD = cipherPassword(passwordTextBox.Text.Trim());
                user.ID = objectUser.login(user);
                if (user.ID != 0)
                {
                    Principal FormularioPrincipal = new Principal();
                    FormularioPrincipal.user.ID = user.ID;
                    this.Hide();
                    FormularioPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.ResetText();
                }
            }
            catch (SqlException sqlExceptionX)
            {
                MessageBox.Show("Hubo un problema al conectarse al servidor. " + sqlExceptionX.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Methods
        private string cipherPassword(string password)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(password);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString().ToUpper();
        }
        #endregion
    }
}
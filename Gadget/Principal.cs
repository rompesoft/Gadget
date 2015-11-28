using Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadget
{
    public partial class Principal : Form
    {
        #region Objects
        public UserEnt user = new UserEnt();
        #endregion
        #region Form
        public Principal()
        {
            InitializeComponent();
        }
        #endregion

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
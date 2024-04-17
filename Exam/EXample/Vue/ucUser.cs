using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vue
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }

        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            
            ucUtilisateur user = new ucUtilisateur();

            
        }
    }
}

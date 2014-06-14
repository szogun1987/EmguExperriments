using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguExperiments
{
    public partial class MainWindow : Form
    {
        private UserControl currentControl;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void basicTranslations_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayControl(UserControl control)
        {
            if (currentControl != null)
            {
                contentPanel.Controls.Remove(currentControl);
                currentControl.Dispose();
            }


        }
    }
}

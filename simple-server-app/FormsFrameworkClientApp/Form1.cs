using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace FormsFrameworkClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Requires admin privileges.
            // Requires service reference: ProjectName > Add > Service reference
            ServerClass myServer = new ServerClass("http://localhost:8080/MyLocalServer");
        }

        private void buttonGetFrom_Click(object sender, EventArgs e)
        {

        }
    }
}

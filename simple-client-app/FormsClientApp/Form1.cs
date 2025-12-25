using ServiceRef;

namespace FormsClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetFromTheServer_Click(object sender, EventArgs e)
        {
           InterfaceServerClient client = new InterfaceServerClient();

            string getFrom = client.getServerString();
            textBox1.Text = getFrom;
            //MessageBox.Show(getFrom);

            bool ok = client.sendsToServer("Client Message"); 
            MessageBox.Show("Server returns: " + ok);
        }
    }
}

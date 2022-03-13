namespace WinFormInputData
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            string str = txtBox.Text;
            string strToUpper = str.ToUpper();
            if (txtBox.Text == "SHOWN")
            {
                lblEmpty.Visible = true;
            }
            else if (txtBox.Text == "HIDE")
            {
                lblEmpty.Visible = false;
            }
            else if (txtBox.Text == "BESARKAN")
            {
                lblEmpty.Font = new Font("BESARKAN", lblEmpty.Font.Size + 2);
            }
            else if (txtBox.Text == "KECILKAN")
            {
                lblEmpty.Font = new Font("BESARKAN", lblEmpty.Font.Size - 2);
            }
            else if (txtBox.Text == "RESTART")
            {
                lblEmpty.Text = "[EMPTY]";
            }
            else if (txtBox.Text.Contains("ISI:"))
            {
                string isi = txtBox.Text.Substring(4);
                lblEmpty.Text = isi;
            }
            else if (strToUpper == "MERAH")
            {
                lblEmpty.ForeColor = Color.Red;
            }
            else if (strToUpper == "BIRU")
            {
                lblEmpty.ForeColor = Color.Blue;
            }
            else if (strToUpper == "HIJAU")
            {
                lblEmpty.ForeColor = Color.Green;
            }
            else
            {
                string message = "Syntax Error";
                string title = "Command not Valid";
                MessageBox.Show(message, title);
            }
        }
    }
}
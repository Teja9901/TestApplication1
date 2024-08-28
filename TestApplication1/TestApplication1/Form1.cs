using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Windows.Forms.VisualStyles;

namespace TestApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                
                MessageBox.Show("please Enter User Email ");
            }
            if (string.IsNullOrEmpty(txtPassword.Text)) {
                MessageBox.Show("please Enter Password ");
            }
          

            
        }

        public static HashSet<string> GetValidSubstrings(string S, HashSet<string> dictionary)
        {

            HashSet<string> validWords = new HashSet<string>();
            int n = S.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {

                    string substring = S.Substring(i, j - i);
                    if (dictionary.Contains(substring))
                    {
                        validWords.Add(substring);
                    }
                }
            }
            return validWords;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

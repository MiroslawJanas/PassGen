using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePass
{
    public partial class Form1 : Form
    {
        
        private static Random ran = new Random();
        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!$%&()=?-_.qwertzuioplkjhgfdsayxcvbnm";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[ran.Next(s.Length)]).ToArray());
        }


        public Form1()
        {
            InitializeComponent();
            txtBox1.Text = "12";
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            label1.Text = RandomString(Convert.ToInt32(txtBox1.Text));
            Clipboard.SetText(label1.Text);
            return;

        }
    }
}
    



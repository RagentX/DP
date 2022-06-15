using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Avt : Form
    {
        public Avt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rez = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                WebRequest request = WebRequest.Create("http://antonose.beget.tech/avt.php?log="+textBox1.Text+"&pass="+textBox2.Text);
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            rez += line;
                        }
                    }
                }
                //rez = rez.Replace("<meta charset=\"utf - 8\" />", "");
                if (rez != "")
                {
                    Properties.Settings.Default.id = Convert.ToInt32(rez);
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Пароль и логин не правильный");
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }
    }
}

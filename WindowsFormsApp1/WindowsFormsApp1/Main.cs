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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int[] selectData = { 1, 0, 0 };

        private void zakButton_Click(object sender, EventArgs e)
        {
            zakData.Visible = true;
            uslugiData.Visible = false;
            skladData.Visible = false;
            selectData[0] = 1;
            selectData[1] = 0;
            selectData[2] = 0;
        }
        private void uslugiButton_Click(object sender, EventArgs e)
        {
            zakData.Visible = false;
            uslugiData.Visible = true;
            skladData.Visible = false;
            selectData[0] = 0;
            selectData[1] = 1;
            selectData[2] = 0;
        }
        private void skladButton_Click(object sender, EventArgs e)
        {
            zakData.Visible = false;
            uslugiData.Visible = false;
            skladData.Visible = true;
            selectData[0] = 0;
            selectData[1] = 0;
            selectData[2] = 1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            zakData.Visible = true;
            uslugiData.Visible = false;
            skladData.Visible = false;
            selectData[0] = 1;
            selectData[1] = 0;
            selectData[2] = 0;
            upDate();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(selectData[0] == 1)
            {
                //AddZak zakForm = new AddZak();
                //zakForm.ShowDialog();
            }
            else
                if (selectData[1] == 1)
            {
                AddService servForm = new AddService();
                servForm.ShowDialog();  
            }
            else
                if (selectData[2] == 1)
            {
                AddParts partForm = new AddParts();
                partForm.ShowDialog();
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectData[0] == 1)
            {

            }
            else
                if (selectData[1] == 1)
            {
                AddService servForm = new AddService();
                servForm.ShowDialog();
            }
            else
                if (selectData[2] == 1)
            {
                AddParts partForm = new AddParts();
                partForm.ShowDialog();
            }
        }

        private void dellButton_Click(object sender, EventArgs e)
        {
            if (selectData[0] == 1)
            {

            }
            else
                if (selectData[1] == 1)
            {
                AddService servForm = new AddService();
                servForm.ShowDialog();
            }
            else
                if (selectData[2] == 1)
            {
                AddParts partForm = new AddParts();
                partForm.ShowDialog();
            }
        }

        private void upDateButton_Click(object sender, EventArgs e)
        {
            upDate();
        }
        private void upDate()
        {
            string rezParts = "";
            WebRequest requestParts = WebRequest.Create("http://antonose.beget.tech/parts.php");
            WebResponse responseParts = requestParts.GetResponse();
            using (Stream streamParts = responseParts.GetResponseStream())
            {
                using (StreamReader readerParts = new StreamReader(streamParts))
                {
                    string line = "";
                    while ((line = readerParts.ReadLine()) != null)
                    {
                        rezParts += line;
                    }
                }
            }
            rezParts = rezParts.Replace("<BR/>", "\n");
            string[] masRezParts = rezParts.Split('\n');
            int i = 0;
            foreach (string tabelStr in masRezParts)
            {
                string[] tabelMasStr = tabelStr.Split(';');
                if (tabelStr == "")
                    break;
                skladData.Rows.Add();
                skladData.Rows[i].Cells[0].Value = tabelMasStr[0];
                skladData.Rows[i].Cells[1].Value = tabelMasStr[1];
                skladData.Rows[i].Cells[2].Value = tabelMasStr[2];
                skladData.Rows[i].Cells[3].Value = tabelMasStr[3];

                i++;
            }
            string rezService = "";
            WebRequest requestService = WebRequest.Create("http://antonose.beget.tech/service.php");
            WebResponse responseService = requestService.GetResponse();
            using (Stream streamService = responseService.GetResponseStream())
            {
                using (StreamReader readerService = new StreamReader(streamService))
                {
                    string line = "";
                    while ((line = readerService.ReadLine()) != null)
                    {
                        rezService += line;
                    }
                }
            }
            rezService = rezService.Replace("<BR/>", "\n");
            string[] masRezService = rezService.Split('\n');
            i = 0;
            foreach (string tabelStr in masRezService)
            {
                string[] tabelMasStr = tabelStr.Split(';');
                if (tabelStr == "")
                    break;
                uslugiData.Rows.Add();
                uslugiData.Rows[i].Cells[0].Value = tabelMasStr[0];
                uslugiData.Rows[i].Cells[1].Value = tabelMasStr[1];
                uslugiData.Rows[i].Cells[2].Value = tabelMasStr[2];
                i++;
            }
            string rezOrders = "";
            WebRequest requestOrders = WebRequest.Create("http://antonose.beget.tech/orders.php");
            WebResponse responseOrders = requestOrders.GetResponse();
            using (Stream streamOrders = responseOrders.GetResponseStream())
            {
                using (StreamReader readerOrders = new StreamReader(streamOrders))
                {
                    string line = "";
                    while ((line = readerOrders.ReadLine()) != null)
                    {
                        rezOrders += line;
                    }
                }
            }
            rezOrders = rezOrders.Replace("<BR/>", "\n");
            string[] masRezOrders = rezOrders.Split('\n');
            i = 0;
            foreach (string tabelStr in masRezOrders)
            {
                string[] tabelMasStr = tabelStr.Split(';');
                if (tabelStr == "")
                    break;
                zakData.Rows.Add();
                zakData.Rows[i].Cells[0].Value = tabelMasStr[0];
                zakData.Rows[i].Cells[1].Value = tabelMasStr[1];
                zakData.Rows[i].Cells[2].Value = tabelMasStr[2];
                zakData.Rows[i].Cells[3].Value = tabelMasStr[3];
                i++;
            }
        }
    }
}

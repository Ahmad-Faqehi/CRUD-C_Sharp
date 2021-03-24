using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using System.IO;

namespace Libery
{
    public partial class Libray : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter da;
        DataSet ds;
        int count = 0;
        int pageNum = 0;
        int countSe = 0;

        public Libray()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            string sql = "select * from Library";
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\alfaq\\Documents\\Library.accdb");
            connection.Open();
            da = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();
            da.Fill(ds);
            showData(pageNum);

            // to count how many row in db
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\alfaq\\Documents\\Library.accdb"))
            using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Library", con))
            {
                con.Open();
                count = (int)command.ExecuteScalar();
            }

            // to hide the add form
            showInfoUp(false);
            showInfoAdd(false);
            showINfoSe(false);

        }
        public void showData(int index)
        {

            //IdDB.Text = ds.Tables[0].Rows[index][0].ToString(); ;
            //TitleDB.Text = ds.Tables[0].Rows[index][1].ToString();
            //AutDB.Text = ds.Tables[0].Rows[index][2].ToString();
            //PubDB.Text = ds.Tables[0].Rows[index][3].ToString();

        }

        public void showInfoAdd(bool check)
        {

            //TitleNew.Visible = check;
            //AuthNew.Visible = check;
            //NewPub.Visible = check;
            //tBoxTitle.Visible = check;
            //tBoxpub.Visible = check;
            //tBoxAuth.Visible = check;
            //tBoxpub.Visible = check;
            //buttonAdd.Visible = check;
        }

        public void showInfoUp(bool check)
        {
            //TitleNew.Visible = check;
            //AuthNew.Visible = check;
            //NewPub.Visible = check;
            //Upbut.Visible = check;
            //UpAut.Visible = check;
            //UpTit.Visible = check;
            //UpPub.Visible = check;
        }

        public void showINfoSe(bool check)
        {

            //TitleLab.Visible = check;
            //AuthLab.Visible = check;
            //ResultLab.Visible = check;
            //PubLab.Visible = check;
        }


        private void UpAut_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthLab_Click(object sender, EventArgs e)
        {

        }

        private void TitleLab_Click(object sender, EventArgs e)
        {

        }

        private void ResultLab_Click(object sender, EventArgs e)
        {

        }

        private void LastBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Done !!");
            MessageBox.Show("Delete Done !!");
            MessageBox.Show("Add Done !!");
        }

        private void FirstBut_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SearchBut_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpPub_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpTit_TextChanged(object sender, EventArgs e)
        {

        }

        private void PubLab_Click(object sender, EventArgs e)
        {

        }

        private void Upbut_Click(object sender, EventArgs e)
        {

        }

        private void DeletBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void UpdateBut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last Book");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Book");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void tBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxAuth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxpub_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPub_Click(object sender, EventArgs e)
        {

        }

        private void AuthNew_Click(object sender, EventArgs e)
        {

        }

        private void TitleNew_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PubDB_Click(object sender, EventArgs e)
        {

        }

        private void AutDB_Click(object sender, EventArgs e)
        {

        }

        private void TitleDB_Click(object sender, EventArgs e)
        {

        }

        private void IdDB_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthNew_Click_1(object sender, EventArgs e)
        {

        }

        private void TitleNew_Click_1(object sender, EventArgs e)
        {

        }

        private void TitleNew_Click_2(object sender, EventArgs e)
        {

        }
    }
}

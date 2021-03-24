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
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter da;
        DataSet ds;
        int count = 0;
        int pageNum = 0;
        int countSe = 0;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Libray fm = new Libray();
            fm.Show();
            string sql_select = "select * from Library";
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\alfaq\\Documents\\Library.accdb");
            connection.Open();
            da = new OleDbDataAdapter(sql_select, connection);
            ds = new DataSet();
            da.Fill(ds);
            showData(pageNum);

            // to count how many row in db
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\alfaq\\Documents\\Library.accdb"))
            using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Library", con))
            {
                    
                count = (int)command.ExecuteScalar();
            }

            // to hide the add form
            showInfoUp(false);
            showInfoAdd(false);
            showINfoSe(false);



        }

        public void showData(int index)
        {

            IdDB.Text = ds.Tables[0].Rows[index][0].ToString(); ;
            TitleDB.Text = ds.Tables[0].Rows[index][1].ToString();
            AutDB.Text = ds.Tables[0].Rows[index][2].ToString();
            PubDB.Text = ds.Tables[0].Rows[index][3].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showInfoAdd(false);
            showInfoUp(false);
                pageNum++;

                if (pageNum < count)
                {
                    showData(pageNum);
                }
                else
                {
                    MessageBox.Show("This it the last book");
                    pageNum--;
                }
            

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            showInfoAdd(false);
            showInfoUp(false);
            pageNum--;
            if (pageNum >= 0)
            {
                showData(pageNum);
            }
            else
            {
                MessageBox.Show("This is the first book");
                pageNum++;
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // to show the form for add
            showInfoUp(false);
            showInfoAdd(true);


        }

        public void showInfoAdd(bool check) {

            TitleNew.Visible = check;
            AuthNew.Visible = check;
            NewPub.Visible = check;
            tBoxTitle.Visible = check;
            tBoxpub.Visible = check;
            tBoxAuth.Visible = check;
            tBoxpub.Visible = check;
            buttonAdd.Visible = check;
        }

        public void showInfoUp(bool check)
        {
            TitleNew.Visible = check;
            AuthNew.Visible = check;
            NewPub.Visible = check;
            Upbut.Visible = check;
            UpAut.Visible = check;
            UpTit.Visible = check;
            UpPub.Visible = check;
        }

        public void showINfoSe(bool check) {

            TitleLab.Visible = check;
            AuthLab.Visible = check;
            ResultLab.Visible = check;
            PubLab.Visible = check;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {   // this mehod for insert


              int insert_id = count + 1;
            da.InsertCommand = new OleDbCommand();
            da.InsertCommand.CommandText = "insert into Library (book_id, book_title, author, publication ) values('" + insert_id + "' ,'" + tBoxTitle.Text + "' , '" + tBoxAuth.Text + "' , '" + tBoxpub.Text + "')";
            da.InsertCommand.Connection = connection;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Add Done Successfully");
           



        }
        private void Upbut_Click(object sender, EventArgs e)
        {   // this mehod for update

            int numID = pageNum + 1;
            string sql_update = "UPDATE Library  set book_title = @title, author = @auth, publication = @pub WHERE book_id = @id";
            da.UpdateCommand = new OleDbCommand();
            da.UpdateCommand.CommandText = sql_update;
            da.UpdateCommand.Connection = connection;
            da.UpdateCommand.Parameters.AddWithValue("@title", UpTit.Text);
            da.UpdateCommand.Parameters.AddWithValue("@auth", UpAut.Text);
            da.UpdateCommand.Parameters.AddWithValue("@pub", UpPub.Text);
            da.UpdateCommand.Parameters.AddWithValue("@id", numID);
            da.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("Update Done Successfully");
          


        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   // this method for delete
            
            int numID = pageNum + 1 ;
            da.DeleteCommand = new OleDbCommand();
            da.DeleteCommand.CommandText = "DELETE FROM Library WHERE book_id = " + numID + "";
            da.DeleteCommand.Connection = connection;
            da.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("Delete Done Successfully");
           
           

        }

        private void UpdateBut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showInfoAdd(false);
                int numID = pageNum;
                UpTit.Text = ds.Tables[0].Rows[numID][1].ToString();
                UpAut.Text = ds.Tables[0].Rows[numID][2].ToString();
                UpPub.Text = ds.Tables[0].Rows[numID][3].ToString();
            showInfoUp(true);

        }

        private void FirstBut_Click(object sender, EventArgs e)
        {
            pageNum = 0;
            showData(pageNum);
        }

        private void LastBut_Click(object sender, EventArgs e)
        {
            pageNum = count - 1;
            showData(pageNum);
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            // search but
           

            using (OleDbConnection connSea = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\alfaq\\Documents\\Library.accdb"))
            using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Library WHERE book_title LIKE '" + tbSearch.Text.ToString() + "%' ", connSea))
            {
                connSea.Open();
                countSe = (int)command.ExecuteScalar();
            }


            if (countSe != 0 ) {
                showINfoSe(true);
            da.SelectCommand = new OleDbCommand();
            da.SelectCommand.CommandText = "SELECT * FROM Library WHERE book_title LIKE '"+ tbSearch.Text.ToString() + "%' ";
            da.SelectCommand.Connection = connection;
            da.SelectCommand.ExecuteNonQuery();
            ds = new DataSet();
            da.Fill(ds);

        
            TitleLab.Text = ds.Tables[0].Rows[0][1].ToString();
            AuthLab.Text = ds.Tables[0].Rows[0][2].ToString();
            PubLab.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("not found");
            }
            
        }






















        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void lab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void NewPub_Click(object sender, EventArgs e)
        {

        }

        private void IdNew_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxpub_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpAut_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpTit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleNew_Click(object sender, EventArgs e)
        {

        }

        private void AuthNew_Click(object sender, EventArgs e)
        {

        }

        private void IdDB_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AutDB_Click(object sender, EventArgs e)
        {

        }

        private void PubDB_Click(object sender, EventArgs e)
        {

        }

        private void AuthLab_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

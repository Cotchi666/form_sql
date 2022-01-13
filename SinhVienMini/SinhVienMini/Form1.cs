using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace SinhVienMini
{
    public partial class Form1 : Form
    {
        //MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;Initial Catalog = 'csdl'; username=root;password=");
        string str = "Server = localhost ; Database = csdl; Uid = root; Pwd =; Charset = utf8  ";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //FillDGV();
            loadData();

        }
        public void loadData()
        {
            using(MySqlConnection con = new MySqlConnection(str))
            {
                con.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM book", con);
                DataTable table = new DataTable();
                mySqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        //public void FillDGV()
        //{
        //    MySqlCommand command = new MySqlCommand("SELECT * FROM book", connection);
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;   
        //}


        //private void BTN_INSERT_IMAGE_Click(object sender, EventArgs e)
        //{
        //    MemoryStream ms = new MemoryStream();
        //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
        //    byte[] img = ms.ToArray();

        //    String insertQuery = "INSERT INTO db_images.myimages(ID, Name, Description, Image) VALUES(@id, @name, @desc, @img)";

        //    connection.Open();

        //    command = new MySqlCommand(insertQuery, connection);

        //    command.Parameters.Add("@id", MySqlDbType.VarChar, 20);
        //    command.Parameters.Add("@name", MySqlDbType.VarChar, 200);
        //    command.Parameters.Add("@desc", MySqlDbType.Text);
        //    command.Parameters.Add("@img", MySqlDbType.Blob);

        //    command.Parameters["@id"].Value = textBoxID.Text;
        //    command.Parameters["@name"].Value = textBoxNAME.Text;
        //    command.Parameters["@desc"].Value = textBoxDESC.Text;
        //    command.Parameters["@img"].Value = img;

        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        MessageBox.Show("Data Inserted");
        //    }

        //    connection.Close();
        //}


        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = string.Format()
        }
    }
}


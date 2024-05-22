using MySql.Data.MySqlClient;
using System.Data;

namespace CS2C_CRUD_BacaniChristiane
{
    public partial class StudFrm : Form
    {
        public StudFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudFrm_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=studentsinv_db";
            string query2 = "select * from studentprofile";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgstud.DataSource = dt;


        }

        private void btnAdd_Click_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=studentsinv_db";
            string query = "INSERT INTO studentprofile(studentid, lastname, firstname, middlename) VALUES('" + txtstudentid.Text + "','" + this.txtln.Text + "','" + this.txtfn.Text + "','" + this.txtmn.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Added!");
            conn.Close();
            string query2 = "select * from studentprofile";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgstud.DataSource = dt;


        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            txtstudentid.Text = "";
            txtln.Text = "";
            txtfn.Text = "";
            txtmn.Text = "";

        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=studentsinv_db";
            string query = "DELETE FROM studentprofile WHERE studentid = '" + this.txtstudentid.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted!");
            conn.Close();
            string query2 = "select * from studentprofile";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgstud.DataSource = dt;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=studentsinv_db";
            string query = "UPDATE studentprofile SET studentid = @studentid, lastname = @lastname, firstname = @firstname, middlename = @middlename WHERE studentid = @studentid";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Update!");
            conn.Close();
            string query2 = "select * from studentprofile";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgstud.DataSource = dt;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=studentsinv_db";
            string query = "UPDATE studentprofile SET lastname = @lastname, firstname = @firstname, middlename = @middlename WHERE studentid = @studentid";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@lastname",this.txtln.Text);
                cmd.Parameters.AddWithValue("@firstname", this.txtfn.Text);
                cmd.Parameters.AddWithValue("@middlename", this.txtmn.Text);
                cmd.Parameters.AddWithValue("@studentid", this.txtstudentid.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Recorded Successfully!");


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Data.SqlClient.SqlException;

namespace regAndAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command1 = new SqlCommand("SELECT [role] FROM [user]", db.getConnection());

            SqlCommand command = new SqlCommand("SELECT * FROM [user] where [login] = @ul AND [password] = @up", db.getConnection()); // сопоставление логина и пароля в бд
            command.Parameters.Add("@ul", SqlDbType.NVarChar).Value = loginUser;
            command.Parameters.Add("@up", SqlDbType.NVarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (command1 = "admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide(); 
            Form2 fr2 = new Form2();
            fr2.Show();
        }

    }
}

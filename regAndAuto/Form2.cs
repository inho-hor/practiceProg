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

namespace regAndAuto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void returnEntrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (userLoginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (userPasswordField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (userPasswordDbField.Text == "")
            {
                MessageBox.Show("Введите повторный пароль");
                return;
            }
            if (isUserExist())
                return;
            if (checkPassword())
                return;

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO [user] ([login], [password], [nameUser]) VALUES (@login, @pass, @uN)", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = userLoginField.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = userPasswordField.Text;
            command.Parameters.Add("@uN", SqlDbType.NVarChar).Value = userNameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [user] where [login] = @ul", db.getConnection());
            command.Parameters.Add("@ul", SqlDbType.NVarChar).Value = userLoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином существует, введите новый");
                return true;
            }
            else
                return false;
        }

        public Boolean checkPassword()
        {
            if (userPasswordField.Text == userPasswordDbField.Text)
            {
                MessageBox.Show("Проверьте правильность введённого пароля");
                return true;
            }
            else
                return false;
        }

    }
}

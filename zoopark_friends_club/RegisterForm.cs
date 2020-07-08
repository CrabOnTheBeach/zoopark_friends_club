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

namespace zoopark_friends_club
{
    public partial class RegisterForm : Form
    {
        private MySqlConnection con;
        public RegisterForm()
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";

            con = new MySqlConnection(cs);
            con.Open();
            
            string sql = "SELECT * FROM Sex";

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    Sex.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private bool IsFieldsOk()
        {
            if (PhoneNumber.Text.Length != 11)
                return false;
            try
            {
                Convert.ToInt64(PhoneNumber.Text);
            }
            catch { return false; }

            if (NameField.Text == "")
                return false;

            if (Sex.SelectedIndex == -1)
                return false;

            string sql = "SELECT * FROM People " +
                         "WHERE People.PhoneNumber=" + "\"" + PhoneNumber.Text + "\" ";

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())
                    if (rdr.HasRows)
                        return false;
            

            return true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!IsFieldsOk())
            {
                MessageBox.Show("Incorrect data!");
                return;
            }

            var phoneNumber = new MySqlParameter("@phoneNumber", MySqlDbType.VarChar) { Value = PhoneNumber.Text };
            var peopleName = new MySqlParameter("@peopleName", MySqlDbType.VarChar) { Value = NameField.Text };
            var birthDay = new MySqlParameter("@birthDay", MySqlDbType.Date) { Value = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")};
            var sex = new MySqlParameter("@PeopleSex", MySqlDbType.VarChar) { Value = Sex.Text };

            string sql = "INSERT People(PhoneNumber, PeopleName, PeopleSex, BirthDay) VALUES(@phoneNumber, @peopleName, @PeopleSex, @birthDay)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add(phoneNumber);
            cmd.Parameters.Add(peopleName);
            cmd.Parameters.Add(birthDay);
            cmd.Parameters.Add(sex);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Вы успешно зарегестрированы!");
            Close();

        }
    }
}

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
    public partial class EditPeopleForm : Form
    {
        private MySqlConnection con;
        private string phoneNumber;
        public EditPeopleForm(string number, string name)
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";
            con = new MySqlConnection(cs);
            con.Open();
            phoneNumber = number;
            NumberBox.Text = number;

            string sql = "SELECT * FROM Sex";

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    SexBox.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
            NameBox.Text = name;
        }

        private bool IsFieldsOk()
        {
            if (NumberBox.Text.Length != 11)
                return false;
            try
            {
                Convert.ToInt64(NumberBox.Text);
            }
            catch { return false; }

            if (NameBox.Text == "")
                return false;

            if (SexBox.SelectedIndex == -1)
                return false;

            string sql = "SELECT * FROM People " +
                         "WHERE People.PhoneNumber=" + "\"" + NumberBox.Text + "\" ";

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())
                if (NumberBox.Text != phoneNumber && rdr.HasRows)
                {
                    MessageBox.Show("Такой номер уже занят");
                    return false;
                }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!IsFieldsOk())
            {
                MessageBox.Show("Incorrect data!");
                return;
            }

            var phoneNumberParameter = new MySqlParameter("@phoneNumber", MySqlDbType.VarChar) { Value = NumberBox.Text };
            var peopleName = new MySqlParameter("@peopleName", MySqlDbType.VarChar) { Value = NameBox.Text };
            var birthDay = new MySqlParameter("@birthDay", MySqlDbType.Date) { Value = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") };
            var sex = new MySqlParameter("@PeopleSex", MySqlDbType.VarChar) { Value = SexBox.Text };

            string sql = "UPDATE People" +
                " Set " +
                "PhoneNumber = @phoneNumber, " +
                "PeopleName = @peopleName, " +
                "PeopleSex = @PeopleSex, " +
                "BirthDay = @birthDay " +
                "WHERE PhoneNumber = " + "\"" + phoneNumber + "\"";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add(phoneNumberParameter);
            cmd.Parameters.Add(peopleName);
            cmd.Parameters.Add(birthDay);
            cmd.Parameters.Add(sex);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Изменения успешно сохранены!");
            Close();
        }

        private void ChoosePic_Click(object sender, EventArgs e)
        {

        }
    }
}

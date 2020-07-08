using Org.BouncyCastle.Asn1.Mozilla;
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
using System.Linq.Expressions;

namespace zoopark_friends_club
{
    public partial class LoginForm : Form, IHidable
    {
        private MySqlConnection con;
        
        public LoginForm()
        {
            InitializeComponent();
            TopLevel = false;
            Visible = true;
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";
            con = new MySqlConnection(cs);
            con.Open();
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

            return true;
        }

        public void ShowForm()
        {
            Visible = true;
        }

        public void HideForm()
        {
            Visible = false;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var f = new RegisterForm();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!IsFieldsOk())
            {
                MessageBox.Show("Incorrect data");
                return;
            }

            string sql ="SELECT People.PeopleId FROM People " +
                        "WHERE People.PhoneNumber=" + "\"" + PhoneNumber.Text + "\"";
            var cmd = new MySqlCommand(sql, con);
            int PeopleId = -1;
            using (var rdr = cmd.ExecuteReader())
            {
                if (!rdr.HasRows)
                {
                    MessageBox.Show("Нет пользователя с таким номером");
                    return;
                }
                rdr.Read();
                PeopleId = rdr.GetInt32(0);
            }
            (ParentForm as Main).Login(PeopleId);
        }
    }
}

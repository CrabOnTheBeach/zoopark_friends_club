using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoopark_friends_club
{
    public partial class PersonalCabinet : Form, IHidable
    {
        private int peopleId;
        private string phoneNumber;
        private string name;
        private string sex;
        private string birthday;
        private MySqlConnection con;
        public PersonalCabinet()
        {       
            InitializeComponent();
            TopLevel = false;
            Visible = false;
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";
            con = new MySqlConnection(cs);
            con.Open();
        }

        public void setNumber(int PeopleId)
        {
            peopleId = PeopleId;
            updateFields();
        }

        private void updateFields()
        {
            string sql = "SELECT People.PeopleName, People.PeopleSex, People.PhoneNumber, People.BirthDay FROM People " +
                    "WHERE People.PeopleId=" + "\"" + peopleId + "\"";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())
            {
                rdr.Read();
                name = rdr.GetString(0);
                sex = rdr.GetString(1);
                phoneNumber = rdr.GetString(2);
                birthday = rdr.GetDateTime(3).ToString("yyyy-MM-dd");

                NameBox.Enabled = false;
                SexBox.Enabled = false;
                NumberBox.Enabled = false;
                BirthDayBox.Enabled = false;
                NameBox.Text = name;
                SexBox.Text = sex;
                NumberBox.Text = phoneNumber;
                BirthDayBox.Text = birthday;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var f = new EditPeopleForm(phoneNumber, NameBox.Text);
            f.ShowDialog();

            updateFields();
        }

        private void SupportedZoo_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Residents.ResidentId, Residents.ResidentName as \"Имя жителя\", Sex.SexName as \"Пол\", Species.SpeciesName as \"Вид\", " +
                        "Genus.GenusName as \"Род\", Family.FamilyName as \"Семейство\" " +
                        "FROM Residents " +
                        "INNER JOIN Sex ON Sex.SexId=Residents.SexId " +
                        "INNER JOIN Species ON Residents.SpeciesId=Species.SpeciesId " +
                        "INNER JOIN Genus ON Species.GenusId=Genus.GenusId " +
                        "INNER JOIN Family ON Genus.FamilyId=Family.FamilyId " +
                        "WHERE ResidentId IN (SELECT ResidentId FROM PeopleResidents WHERE PeopleId=" + peopleId + ")";
            var mySqlDataAdapter = new MySqlDataAdapter(sql, con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            var f = new SearchResultForm(DS, peopleId);
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonalCabinet_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void HideForm()
        {
            Visible = false;
        }

        public void ShowForm()
        {
            Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

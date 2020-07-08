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
    public partial class ViewZooForm : Form
    {
        private int residentId;
        private int peopleId;
        private MySqlConnection con;
        public ViewZooForm(int PeopleId, int ResidentId)
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";

            con = new MySqlConnection(cs);
            con.Open();

            residentId = ResidentId;
            peopleId = PeopleId;
            string sql = "SELECT Residents.ResidentId, Residents.ResidentName as \"Имя жителя\", Sex.SexName as \"Пол\", Species.SpeciesName as \"Вид\", " +
                       "Genus.GenusName as \"Род\", Family.FamilyName as \"Семейство\", Residents.ResidentBirthDate " +
                       "FROM Residents " +
                       "INNER JOIN Sex ON Sex.SexId=Residents.SexId " +
                       "INNER JOIN Species ON Residents.SpeciesId=Species.SpeciesId " +
                       "INNER JOIN Genus ON Species.GenusId=Genus.GenusId " +
                       "INNER JOIN Family ON Genus.FamilyId=Family.FamilyId " +
                       "WHERE ResidentId =" + residentId;
            
            var mySqlDataAdapter = new MySqlDataAdapter(sql, con);
            NameBox.Enabled = false;
            SexBox.Enabled = false;
            SpeciesBox.Enabled = false;
            GenusBox.Enabled = false;
            FamilyBox.Enabled = false;
            BirthDayBox.Enabled = false;

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())
                while (rdr.Read())
                {
                    NameBox.Text = rdr.GetString(1);
                    SexBox.Text = rdr.GetString(2);
                    SpeciesBox.Text = rdr.GetString(3);
                    GenusBox.Text = rdr.GetString(4);
                    FamilyBox.Text = rdr.GetString(5);
                    //if (rdr.GetDateTime(6) != null)
                    //    BirthDayBox.Text = rdr.GetDateTime(6).ToString("yyyy-MM-dd");
                    //else BirthDayBox.Text = "None";
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool IsOkToBecameSupporter()
        {
            if (peopleId < 0)
            {
                MessageBox.Show("Сначала вы должна залогиниться");
                return false;
            }

            string sql = "SELECT PeopleResidents.PeopleId FROM PeopleResidents " +
                         "WHERE PeopleResidents.ResidentId=" + residentId;
            var cmd = new MySqlCommand(sql, con);
            int PeopleId = -1;
            using (var rdr = cmd.ExecuteReader())
            {
                if (!rdr.HasRows)
                {
                    return true;
                }
                rdr.Read();
                PeopleId = rdr.GetInt32(0);
            }

            if (PeopleId == peopleId)
            {
                MessageBox.Show("Вы уже опекун этого животного");
                return false;
            }    

            return true;
        }

        private void BecameSupporterButton_Click(object sender, EventArgs e)
        {
            if (!IsOkToBecameSupporter())
                return;
            string sql = "INSERT PeopleResidents(PeopleId, ResidentId) VALUES(" + peopleId + ", " + residentId + ");";

            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы успешно стали опекуном животного");
        }
    }
}

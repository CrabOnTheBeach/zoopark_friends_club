using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace zoopark_friends_club
{
    public partial class SearchRequestForm : Form, IHidable
    {
        private MySqlConnection con;
        private int SexId = -1;
        private int SpeciesId = -1;
        private int peopleId;

        public SearchRequestForm(int PeopleId)
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";

            con = new MySqlConnection(cs);
            con.Open();

            ClickBinding();

            peopleId = PeopleId;
        }

        private void ClickBinding()
        {
            label1.Text = "Имя животного";
            Sex.Text = "Пол";
            Sex.Click += new System.EventHandler(this.SexClick);
            Species.Text = "Вид";
            Species.Click += new System.EventHandler(this.SpeciesClick);
        }

        private void SpeciesClick(object sender, EventArgs e)
        {
            Species.Items.Clear();
            
            string sql = "SELECT SpeciesId, SpeciesName FROM Species";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    Species.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void SexClick(object sender, EventArgs e)
        {
            Sex.Items.Clear();
            string sql = "SELECT * FROM Sex";

            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

            while (rdr.Read())
                Sex.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeciesId = (Species.SelectedItem as MyPair).Id;
        }

        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            SexId = (Sex.SelectedItem as MyPair).Id;
        }

        public void ShowForm()
        {
            Visible = true;
        }

        public void HideForm() 
        {
            Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            string sql = "SELECT Residents.ResidentId, Residents.ResidentName as \"Имя жителя\", Sex.SexName as \"Пол\", Species.SpeciesName as \"Вид\", " +
                        "Genus.GenusName as \"Род\", Family.FamilyName as \"Семейство\" " +
                        "FROM Residents " +
                        "INNER JOIN Sex ON Sex.SexId=Residents.SexId " +
                        "INNER JOIN Species ON Residents.SpeciesId=Species.SpeciesId " +
                        "INNER JOIN Genus ON Species.GenusId=Genus.GenusId " +
                        "INNER JOIN Family ON Genus.FamilyId=Family.FamilyId " +
                        "WHERE Residents.ResidentId IS NOT NULL ";
                    
            if (SpeciesId != -1)
                sql += "ANS Species.SpeciesId=" + SpeciesId + " ";
            if (SexId != -1)
                sql += "AND Sex.SexId=" + SexId + " ";
            if (ResidentName.Text != "")
                sql += "AND Residents.ResidentName=\"" + ResidentName.Text + "\" ";

            var mySqlDataAdapter = new MySqlDataAdapter(sql, con);

            DataSet DS = new DataSet();

            mySqlDataAdapter.Fill(DS);

            var f = new SearchResultForm(DS, peopleId);
            f.Show();
            
        }

        
    }
}

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
    public partial class AddForm : Form
    {
        private MySqlConnection con;
        public AddForm()
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";

            con = new MySqlConnection(cs);
            con.Open();
            SpeciesCombo.Click += new System.EventHandler(this.SpeciesComboClick);
            GenusCombo.Click += new System.EventHandler(this.GenusComboClick);
            FamilyCombo.Click += new System.EventHandler(this.FamilyComboClick);
            SexCombo.Click += new System.EventHandler(this.SexComboClick);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SpeciesComboClick(object sender, EventArgs e)
        {
            SpeciesCombo.Items.Clear();

            string sql = "SELECT SpeciesId, SpeciesName FROM Species";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    SpeciesCombo.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void FamilyComboClick(object sender, EventArgs e)
        {
            FamilyCombo.Items.Clear();

            string sql = "SELECT FamilyId, FamilyName FROM Family";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    FamilyCombo.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void GenusComboClick(object sender, EventArgs e)
        {
            GenusCombo.Items.Clear();

            string sql = "SELECT GenusId, GenusName FROM Genus";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    GenusCombo.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void SexComboClick(object sender, EventArgs e)
        {
            SexCombo.Items.Clear();

            string sql = "SELECT SexId, SexName FROM Sex";
            var cmd = new MySqlCommand(sql, con);

            using (var rdr = cmd.ExecuteReader())

                while (rdr.Read())
                    SexCombo.Items.Add(new MyPair(rdr.GetInt32(0), rdr.GetString(1)));
        }

        private void AddFamily_Click(object sender, EventArgs e)
        {
            if (FamilyText.Text == "")
            {
                MessageBox.Show("Введите название семейства!");
                return;
            }
            string sql = "INSERT Family(FamilyName) VALUES(\"" + FamilyText.Text + "\")";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено!");
        }

        private void AddGenus_Click(object sender, EventArgs e)
        {
            if (GenusText.Text == "" || FamilyCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Введите название рода и выберете название семейства!");
            }
            string sql = "INSERT Genus(GenusName, FamilyId) VALUES(\"" + GenusText.Text + "\"," + (FamilyCombo.SelectedItem as MyPair).Id + ")";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено!");
        }

        private void AddSpecies_Click(object sender, EventArgs e)
        {
            if (SpeciesText.Text == "" || GenusCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Введите выберете рода и введите название вида!");
            }
            string sql = "INSERT Species(SpeciesName, GenusId) VALUES(\"" + SpeciesText.Text + "\"," + (GenusCombo.SelectedItem as MyPair).Id + ")";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено!");
        }

        private void AddResident_Click(object sender, EventArgs e)
        {
            if (NameText.Text == "" || SpeciesCombo.SelectedIndex < 0 || SexCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Выберете название вида и название пола и введите имя!");
            }
            string sql = "INSERT Residents(ResidentName, SpeciesId, SexId) VALUES(\"" + NameText.Text + "\"," + (SpeciesCombo.SelectedItem as MyPair).Id +
                          "," + (SexCombo.SelectedItem as MyPair).Id +  ")";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено!");
        }
    }
}

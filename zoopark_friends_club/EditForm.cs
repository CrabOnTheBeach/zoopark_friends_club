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
    public partial class EditForm : Form
    {
        private MySqlConnection con;

        public EditForm()
        {
            InitializeComponent();
            string cs = "server=localhost;user=root;database=zoopark;port=3306;password=1234";

            con = new MySqlConnection(cs);
            con.Open();

            SpeciesCombo.Click += new System.EventHandler(this.SpeciesComboClick);
            GenusCombo.Click += new System.EventHandler(this.GenusComboClick);
            FamilyCombo.Click += new System.EventHandler(this.FamilyComboClick);
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

        private void FamilyEditButton_Click(object sender, EventArgs e)
        {
            if (FamilyCombo.SelectedIndex < 0 || FamilyText.Text == "")
            {
                MessageBox.Show("Введите название семейства!");
                return;
            }
            MessageBox.Show(FamilyCombo.Text);
            string sql = "UPDATE Family" +
                " Set " +
                "FamilyName =\"" + FamilyText.Text + "\" " +
                "WHERE FamilyId = " + "\"" + (FamilyCombo.SelectedItem as MyPair).Id + "\"";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно изменено!");
            FamilyCombo.Text = "";
        }

        private void GenusEditButton_Click(object sender, EventArgs e)
        {
            if (GenusCombo.SelectedIndex < 0 || GenusText.Text == "")
            {
                MessageBox.Show("Введите название семейства!");
                return;
            }

            string sql = "UPDATE Genus" +
                " Set " +
                "GenusName =\"" + GenusText.Text + "\" " +
                "WHERE GenusId = " + "\"" + (GenusCombo.SelectedItem as MyPair).Id + "\"";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно изменено!");
            GenusCombo.Text = "";
        }

        private void SpeciesEditButton_Click(object sender, EventArgs e)
        {
            if (SpeciesCombo.SelectedIndex < 0 || SpeciesText.Text == "")
            {
                MessageBox.Show("Введите название семейства!");
                return;
            }

            string sql = "UPDATE Species" +
                " Set " +
                "SpeciesName =\"" + SpeciesText.Text + "\" " +
                "WHERE SpeciesId = " + "\"" + (SpeciesCombo.SelectedItem as MyPair).Id + "\"";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно изменено!");
            SpeciesCombo.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoopark_friends_club
{
    public partial class Main : Form
    {
        private LoginForm loginForm;
        private PersonalCabinet pc;
        private int peopleId;
        public Main()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            pc = new PersonalCabinet();
            panel2.Controls.Add(loginForm);
            panel2.Controls.Add(pc);
            peopleId = -1;
        }

        private void SearchResident_Click(object sender, EventArgs e)
        {
            var f = new SearchRequestForm(peopleId);
            f.Show();
        }

        public void Login(int PeopleId)
        {
            peopleId = PeopleId;
            pc.setNumber(PeopleId);
            loginForm.HideForm();
            pc.ShowForm();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var f = new AddForm();
            f.ShowDialog();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var f = new EditForm();
            f.ShowDialog();
        }
    }
}
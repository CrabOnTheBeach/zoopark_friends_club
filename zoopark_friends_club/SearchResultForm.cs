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
    public partial class SearchResultForm : Form
    {
        private int peopleId;
        public SearchResultForm(DataSet DS, int PeopleId)
        {
            InitializeComponent();
            DataGrid.DataSource = DS.Tables[0];
            DataGrid.Columns["ResidentId"].Visible = false;
            peopleId = PeopleId;
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var residentId = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells["ResidentId"].Value);
            if (residentId < 0)
                return;
            var f = new ViewZooForm(peopleId, residentId);
            f.ShowDialog();
        }
    }
}

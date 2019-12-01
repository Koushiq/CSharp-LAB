using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Home : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }


        public Home()
        {
            InitializeComponent();
            string sql = @"select * from movieinfo";
            this.PopulateGridView(sql);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.txtSearchBox.Text = "";
            string sql = @"select * from movieinfo";
            this.PopulateGridView(sql);
        }

        private void lblMovieSearch_Click(object sender, EventArgs e)
        {
            string sql = @"select * from movieinfo where title= '" + txtSearchBox.Text + "' ;";
            this.PopulateGridView(sql);
        }

        public void PopulateGridView(string sql)
        {
            Da = new DataAccess();
            Ds = Da.ExecuteQuery(sql);
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.DataSource = Ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from movieinfo where title like '" + txtAutoSearch.Text + "%' ;";
            this.PopulateGridView(sql);
        }
    }
}

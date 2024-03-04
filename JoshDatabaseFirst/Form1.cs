using JoshDatabaseFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshDatabaseFirst
{
    public partial class AuthorDetails : Form
    {
        private CourseDBcontext coursesDBContext;

        private void ClearControls()
        {
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            dtpDOB.Value = DateTime.Today;
        }

        private void RefreshAuthors()
        {
            dgvAuthors.DataSource = coursesDBContext.Authors.ToList();
            dgvAuthors.Columns[0].ReadOnly = true;
            dgvAuthors.Columns[4].Visible = false;

        }
        public AuthorDetails()
        {
            InitializeComponent();
            coursesDBContext = new CourseDBcontext();
        }

        private void AuthorDetails_Load(object sender, EventArgs e)
        {
            RefreshAuthors();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

            ClearControls();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            //creating a new author and adding
            Author author = new Author();
            author.FirstName = Firstname.Text;
            author.LastName = Lastname.Text;
            author.DateOfBirth = dtpDOB.Value;

            try
            {
                coursesDBContext.Authors.Add(author);
                coursesDBContext.SaveChanges();

                RefreshAuthors();

                ClearControls();
            }
            catch (Exception ex) 
            { MessageBox.Show("Error: could not insert Author.Details:" + ex.Message); }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            Author author = (Author)dgvAuthors.SelectedCells[0].OwningRow.DataBoundItem;
            coursesDBContext.Authors.Update(author);
            coursesDBContext.SaveChanges();
            RefreshAuthors();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell datagridviewcell in dgvAuthors.SelectedCells)
            {
                Author author = (Author)dgvAuthors.SelectedCells[0].OwningRow.DataBoundItem;
                coursesDBContext.Authors.Remove(author);
            }
            
            coursesDBContext.SaveChanges();
            RefreshAuthors();
        }
    }
}

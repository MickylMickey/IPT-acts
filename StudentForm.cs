using Sumagang_Jon_Mickyl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumagang_Jon_Mickyl
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            
            StudentNameLabel.Text = "Sumagang Jon Mickyl";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "Bautista Pangasinan";
            StudentContactLabel.Text = "09914850595";
            StudentEmailLabel.Text = "mickylmickey@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Mary Sumagang";
            ParentContactLabel.Text = "09317570091";
            HobbiesLabel.Text = "Gaming";
            NicknameLabel.Text = "JM";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}
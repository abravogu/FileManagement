using NttDataFileManagement.Business.Logic.Contracts;
using NttDataFileManagement.Business.Logic.Implementations;
using NttDataFileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NttData.FileManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IStudentService studentService= new StudentService();
            Student student = new Student();
            student.Name = txtname.Text;
            student.Age = txtbirthday.Text;
            student.Surname=txtsurname.Text;

            studentService.Add(student);
            MessageBox.Show("Thestudent is saved");
        }

        private int calculateAge(String birthday)
        {
            int age=;
        }
    }
}

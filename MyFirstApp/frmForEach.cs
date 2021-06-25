using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyFirstApp.ForeachLoop;

namespace MyFirstApp
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudenId.Text); // caixa de text
            student.Name = txtName.Text;
            student.Surname= txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList();
            
            //boxing
            studentList.Add(student);
            
            foreach (var _student in studentList)
            {
                // unboxing (polymorphism)
                MessageBox.Show(((Student)_student).Name +
                          " " + ((Student)_student).Surname);


            }

        }
    }
}

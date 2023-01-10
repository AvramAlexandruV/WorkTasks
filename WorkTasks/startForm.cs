using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkTasks
{
    public partial class startForm : Form
    {
        List<Employee> values;

        public startForm()
        {
            InitializeComponent();
            getData();
            showData();
        }

        public void getData() {
            values = File.ReadAllLines("./MOCK_EMPLOYEE_DATA.csv")
                                .Skip(1)
                                .Select(v => Employee.FromCsv(v))
                                .ToList();
        }

        public void showData() {
            dataGridView1.DataSource = values;
        }

        private void viewTasksButton_Click(object sender, EventArgs e)
        {
            var newForm = new viewTasks();
            newForm.Show();
        }

        private void assignTasks_Click(object sender, EventArgs e)
        {
            var newForm = new assignTasks();
            newForm.Show();
        }

        private void manageTasks_Click(object sender, EventArgs e)
        {
            var newForm = new manageTasks();
            newForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new Add();
            newForm.Show();
        }
    }
}

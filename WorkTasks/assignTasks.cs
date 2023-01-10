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
    public partial class assignTasks : Form
    {
        List<Task> tasks;
        List<Employee> employees;

        int taskIndex;
        int employeeIndex;

        public assignTasks()
        {
            InitializeComponent();
            getData();
            showData();
        }

        public void getData()
        {
            tasks = File.ReadAllLines("./MOCK_EMPLOYEE_TASKS.csv")
                                .Skip(1)
                                .Select(v => Task.FromCsv(v))
                                .ToList();

            employees = File.ReadAllLines("./MOCK_EMPLOYEE_DATA.csv")
                                .Skip(1)
                                .Select(v => Employee.FromCsv(v))
                                .ToList();
        }

        public void showData() {

            dataGridView2.Columns.Add("Task", "Task");
            dataGridView2.Columns.Add("Departament", "Departament");
            dataGridView2.Columns.Add("GivenTo", "GivenTo");

            foreach (var x in tasks.Select((value, i) => new { i, value }))
            {
                var index = x.i;
                dataGridView2.Rows.Add(tasks[index].taskHeader, tasks[index].departaments, tasks[index].givenTo);
            }


            dataGridView1.Columns.Add("Employee", "Employee");
            dataGridView1.Columns.Add("Departament", "Departament");
            foreach (var x in employees.Select((value, i) => new { i, value }))
            {
                var index = x.i;
                string addEmployee = employees[index].first_name + " " + employees[index].last_name;
                dataGridView1.Rows.Add(addEmployee, employees[index].departament);
            }


        }

        public void assign() {
            taskIndex = dataGridView2.CurrentCell.RowIndex;
            employeeIndex = dataGridView1.CurrentCell.RowIndex;

            if (tasks[taskIndex].departaments != employees[employeeIndex].departament) {
                MessageBox.Show("The employee can't be assigned to a task in this departament!!");
                return;
            }

            if (tasks[taskIndex].givenTo != "none") {
                MessageBox.Show("Task already assigned to " + tasks[taskIndex].givenTo);
                return;
            }

            string path = @"./MOCK_EMPLOYEE_TASKS.csv";
            List<string> lines = new List<string>();


            using (StreamReader reader = new StreamReader(path))
            {
                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(tasks[taskIndex].taskHeader)) {
                        line = tasks[taskIndex].taskHeader + ',' + tasks[taskIndex].departaments + ',' + tasks[taskIndex].status + ',' + tasks[taskIndex].deadline + ',' + tasks[taskIndex].by + ',' + tasks[taskIndex].description + ',' + employees[employeeIndex].first_name + " " + employees[employeeIndex].last_name;
                    }
                    lines.Add(line);
                }

            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }

            MessageBox.Show("Task assigned!!");

            clear();
        }

        private void clear() {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();

            getData();
            showData();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            assign();
        }
    }
}

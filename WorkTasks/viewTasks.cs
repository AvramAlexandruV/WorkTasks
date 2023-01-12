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
    public partial class viewTasks : Form
    {
        List<Task> tasks;

        //to check if we have filtering on
        public static int Filtered = 0;

        //the key we search by
        string searchKey= "";


        public viewTasks()
        {
            InitializeComponent();
            getData();
            showData();
        }

        public void getData() 
        {
            if (Filtered == 0)
                noFiltering();
            else
                withFiltering();
        }

        public void showData() 
        {
            createColumns();

            foreach (var x in tasks.Select((value, i) => new { i, value }))
            {
                var index = x.i;
                if (tasks[index].taskHeader != "INVALID")
                {
                    dataGridView1.Rows.Add(
                        tasks[index].taskHeader,
                        tasks[index].departaments,
                        tasks[index].status,
                        tasks[index].deadline,
                        tasks[index].by,
                        tasks[index].description,
                        tasks[index].givenTo
                        );
                }
            }
        }

        public void createColumns()
        {
            dataGridView1.Columns.Add("Task Header", "Task Header");
            dataGridView1.Columns.Add("Departaments", "Departaments");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("Deadline", "Deadline");
            dataGridView1.Columns.Add("By", "By");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Given To", "Given To");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchKey = textBox1.Text;

            if (textBox1.Text == "")
                Filtered = 0;
            else
                Filtered = 1;

            getData();
            clear();
            showData();
        }

        private void clear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        public void noFiltering() 
        {
            tasks = File.ReadAllLines("./MOCK_EMPLOYEE_TASKS.csv")
                                .Skip(1)
                                .Select(t => Task.FromCsv(t))
                                .ToList();
        }

        public void withFiltering()
        {
            tasks = File.ReadAllLines("./MOCK_EMPLOYEE_TASKS.csv")
                               .Skip(1)
                               .Select(t => Task.FromCsvFilter(t, searchKey))
                               .ToList();
        }
    }
}

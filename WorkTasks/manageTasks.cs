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
    public partial class manageTasks : Form
    {
        List<Task> tasks;
        int taskIndex;
        public manageTasks()
        {
            InitializeComponent();
            getData();
            showData();
        }

        public void getData() {
            tasks = File.ReadAllLines("./MOCK_EMPLOYEE_TASKS.csv")
                        .Skip(1)
                        .Select(t => Task.FromCsv(t))
                        .ToList();
        }

        public void showData() {
            dataGridView1.Columns.Add("Task", "Task");
            dataGridView1.Columns.Add("Status", "Status");

            foreach (var x in tasks.Select((value, i) => new { i, value })) {
                var index = x.i;
                dataGridView1.Rows.Add(tasks[index].taskHeader, tasks[index].status);
            }
        }

        private void openStatus_Click(object sender, EventArgs e)
        {
            set("Open");
        }

        private void inProgressStatus_Click(object sender, EventArgs e)
        {
            set("In Progress");
        }

        private void completedStatus_Click(object sender, EventArgs e)
        {
            set("Completed");
        }

        private void blockedStatus_Click(object sender, EventArgs e)
        {
            set("Blocked");
        }

        private void closedStatus_Click(object sender, EventArgs e)
        {
            set("Closed");
        }

        private void deleteCompleted_Click(object sender, EventArgs e)
        {

            string path = @"./MOCK_EMPLOYEE_TASKS.csv";
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.Contains("Completed") && !line.Contains("none") )
                    {
                        lines.Add(line);
                    }  
                }

            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }

            MessageBox.Show("Deleted All Unassigned Completed Tasks!!");

            clear();
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            string path = @"./MOCK_EMPLOYEE_TASKS.csv";
            string line = null;

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                    writer.WriteLine(line);
            }

            MessageBox.Show("Deleted All Tasks!!");

            clear();
        }

        public void set(string new_status) {
            taskIndex = dataGridView1.CurrentCell.RowIndex;

            string path = @"./MOCK_EMPLOYEE_TASKS.csv";
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(tasks[taskIndex].taskHeader))
                    {
                        line = tasks[taskIndex].taskHeader + ',' + tasks[taskIndex].departaments + ',' + new_status + ',' + tasks[taskIndex].deadline + ',' + tasks[taskIndex].by + ',' + tasks[taskIndex].description + ',' + tasks[taskIndex].givenTo;
                    }
                    lines.Add(line);
                }

            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }

            MessageBox.Show("Task updated!!");

            clear();
        }

        private void clear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            getData();
            showData();
        }
    }
}

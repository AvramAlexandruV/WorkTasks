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
        public viewTasks()
        {
            InitializeComponent();
            getData();
            showData();
        }

        public void getData() 
        {
            tasks = File.ReadAllLines("./MOCK_EMPLOYEE_TASKS.csv")
                                .Skip(1)
                                .Select(t => Task.FromCsv(t))
                                .ToList();
        }

        public void showData() 
        {
            dataGridView1.DataSource = tasks;
        }
    }
}

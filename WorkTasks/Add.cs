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
    public partial class Add : Form
    {
        string taskHeader;
        string departaments;
        string status;
        string deadline;
        string by;
        string description;

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"./MOCK_EMPLOYEE_TASKS.csv";
            List<string> lines = new List<string>();


            using (StreamReader reader = new StreamReader(path))
            {
                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                taskHeader = textBox1.Text;
                departaments = textBox2.Text;
                status = textBox3.Text;
                deadline = textBox4.Text;
                by = textBox5.Text;
                description = textBox6.Text;

                line = taskHeader + ',' + departaments + ',' + status + ',' + deadline + ',' + by + ',' + description + ',' + "none";
                lines.Add(line);
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }

            MessageBox.Show("New task added!!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        
    }
}

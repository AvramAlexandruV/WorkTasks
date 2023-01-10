using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTasks
{
    public class Task
    {
        public string taskHeader { get; set; }
        public string departaments { get; set; }
        public string status { get; set; }
        public string deadline { get; set; }
        public string by { get; set; }
        public string description { get; set; }
        public string givenTo { get; set; }

        public static Task create(string new_taskHeader, string new_departaments, string new_status, string new_deadline, string new_by, string new_description)
        {
            Task newTask = new Task();

            newTask.taskHeader = new_taskHeader;
            newTask.departaments = new_departaments;
            newTask.status = new_status;
            newTask.deadline = new_deadline;
            newTask.by = new_by;
            newTask.description = new_description;

            return newTask;
        }

        public static Task FromCsv(string csvLine) {
            string[] values = csvLine.Split(',');
            Task task = new Task();

            task.taskHeader = values[0];
            task.departaments = values[1];
            task.status = values[2];
            task.deadline = values[3];
            task.by = values[4];
            task.description = values[5];
            task.givenTo = values[6];

            return task;
        }
    }   
}

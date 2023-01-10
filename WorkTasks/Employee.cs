using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTasks
{
    public class Employee
    {
        public int Id { get; set; }
        public string ssn { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string street_name { get; set; }
        public int street_number { get; set; }
        public string zipcode { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string departament { get; set; }

        public static Employee FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Employee employees = new Employee();

            employees.Id = Convert.ToInt32(values[0]);
            employees.ssn = values[1];
            employees.first_name = values[2];
            employees.last_name = values[3];
            employees.gender = values[4];
            employees.street_name = values[5];
            employees.street_number = Convert.ToInt32(values[6]);
            employees.zipcode = values[7];
            employees.city = values[8];
            employees.email = values[9];
            employees.departament = values[10];

            return employees;
        }
    }

}

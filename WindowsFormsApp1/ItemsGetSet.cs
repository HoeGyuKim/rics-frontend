using System;

namespace WindowsFormsApp1
{
    public class ReconditionedDetails
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long ProductNum { get; set; }
        public string ProductName { get; set; }
        public string SerialNum { get; set; }
        public string Worker { get; set; }
        public string Manager { get; set; }
        public string DepartmentName { get; set; }
    }

    public class ReconditionedListItem
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long ProductNum { get; set; }
        public string ProductName { get; set; }
        public string SerialNum { get; set; }
        public string Worker { get; set; }
        public string Manager { get; set; }
        public string DepartmentName { get; set; }
    }
    public class SimpleReconditioned
    {
        public int productNum { get; set; }
        public string productName { get; set; }
    }
    public class SimpleMembers
    {
        public string Name { get; set; }
        public int EmployeeNum { get; set; }
        public Department Department { get; set; }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
    }
}

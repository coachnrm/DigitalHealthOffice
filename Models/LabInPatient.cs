using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class LabInPatient
	{
        public int LabOrderNumber { get; set; }
        public string Vn { get; set; }
        public string Hn { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string ReceiveTime { get; set; }
        public string ReportTime { get; set; }
        public string ConfirmReport { get; set; }
        public string Name { get; set; }
        public string FormName { get; set; }
        public double Inventory { get; set; }
    }
}
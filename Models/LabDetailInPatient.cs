using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
	public class LabDetailInPatient
	{
        public string labitemssubgroupname { get; set; }
        public string labitemsname { get; set; }
        public string lab_order_result { get; set; }
        public string labitemsunit { get; set; }
        public string labitemsnormalvalue { get; set; }
        public object lab_order_bacteric { get; set; }
    }
}
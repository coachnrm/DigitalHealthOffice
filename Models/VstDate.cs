using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class VstDate
	{
		public DateTime vstdate { get; set; }
        public string icd10 { get; set; }
        public string diagname { get; set; }
        public string oper_name { get; set; }
        public string doctor_name { get; set; }
        public string vn { get; set; }
        public string an { get; set; }
    }
}
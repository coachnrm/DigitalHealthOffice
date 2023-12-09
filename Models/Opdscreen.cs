using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class Opdscreen
	{
		public string pname { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string icd10 { get; set; }
        public string icd10_name { get; set; }
        public string doctor_name { get; set; }
        public string pttype { get; set; }
        public string pttype_name { get; set; }
        public double? numnuk { get; set; }
        public double? aunnahaphoom { get; set; }
        public double? cheeppajorn { get; set; }
        public object untrakanhaijai { get; set; }
        public string kwamdun { get; set; }
        public int? suansung { get; set; }
        public object fbs { get; set; }
        public double? bmi { get; set; }
        public string cc { get; set; }
        public object hpi { get; set; }
        public object pmh { get; set; }
        public object fh { get; set; }
        public object pe { get; set; }
        public string cc_persist_disease { get; set; }
        public string cc_operation_name { get; set; }
        public object agent { get; set; }
        public object symptom { get; set; }
        public object report_date { get; set; }
        public string image { get; set; }
	}
}
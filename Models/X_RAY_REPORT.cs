using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class X_RAY_REPORT
	{
        public string hn { get; set; }
        public string vn { get; set; }
        public DateTime? report_date { get; set; }
        public string report_time { get; set; }
        public string xray_items_name { get; set; }
        public object xray_type_name { get; set; }
        public object xray_side_name { get; set; }
        public string report_text { get; set; }
        public string report_rtf { get; set; }
    }
}
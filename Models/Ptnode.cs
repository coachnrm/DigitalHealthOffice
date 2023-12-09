using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class Ptnode
	{
        public string plaintext { get; set; }
        public DateTime noteDatetime { get; set; }
        public string hasExpired { get; set; }
        public DateTime? expireDate { get; set; }
        public string publicNote { get; set; }
    }
}
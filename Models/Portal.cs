using System;
using System.ComponentModel.DataAnnotations;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
	public class Portal
	{
        public int Id { get; set; }

        public string? QueueId {get; set;}
      
        public string? PatientName { get; set; }
		
        public string? PatientType { get; set; }

        public string? PortalType { get; set; }

		public string? UrgentType {get; set; }

		public string? PortalName {get; set; }  

        public string? Note {get; set;}

        public string? Status {get; set;}

        public string? StartPort {get; set;}

        public string? EndPort1 {get; set;}

        public string? EndPort2 {get; set;}

        public string? EndPort3 {get; set;}

        public string? EndPort4 {get; set;}

	}
}
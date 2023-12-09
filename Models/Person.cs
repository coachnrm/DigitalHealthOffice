using System;
using System.ComponentModel.DataAnnotations;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
	public class Person
	{
        public int Id { get; set; }
      
        [Required]
        public string? FirstName { get; set; }
		[Required]
        public string? LastName { get; set; }

        [Required,EmailAddress]
        public string? Email { get; set; }

		public string? Occupation {get; set; }

		public string? Suggestion {get; set; }  
	}
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; }
        public int Status { get; set; } // 0: Active, 1: On Leave, 2: Terminated
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? EmpImage { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int DesignationId { get; set; }
        public Designation? Designation { get; set; }
        public int ShiftId { get; set; }
        public Shift? Shift { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}






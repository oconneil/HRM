using HRM.Domain.Enums;

namespace HRM.Domain.Entities;

public sealed class Employee : BaseEntity
{
    public string EmployeeCode { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; } = Gender.Unspecified;
    public EmployeeStatus Status { get; set; } = EmployeeStatus.Active;

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public Guid PositionId { get; set; }
    public Position Position { get; set; } = null!;
}

using Core.Entities;

namespace Entities.DTOs;

public class RentalDetailDto : IDto
{
    public string Description { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}
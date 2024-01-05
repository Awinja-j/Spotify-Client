using System.ComponentModel.DataAnnotations;

namespace MvcSpotify.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime SubscribedDate { get; set; }

    public bool Subscribed {get; set; }

}
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BestRestaurants.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public int RestaurantId { get; set; }

    public virtual Restaurant Restaurant { get; set; }
  }


}
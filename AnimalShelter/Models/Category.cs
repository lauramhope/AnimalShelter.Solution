using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Species { get; set; }
    public List<Animal> Animals { get; set; }
  }
}
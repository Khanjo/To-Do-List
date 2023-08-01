using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Item
    {
        [Required(ErrorMessage = "The item's description cannot be empty")]
        public string Description { get; set; }
        public int ItemId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category, please add one first")]
        public int CategoryId { get; set; }
        public bool Completed { get; set; } = false;
        public Category Category { get; set; }
        public List<ItemTag> JoinEntities { get; }
    }
}
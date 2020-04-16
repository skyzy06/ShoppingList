using System;

namespace ShoppingList.Models
{
    public class HomeMenuItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}

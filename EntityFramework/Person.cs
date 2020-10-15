using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ToPage.Tests.Data
{
    public class Person
    {
        [Key]
        public string Name { get; set; }
    }
}

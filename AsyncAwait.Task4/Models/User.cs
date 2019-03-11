using System.Data.Linq.Mapping;

namespace AsyncAwait.Task4.Models
{
    //[Table(Name = "User")]
    public class User
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        //[Column]
        public string Name { get; set; }

        //[Column]
        public string SecondName { get; set; }

        //[Column]
        public int Age { get; set; }
    }
}


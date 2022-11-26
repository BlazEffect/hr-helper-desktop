using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAntHR.Models
{
    [AutoGenerateTable]
    [Alias("Employee")]
    [JengaEntity]

    internal class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [JengaImage(200,200)]

        public byte[] Photo { get; set; }
        [JengaIdentifier]
        public int Name { get; set; }
        [JengaOptions("Male,Female,Non-Binary")]
        public string Gender { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }

        [JengaOptions("Admin,Employee")]

        public string Role { get; set; } = "Admin";
        public DateTime DateAdded { get; set; } = DateTime.Now;

    }
}

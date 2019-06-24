using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.DAL.ORM.Entity
{
    [Table("Users")]//Table attribute içeriisne yazılmış olan string değeri tablo oluştururuken tablo ismi oalrak belrilenecektir
    public class AppUser:BaseEntity
    {
        [MaxLength(30)]//boyutunu belirledim
        public string LastName { get; set; }

        //Notmapped entity içerisnde var olmasına rağmen database'de bir tablo oalrak teşekkül etemeyecek. Bir sütun olarak oluşmayacak.
        [NotMapped]
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return Name;
                }
                else
                {
                    return Name + " " + LastName;
                }
            }
        }

        [Required]//Boş geçilemez
        public string UserName { get; set; }

        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }
    }
}

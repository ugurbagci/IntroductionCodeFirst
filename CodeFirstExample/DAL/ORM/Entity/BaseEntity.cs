using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.DAL.ORM.Entity
{
    public class BaseEntity
    {
        //using System.ComponentModel.DataAnnotations
        //using System.ComponentModel.DataAnnotations.Schema
        //ID olarak eklediğim property Enttiy Frame work sayesinde primery key olarak algılıyor ve Identyt'is 1 den başlayıp bir bir artacak
        [Key]//primery key olarak işaretledim
        [Column(Order=1)]//Column ile database'de sütün sırasını belirleyebilrisiniz
        public int ID { get; set; }

        [Column(Order =2)]//Bu işlemlerin hepsine Mapping denir.
        public string Name { get; set; }

        [Column(TypeName="datetime2")]//Veri tipimi işaret ettm
        public DateTime? Add_Date { get; set; }
        //Veri tiplerinin sonunu soru işareti koyduğumuzda boş geçilebilir. Yani null değer alır
        public bool isActive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatOkulu.Models
{
    [Table("Sanatcilar")]
    public class Sanatci
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Ad { get; set; }

        //virtual konduğunda bu navigation property de Lazy Loading aktif olur bu ihtiyaç halinde yükleme yapar
        //yani ben diger tarafta formlarda çağırmadıgım sürece foreach ile yükleme yapmaz
        //sadece çağırılırsa sql den joinleyip seçilip getiriliyor
        public virtual ICollection<Eser> Eserler { get; set; } //bu sanatçının birden çok eseri olabilir
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanielAdrianCornejo_Examen1P.Models
{
    [Table("DC_Tabla1")]
    public class DC_Carro
    {
        public int DC_CarroID { get; set; }
        [StringLength(50, MinimumLength =4)]
        public int DC_Cantidad { get; set; }
        public string? DC_Marca { get; set; }
        [Range(0.01 , 99.99)]
        public decimal DC_Precio { get; set; }
        [Required]
        public bool DC_Vendido { get; set; }
        public DateTime DC_Fecha { get; set; }
    }
}

using System.Data.Linq.Mapping;

namespace WCFcalcEmpl
{
    //Objeto de replica de información contenida en tabla
    [Table(Name = "ComisionxVentas")]
    public class Cliente
    {
        //Columnas
        [Column(IsPrimaryKey = true, IsDbGenerated = false)]
        public string id { get; set; }
        [Column]
        public string nombre { get; set; }
        [Column]
        public string Tipo_id { get; set; }
        [Column]
        public string jefe { get; set; }
        [Column]
        public string provincia { get; set; }
        [Column]
        public decimal cuotaventas { get; set; }
        [Column]
        public decimal bonificacion { get; set; }
        [Column]
        public decimal porccomision { get; set; }
        [Column]
        public decimal ventasanuales { get; set; }
        [Column]
        public decimal ventasanioant { get; set; }
        [Column]
        public decimal promediomensual { get; set; }
        [Column]
        public decimal comision { get; set; }
    }
    }
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica_UPQROO.Models
{
    public class PlanTratamiento
    {
        [Key]
        public int PkTratamiento { get; set; }
        public string Modalidad { get; set; }
        public string Descripcion { get; set; }
        public string Dosis { get; set; }
        public DateTime Fecha { get; set; }
        public int FkDiagnostico { get; set; }
        //[ForeignKey("FkDiagnostico")]
        //public Diagnostico diagnostico { get; set; }
    }
}

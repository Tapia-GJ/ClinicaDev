using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinica_UPQROO.Models
{
    public class CartaConsentimiento
    {
        [Key]
        public int PkFolio { get; set; }
        public DateTime Fecha { get; set; }
        public int FkPersona { get; set; }
        public int FkTerapeuta { get; set; }
        public string Tutor { get; set; }
        public string Testigo { get; set; }
        public int FkDiagnostico { get; set; }

        [ForeignKey("FkPersona")]
        public Persona Paciente { get; set; }

        [ForeignKey("FkTerapeuta")]
        public Persona Terapeuta { get; set; }

    }
}

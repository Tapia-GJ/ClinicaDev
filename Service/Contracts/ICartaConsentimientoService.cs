using Clinica_UPQROO.Models;
using Service.ContractsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ICartaConsentimientoService
    {
        List<CartaConsentimiento> GetAll();
        CartaConsentimiento GetById(int id);
        Task<ResponseHelper> Create(CartaConsentimiento model);
        Task<ResponseHelper> Update(CartaConsentimiento model);
        Task<ResponseHelper> Delete(int id);
    }
}

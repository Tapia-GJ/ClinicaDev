using Clinica_UPQROO.Models;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Repository.CartaConsentimientoDao
{
    public class CartaConsentimientoRepository
    {
        private readonly ApplicationDbContext _context;

        public CartaConsentimientoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public int Create(CartaConsentimiento model)
        //{
        //    try
        //    {
        //        _context.QueryAsync
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    _context.CartaConsentimientos.Add(model);
        //    return _context.SaveChanges();
        //}
        //public int Update(CartaConsentimiento model)
        //{
        //    _context.CartaConsentimientos.Update(model);
        //    return _context.SaveChanges();
        //}
        //public CartaConsentimiento GetById(int id)
        //{
        //    var curriculum = _context.CartaConsentimientos.Find(id);
        //    return curriculum;
        //    //var curriculum = _context.Curriculums.FirstOrDefault(x => x.Id == id);//expresiones lamda
        //    //var curriculum = _context.Curriculums.Where(x => x.Id == id).FirstOrDefault();
        //}
        //public int Delete(int id)
        //{
        //    var curriculum = _context.CartaConsentimientos.Find(id);
        //    _context.CartaConsentimientos.Remove(curriculum);
        //    return _context.SaveChanges();
        //}
    }
}

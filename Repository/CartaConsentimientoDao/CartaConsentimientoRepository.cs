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

        public List<Curriculum> GetAll()
        {
            return _context.Curriculums.ToList();
        }
        public int Create(CartaConsentimiento model)
        {
            _context.Curriculums.Add(model);
            return _context.SaveChanges();
        }
        public int Update(Curriculum model)
        {
            _context.Curriculums.Update(model);
            return _context.SaveChanges();
        }
        public Curriculum GetById(int id)
        {
            var curriculum = _context.Curriculums.Find(id);
            return curriculum;
            //var curriculum = _context.Curriculums.FirstOrDefault(x => x.Id == id);//expresiones lamda
            //var curriculum = _context.Curriculums.Where(x => x.Id == id).FirstOrDefault();
        }
        public int Delete(int id)
        {
            var curriculum = _context.Curriculums.Find(id);
            _context.Curriculums.Remove(curriculum);
            return _context.SaveChanges();
        }
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperinceService
    {
        IExperienceDal _experinceDal;

        public ExperienceManager(IExperienceDal experinceDal)
        {
            _experinceDal = experinceDal;
        }

        public void TAdd(Experience t)
        {
            _experinceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experinceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _experinceDal.GetByID(id);
        }

      

        public List<Experience> TGetList()
        {
            return _experinceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experinceDal.Update(t);
        }
    }
}

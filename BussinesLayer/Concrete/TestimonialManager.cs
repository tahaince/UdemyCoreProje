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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimional t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimional t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimional TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        
        public List<Testimional> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimional t)
        {
             _testimonialDal.Update(t);
        }
    }
}

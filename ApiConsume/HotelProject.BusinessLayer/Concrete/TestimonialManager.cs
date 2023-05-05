using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialService _testimonialDal;

        public TestimonialManager(ITestimonialService testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.TDelete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.TGetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.TGetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.TInsert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.TUpdate(t);
        }
    }
}

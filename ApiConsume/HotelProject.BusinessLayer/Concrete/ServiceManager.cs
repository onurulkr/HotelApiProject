﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceService _serviceDal;

        public ServiceManager(IServiceService serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service t)
        {
            _serviceDal.TDelete(t);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.TGetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.TGetList();
        }

        public void TInsert(Service t)
        {
            _serviceDal.TInsert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.TUpdate(t);
        }
    }
}

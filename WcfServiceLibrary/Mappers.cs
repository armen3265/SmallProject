using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EF6;
using AutoMapper.EquivalencyExpression;
using DAL.Records;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Mappers
    {
        public static Mapper modelsDTO;
        static Mappers()
        {
            var modelsDTOConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerRecord>().ReverseMap();
                cfg.CreateMap<PhoneNumber, PhoneNumberRecord>().ReverseMap();
                cfg.CreateMap<Classification, ClassificationRecord>().ReverseMap();
            });
            
            modelsDTO = new Mapper(modelsDTOConfig);
        }
        
    }
}

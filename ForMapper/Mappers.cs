using AutoMapper;
using ForMapper.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Mappers
    {
        public static Mapper modelsDTO;
        public static Mapper recordsDTO;
        static Mappers()
        {
            var modelsDTOConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerRecord>().ReverseMap();
                cfg.CreateMap<PhoneNumber, PhoneNumberRecord>().ReverseMap();
                cfg.CreateMap<Classification, ClassificationRecord>().ReverseMap();
            });
            var recordsDTOConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerRecord, Customer>();
                cfg.CreateMap<PhoneNumberRecord, PhoneNumber>();
                cfg.CreateMap<ClassificationRecord, Classification>();
            });

            modelsDTO = new Mapper(modelsDTOConfig);
            recordsDTO = new Mapper(recordsDTOConfig);
        }
        
    }
    //public class ProxyConverter<TSource, TDestination> : ITypeConverter<TSource, TDestination>
    //where TSource : class
    //where TDestination : class
    //{
    //    public TDestination Convert(ResolutionContext context)
    //    {
    //        // Get dynamic proxy base type
    //        var baseType = context.SourceValue.GetType().BaseType;

    //        // Return regular map if base type == Abstract base type
    //        if (baseType == typeof(TSource))
    //            baseType = context.SourceValue.GetType();

    //        // Look up map for base type
    //        var destType = (from maps in Mapper.GetAllTypeMaps()
    //                        where maps.SourceType == baseType
    //                        select maps).FirstOrDefault().DestinationType;

    //        return Mapper.DynamicMap(context.SourceValue, baseType, destType) as TDestination;
    //    }
    //}
}

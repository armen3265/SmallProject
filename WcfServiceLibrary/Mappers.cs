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

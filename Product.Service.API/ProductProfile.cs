using AutoMapper;
using Product.Service.API.Entities;
using Product.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service.API
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            MappingEntityToDto();
            MappingDtoToEntity();
        }

        private void MappingEntityToDto()
        {
            CreateMap<ProductEntity, ProductDTO>();
        }

        private void MappingDtoToEntity()
        {
            CreateMap<CreateProductFormDTO, ProductEntity>();
            CreateMap<UpdateProductFormDTO, ProductEntity>();
        }
    }
}

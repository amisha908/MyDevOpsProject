﻿using AutoMapper;
using DevopsApplication.Models;
using DevopsApplication.Models.Dto;

namespace DevopsApplication
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();

            });
            return mappingConfig;

        }
    }
}

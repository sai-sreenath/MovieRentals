﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VideoRentals.Dtos;
using VideoRentals.Models;

namespace VideoRentals.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        { 
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();

        }
    }
}
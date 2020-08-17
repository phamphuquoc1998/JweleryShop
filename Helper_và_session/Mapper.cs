using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication2.Models.Domain;

namespace WebApplication2.Helper_và_session
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<UserRegistrationModel, User>();
            
        }
    }
}

using AutoMapper;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ChGeneral, ChGeneralDTO > ().ReverseMap();
            CreateMap<ChMedical, ChMedicalDTO>().ReverseMap();
        }
    }
}

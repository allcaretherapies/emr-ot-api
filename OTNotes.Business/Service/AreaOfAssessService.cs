using AutoMapper;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.Business.Service
{
    public class AreaOfAssessService : IAreaOfAssess
    {
        private readonly AreaOfAssessDAL _areaOfAssessDAL;
        private readonly IMapper _mapper;

        public AreaOfAssessService(AreaOfAssessDAL areaOfAssessDAL, IMapper mapper)
        {
            _areaOfAssessDAL = areaOfAssessDAL;
            _mapper = mapper;
        }

        public async Task<AreaOfAssessDTO> GetAreaOfAssessByVisitIDAsync(int visitId)
        {
            var areaOfAssessEntity = await _areaOfAssessDAL.GetAreaOfAssessById(visitId);
            var dataAreaOfAssess = _mapper.Map<AreaOfAssessDTO>(areaOfAssessEntity);
            return dataAreaOfAssess;
        }

        public async Task<bool> SaveAreaOfAssessAsync(AreaOfAssessDTO areaOfAssessDTO)
        {
           var status = await _areaOfAssessDAL.SaveAreaOfAssess(_mapper.Map<AreaOfAssess>(areaOfAssessDTO));
            return status;
        }
    }
}

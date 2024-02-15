using AutoMapper;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;

public class CHGeneralService : ICHGeneralService
{
    private readonly CHGeneralDAL _chGeneralDAL;
    private readonly IMapper _mapper;


    public CHGeneralService(CHGeneralDAL chGeneralDAL, IMapper mapper)
    {
        _chGeneralDAL = chGeneralDAL;
        _mapper = mapper;
    }

    public ChGeneralDTO GetCHAGeneralByVisitID(int visitId)
    {
        var chGeneralEntity = _chGeneralDAL.GetCHAGeneralByVisitID(visitId);
        var dataGeneral=_mapper.Map<ChGeneralDTO>(chGeneralEntity);

        return dataGeneral;
    }

    public bool SaveCHGeneral(ChGeneralDTO chGeneralDTO)
    {
        var status = _chGeneralDAL.SaveCHGeneral(_mapper.Map<ChGeneral>(chGeneralDTO));
        return status;
    }
}

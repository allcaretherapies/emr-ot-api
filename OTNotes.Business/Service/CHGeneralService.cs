using AutoMapper;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;
using System.Threading.Tasks;

public class CHGeneralService : ICHGeneralService
{
    private readonly CHGeneralDAL _chGeneralDAL;
    private readonly IMapper _mapper;

    public CHGeneralService(CHGeneralDAL chGeneralDAL, IMapper mapper)
    {
        _chGeneralDAL = chGeneralDAL;
        _mapper = mapper;
    }

    public async Task<ChGeneralDTO> GetCHAGeneralByVisitIDAsync(int visitId)
    {
        var chGeneralEntity = await _chGeneralDAL.GetCHAGeneralByVisitIDAsync(visitId);
        var dataGeneral = _mapper.Map<ChGeneralDTO>(chGeneralEntity);

        return dataGeneral;
    }

    public async Task<bool> SaveCHGeneralAsync(ChGeneralDTO chGeneralDTO)
    {
        var status = await _chGeneralDAL.SaveCHGeneralAsync(_mapper.Map<ChGeneral>(chGeneralDTO));
        return status;
    }
}

using AutoMapper;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;

public class CHMedicalService : ICHMedicalService//,IDisposable
{
    private readonly CHMedicalDAL _dAL;
    private readonly IMapper _mapper;

    public CHMedicalService(CHMedicalDAL chMedicalDAL, IMapper mapper)
    {
        _dAL = chMedicalDAL ?? throw new ArgumentNullException(nameof(chMedicalDAL));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<ChMedicalDTO> GetCHMedicalByVisitIDAsync(int visitId)
    {
        try
        {
            var chEntity = await _dAL.GetCHMedicalByVisitIDAsync(visitId);
            return _mapper.Map<ChMedicalDTO>(chEntity);
        }
        catch (Exception ex)
        {
            // Log the exception
            //_logger.LogError(ex, "Error while retrieving CHMedical entity by visit ID {VisitId}", visitId);

            // Optionally, re-throw the exception to propagate it to the caller
            throw;
        }
    }

    public async Task<bool> SaveCHMedicalAsync(ChMedicalDTO chDTO)
    {
        var status = await _dAL.SaveChMedicalAsync(_mapper.Map<ChMedical>(chDTO));
        return status;
    }

    // Implement IDisposable
    private bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Dispose();
            }
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    
}

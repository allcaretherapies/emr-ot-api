using OTNotes.DTO;
using System.Threading.Tasks;

namespace OTNotes.Business.Interface
{
    public interface ICHGeneralService
    {
        Task<ChGeneralDTO> GetCHAGeneralByVisitIDAsync(int visitId);
        Task<bool> SaveCHGeneralAsync(ChGeneralDTO chGeneralDTO);
    }
}

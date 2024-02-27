using OTNotes.DTO;
using System.Threading.Tasks;

namespace OTNotes.Business.Interface
{
    public interface ICHMedicalService
    {
        Task<ChMedicalDTO> GetCHMedicalByVisitIDAsync(int visitId);
        Task<bool> SaveCHMedicalAsync(ChMedicalDTO chDTO);
    }
}

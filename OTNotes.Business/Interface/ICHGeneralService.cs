using OTNotes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.Business.Interface
{
    public interface ICHGeneralService
    {
        ChGeneralDTO GetCHAGeneralByVisitID(int visitId);
        bool SaveCHGeneral(ChGeneralDTO chGeneralDTO);
    }
}

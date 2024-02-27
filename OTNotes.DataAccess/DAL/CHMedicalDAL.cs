using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OTNotes.DataAccess.DBObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OTNotes.DataAccess.DAL
{
    public class CHMedicalDAL
    {
        private readonly OtnotesContext _dbContext;
        private readonly ILogger<CHMedicalDAL> _logger;

        public CHMedicalDAL(OtnotesContext dbContext, ILogger<CHMedicalDAL> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<ChMedical> GetCHMedicalByVisitIDAsync(int visitId)
        {
            try
            {
                var data = await _dbContext.CHMedicals
                    .OrderBy(o => o.CreatedDate)
                    .FirstOrDefaultAsync(x => x.VisitId == visitId);

                return data;
            }
            catch (DbUpdateException ex)
            {
                HandleDataAccessException(ex);
                return null;
            }
            catch (SqlException ex)
            {
                HandleDataAccessException(ex);
                return null;
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                HandleDataAccessException(ex);
                return null;
            }
        }

        public async Task<bool> SaveChMedicalAsync(ChMedical chMedical)
        {
            try
            {
                var existingData = await GetCHMedicalByVisitIDAsync(chMedical.VisitId);

                if (existingData == null)
                {
                    await _dbContext.CHMedicals.AddAsync(chMedical);
                }
                else
                {
                    UpdateExistingChMedical(existingData, chMedical);
                }

                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                HandleDataAccessException(ex);
                return false;
            }
        }

        private void UpdateExistingChMedical(ChMedical caseHistoryChild, ChMedical newData)
        {
            var dataExist = _dbContext.CHMedicals.Find(caseHistoryChild.CHMedicalId);
            if (dataExist == null)
                return;
            dataExist.FCMIds = caseHistoryChild.FCMIds;
            dataExist.HadHeadInjury = caseHistoryChild.HadHeadInjury;
            dataExist.HeadInjuryDescription = caseHistoryChild.HeadInjuryDescription;
            dataExist.HasAllergy = caseHistoryChild.HasAllergy;
            dataExist.AllergyDescription = caseHistoryChild.AllergyDescription;
            dataExist.PreviousSurgeriesDescription = caseHistoryChild.PreviousSurgeriesDescription;
            dataExist.OverallHealthDescription = caseHistoryChild.OverallHealthDescription;
            dataExist.DoesWearGlasses = caseHistoryChild.DoesWearGlasses;
            dataExist.LastHearingScreeningDate = caseHistoryChild.LastHearingScreeningDate;
            dataExist.Diagnosis1 = caseHistoryChild.Diagnosis1;
            dataExist.Diagnosis1OnsetDate = caseHistoryChild.Diagnosis1OnsetDate;
            dataExist.Diagnosis2 = caseHistoryChild.Diagnosis2;
            dataExist.Diagnosis2OnsetDate = caseHistoryChild.Diagnosis2OnsetDate;
            dataExist.Diagnosis3 = caseHistoryChild.Diagnosis3;
            dataExist.Diagnosis3OnsetDate = caseHistoryChild.Diagnosis3OnsetDate;
            dataExist.Diagnosis4 = caseHistoryChild.Diagnosis4;
            dataExist.Diagnosis4OnsetDate = caseHistoryChild.Diagnosis4OnsetDate;
            dataExist.DoesWearHearingAids = caseHistoryChild.DoesWearHearingAids;
            dataExist.IsOnMedication = caseHistoryChild.IsOnMedication;
            dataExist.MedicationDescription = caseHistoryChild.MedicationDescription;
            dataExist.UpdatedDate = caseHistoryChild.UpdatedDate;
            _dbContext.CHMedicals.Update(dataExist);
            _dbContext.SaveChanges();
            // Mark entity as modified and save changes
            //_dbContext.Entry(existingData).State = EntityState.Modified;
        }

        private void HandleDataAccessException(Exception ex)
        {
            _logger.LogError(ex, "An error occurred in data access.");
            Console.WriteLine("An error occurred in data access: " + ex.Message);
            throw new DataAccessException("An error occurred in data access.", ex);
        }
        

       
    }
}

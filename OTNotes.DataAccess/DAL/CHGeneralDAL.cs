using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OTNotes.DataAccess.DBObject;
using System;
using System.Threading.Tasks;

namespace OTNotes.DataAccess.DAL
{
    public class CHGeneralDAL
    {
        private readonly OtnotesContext _dbContext;
        private readonly ILogger<CHGeneralDAL> _logger;

        public CHGeneralDAL(OtnotesContext dbContext, ILogger<CHGeneralDAL> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<ChGeneral> GetCHAGeneralByVisitIDAsync(int visitId)
        {
            var data = await _dbContext.CHGenerals.OrderBy(o => o.CreatedDate).FirstOrDefaultAsync(x => x.VisitId == visitId);
            return data;
        }

        public async Task<bool> SaveCHGeneralAsync(ChGeneral chGeneral)
        {
            try
            {
                var isDataExist = await GetCHAGeneralByVisitIDAsync(chGeneral.VisitId);
                if (isDataExist == null)
                {
                    chGeneral.CreatedDate = DateTime.Now;
                    await _dbContext.CHGenerals.AddAsync(chGeneral);
                }
                else
                {
                    UpdateExistingChGeneral(chGeneral);
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

        private void UpdateExistingChGeneral(ChGeneral existingData)
        {
            var dataExist = _dbContext.CHGenerals.FirstOrDefault(x => x.VisitId == existingData.VisitId);
            if (dataExist == null)
                return;

            dataExist.DominantLanguage = existingData.DominantLanguage;
            dataExist.DominantLanguageOther = existingData.DominantLanguageOther;
            dataExist.AdditionalLanguages = existingData.AdditionalLanguages;
            dataExist.IsHomeBound = existingData.IsHomeBound;
            dataExist.HomBoundDetail = existingData.HomBoundDetail;
            dataExist.HomBoundDescription = existingData.HomBoundDescription;
            dataExist.PriorAdl = existingData.PriorAdl;
            dataExist.HasFallHistory = existingData.HasFallHistory;
            dataExist.FallHistoryDate = existingData.FallHistoryDate;
            dataExist.IsIntervention = existingData.IsIntervention;
            dataExist.InterventionDetail = existingData.InterventionDetail;
            dataExist.ReportedBy = existingData.ReportedBy;
            dataExist.LivingSituation = existingData.LivingSituation;
            dataExist.LivingSituationDescription = existingData.LivingSituationDescription;
            dataExist.EnvBarrier = existingData.EnvBarrier;
            dataExist.EnvBarrierEquipment = existingData.EnvBarrierEquipment;
            dataExist.AdaptiveEquipment = existingData.AdaptiveEquipment;
            dataExist.AdaptiveEquipmentDeatil = existingData.AdaptiveEquipmentDeatil;
            dataExist.CommunicatesThrough = existingData.CommunicatesThrough;
            dataExist.UnderstandingLevel = existingData.UnderstandingLevel;
            dataExist.HasFamilyDefict = existingData.HasFamilyDefict;
            dataExist.FamilyDefictDescription = existingData.FamilyDefictDescription;
            dataExist.DeficitEffect = existingData.DeficitEffect;
            dataExist.LivingSiblingDescription = existingData.LivingSiblingDescription;
            dataExist.AttendSchool = existingData.AttendSchool;
            dataExist.WhereName = existingData.WhereName;
            dataExist.ClassGrade = existingData.ClassGrade;
            dataExist.CurrentPlan = existingData.CurrentPlan;
            dataExist.HasSocialSkillConcern = existingData.HasSocialSkillConcern;
            dataExist.SocialSkillConcernDescription = existingData.SocialSkillConcernDescription;
            dataExist.SpeechTherapyReason = existingData.SpeechTherapyReason;
            dataExist.ExpectedOutcome = existingData.ExpectedOutcome;
            dataExist.HasSpeechTherapyInPast = existingData.HasSpeechTherapyInPast;
            dataExist.PastSpeechTherapyDescription = existingData.PastSpeechTherapyDescription;
            dataExist.ReceivedPastSpeechTherapyReport = existingData.ReceivedPastSpeechTherapyReport;
            dataExist.OtherSpecialistsWorkedWith = existingData.OtherSpecialistsWorkedWith;
            dataExist.IsReceivingOutsideAgencyService = existingData.IsReceivingOutsideAgencyService;
            dataExist.ReceivingOutsideAgencyWhere = existingData.ReceivingOutsideAgencyWhere;
            dataExist.SitupAge = existingData.SitupAge;
            dataExist.StandAge = existingData.StandAge;
            dataExist.SpeakWordAge = existingData.SpeakWordAge;
            dataExist.CrawlAge = existingData.CrawlAge;
            dataExist.WalkAge = existingData.WalkAge;
            dataExist.ComWordsAge1 = existingData.ComWordsAge1;
            dataExist.ComWordsAge = existingData.ComWordsAge;
            dataExist.UpdatedDate = DateTime.Now;
            dataExist.HaveYouReceiveReport = existingData.HaveYouReceiveReport;
            _dbContext.CHGenerals.Update(dataExist);
            _dbContext.SaveChanges();

        }

        private void HandleDataAccessException(Exception ex)
        {
            _logger.LogError(ex, "An error occurred in data access.");
            Console.WriteLine("An error occurred in data access: " + ex.Message);
            throw new DataAccessException("An error occurred in data access.", ex);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTNotes.DataAccess.DAL
{
    public class AreaOfAssessDAL
    {
        private readonly OtnotesContext _dbContext;
        public AreaOfAssessDAL(OtnotesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AreaOfAssess> GetAreaOfAssessById(int id)
        {
            var areaOfAssess = await _dbContext.AreaOfAssesses
                                              .Where(x => x.VisitId == id)
                                              .SingleOrDefaultAsync();
            return areaOfAssess;
        }


        public async Task<bool> SaveAreaOfAssess(AreaOfAssess areaOfAssess)
        {
            var existingData = await GetAreaOfAssessById(areaOfAssess.VisitId);
            if (existingData == null)
            {
                areaOfAssess.CreatedBy = areaOfAssess.CreatedBy;
                areaOfAssess.CreatedDate = DateTime.Now;
                areaOfAssess.UpdatedBy = null;
                await _dbContext.AreaOfAssesses.AddAsync(areaOfAssess);
            }
            else
            {
                existingData.AssessArea = areaOfAssess.AssessArea;
                existingData.UpdatedBy = areaOfAssess.UpdatedBy;
                existingData.UpdatedDate = DateTime.Now;
                UpdateExistingAreaOfAssess(existingData);
            }

            await _dbContext.SaveChangesAsync();
            return true;
          
        }

        private void UpdateExistingAreaOfAssess(AreaOfAssess areaOfAssess)
        {
            var dataExist = _dbContext.AreaOfAssesses.Find(areaOfAssess.AreaOfAssessId);
            if (dataExist == null)
                return;
            dataExist.AssessArea = areaOfAssess.AssessArea;
            _dbContext.AreaOfAssesses.Update(dataExist);
            _dbContext.SaveChanges();
        }
    }
}

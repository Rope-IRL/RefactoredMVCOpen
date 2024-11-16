using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface ILesseeAdditionalInfoRepository
{
    public Task<List<LesseeAdditionalInfo>> GetAllLesseeAdditionalInfos();
    
    public Task<LesseeAdditionalInfo> GetLesseeAdditionalInfoById(int id);
    
    public Task AddLesseeAdditionalInfo(LesseeAdditionalInfo lesseeAdditionalInfo);
    
    public Task UpdateLesseeAdditionalInfo(LesseeAdditionalInfo lesseeAdditionalInfo);
    
    public Task DeleteLesseeAdditionalInfo(int id);
}
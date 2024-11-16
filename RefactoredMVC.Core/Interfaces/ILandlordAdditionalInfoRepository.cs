using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface ILandlordAdditionalInfoRepository
{
    public Task<List<LandlordAdditionalInfo>> GetAdditionalInfosAsync();
    
    public Task<LandlordAdditionalInfo> GetAdditionalInfoByIdAsync(int id);
    
    public Task AddAdditionalInfoAsync(LandlordAdditionalInfo additionalInfos);
    
    public Task UpdateAdditionalInfoAsync(LandlordAdditionalInfo additionalInfos);
    
    public Task DeleteAdditionalInfoAsync(int id);
}
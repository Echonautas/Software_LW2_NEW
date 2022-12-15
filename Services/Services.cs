using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Models;

namespace Software.Design.Services;

public class My_Services
{
    private readonly Context _dbContext;

    public My_Services(Context dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<F1>> Get()
    {
        var placeholder = await _dbContext.Database.ToListAsync();
        return placeholder;
    }
    public async Task<F1DTO> Create(F1DTO f1DTO)
    {
        var placeholder = new F1(f1DTO);
        await _dbContext.AddAsync(placeholder);
        await _dbContext.SaveChangesAsync();
        return f1DTO;
    }
    public async Task<F1> Get_By_ID(int id)
    {
        var placeholder = await _dbContext.Database.Where(x => x.Id == id).FirstOrDefaultAsync();
        return placeholder;
    }
    public async Task<F1> Edit(int id, F1DTO f1DTO)
    {
        var placeholder = await _dbContext.Database.Where(x => x.Id == id).FirstOrDefaultAsync();

            placeholder.Name = f1DTO.Name;
            placeholder.WorldChampionships = f1DTO.WorldChampionships;
            placeholder.Country = f1DTO.Country;
            placeholder.TeamId = f1DTO.TeamId;
            await _dbContext.SaveChangesAsync();
        
        return placeholder;

    }
    public async Task<F1> Delete(int id)
    {
       var placeholder = await _dbContext.Database.Where(x => x.Id == id).FirstOrDefaultAsync();
       
       _dbContext.Database.Remove(placeholder);
        await _dbContext.SaveChangesAsync();
        await _dbContext.Database.ToListAsync();
        return placeholder;
    }
}
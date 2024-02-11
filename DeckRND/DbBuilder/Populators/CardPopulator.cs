using MtgApiManager.Lib.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBuilder.Populators;

public static class CardPopulator
{
    public static async Task PopulateAsync(IMtgServiceProvider serviceProvider, string cardDirectory)
    {
        var cardService = serviceProvider.GetCardService();
        var cardPageCount = 1;
        while (true)
        {
            try
            {
                var result = await cardService.Where(x => x.Page, cardPageCount)
                                        .Where(x => x.PageSize, 100)
                                        .AllAsync();
                if (result is not null && result.Value is not null && result.Value.Count == 0)
                {
                    return;
                }

                var filePath = Path.Combine(cardDirectory, $"{cardPageCount}.json");
                File.WriteAllText(filePath, JsonConvert.SerializeObject(result.Value));
                cardPageCount++;
            }
            catch (Exception)
            {
                break;
            }
        }
    }
}

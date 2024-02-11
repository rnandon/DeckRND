using MtgApiManager.Lib.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBuilder.Populators;

public class SetPopulator
{
    public static async Task PopulateAsync(IMtgServiceProvider serviceProvider, string setDirectory)
    {
		try
        {
            var service = serviceProvider.GetSetService();
            var result = await service.AllAsync();
            if (result is not null && result.Value is not null && result.Value.Count > 0)
            {
                File.WriteAllText(Path.Combine(setDirectory, "Sets.json"), JsonConvert.SerializeObject(result.Value));
            }
        }
		catch { }
		finally { }
    }
}

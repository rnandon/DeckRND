﻿using MtgApiManager.Lib.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBuilder.Populators;

public static class FormatPopulator
{
    public static async Task PopulateAsync(IMtgServiceProvider serviceProvider, string formatDirectory)
    {
        try
        {
            var service = serviceProvider.GetCardService();
            var result = await service.GetFormatsAsync();
            if (result is not null && result.Value is not null && result.Value.Count > 0)
            {
                File.WriteAllText(Path.Combine(formatDirectory, "Formats.json"), JsonConvert.SerializeObject(result.Value));
            }
        }
        catch { }
        finally { }
    }
}
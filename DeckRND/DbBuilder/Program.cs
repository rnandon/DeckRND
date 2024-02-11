// See https://aka.ms/new-console-template for more information
using DbBuilder.Populators;
using MtgApiManager.Lib.Service;
using Newtonsoft.Json;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
var serviceProvider = new MtgServiceProvider();

var baseDirectory = @"D:\DeckRND";
var cardsDirectory = Path.Combine(baseDirectory, "Cards");
var setsDirectory = Path.Combine(baseDirectory, "Sets");
var typesDirectory = Path.Combine(baseDirectory, "Types");
var subTypesDirectory = Path.Combine(baseDirectory, "Subtypes");
var superTypesDirectory = Path.Combine(baseDirectory, "Supertypes");
var formatsDirectory = Path.Combine(baseDirectory, "Formats");

Directory.CreateDirectory(cardsDirectory);
Directory.CreateDirectory(setsDirectory);
Directory.CreateDirectory(typesDirectory);
Directory.CreateDirectory(subTypesDirectory);
Directory.CreateDirectory(superTypesDirectory);
Directory.CreateDirectory(formatsDirectory);

try
{
    await CardPopulator.PopulateAsync(serviceProvider, cardsDirectory);
    await SetPopulator.PopulateAsync(serviceProvider, setsDirectory);
    await TypePopulator.PopulateAsync(serviceProvider,  typesDirectory);
    await SubtypePopulator.PopulateAsync(serviceProvider, subTypesDirectory);
    await SupertypePopulator.PopulateAsync(serviceProvider,  superTypesDirectory);
    await FormatPopulator.PopulateAsync(serviceProvider, formatsDirectory);
}
catch { }

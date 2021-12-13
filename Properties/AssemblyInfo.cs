using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(NickysModMenu.BuildInfo.Description)]
[assembly: AssemblyDescription(NickysModMenu.BuildInfo.Description)]
[assembly: AssemblyCompany(NickysModMenu.BuildInfo.Company)]
[assembly: AssemblyProduct(NickysModMenu.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + NickysModMenu.BuildInfo.Author)]
[assembly: AssemblyTrademark(NickysModMenu.BuildInfo.Company)]
[assembly: AssemblyVersion(NickysModMenu.BuildInfo.Version)]
[assembly: AssemblyFileVersion(NickysModMenu.BuildInfo.Version)]
[assembly: MelonInfo(typeof(NickysModMenu.Main), NickysModMenu.BuildInfo.Name, NickysModMenu.BuildInfo.Version, NickysModMenu.BuildInfo.Author, NickysModMenu.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
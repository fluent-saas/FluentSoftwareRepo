using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FluentSoftware.Localization
{
    public static class FluentSoftwareLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FluentSoftwareConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FluentSoftwareLocalizationConfigurer).GetAssembly(),
                        "FluentSoftware.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

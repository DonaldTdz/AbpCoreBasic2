using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpCoreBasic.Localization
{
    public static class AbpCoreBasicLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpCoreBasicConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpCoreBasicLocalizationConfigurer).GetAssembly(),
                        "AbpCoreBasic.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

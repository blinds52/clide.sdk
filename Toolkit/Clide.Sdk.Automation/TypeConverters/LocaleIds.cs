namespace Clide.Sdk.Automation.TypeConverters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using NuPattern.ComponentModel;
    using NuPattern.Diagnostics;

    /// <summary>
    /// A custom type converter for returning a list of System.String values.
    /// </summary>
    [DisplayName("LocaleIds Custom Enumeration Type Converter")]
    [Category("General")]
    [Description("Returns a list of custom enumerations.")]
    [CLSCompliant(false)]
    public class LocaleIds : StringConverter
    {
        private static readonly ITracer tracer = Tracer.Get<LocaleIds>();
        private static readonly Lazy<List<StandardValue>> locales = new Lazy<List<StandardValue>>(GetLocales);

        /// <summary>
        /// Determines whether this converter supports standard values.
        /// </summary>
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Determines whether this converter only allows selection of items returned by <see cref="GetStandardValues"/>.
        /// </summary>
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Returns the list of string values for the enumeration
        /// </summary>
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(locales.Value);
        }

        private static List<StandardValue> GetLocales()
        {
            return CultureInfo
                .GetCultures(CultureTypes.AllCultures)
                .Select(ci => new StandardValue(ci.DisplayName, ci.LCID.ToString(), "Locale ID: " + ci.LCID, ci.ThreeLetterISOLanguageName))
                .ToList();
        }
    }
}

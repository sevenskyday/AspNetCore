// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.Formatters.Json
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.Formatters.Json.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// {0} cannot be null.
        /// </summary>
        internal static string ContractResolverCannotBeNull
        {
            get => GetString("ContractResolverCannotBeNull");
        }

        /// <summary>
        /// {0} cannot be null.
        /// </summary>
        internal static string FormatContractResolverCannotBeNull(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ContractResolverCannotBeNull"), p0);

        /// <summary>
        /// Cannot configure JSON casing behavior on '{0}' contract resolver. The supported contract resolver is {1}.
        /// </summary>
        internal static string InvalidContractResolverForJsonCasingConfiguration
        {
            get => GetString("InvalidContractResolverForJsonCasingConfiguration");
        }

        /// <summary>
        /// Cannot configure JSON casing behavior on '{0}' contract resolver. The supported contract resolver is {1}.
        /// </summary>
        internal static string FormatInvalidContractResolverForJsonCasingConfiguration(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidContractResolverForJsonCasingConfiguration"), p0, p1);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}

namespace Clide.Sdk.Automation.ValueProviders
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using Microsoft.CSharp;
    using NuPattern.Runtime;

    [DisplayName("Code Identifier from Expression")]
    [Category("General")]
    [Description("Sanitizes the specified Expression property to make it a valid code identifier.")]
    [CLSCompliant(false)]
    public class CodeIdentifier : ValueProvider
    {
        /// <summary>
        /// Evaluates the provider and returns the value.
        /// </summary>
        public override object Evaluate()
        {
            return this.Expression.Replace(" ", "");
        }

        [Description("Expression to convert to a valid code identifier.")]
        public string Expression { get; set; }
    }
}
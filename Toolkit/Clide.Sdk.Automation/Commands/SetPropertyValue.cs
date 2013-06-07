namespace Clide.Sdk.Automation.Commands
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Composition;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using NuPattern;
    using NuPattern.Diagnostics;
    using NuPattern.Runtime;
    
    public class SetPropertyValue : Command
    {
        [Required(AllowEmptyStrings = false)]
        public string PropertyName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string PropertyValue { get; set; }

        [Import(AllowDefault = true)]
        public IProductElement CurrentElement { get; set; }

        public override void Execute()
        {
            this.ValidateObject();

            var property = this.CurrentElement.Properties.FirstOrDefault(p => p.DefinitionName == this.PropertyName);
            if (property != null)
                property.RawValue = this.PropertyValue;
        }

    }
}
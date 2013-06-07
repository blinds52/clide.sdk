using System;
using System.ComponentModel;
using NuPattern.Presentation;

namespace Clide.Sdk.Assets.Wizards
{
    /// <summary>
    /// A wizard for displaying pages to configure the current element.
    /// </summary>
    [DisplayName("ProductWizard")]
    [Description("A custom wizard for displaying pages to configure the current element.")]
    [Category("General")]
    [CLSCompliant(false)]
    partial class ProductWizard : WizardWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductWizard"/> class.
        /// </summary>
        /// <param name="serviceProvider">A service provider.</param>
        public ProductWizard(IServiceProvider serviceProvider) :
            base(serviceProvider)
        {
            this.InitializeComponent();
        }
    }
}
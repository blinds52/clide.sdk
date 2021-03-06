﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clide.Sdk
{
	using global::Clide.Sdk.Automation.TypeConverters;
	using global::NuPattern.ComponentModel.Design;
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A Visual Studio extension project to expose commands, menus and other automation.
	/// </summary>
	[Description("A Visual Studio extension project to expose commands, menus and other automation.")]
	[ToolkitInterfaceProxy(ExtensionId = "f24d5912-1045-4408-862d-03bc85142290", DefinitionId = "4c65cb2d-3b58-4eab-89ad-8cce92c1788a", ProxyType = typeof(VisualStudioExtension))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.21.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class VisualStudioExtension : IVisualStudioExtension
	{

		private Runtime.IProduct target;
		private IProductProxy<IVisualStudioExtension> proxy;

		/// <summary>
		/// Creates a new instance of the <see cref="VisualStudioExtension"/> class.
		/// </summary>
		[ImportingConstructor]
		private VisualStudioExtension() { }

		/// <summary>
		/// Creates a new instance of the <see cref="VisualStudioExtension"/> class.
		/// </summary>
		public VisualStudioExtension(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IVisualStudioExtension>();
			OnCreated();
		}

		/// <summary>
		/// When overridden, initializes the class.
		/// </summary>
		partial void OnCreated();

		/// <summary>
		/// Identifier for your extension. Should never change, so that updates are properly notified to Visual Studio. Can be a regular string, typically in the format of CompanyName.ProductName, but sometimes a GUID is used.
		/// </summary>
		[Description("Identifier for your extension. Should never change, so that updates are properly notified to Visual Studio. Can be a regular string, typically in the format of CompanyName.ProductName, but sometimes a GUID is used.")]
		[DisplayName("Vsix Identifier")]
		[Category("General")]
		public virtual String VsixId
		{
			get { return this.proxy.GetValue(() => this.VsixId); }
			set { this.proxy.SetValue(() => this.VsixId, value); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.ProductName
		/// </summary>
		[Description("Description for VisualStudioExtension.ProductName")]
		[DisplayName("Product Name")]
		[Category("General")]
		public virtual String ProductName
		{
			get { return this.proxy.GetValue(() => this.ProductName); }
			set { this.proxy.SetValue(() => this.ProductName, value); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.Author
		/// </summary>
		[Description("Description for VisualStudioExtension.Author")]
		[DisplayName("Author")]
		[Category("General")]
		public virtual String Author
		{
			get { return this.proxy.GetValue(() => this.Author); }
			set { this.proxy.SetValue(() => this.Author, value); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.Version
		/// </summary>
		[Description("Description for VisualStudioExtension.Version")]
		[DisplayName("Version")]
		[Category("General")]
		public virtual String Version
		{
			get { return this.proxy.GetValue(() => this.Version); }
			set { this.proxy.SetValue(() => this.Version, value); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.Description
		/// </summary>
		[Description("Description for VisualStudioExtension.Description")]
		[DisplayName("Description")]
		[Category("General")]
		public virtual String Description
		{
			get { return this.proxy.GetValue(() => this.Description); }
			set { this.proxy.SetValue(() => this.Description, value); }
		}

		/// <summary>
		/// The Locale element describes the locale of the extension.  The locale value is a four digit numerical value.
		/// </summary>
		[Description("The Locale element describes the locale of the extension.  The locale value is a four digit numerical value.")]
		[DisplayName("Locale")]
		[Category("General")]
		[TypeConverter(typeof(LocaleIds))]
		[Editor(typeof(StandardValuesEditor), typeof(UITypeEditor))]
		public virtual String Locale
		{
			get { return this.proxy.GetValue(() => this.Locale); }
			set { this.proxy.SetValue(() => this.Locale, value); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.RootNamespace
		/// </summary>
		[Description("Description for VisualStudioExtension.RootNamespace")]
		[DisplayName("Root Namespace")]
		[Category("General")]
		public virtual String RootNamespace
		{
			get { return this.proxy.GetValue(() => this.RootNamespace); }
			set { this.proxy.SetValue(() => this.RootNamespace, value); }
		}

		/// <summary>
		/// Gets or sets the ToolkitInfo property.
		/// </summary>
		public virtual IProductToolkitInfo ToolkitInfo
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}

		/// <summary>
		/// Gets or sets the CurrentView property.
		/// </summary>
		public virtual IView CurrentView
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		public virtual String InstanceName
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		public virtual Double InstanceOrder
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		public virtual Boolean InTransaction
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		public virtual Boolean IsSerializing
		{ 
			get { return this.proxy.GetValue(() => this.IsSerializing); }
		}

		/// <summary>
		/// Description for VisualStudioExtension.DefaultView
		/// </summary>
		[Description("Description for VisualStudioExtension.DefaultView")]
		public virtual IDefaultView DefaultView
		{
			get { return this.proxy.GetView(() => this.DefaultView, view => new DefaultView(view)); }
		}

		/// <summary>
		/// Deletes this element.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IProduct"/>) of this element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the specified generalized interface of this element, if possible.
		/// </summary>
		public virtual TGeneralizedInterface As<TGeneralizedInterface>() where TGeneralizedInterface : class
		{
			return this.target as TGeneralizedInterface;
		}
	}
}

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
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// A Visual Studio extension project to expose commands, menus and other automation.
	/// </summary>
	[Description("A Visual Studio extension project to expose commands, menus and other automation.")]
	[ToolkitInterface(ExtensionId = "f24d5912-1045-4408-862d-03bc85142290", DefinitionId = "4c65cb2d-3b58-4eab-89ad-8cce92c1788a", ProxyType = typeof(VisualStudioExtension))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.21.0")]
	public partial interface IVisualStudioExtension : IToolkitInterface
	{

		/// <summary>
		/// Identifier for your extension. Should never change, so that updates are properly notified to Visual Studio. Can be a regular string, typically in the format of CompanyName.ProductName, but sometimes a GUID is used.
		/// </summary>
		[Description("Identifier for your extension. Should never change, so that updates are properly notified to Visual Studio. Can be a regular string, typically in the format of CompanyName.ProductName, but sometimes a GUID is used.")]
		[DisplayName("Vsix Identifier")]
		[Category("General")]
		String VsixId { get; set; }

		/// <summary>
		/// Description for VisualStudioExtension.ProductName
		/// </summary>
		[Description("Description for VisualStudioExtension.ProductName")]
		[DisplayName("Product Name")]
		[Category("General")]
		String ProductName { get; set; }

		/// <summary>
		/// Description for VisualStudioExtension.Author
		/// </summary>
		[Description("Description for VisualStudioExtension.Author")]
		[DisplayName("Author")]
		[Category("General")]
		String Author { get; set; }

		/// <summary>
		/// Description for VisualStudioExtension.Version
		/// </summary>
		[Description("Description for VisualStudioExtension.Version")]
		[DisplayName("Version")]
		[Category("General")]
		String Version { get; set; }

		/// <summary>
		/// Description for VisualStudioExtension.Description
		/// </summary>
		[Description("Description for VisualStudioExtension.Description")]
		[DisplayName("Description")]
		[Category("General")]
		String Description { get; set; }

		/// <summary>
		/// The Locale element describes the locale of the extension.  The locale value is a four digit numerical value.
		/// </summary>
		[Description("The Locale element describes the locale of the extension.  The locale value is a four digit numerical value.")]
		[DisplayName("Locale")]
		[Category("General")]
		[TypeConverter(typeof(LocaleIds))]
		[Editor(typeof(StandardValuesEditor), typeof(UITypeEditor))]
		String Locale { get; set; }

		/// <summary>
		/// Description for VisualStudioExtension.RootNamespace
		/// </summary>
		[Description("Description for VisualStudioExtension.RootNamespace")]
		[DisplayName("Root Namespace")]
		[Category("General")]
		String RootNamespace { get; set; }

		/// <summary>
		/// Gets or sets the ToolkitInfo property.
		/// </summary>
		IProductToolkitInfo ToolkitInfo { get; }

		/// <summary>
		/// Gets or sets the CurrentView property.
		/// </summary>
		IView CurrentView { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Description for VisualStudioExtension.DefaultView
		/// </summary>
		[Description("Description for VisualStudioExtension.DefaultView")]
		IDefaultView DefaultView { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IProduct"/>) of this element.
		/// </summary>
		Runtime.IProduct AsProduct();
	}
}

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
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Description for VisualStudioExtension.DefaultView
	/// </summary>
	[Description("Description for VisualStudioExtension.DefaultView")]
	[ToolkitInterface(ExtensionId = "f24d5912-1045-4408-862d-03bc85142290", DefinitionId = "40430b9d-7034-4b4d-a2f7-ea6d5832f2cb", ProxyType = typeof(DefaultView))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.21.0")]
	public partial interface IDefaultView : IToolkitInterface
	{

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IVisualStudioExtension Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IView"/>) of this element.
		/// </summary>
		Runtime.IView AsView();
	}
}
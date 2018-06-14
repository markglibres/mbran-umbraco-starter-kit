//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace MBran.Modules
{
	/// <summary>Navigation</summary>
	[PublishedContentModel("navigation")]
	public partial class Navigation : PublishedContentModel, IModuleContent, INavigationContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "navigation";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Navigation(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Navigation, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Enable?
		///</summary>
		[ImplementPropertyType("enable")]
		public bool Enable
		{
			get { return MBran.Modules.ModuleContent.GetEnable(this); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public IEnumerable<IPublishedContent> Links
		{
			get { return MBran.Modules.NavigationContent.GetLinks(this); }
		}
	}
}

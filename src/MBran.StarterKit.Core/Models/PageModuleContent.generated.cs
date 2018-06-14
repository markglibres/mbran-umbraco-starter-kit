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

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1146 with alias "pageModuleContent"
	/// <summary>{Page Module Content}</summary>
	public partial interface IPageModuleContent : IPublishedContent
	{
		/// <summary>Content Modules</summary>
		IEnumerable<IPublishedContent> ContentModules { get; }
	}

	/// <summary>{Page Module Content}</summary>
	[PublishedContentModel("pageModuleContent")]
	public partial class PageModuleContent : PublishedContentModel, IPageModuleContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageModuleContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageModuleContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageModuleContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Modules
		///</summary>
		[ImplementPropertyType("contentModules")]
		public IEnumerable<IPublishedContent> ContentModules
		{
			get { return GetContentModules(this); }
		}

		/// <summary>Static getter for Content Modules</summary>
		public static IEnumerable<IPublishedContent> GetContentModules(IPageModuleContent that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("contentModules"); }
	}
}
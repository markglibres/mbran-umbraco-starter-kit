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
	// Mixin content Type 1179 with alias "formHtmlContent"
	/// <summary>{Form Html Content}</summary>
	public partial interface IFormHtmlContent : IPublishedContent
	{
		/// <summary>Content</summary>
		IHtmlString Content { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>{Form Html Content}</summary>
	[PublishedContentModel("formHtmlContent")]
	public partial class FormHtmlContent : PublishedContentModel, IFormHtmlContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "formHtmlContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FormHtmlContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FormHtmlContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return GetContent(this); }
		}

		/// <summary>Static getter for Content</summary>
		public static IHtmlString GetContent(IFormHtmlContent that) { return that.GetPropertyValue<IHtmlString>("content"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(IFormHtmlContent that) { return that.GetPropertyValue<string>("title"); }
	}
}

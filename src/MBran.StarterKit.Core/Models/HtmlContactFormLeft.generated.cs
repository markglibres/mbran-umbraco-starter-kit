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
	/// <summary>Html Contact Form - Left</summary>
	[PublishedContentModel("htmlContactFormLeft")]
	public partial class HtmlContactFormLeft : PublishedContentModel, IFormHtmlContent, IModuleContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "htmlContactFormLeft";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HtmlContactFormLeft(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HtmlContactFormLeft, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return MBran.Modules.FormHtmlContent.GetContent(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return MBran.Modules.FormHtmlContent.GetTitle(this); }
		}

		///<summary>
		/// Enable?
		///</summary>
		[ImplementPropertyType("enable")]
		public bool Enable
		{
			get { return MBran.Modules.ModuleContent.GetEnable(this); }
		}
	}
}

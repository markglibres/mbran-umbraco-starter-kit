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
	/// <summary>Basic Image Html</summary>
	[PublishedContentModel("basicImageHtml")]
	public partial class BasicImageHtml : PublishedContentModel, IBasicImageHtmlContent, IModuleContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicImageHtml";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicImageHtml(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicImageHtml, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return MBran.Modules.BasicImageHtmlContent.GetContent(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return MBran.Modules.BasicImageHtmlContent.GetImage(this); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return MBran.Modules.BasicImageHtmlContent.GetSummary(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return MBran.Modules.BasicImageHtmlContent.GetTitle(this); }
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

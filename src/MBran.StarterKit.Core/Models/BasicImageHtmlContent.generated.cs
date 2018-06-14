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
	// Mixin content Type 1157 with alias "basicImageHtmlContent"
	/// <summary>{Basic Image Html Content}</summary>
	public partial interface IBasicImageHtmlContent : IPublishedContent
	{
		/// <summary>Content</summary>
		IHtmlString Content { get; }

		/// <summary>Image</summary>
		IPublishedContent Image { get; }

		/// <summary>Summary</summary>
		string Summary { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>{Basic Image Html Content}</summary>
	[PublishedContentModel("basicImageHtmlContent")]
	public partial class BasicImageHtmlContent : PublishedContentModel, IBasicImageHtmlContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicImageHtmlContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicImageHtmlContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicImageHtmlContent, TValue>> selector)
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
		public static IHtmlString GetContent(IBasicImageHtmlContent that) { return that.GetPropertyValue<IHtmlString>("content"); }

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return GetImage(this); }
		}

		/// <summary>Static getter for Image</summary>
		public static IPublishedContent GetImage(IBasicImageHtmlContent that) { return that.GetPropertyValue<IPublishedContent>("image"); }

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return GetSummary(this); }
		}

		/// <summary>Static getter for Summary</summary>
		public static string GetSummary(IBasicImageHtmlContent that) { return that.GetPropertyValue<string>("summary"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(IBasicImageHtmlContent that) { return that.GetPropertyValue<string>("title"); }
	}
}

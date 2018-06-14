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
	/// <summary>Full Width Subscribe Form</summary>
	[PublishedContentModel("fullWidthSubscribeForm")]
	public partial class FullWidthSubscribeForm : PublishedContentModel, IFormTextAndImageContent, IModuleContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "fullWidthSubscribeForm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FullWidthSubscribeForm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FullWidthSubscribeForm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public string Content
		{
			get { return MBran.Modules.FormTextAndImageContent.GetContent(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return MBran.Modules.FormTextAndImageContent.GetImage(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return MBran.Modules.FormTextAndImageContent.GetTitle(this); }
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

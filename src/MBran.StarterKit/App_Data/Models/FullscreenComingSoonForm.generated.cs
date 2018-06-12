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
	/// <summary>Fullscreen Coming Soon Form</summary>
	[PublishedContentModel("fullscreenComingSoonForm")]
	public partial class FullscreenComingSoonForm : PublishedContentModel, IFormTextAndImageContent, IModuleContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "fullscreenComingSoonForm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FullscreenComingSoonForm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FullscreenComingSoonForm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public string Content
		{
			get { return Umbraco.Web.PublishedContentModels.FormTextAndImageContent.GetContent(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return Umbraco.Web.PublishedContentModels.FormTextAndImageContent.GetImage(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.FormTextAndImageContent.GetTitle(this); }
		}

		///<summary>
		/// Enable?
		///</summary>
		[ImplementPropertyType("enable")]
		public bool Enable
		{
			get { return Umbraco.Web.PublishedContentModels.ModuleContent.GetEnable(this); }
		}
	}
}
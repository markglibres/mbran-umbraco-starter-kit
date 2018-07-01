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
	// Mixin content Type 1235 with alias "navigationMultiContent"
	/// <summary>{Navigation Multi Content}</summary>
	public partial interface INavigationMultiContent : IPublishedContent
	{
		/// <summary>Navigration Groups</summary>
		IEnumerable<IPublishedContent> NavigrationGroups { get; }
	}

	/// <summary>{Navigation Multi Content}</summary>
	[PublishedContentModel("navigationMultiContent")]
	public partial class NavigationMultiContent : PublishedContentModel, INavigationMultiContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "navigationMultiContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NavigationMultiContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavigationMultiContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Navigration Groups
		///</summary>
		[ImplementPropertyType("navigrationGroups")]
		public IEnumerable<IPublishedContent> NavigrationGroups
		{
			get { return GetNavigrationGroups(this); }
		}

		/// <summary>Static getter for Navigration Groups</summary>
		public static IEnumerable<IPublishedContent> GetNavigrationGroups(INavigationMultiContent that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("navigrationGroups"); }
	}
}

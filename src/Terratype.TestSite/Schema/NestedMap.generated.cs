//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
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

namespace Terratype.TestSite.Schema
{
	/// <summary>Nested Map</summary>
	[PublishedContentModel("nestedMap")]
	public partial class NestedMap : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "nestedMap";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NestedMap(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NestedMap, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Map: some text
		///</summary>
		[ImplementPropertyType("map")]
		public Terratype.Models.Model Map
		{
			get { return this.GetPropertyValue<Terratype.Models.Model>("map"); }
		}

		///<summary>
		/// Map Name: This is the name
		///</summary>
		[ImplementPropertyType("mapName")]
		public string MapName
		{
			get { return this.GetPropertyValue<string>("mapName"); }
		}
	}
}

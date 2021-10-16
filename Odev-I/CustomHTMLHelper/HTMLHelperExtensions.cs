using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Odev_I.CustomHTMLHelper
{
    public static class HTMLHelperExtensions 
    {

		public static IHtmlContent Date(this IHtmlHelper helper, string type, string name, string id)
		{

			TagBuilder builder = new TagBuilder("input");
			builder.Attributes.Add("type", type);
			builder.Attributes.Add("name", name);
			builder.Attributes.Add("id", id);
			builder.TagRenderMode = TagRenderMode.SelfClosing;

			return builder;
		}

		public static IHtmlContent Button(this IHtmlHelper helper, string type, string text)
		{

			TagBuilder builder = new TagBuilder("button");
			builder.Attributes.Add("type", type);
			builder.Attributes.Add("",text);
			builder.TagRenderMode = TagRenderMode.EndTag;

			return builder;
		}
		public static IHtmlContent Button(this IHtmlHelper helper, string text)
		{
			string buttonHtml = $"<button>{text}</button>";
			HtmlString button = new HtmlString(buttonHtml);
			return button;
		}

	}
}

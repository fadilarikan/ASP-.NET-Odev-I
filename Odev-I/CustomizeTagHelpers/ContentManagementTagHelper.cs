using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Odev_I.CustomizeTagHelpers
{
	[HtmlTargetElement("contentManage")]
	public class ContentManagementTagHelper : TagHelper
    {
		public string Title { get; set; }
		public string TitleColor { get; set; }
		public string Text { get; set; }
		public string TextColor { get; set; }


		public override void Process(TagHelperContext context, TagHelperOutput output)
		{

			output.TagName = "div";
			output.Attributes.Add("class", "divContent");
			output.PreContent.SetHtmlContent($"<h2 style= color:{TitleColor}> {Title}</h2>");
			output.PostContent.SetHtmlContent($"<p style= color:{TextColor}> {Text}</p2>");

		}

	}
}

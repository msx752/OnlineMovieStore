using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore
{
    public static class HtmlHelperExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent DrawStars(this IHtmlHelper htmlHelper, OnlineMovieStore.Data.Tables.Rating rating)
        {
            string html = "";
            var star = Math.Round(((rating.AverageRating / 100) / 2) * 10);
            for (int i = 1; i <= 5; i++)
            {
                string IsChecked = "";
                if (star <= i && star != 0)
                {
                    IsChecked = "star-checked";
                }
                html += $"<span class=\"fa fa-star {IsChecked}\"></span>";
            }

            return new HtmlString(html);
        }
    }
}

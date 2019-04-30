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
            var stars = (((rating.AverageRating / 100)*0.5))*10;
            var star = Math.Round(stars,MidpointRounding.AwayFromZero);
            for (int i = 0; i < star; i++)
            {
                html += $"<span class=\"fa fa-star star-checked\"></span>";
            }
            var rslt = 5 - star;
            for (int i = 0; i < rslt; i++)
            {
                html += $"<span class=\"fa fa-star\"></span>";
            }

            return new HtmlString(html);
        }
    }
}

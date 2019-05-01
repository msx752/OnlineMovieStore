using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace OnlineMovieStore
{
    public static class Extensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            if (!user.Identity.IsAuthenticated)
            {
                throw new Exception("user is not authenticated");
            }
            return user.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
        }

    }
    public static class HtmlHelperExtensions
    {
        public static Microsoft.AspNetCore.Html.IHtmlContent DrawStars(this IHtmlHelper htmlHelper, OnlineMovieStore.Data.Tables.Rating rating)
        {
            string html = "";
            var stars = (((rating.AverageRating / 100) * 0.5)) * 10;
            var star = Math.Round(stars, MidpointRounding.AwayFromZero);
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

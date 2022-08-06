using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using System.Collections;
using System.Web;
using Microsoft.Win32;
using System.Diagnostics;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Movies;

namespace GrieeX.GrieeXBase
{
    public partial class Movie : Movies
    {
        public class Search
        {
            private Search()
            {
            }


            public class TMDB
            {
                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches(title);
                }

                private static SearchResultCollection GetMatches(string title)
                {
                    try
                    {
                        SearchResultCollection moviesArrayList = new SearchResultCollection();
                        TMDbClient client = new TMDbClient(GrieeXSettings.TmdbApiKey);
                        SearchContainer<SearchMovie> results = client.SearchMovieAsync(title).Result;

                        foreach (SearchMovie result in results.Results)
                            moviesArrayList.Add(new Movie.Search.SearchResult(result.Id.ToString(), result.Title));

                        return moviesArrayList;
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }


            }


            public class AnimeGenTr
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches("http://www.anime.gen.tr/ara.php?", title);
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        System.Uri url = new System.Uri(urlType + title.Replace("[\\p{Blank}]+", "%20"));

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._POST.Retrieve(url, out responseUri, "&aranacak=", title, false);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("animetanitim.php?");


                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = string.Empty;

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf("id=", movieMatch.Index);
                                endpos = stringData.IndexOf(">", nStartPos);
                                movieId = stringData.Substring(nStartPos + 3, endpos - nStartPos - 4);

                                //title
                                nStartPos = stringData.IndexOf(">", movieMatch.Index);
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                title = stringData.Substring(nStartPos + 1, endpos - nStartPos - 1);

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }
            }

            public class AnimeNfo
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches("http://www.animenfo.com/search.php?query=" + title + "&queryin=anime_titles&option=keywords");
                }

                private static SearchResultCollection GetMatches(string urlType)
                {
                    try
                    {
                        System.Uri url = new System.Uri(urlType);

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("animetitle");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = string.Empty;

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf(",", movieMatch.Index);
                                endpos = stringData.IndexOf(">", nStartPos) + 1;
                                movieId = "animetitle" + stringData.Substring(nStartPos, endpos - nStartPos - 2);

                                //title
                                nStartPos = stringData.IndexOf(".html", movieMatch.Index);
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                title = stringData.Substring(nStartPos + 7, endpos - nStartPos - 7);

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }
            }

            public class BeyazPerde
            {
                private BeyazPerde()
                {
                }

                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches("http://www.beyazperde.com/ara/?q=", title);
                }

                private static string LinkChange(string url)
                {
                    if (string.IsNullOrEmpty(url))
                        return null;

                    url = url.ToLowerInvariant();
                    url = url.Replace("ş", "%FE");
                    url = url.Replace("ğ", "%F0");
                    url = url.Replace("ı", "%FD");
                    url = url.Replace("ü", "%FC");
                    url = url.Replace("ö", "%F6");
                    url = url.Replace("ç", "%E7");

                    return url;
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        title = title.Replace(" ", "%20");
                        title = LinkChange(title);
                        System.Uri url = new System.Uri(urlType + title);

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {

                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("</td><td style=\" vertical-align:top;\" class=\"totalwidth\"><div><div style=\"margin-top:-5px;\">\\n<a href='/filmler/film-");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        int iTempStart = 0;
                        int iTempEnd = 0;
                        iTempStart = stringData.IndexOf("<div class=\"vmargin10b \">");
                        iTempEnd = stringData.IndexOf("</table>", iTempStart + 1);

                        if (iTempEnd != -1)
                        {
                            stringData = stringData.Substring(iTempStart, iTempEnd - iTempStart);
                            movieMatches = moviesRegex.Matches(stringData);

                            if (movieMatches.Count != 0)
                            {
                                string movieId = null;
                                string title = string.Empty;

                                foreach (Match movieMatch in movieMatches)
                                {
                                    int nStartPos = 0;
                                    int endpos = 0;

                                    //id
                                    nStartPos = stringData.IndexOf("film-", movieMatch.Index);
                                    endpos = stringData.IndexOf("/'>", nStartPos);
                                    movieId = stringData.Substring(nStartPos + 5, endpos - nStartPos - 5);

                                    //title
                                    nStartPos = stringData.IndexOf("", movieMatch.Index);
                                    endpos = stringData.IndexOf("<span class=\"fs11\">", nStartPos);
                                    title = Parse.StripHTML(stringData.Substring(nStartPos, endpos - nStartPos)).Trim();

                                    SearchResult result = new SearchResult(movieId, title);
                                    searchResultCollection.Add(result);
                                }
                            }
                        }
                    }
                    return searchResultCollection;

                }
            }

            public class FilmComTr
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches("https://www.film.com.tr/search.cfm?keyword=", title);
                }

                private static string LinkChange(string url)
                {
                    if (string.IsNullOrEmpty(url))
                        return null;

                    url = url.ToLowerInvariant();
                    url = url.Replace("ş", "s");
                    url = url.Replace("ğ", "g");
                    url = url.Replace("ı", "i");
                    url = url.Replace("ü", "u");
                    url = url.Replace("ö", "o");
                    url = url.Replace("ç", "c");

                    return url;
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        title = LinkChange(title);
                        title = title.Replace("[\\p{Blank}]+", "%20");

                        System.Uri url = new System.Uri(urlType + title);


                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("<li><a href=\"/film.cfm?");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = string.Empty;

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf("fid=", movieMatch.Index);
                                endpos = stringData.IndexOf("\"", nStartPos);
                                movieId = stringData.Substring(nStartPos + 4, endpos - nStartPos - 4);

                                //title
                                nStartPos = stringData.IndexOf("turkname", movieMatch.Index);
                                if (nStartPos == -1)
                                {
                                    nStartPos = stringData.IndexOf("orgname1", movieMatch.Index);
                                }
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                title = stringData.Substring(nStartPos + 10, endpos - nStartPos - 10);
                                title = Parse.StripHTML(title);

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }
            }

            public class IMDB
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    //return GetMatches("https://www.imdb.com/find?tt=on;nm=on;mx=20;q=", title);
                    return GetMatches("https://www.imdb.com/find?s=all&q=", title);
                }

                protected static internal SearchResultCollection GetExtendedMatches(string title)
                {
                    return GetMatches("https://www.imdb.com/find?more=tt;q=", title);
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        System.Uri url = new System.Uri(urlType + title.Replace("[\\p{Blank}]+", "%20"));

                        string stringData;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();
                        if (responseUri != null)
                        {
                            //string responseUrl = responseUri.AbsoluteUri;
                            //string ImdbIdSetting = "tt[0-9]{1,15}";
                            //Regex regexImdbId = new Regex(ImdbIdSetting);

                            //Match idMatch = regexImdbId.Match(responseUrl);
                            //if (idMatch.Length > 0)
                            //{
                            //    //id 
                            //    int nStartPos = responseUrl.IndexOf("/tt");
                            //    int endpos;

                            //    string movieId = Convert.ToString(idMatch);

                            //    //title 
                            //    string start = "<title>";
                            //    string end = "</title>";

                            //    nStartPos = stringData.IndexOf(start);
                            //    endpos = stringData.IndexOf(end, nStartPos);
                            //    string movieTitle = stringData.Substring(nStartPos + start.Length, endpos - nStartPos - +start.Length);

                            //    SearchResult result = new SearchResult(movieId, movieTitle);
                            //    moviesArrayList.Add(result);

                            //}

                            //else
                            //{
                            moviesArrayList = GetSearchMatches(stringData);
                            //}
                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetMoviesData(ArrayList moviesRawList)
                {
                    SearchResultCollection imdbArrayList = new SearchResultCollection();

                    SearchResult movie;
                    int truncateLength = 0;
                    int truncateStartLength = 3;
                    Regex regexImdbId = new Regex("tt[0-9]{1,15}");
                    Regex regexImdbTitle = new Regex("/\\D>[\\w\\s,()/>]{1,60}");

                    foreach (string rawData in moviesRawList)
                    {
                        Match idMatch = regexImdbId.Match(rawData);
                        if (idMatch.ToString().Length > 0)
                        {
                            movie = new SearchResult();
                            Match titleMatch = regexImdbTitle.Match(rawData);
                            if (titleMatch.ToString().Length > truncateLength)
                            {
                                movie = new SearchResult();
                                movie.Key = Convert.ToString(idMatch);
                                movie.Title = Convert.ToString(titleMatch);
                                movie.Title = movie.Title.Substring(truncateStartLength, movie.Title.Length - truncateLength - truncateStartLength);
                                imdbArrayList.Add(movie);

                            }
                        }
                    }
                    return imdbArrayList;
                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    string movieId;
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("<td class=\"result_text\"> <a href=\"/title/tt[0-9]{1,15}");

                    //[0-9]{4} 
                    MatchCollection movieMatches;
                    if (stringData.Length > 0)
                    {
                        movieMatches = moviesRegex.Matches(stringData);

                        Regex yearRegex = new Regex("[0-9]{4}");
                        if (movieMatches.Count != 0)
                        {
                            foreach (Match movieMatch in movieMatches)
                            {

                                int nStartPos = stringData.IndexOf("tt", movieMatch.Index);
                                int endpos = stringData.IndexOf("/?ref", nStartPos);

                                movieId = stringData.Substring(nStartPos, endpos - nStartPos);

                                //title 
                                nStartPos = stringData.IndexOf(">", nStartPos);
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                string title = stringData.Substring(nStartPos + 1, endpos - nStartPos - 1);




                                //year 
                                string stringYear = stringData.Substring(endpos, 12);
                                Match yearMatch = yearRegex.Match(stringYear);
                                if (yearMatch != null && yearMatch.Length > 0)
                                {
                                    title += " (" + Convert.ToString(yearMatch) + ")";
                                }

                                if (!string.IsNullOrEmpty(title))
                                {
                                    SearchResult result = new SearchResult(movieId, title);
                                    searchResultCollection.Add(result);
                                }
                            }
                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }

            }

            public class Sinema
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    //return GetMatches("https://www.sinema.com/arama?", title);
                    return GetMatches("https://www.sinema.com/Search.aspx?Search=", title);
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        System.Uri url = new System.Uri(urlType + title.Replace("[\\p{Blank}]+", "%20"));

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        //stringData = HTTPRetriever._POST.Retrieve(url, out responseUri, "&query=", title, false);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    string searchRegex = "<div class=\"carouselItem\">";
                    string movieId = null;
                    SearchResultCollection searchResultCollection = new SearchResultCollection();

                    Regex moviesRegex = new Regex(searchRegex);

                    MatchCollection movieMatches = null;
                    if (stringData.Length > 0)
                    {
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf("https://www.sinema.com/MediaPage.aspx?", movieMatch.Index);
                                endpos = stringData.IndexOf("\"", nStartPos);
                                movieId = stringData.Substring(nStartPos, endpos - nStartPos);
                                //movieId = movieId.Remove(movieId.IndexOf("/"), movieId.Length - movieId.IndexOf("/"));


                                //title
                                nStartPos = stringData.IndexOf("class=\"b\">", movieMatch.Index);
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                string title = stringData.Substring(nStartPos + 12, endpos - nStartPos - 12).Trim();

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }
            }

            public class Sinemalar
            {
                //                function createCookie(name,value,days) {
                //if (days) {
                //var date = new Date();
                //date.setTime(date.getTime()+(days*24*60*60*1000));
                //var expires = '; expires='+date.toGMTString();
                //}
                //else var expires = '';
                //document.cookie = name+'='+value+expires+'; path=/';
                //}
                //function readCookie(name) {
                //var nameEQ = name + '=';
                //var ca = document.cookie.split(';');
                //for(var i=0;i < ca.length;i++) {
                //var c = ca[i];
                //while (c.charAt(0)==' ') c = c.substring(1,c.length);
                //if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
                //}
                //return null;
                //}
                protected static internal SearchResultCollection Run(string title)
                {

                    return GetMatches("https://www.sinemalar.com/ara/?type=all&q=", title);
                }

                private static string LinkChange(string url)
                {
                    if (string.IsNullOrEmpty(url))
                        return null;

                    url = url.ToLowerInvariant();
                    url = url.Replace("ş", "s");
                    url = url.Replace("ğ", "g");
                    url = url.Replace("ı", "i");
                    url = url.Replace("ü", "u");
                    url = url.Replace("ö", "o");
                    url = url.Replace("ç", "c");

                    return url;
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        title = LinkChange(title);

                        System.Uri url = new System.Uri(urlType + title.Replace("[\\p{Blank}]+", "%20"));

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("<div class=\"grid8\">");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;

                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = "";

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf("film/", movieMatch.Index);
                                endpos = stringData.IndexOf("\"", nStartPos);
                                movieId = stringData.Substring(nStartPos + 5, endpos - nStartPos - 5);


                                //title
                                nStartPos = stringData.IndexOf("title=", movieMatch.Index);
                                endpos = stringData.IndexOf("\">", nStartPos);
                                title = stringData.Substring(nStartPos + 7, endpos - nStartPos-7);

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;
                }
            }

            public class SinemaTurk
            {

                protected static internal SearchResultCollection Run(string title)
                {
                    title = title.Replace(", The", "");
                    return GetMatches("http://www.sinematurk.com/arama/?a=", title);
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        //title = LinkChange(title);

                        System.Uri url = new System.Uri(urlType + title);

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            moviesArrayList = GetSearchMatches(stringData);

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {
                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("<h2>");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        int nTemp = 0;
                        stringData = Parse.GetText(stringData, "<ul class=\"InTheatersList\">", "</ul>", 0, ref nTemp);
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = string.Empty;

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;

                                //id
                                nStartPos = stringData.IndexOf("/", movieMatch.Index);
                                endpos = stringData.IndexOf("/\">", nStartPos + 1);
                                movieId = stringData.Substring(nStartPos, endpos - nStartPos);

                                //title
                                nStartPos = stringData.IndexOf("/\">", movieMatch.Index);
                                endpos = stringData.IndexOf("</a>", nStartPos);
                                title = stringData.Substring(nStartPos + 3, endpos - nStartPos - 3).Trim();

                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }

                        }
                        else
                        {
                        }
                    }
                    return searchResultCollection;

                }
            }


            public class TurkceAltyazi
            {
                private TurkceAltyazi()
                {
                }

                protected static internal SearchResultCollection Run(string title)
                {
                    return GetMatches("https://www.turkcealtyazi.org/find.php?cat=sub&find=", title);
                }

                private static string LinkChange(string url)
                {
                    if (string.IsNullOrEmpty(url))
                        return null;

                    url = url.ToLowerInvariant();
                    url = url.Replace("ş", "%FE");
                    url = url.Replace("ğ", "%F0");
                    url = url.Replace("ı", "%FD");
                    url = url.Replace("ü", "%FC");
                    url = url.Replace("ö", "%F6");
                    url = url.Replace("ç", "%E7");

                    return url;
                }

                private static SearchResultCollection GetMatches(string urlType, string title)
                {
                    try
                    {
                        title = title.Replace(" ", "%20");
                        title = LinkChange(title);
                        System.Uri url = new System.Uri(urlType + title);

                        string stringData = null;
                        System.Uri responseUri = null;
                        stringData = HTTPRetriever._GET.Retrieve(url, System.Text.Encoding.UTF8, out responseUri);
                        SearchResultCollection moviesArrayList = new SearchResultCollection();

                        if (responseUri != null)
                        {
                            if (url.AbsoluteUri == responseUri.AbsoluteUri)
                            {
                                moviesArrayList = GetSearchMatches(stringData);
                            }
                            else
                            {
                                Movie m = new Parse.TurkceAltyazi(new SearchResult(responseUri.AbsoluteUri.Replace("https://www.turkcealtyazi.org", ""), ""));
                                moviesArrayList.Add(new SearchResult(responseUri.AbsoluteUri.Replace("https://www.turkcealtyazi.org", ""), m.OtherName));
                            }

                            return moviesArrayList;
                        }
                        else
                        {
                            return null;

                        }
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                        return null;
                    }

                }

                private static SearchResultCollection GetSearchMatches(string stringData)
                {

                    SearchResultCollection searchResultCollection = new SearchResultCollection();
                    Regex moviesRegex = new Regex("<div style=\"float:left;width:108px;padding-left:8px;\">");

                    if (stringData.Length > 0)
                    {
                        MatchCollection movieMatches = null;
                        movieMatches = moviesRegex.Matches(stringData);

                        if (movieMatches.Count != 0)
                        {
                            string movieId = null;
                            string title = string.Empty;

                            foreach (Match movieMatch in movieMatches)
                            {
                                int nStartPos = 0;
                                int endpos = 0;


                                //Id
                                nStartPos = stringData.IndexOf("href=\"", movieMatch.Index);
                                endpos = stringData.IndexOf("title", nStartPos);
                                movieId = stringData.Substring(nStartPos + 6, endpos - nStartPos - 8);

                                //title
                                nStartPos = stringData.IndexOf("title=\"", movieMatch.Index);
                                endpos = stringData.IndexOf("\">", nStartPos);
                                title = Parse.StripHTML(stringData.Substring(nStartPos + 7, endpos - nStartPos - 7)).Trim();


                                SearchResult result = new SearchResult(movieId, title);
                                searchResultCollection.Add(result);
                            }
                        }
                    }
                    return searchResultCollection;

                }
            }



            public class SearchResult
            {
                public virtual string Key
                {
                    get { return _key; }
                    set { _key = value; }
                }

                public virtual string Title
                {
                    get { return _title; }
                    set { _title = HttpUtility.HtmlDecode(value); }
                }

                public virtual string Size
                {
                    get { return _size; }
                    set { _size = value; }
                }

                public virtual string Poster
                {
                    get { return _poster; }
                    set { _poster = value; }
                }


                private string _key;
                private string _title;
                private string _size;
                private string _poster;


                public SearchResult(string key, string title)
                {
                    this.Key = key;
                    this.Title = title;
                }

                public SearchResult(string key, string title, string size)
                {
                    this.Key = key;
                    this.Title = title;
                    this.Size = size;
                }

                public SearchResult(string key, string title, string poster, string size)
                {
                    this.Key = key;
                    this.Title = title;
                    this.Poster = poster;
                }

                public SearchResult()
                {
                }

                public override string ToString()
                {
                    return _title;
                }
            }

            public class SearchResultCollection : CollectionBase
            {
                public SearchResultCollection()
                {
                }

                public int Add(SearchResult item)
                {
                    return List.Add(item);
                }

                public SearchResult GetSearchResultByIdenfier(string key)
                {
                    foreach (SearchResult movie in this)
                    {
                        if (movie.Key == key)
                        {
                            return movie;
                        }
                    }
                    return null;
                }
                public SearchResult Item(int index)
                {
                    return (SearchResult)List[index];
                }
            }

        }

        public class Parse
        {
            private Parse()
            {
            }

            public class Tmdb : Movie
            {
                protected internal Tmdb(Movie.Search.SearchResult searchResult, Boolean bPosterDownload)
                {
                    TMDbClient client = new TMDbClient(GrieeXSettings.TmdbApiKey);
                    var lang = "en";

                    if (Settings.Language == "Turkish")
                        lang = "tr";


                    TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(searchResult.Key, lang, MovieMethods.Credits | MovieMethods.Images | MovieMethods.Undefined).Result;

                    this.ContentProvider = (int)Enums.WebType.TMDB;
                    this.ImdbNumber = movie.ImdbId;
                    this.TmdbNumber = Util.convertToString(movie.Id);
                    this.OrginalName = movie.OriginalTitle;
                    this.OtherName = movie.Title;

                    if (movie.ReleaseDate != null)
                        this.Year = movie.ReleaseDate.Value.Year.ToString();
                    this.UserRating = movie.VoteAverage.ToString();
                    this.Votes = Util.convertToDecimalString(movie.VoteCount);
                    if (Settings.Language == "English")
                        this.EnglishPlot = movie.Overview;
                    else
                       this.OtherPlot = movie.Overview;
                    this.Budget = Util.convertToMoney(movie.Budget.ToString());
                    this.ProductionCompany = String.Join(", ", movie.ProductionCompanies.Select(i => i.Name).ToArray()); ;

                    this.Director = String.Join(", ", movie.Credits.Crew.Where(i => i.Department == "Directing").Select(i => i.Name).ToArray());
                    this.Writer = String.Join(", ", movie.Credits.Crew.Where(i => i.Department == "Writing").Select(i => i.Name).ToArray());
                    this.Genre = GenreReplace(String.Join(", ", movie.Genres.Select(i => i.Name).ToArray()));
                    this.Country = String.Join(", ", movie.ProductionCountries.Select(i => i.Name).ToArray());
                    this.Language = movie.SpokenLanguages.FirstOrDefault().Name;
                    this.RunningTime = movie.Runtime.ToString();
                    this.UserRating = movie.VoteAverage.ToString();
                    this.ReleaseDate = movie.ReleaseDate.Value.ToString("yyyy/MM/dd");


                    this.URL = "https://www.themoviedb.org/movie/" + movie.Id;

                    this.Casts = new List<GrieeXBase.Casts>();
                    foreach (Cast item in movie.Credits.Cast)
                    {
                        if (!String.IsNullOrEmpty(item.ProfilePath))
                            this.Casts.Add(new Casts(item.Name, item.Character, "https://www.themoviedb.org/person/" + item.Id, "https://image.tmdb.org/t/p/w185" + item.ProfilePath, item.Id.ToString(), this.MovieID, 1));
                        else
                            this.Casts.Add(new Casts(item.Name, item.Character, "https://www.themoviedb.org/person/" + item.Id, "", item.Id.ToString(), this.MovieID, 1));

                        if (Settings.ShowCastImage && !String.IsNullOrEmpty(item.ProfilePath))
                        {
                            try
                            {
                                WebClient dl = new WebClient();
                                dl.DownloadFile("https://image.tmdb.org/t/p/w185" + item.ProfilePath, GrieeXSettings.CastPath + item.Id.ToString() + ".jpg");
                                dl.Dispose();
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }


                    if (bPosterDownload)
                    {
                        try
                        {
                            String poster = "https://image.tmdb.org/t/p/w500" + movie.PosterPath;
                            this.Poster = poster;

                            WebClient dl = new WebClient();
                            dl.DownloadFile(poster, GrieeXSettings.PosterPath + this.ImdbNumber + ".jpg");
                            dl.Dispose();
                        }
                        catch (Exception ex)
                        {
                        }
                    }

                }
            }

            public class Imdb : Movie
            {
                protected internal Imdb(Movie.Search.SearchResult searchResult)
                {
                    ImdbRun(searchResult, false);
                }

                protected internal Imdb(Movie.Search.SearchResult searchResult, bool bPosterDownload)
                {
                    ImdbRun(searchResult, bPosterDownload);
                }

                private void ImdbRun(Movie.Search.SearchResult searchResult, bool bPosterDownload)
                {
                    string strHtml;
                    string strStart;
                    string strEnd;
                    string strTemp;
                    int nStartPos = 0;

                    strHtml = HTTPRetriever._GET.Retrieve("https://www.imdb.com/title/" + searchResult.Key + "/");

                    strHtml = Decode(strHtml);

                    this.URL = "https://www.imdb.com/title/" + searchResult.Key;

                    this.ImdbNumber = searchResult.Key;
                    this.ContentProvider = (int)Enums.WebType.IMDB;

                    // Title 
                    strStart = "<title>";
                    strEnd = "</title>";
                    this.OrginalName = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    strTemp = this.OrginalName.Replace("IMDb - ", "");

                    if (this.OrginalName.Contains("("))
                    {
                        strTemp = this.OrginalName.Substring(OrginalName.LastIndexOf("("), OrginalName.Length - OrginalName.LastIndexOf("(")).Trim();
                        this.OrginalName = this.OrginalName.Replace(strTemp, "").Trim();
                    }


                    if (Settings.The == true && this.OrginalName.StartsWith("The "))
                    {
                        this.OrginalName = this.OrginalName.Substring(4, this.OrginalName.Length - 4) + ", The";
                    }

                    this.OrginalName = this.OrginalName.Replace("IMDb - ", "");
                    if (this.OrginalName.Length > 255)
                        this.OrginalName = this.OrginalName.Remove(255);

                    // Year 
                    this.Year = Util.RemoveSpecialCharacters(strTemp);
                    if (this.Year.Length > 4)
                        this.Year = this.Year.Remove(4);

                    // Poster
                    strStart = "ipc-media ipc-media--poster ipc-image-media-ratio--poster ipc-media--baseAlt ipc-media--poster-l";
                    strEnd = "</div>";
                    this.Poster = GetSubText(strHtml, strStart, strEnd, "src=\"", "\"", "", nStartPos, ref nStartPos);

                    if (String.IsNullOrEmpty(this.Poster))
                    {
                        strStart = "class=\"poster\"";
                        strEnd = "</div>";
                        this.Poster = GetSubText(strHtml, strStart, strEnd, "src=\"", "\"", "", nStartPos, ref nStartPos);
                    }

                    if (!String.IsNullOrEmpty(this.Poster))
                    {
                        this.Poster = this.Poster.Substring(0, this.Poster.LastIndexOf("._")) + ".UX500.jpg";
                    }

                    // Genre 
                    strStart = "data-testid=\"genres\">";
                    strEnd = "</div>";
                    this.Genre = GetSubText(strHtml, strStart, strEnd, "role=\"presentation\">", "</span>", ", ", nStartPos, ref nStartPos);
                    this.Genre = GenreReplace(this.Genre);
                    if (this.Genre.Length > 255)
                        this.Genre = this.Genre.Remove(255);

                    // Plot 
                    strStart = "<span role=\"presentation\" data-testid=\"plot-xl\"";
                    strEnd = "</span>";
                    this.EnglishPlot = GetSubText(strHtml, strStart, strEnd, ">", "", "", nStartPos, ref nStartPos);
                    this.EnglishPlot = StripHTML(EnglishPlot);
                    this.EnglishPlot = StripBlanks(EnglishPlot);
                    if (string.IsNullOrEmpty(this.EnglishPlot))
                    {
                        strStart = "itemprop=\"description\">";
                        strEnd = "</p>";
                        this.EnglishPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                        this.EnglishPlot = StripHTML(EnglishPlot);
                        this.EnglishPlot = StripBlanks(EnglishPlot);
                    }



                    // Director 
                    strStart = "<span class=\"ipc-metadata-list-item__label\">Director</span>";
                    strEnd = "</div>";
                    this.Director = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    if (string.IsNullOrEmpty(this.Director))
                    {
                        strStart = "<span class=\"ipc-metadata-list-item__label\">Directors</span>";
                        strEnd = "</div>";
                        this.Director = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    }
                    this.Director = StripArray(Director);
                    this.Director = StripBlanks(Director);
                    if (!string.IsNullOrEmpty(this.Director) && this.Director.Contains("more credit"))
                    {
                        this.Director = this.Director.Remove(this.Director.LastIndexOf(","), this.Director.Length - this.Director.LastIndexOf(","));
                    }
                    if (this.Director.Length > 255)
                        this.Director = this.Director.Remove(255);


                    // Writers 
                    //strStart = "Writers</a>";
                    //strEnd = "<a class=\"ipc-metadata-list-item__icon-link\"";

                    strStart = "<span class=\"ipc-metadata-list-item__label\">Writer</span>";
                    strEnd = "</div>";
                    this.Writer = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    if (string.IsNullOrEmpty(this.Writer))
                    {
                        strStart = "<span class=\"ipc-metadata-list-item__label\">Writers</span>";
                        strEnd = "</div>";
                        this.Writer = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    }
                    this.Writer = StripArray(Writer);
                    this.Writer = StripBlanks(Writer);
                    if (this.Writer.Contains("more credit") && this.Writer.Contains(","))
                    {
                        this.Writer = this.Writer.Remove(this.Writer.LastIndexOf(","), this.Writer.Length - this.Writer.LastIndexOf(","));
                    }
                    if (this.Writer.Length > 255)
                        this.Writer = this.Writer.Remove(255);

                    // Release Date 
                    strStart = "data-testid=\"title-details-releasedate\">";
                    strEnd = "</li>";
                    this.ReleaseDate = GetSubText(strHtml, strStart, strEnd, "releaseinfo?ref_=tt_dt_rdat\">", "</a>", "", nStartPos, ref nStartPos);


                    // Country 
                    strStart = "data-testid=\"title-details-origin\">";
                    strEnd = "</div>";
                    this.Country = GetSubText(strHtml, strStart, strEnd, "tt_dt_cn\">", "</a>", ", ", nStartPos, ref nStartPos);
                    if (this.Country.Length > 255)
                        this.Country = this.Country.Remove(255);


                    // Language 
                    strStart = "data-testid=\"title-details-languages\">";
                    strEnd = "</div>";
                    this.Language = GetSubText(strHtml, strStart, strEnd, "tt_dt_ln\">", "</a>", ", ", nStartPos, ref nStartPos);
                    if (this.Language.Length > 255)
                        this.Language = this.Language.Remove(255);


                    // ********* Production Company ********* //
                    strStart = "data-testid=\"title-details-companies\">";
                    strEnd = "</div>";
                    this.ProductionCompany = GetSubText(strHtml, strStart, strEnd, "<li role=\"presentation\" class=\"ipc-inline-list__item\">", "</li>", ", ", nStartPos, ref nStartPos);
                    if (!String.IsNullOrEmpty(this.ProductionCompany))
                    {
                        this.ProductionCompany = StripHTML(this.ProductionCompany);
                        this.ProductionCompany = StripBlanks(this.ProductionCompany);
                        if (this.ProductionCompany.Contains("See more"))
                        {
                            this.ProductionCompany = this.ProductionCompany.Substring(0, this.ProductionCompany.LastIndexOf("See more")).Trim();
                        }

                    }


                    // ********* Budget ********* //
                    strStart = "data-testid=\"title-boxoffice-budget\">";
                    strEnd = "</div>";
                    this.Budget = GetSubText(strHtml, strStart, strEnd, "<span class=\"ipc-metadata-list-item__list-content-item\">", "</span>", "", nStartPos, ref nStartPos);
                    if (!String.IsNullOrEmpty(this.Budget))
                    {
                        this.Budget = StripHTML(this.Budget);
                        this.Budget = this.Budget.Replace("(estimated)", "");
                        this.Budget = StripBlanks(this.Budget).Replace(",", ".");
                    }


                    // Runtime 
                    strStart = "data-testid=\"title-techspec_runtime\">";
                    strEnd = "</div>";
                    this.RunningTime = GetSubText(strHtml, strStart, strEnd, "<span class=\"ipc-metadata-list-item__list-content-item\">", "</span>", "", nStartPos, ref nStartPos);
                    if (this.RunningTime.Length > 255)
                        this.RunningTime = this.RunningTime.Remove(255);


                    getRating(this.ImdbNumber);
                    getCast(this.ImdbNumber);


                    if (bPosterDownload == true & !String.IsNullOrEmpty(this.Poster))
                    {

                        try
                        {
                            WebClient dl = new WebClient();
                            dl.DownloadFile(this.Poster, GrieeXSettings.PosterPath + searchResult.Key + ".jpg");
                            dl.Dispose();

                        }
                        catch (Exception)
                        {

                        }
                    }
                }

                private static string StripArray(String html)
                {
                    String strReturnValue = "";

                    Regex castRegex = new Regex("<a.*?</a>");
                    MatchCollection castMatches = castRegex.Matches(html);
                    if (castMatches.Count > 0)
                    {
                        foreach (Match matcher in castMatches)
                        {
                            try
                            {
                                if (strReturnValue.Length > 0)
                                {
                                    strReturnValue += ", ";
                                }

                                strReturnValue += StripHTML(matcher.Value);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    return strReturnValue;
                }

                private void getRating(String imdbNumber)
                {
                    string strHtml = HTTPRetriever._GET.Retrieve("https://imdb.com/title/" + imdbNumber + "/ratings");

                    int nStartPos = 0;

                    String strStart = "<span class=\"ipl-rating-star__rating\">";
                    String strEnd = "</span>";
                    this.UserRating = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);

                    if (this.UserRating.Length > 10)
                        this.UserRating = this.UserRating.Remove(10);

                    strStart = "<div class=\"allText\">";
                    strEnd = "IMDb users have given";
                    String strTemp = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    if (!string.IsNullOrEmpty(strTemp))
                        this.Votes = Util.RemoveSpecialCharacters(strTemp);
                }

                private void getCast(String imdbNumber)
                {
                    this.Casts = new List<GrieeXBase.Casts>();

                    string strHtml = HTTPRetriever._GET.Retrieve("https://imdb.com/title/" + imdbNumber + "/fullcredits#cast");

                    String strStart = "<table class=\"cast_list\">";
                    String strEnd = "</table>";
                    int nStartPos = 0;

                    String strCast = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);

                    Regex castRegex = new Regex("<tr class=\"odd\">|<tr class=\"even\">");
                    MatchCollection castMatches = castRegex.Matches(strCast);
                    if (castMatches.Count > 0)
                    {
                        foreach (Match matcher in castMatches)
                        {
                            try
                            {
                                int iStartIndex = matcher.Index;
                                int iStartPos = 0;
                                int iEndPos = 0;

                                iStartPos = strCast.IndexOf("href=\"/name/", iStartIndex);
                                iEndPos = strCast.IndexOf("/?ref", iStartPos);
                                String key = strCast.Substring(iStartPos + 12, iEndPos - iStartPos - 12);

                                iStartPos = strCast.IndexOf("<a href=\"/name/", iStartPos);
                                iEndPos = strCast.IndexOf("</a>", iStartPos);
                                String actor = strCast.Substring(iStartPos, iEndPos - iStartPos + 4);
                                actor = StripHTML(actor);
                                actor = StripBlanks(actor);

                                iStartPos = strCast.IndexOf("<td class=\"character\">", iStartPos);
                                iEndPos = strCast.IndexOf("</td>", iStartPos);
                                String character = strCast.Substring(iStartPos + 22, iEndPos - iStartPos - 22);
                                character = StripHTML(character);
                                character = StripBlanks(character);
                                character = character.Replace("&nbsp;", "");

                                String poster = "";
                                iStartPos = strCast.IndexOf("loadlate=\"", iStartIndex);
                                if (iStartPos != -1 && iStartPos < iEndPos)
                                {
                                    try
                                    {
                                        iEndPos = strCast.IndexOf(".jpg", iStartPos);
                                        poster = strCast.Substring(iStartPos + 10, iEndPos - iStartPos - 6);
                                        poster = poster.Substring(0, poster.LastIndexOf("._")) + "._V1_UX150.jpg";
                                    }
                                    catch
                                    {
                                        poster = "";
                                    }
                                }


                                this.Casts.Add(new Casts(actor, character, "https://www.imdb.com/name/" + key + "/", poster, key, this.MovieID, 1));

                                if (Settings.ShowCastImage && !String.IsNullOrEmpty(poster))
                                {
                                    try
                                    {
                                        WebClient dl = new WebClient();
                                        dl.DownloadFile(poster + ".jpg", GrieeXSettings.CastPath + key + ".jpg");
                                        dl.Dispose();
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }



                    }
                }

                public static string getPoster(string cmd)
                {
                    System.Net.HttpWebRequest req;
                    System.Net.HttpWebResponse res;
                    System.IO.StreamReader sr;
                    string strHtml;

                    req = (HttpWebRequest)System.Net.WebRequest.Create("https://imdb.com/title/" + cmd + "/");

                    res = (HttpWebResponse)req.GetResponse();

                    sr = new StreamReader(res.GetResponseStream(), Encoding.Default);

                    strHtml = sr.ReadToEnd();

                    sr.Close();
                    res.Close();

                    int posterIndex = 0;
                    if (strHtml != null)
                    {
                        posterIndex = strHtml.IndexOf("<td rowspan=\"2\" id=\"img_primary\">");
                    }

                    if (posterIndex > 0)
                    {
                        int displayingIndex = strHtml.IndexOf("src=\"", posterIndex);
                        int results = displayingIndex + "src=\"".Length;
                        int endResults = strHtml.IndexOf("\"", results);

                        return strHtml.Substring(results, endResults - results);
                    }
                    else
                    {

                        return string.Empty;
                    }
                }


            }

            public class BeyazPerde : Movie
            {
                protected internal BeyazPerde(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;


                    strHtml = HTTPRetriever._GET.Retrieve("http://www.beyazperde.com/filmler/film-" + searchResult.Key, System.Text.Encoding.UTF8);

                    this.URL = "http://www.beyazperde.com/filmler/film-" + searchResult.Key + "/";

                    // Türkçe Adı
                    strStart = "<meta property=\"og:title\" content=\"";
                    strEnd = "\" />";
                    this.OtherName = Parse.GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    if (this.OtherName.Length > 255)
                        this.OtherName = this.OtherName.Remove(255);

                    // Türkçe Konu
                    strStart = "itemprop=\"description\">";
                    strEnd = "</div>";
                    this.OtherPlot = Parse.GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    this.OtherPlot = StripBlanks(this.OtherPlot);
                    this.OtherPlot = Parse.StripHTML(this.OtherPlot);
                }
            }

            public class TurkceAltyazi : Movie
            {
                protected internal TurkceAltyazi(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;


                    strHtml = HTTPRetriever._GET.Retrieve("https://www.turkcealtyazi.org" + searchResult.Key, System.Text.Encoding.UTF8);

                    this.URL = "https://www.turkcealtyazi.org" + searchResult.Key;

                    // Türkçe Adı
                    strStart = "<h1><span itemprop=\"name\">";
                    strEnd = "</span>";
                    this.OtherName = Parse.GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    this.OtherName = StripHTML(this.OtherName);
                    if (this.OtherName != null && this.OtherName.Length > 255)
                        this.OtherName = this.OtherName.Remove(255);

                    // Türkçe Konu
                    strStart = "<div class=\"ozet-goster\" itemprop=\"description\">";
                    strEnd = "</div>";
                    this.OtherPlot = Parse.GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    this.OtherPlot = StripBlanks(this.OtherPlot);
                    this.OtherPlot = Parse.StripHTML(this.OtherPlot);
                }
            }

            public class FilmComTr : Movie
            {
                protected internal FilmComTr(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;

                    strHtml = HTTPRetriever._GET.Retrieve("https://www.film.com.tr/film.cfm?fid=" + searchResult.Key);

                    this.URL = "https://www.film.com.tr/film.cfm?fid=" + searchResult.Key;

                    // Türkçe Adı
                    strStart = "<div class=\"title w450\">";
                    strEnd = "</div>";
                    this.OtherName = GetSubText(strHtml, strStart, strEnd, "<h1>", "</h1>", "", nStartPos, ref nStartPos);
                    this.OtherName = StripBlanks(this.OtherName);

                    if (!string.IsNullOrEmpty(this.OtherName) && this.OtherName.Contains("(") == true)
                    {
                        this.OtherName = this.OtherName.Substring(this.OtherName.IndexOf("(") + 1, this.OtherName.Length - this.OtherName.IndexOf("(") - 2);
                    }
                    if (this.OtherName.Length > 255)
                        this.OtherName = this.OtherName.Remove(255);

                    // Türkçe Konu
                    strStart = "synopsis w450";
                    strEnd = "</div>";
                    this.OtherPlot = GetSubText(strHtml, strStart, strEnd, ">", "", "", nStartPos, ref nStartPos);
                    this.OtherPlot = StripBlanks(this.OtherPlot);
                    this.OtherPlot = StripHTML(this.OtherPlot);

                }
            }

            public class Sinema : Movie
            {
                protected internal Sinema(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;

                    strHtml = HTTPRetriever._POST.Retrieve(searchResult.Key, false);

                    this.URL = searchResult.Key;

                    // Türkçe Adı
                    strStart = "<title>";
                    strEnd = "</title>";
                    this.OtherName = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    if (this.OtherName.Length > 255)
                        this.OtherName = this.OtherName.Remove(255);

                    // Türkçe Konu
                    strStart = "<span id=\"ctl00.TopContentPlaceHolder.ctl00.MediaInfoPanel_lblBrif\" style=\"display:none\">";
                    strEnd = "</span>";
                    this.OtherPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.OtherPlot = StripBlanks(this.OtherPlot);
                    this.OtherPlot = StripHTML(this.OtherPlot);
                    this.OtherPlot = Decode(this.OtherPlot);

                }
            }

            public class SinemaTurk : Movie
            {
                protected internal SinemaTurk(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;

                    try
                    {

                        this.URL = "http://www.sinematurk.com" + searchResult.Key;
                        strHtml = HTTPRetriever._GET.Retrieve(this.URL, System.Text.Encoding.UTF8);

                        // Türkçe Adı
                        strStart = "<h1 itemprop=\"name\">";
                        strEnd = "<a href=";
                        this.OtherName = Parse.GetSubText(strHtml, strStart, strEnd, "", "", "", nStartPos, ref nStartPos);
                        this.OtherName = StripBlanks(this.OtherName);
                        if (this.OtherName != null && this.OtherName.Length > 255)
                            this.OtherName = this.OtherName.Remove(255);

                        // Türkçe Konu
                        strStart = "<p itemprop=\"description\">";
                        strEnd = "</p>";
                        this.OtherPlot = Parse.GetSubText(strHtml, strStart, strEnd, "", "", "", nStartPos, ref nStartPos);
                        if (!string.IsNullOrEmpty(this.OtherPlot))
                        {
                            this.OtherPlot = StripHTML(this.OtherPlot);
                            this.OtherPlot = Decode(this.OtherPlot);
                            this.OtherPlot = StripBlanks(this.OtherPlot);
                        }
                        //strPlot = strPlot.Trim
                        //else
                        //{
                        //    strHtml = HTTPRetriever._POST.Retrieve("http://www.sinematurk.com/film.php?action=goToFilmPage&filmid=" + searchResult.Key, true);

                        //    // Türkçe Konu
                        //    strStart = "<span id=\"film-topic-title_konu\">Konu :&nbsp;</span>";
                        //    strEnd = "</div>";
                        //    OtherPlot = GetSubText(strHtml, strStart, strEnd, "", "", "", nStartPos, ref nStartPos);
                        //    OtherPlot = StripHTML(OtherPlot);
                        //    OtherPlot = Decode(OtherPlot);
                        //    OtherPlot = StripBlanks(OtherPlot);
                        //}

                    }
                    catch (Exception)
                    {
                        return;
                    }
                }

                public static string Poster(string cmd)
                {
                    return "http://www.sinematurk.com/images/film/" + cmd + ".jpg";
                }
            }

            public class Sinemalar : Movie
            {
                protected internal Sinemalar(Movie.Search.SearchResult searchResult)
                {
                    string strHtml = null;
                    string strStart = null;
                    string strEnd = null;
                    int nStartPos = 0;


                    strHtml = HTTPRetriever._POST.Retrieve("https://www.sinemalar.com/film/" + searchResult.Key, false);

                    this.URL = "https://www.sinemalar.com/film/" + searchResult.Key;

                    // Türkçe Adı
                    strStart = "<title>";
                    strEnd = "</title>";
                    OtherName = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos).Trim();
                    if (OtherName.Contains("-"))
                        OtherName = OtherName.Substring(0, OtherName.IndexOf("-")).Trim();
                    if (this.OtherName.Length > 255)
                        this.OtherName = this.OtherName.Remove(255);


                    if (this.OtherName.Contains("("))
                    {
                        string strTemp = this.OtherName.Substring(OtherName.LastIndexOf("("), OtherName.Length - OtherName.LastIndexOf("(")).Trim();
                        this.OtherName = this.OtherName.Replace(strTemp, "").Trim();
                    }

                    // Türkçe Konu
                    strStart = "<p itemprop=\"description\" >";
                    strEnd = "</p>";
                    OtherPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    if (String.IsNullOrEmpty(this.OtherPlot))
                    {
                        strStart = "<p itemprop=\"description\"  class=\"text-collapsed\" >";
                        OtherPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    }

                    OtherPlot = StripBlanks(OtherPlot);
                    OtherPlot = StripHTML(OtherPlot);
                    OtherPlot = Decode(OtherPlot);
                    OtherPlot = OtherPlot.Trim();
                }
            }

            public class AnimeGenTr : Movie
            {

                protected internal AnimeGenTr(Movie.Search.SearchResult searchResult, bool bPosterDownload)
                {
                    string strHtml;
                    string strStart;
                    string strEnd;
                    int nStartPos = 0;

                    strHtml = HTTPRetriever._POST.Retrieve("https://www.anime.gen.tr/animetanitim.php?id=" + searchResult.Key, true);

                    strHtml = Decode(strHtml);

                    this.URL = "https://www.anime.gen.tr/animetanitim.php?id=" + searchResult.Key;


                    strStart = "Anime'nin Adı:";
                    strEnd = "</tr>";
                    this.OrginalName = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.OrginalName = StripHTML(this.OrginalName);
                    this.OrginalName = StripBlanks(this.OrginalName);

                    strStart = "Tür:";
                    strEnd = "</tr>";
                    this.Genre = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Genre = StripHTML(this.Genre);
                    this.Genre = StripBlanks(this.Genre);
                    this.Genre = GenreReplace(this.Genre);

                    strStart = "Bölüm Sayısı:";
                    strEnd = "</tr>";
                    this.RunningTime = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.RunningTime = StripHTML(this.RunningTime);
                    this.RunningTime = StripBlanks(this.RunningTime);
                    this.RunningTime = GenreReplace(this.RunningTime);

                    strStart = "Yayım Tarihi:";
                    strEnd = "</tr>";
                    this.Year = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Year = StripHTML(this.Year);
                    this.Year = StripBlanks(this.Year);
                    this.Year = GenreReplace(this.Year);

                    strStart = "Yönetmen:";
                    strEnd = "</tr>";
                    this.Director = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Director = StripHTML(this.Director);
                    this.Director = StripBlanks(this.Director);

                    strStart = "Senaryo:";
                    strEnd = "</tr>";
                    this.Writer = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Writer = StripHTML(this.Writer);
                    this.Writer = StripBlanks(this.Writer);

                    strStart = "Tanıtım:";
                    strEnd = "<b>";
                    this.EnglishPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.EnglishPlot = StripHTML(this.EnglishPlot);
                    this.EnglishPlot = StripBlanks(this.EnglishPlot);



                    if (bPosterDownload == true)
                    {
                        int posterIndex = 0;
                        if (strHtml != null)
                        {
                            posterIndex = strHtml.IndexOf("<table  border=\"0\">");
                        }

                        try
                        {
                            if (posterIndex > 0)
                            {
                                int displayingIndex = strHtml.IndexOf("src=\"", posterIndex);
                                int results = displayingIndex + "src=\"".Length;
                                int endResults = strHtml.IndexOf("\" ", results);
                                string url = "http://www.anime.gen.tr/" + strHtml.Substring(results, endResults - results);

                                WebClient dl = new WebClient();

                                dl.DownloadFile(url, GrieeXSettings.PosterPath + searchResult.Key + ".jpg");
                                dl.Dispose();
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            public class AnimeNfo : Movie
            {
                protected internal AnimeNfo(Movie.Search.SearchResult searchResult, bool bPosterDownload)
                {
                    string strHtml;
                    string strStart;
                    string strEnd;
                    int nStartPos = 0;

                    strHtml = HTTPRetriever._GET.Retrieve("http://www.animenfo.com/" + searchResult.Key);

                    strHtml = Decode(strHtml);

                    this.URL = "http://www.animenfo.com/" + searchResult.Key;

                    // Title 
                    strStart = "Anime : ";
                    strEnd = "</h1>";
                    this.OrginalName = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.OrginalName = StripHTML(this.OrginalName);
                    this.OrginalName = StripBlanks(this.OrginalName);

                    // Genre 
                    strStart = "Genres";
                    strEnd = "</script></td></tr>";
                    this.Genre = GetSubText(strHtml, strStart, strEnd, "</script>", "<script", "", nStartPos, ref nStartPos);
                    this.Genre = StripHTML(this.Genre);
                    this.Genre = StripBlanks(this.Genre);
                    this.Genre = GenreReplace(this.Genre);

                    // Year 
                    strStart = "Year Published";
                    strEnd = "</tr>";
                    this.Year = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Year = StripHTML(this.Year);
                    this.Year = StripBlanks(this.Year);

                    // User Rating 
                    strStart = "User Rating";
                    strEnd = "/10.0";
                    this.UserRating = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.UserRating = StripHTML(this.UserRating);
                    this.UserRating = StripBlanks(this.UserRating);

                    // Votes
                    strStart = "(";
                    strEnd = ")";
                    this.Votes = Util.RemoveSpecialCharacters(GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos));

                    // Plot 
                    strStart = "<!-- google_ad_section_start -->";
                    strEnd = "<!-- google_ad_section_end -->";
                    this.EnglishPlot = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.EnglishPlot = StripHTML(this.EnglishPlot);
                    this.EnglishPlot = StripBlanks(this.EnglishPlot);

                    // Author 
                    strStart = "Author";
                    strEnd = "</tr>";
                    this.Writer = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Writer = StripHTML(this.Writer);
                    this.Writer = StripBlanks(this.Writer);

                    // Director 
                    strStart = "Director";
                    strEnd = "</tr>";
                    this.Director = GetText(strHtml, strStart, strEnd, nStartPos, ref nStartPos);
                    this.Director = StripHTML(this.Director);
                    this.Director = StripBlanks(this.Director);

                    //// Cast 
                    //strStart = "Character";
                    //strEnd = "Explanation";
                    //this.Cast = GetSubText(strHtml, strStart, strEnd, "</td>", "<td class=\"head\">", "@", nStartPos, ref nStartPos);
                    //this.Cast = this.Cast.Replace("\n", ";");
                    //this.Cast = StripHTML(this.Cast);

                    if (bPosterDownload == true)
                    {
                        int posterIndex = 0;
                        if (strHtml != null)
                        {
                            posterIndex = strHtml.IndexOf("<td class=\"anime\" rowspan=\"13\">");
                        }

                        try
                        {
                            if (posterIndex > 0)
                            {
                                int displayingIndex = strHtml.IndexOf("src=\"", posterIndex);
                                int results = displayingIndex + "src=\"".Length;
                                int endResults = strHtml.IndexOf("\" ", results);
                                string url = "http://www.animenfo.com/" + strHtml.Substring(results, endResults - results);

                                WebClient dl = new WebClient();

                                dl.DownloadFile(url, GrieeXSettings.PosterPath + searchResult.Key + ".jpg");
                                dl.Dispose();
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }

                public static string Poster(string cmd)
                {
                    System.Net.HttpWebRequest req;
                    System.Net.HttpWebResponse res;
                    System.IO.StreamReader sr;
                    string strHtml;

                    req = (HttpWebRequest)System.Net.WebRequest.Create("https://imdb.com/title/" + cmd + "/");

                    res = (HttpWebResponse)req.GetResponse();

                    sr = new StreamReader(res.GetResponseStream(), Encoding.Default);

                    strHtml = sr.ReadToEnd();

                    sr.Close();
                    res.Close();

                    int posterIndex = 0;
                    if (strHtml != null)
                    {
                        posterIndex = strHtml.IndexOf("name=\"poster\"");
                    }

                    if (posterIndex > 0)
                    {
                        int displayingIndex = strHtml.IndexOf("src=\"", posterIndex);
                        int results = displayingIndex + "src=\"".Length;
                        int endResults = strHtml.IndexOf("\" ", results);

                        return strHtml.Substring(results, endResults - results);
                    }
                    else
                    {

                        return string.Empty;
                    }
                }
            }





            #region Helpers
            static internal string Decode(string Input)
            {
                if (string.IsNullOrEmpty(Input))
                    return "";

                Input = Input.Replace("&#34;", "\"");
                Input = Input.Replace("&#39;", "`");
                Input = Input.Replace("&#38;", "&");
                Input = Input.Replace("&#60;", "less");
                Input = Input.Replace("&#62;", "greater");

                Input = Input.Replace("&#160;", " ");
                Input = Input.Replace("&#161;", "!");
                Input = Input.Replace("&#164;", "currency");
                Input = Input.Replace("&#162;", "cent");
                Input = Input.Replace("&#163;", "pound");
                Input = Input.Replace("&#165;", "yen");
                Input = Input.Replace("&#166;", "|");
                Input = Input.Replace("&#167;", "section");
                Input = Input.Replace("&#168;", "..");
                Input = Input.Replace("&#169;", "(C)");
                Input = Input.Replace("&#170;", "a");
                Input = Input.Replace("&#171;", "``");

                Input = Input.Replace("&#172;", "not");
                Input = Input.Replace("&#173;", "-");
                Input = Input.Replace("&#174;", "(R)");
                Input = Input.Replace("&#8482;", "TM");
                Input = Input.Replace("&#175;", "-");
                Input = Input.Replace("&#176;", "o");
                Input = Input.Replace("&#177;", "+/-");
                Input = Input.Replace("&#178;", "^2");
                Input = Input.Replace("&#179;", "^3");
                Input = Input.Replace("&#180;", "`");
                Input = Input.Replace("&#181;", "u");
                Input = Input.Replace("&#182;", "P");
                Input = Input.Replace("&#183;", ".");
                Input = Input.Replace("&#184;", ",");
                Input = Input.Replace("&#185;", "^1");
                Input = Input.Replace("&#186;", "o");
                Input = Input.Replace("&#187;", "``");

                Input = Input.Replace("&#188;", "1/4");
                Input = Input.Replace("&#189;", "1/2");
                Input = Input.Replace("&#190;", "3/4");
                Input = Input.Replace("&#191;", "?");
                Input = Input.Replace("&#215;", "x");
                Input = Input.Replace("&#247;", "/");
                Input = Input.Replace("&#192;", "A");
                Input = Input.Replace("&#193;", "A");
                Input = Input.Replace("&#194;", "A");
                Input = Input.Replace("&#195;", "A");
                Input = Input.Replace("&#196;", "A");
                Input = Input.Replace("&#197;", "A");
                Input = Input.Replace("&#198;", "AE");
                Input = Input.Replace("&#199;", "Ç");
                Input = Input.Replace("&#200;", "E");
                Input = Input.Replace("&#201;", "E");
                Input = Input.Replace("&#202;", "E");
                Input = Input.Replace("&#203;", "E");
                Input = Input.Replace("&#204;", "I");
                Input = Input.Replace("&#205;", "I");
                Input = Input.Replace("&#206;", "I");
                Input = Input.Replace("&#207;", "I");
                Input = Input.Replace("&#208;", "D");
                Input = Input.Replace("&#209;", "N");
                Input = Input.Replace("&#210;", "O");
                Input = Input.Replace("&#211;", "O");
                Input = Input.Replace("&#212;", "O");
                Input = Input.Replace("&#213;", "O");
                Input = Input.Replace("&#214;", "Ö");
                Input = Input.Replace("&#216;", "O");
                Input = Input.Replace("&#217;", "U");
                Input = Input.Replace("&#218;", "U");
                Input = Input.Replace("&#219;", "U");
                Input = Input.Replace("&#220;", "Ü");
                Input = Input.Replace("&#221;", "Y");
                Input = Input.Replace("&#222;", "P");
                Input = Input.Replace("&#223;", "ss");
                Input = Input.Replace("&#224;", "a");
                Input = Input.Replace("&#225;", "a");
                Input = Input.Replace("&#226;", "a");
                Input = Input.Replace("&#227;", "a");
                Input = Input.Replace("&#228;", "a");
                Input = Input.Replace("&#229;", "a");
                Input = Input.Replace("&#230;", "ae");
                Input = Input.Replace("&#231;", "ç");
                Input = Input.Replace("&#232;", "e");
                Input = Input.Replace("&#233;", "e");
                Input = Input.Replace("&#234;", "e");
                Input = Input.Replace("&#235;", "e");
                Input = Input.Replace("&#236;", "i");
                Input = Input.Replace("&#237;", "i");
                Input = Input.Replace("&#238;", "i");
                Input = Input.Replace("&#239;", "i");
                Input = Input.Replace("&#240;", "eth");
                Input = Input.Replace("&#241;", "n");
                Input = Input.Replace("&#242;", "o");
                Input = Input.Replace("&#243;", "o");
                Input = Input.Replace("&#244;", "o");
                Input = Input.Replace("&#245;", "o");
                Input = Input.Replace("&#246;", "ö");
                Input = Input.Replace("&#248;", "o");
                Input = Input.Replace("&#249;", "u");
                Input = Input.Replace("&#250;", "u");
                Input = Input.Replace("&#251;", "u");
                Input = Input.Replace("&#252;", "ü");
                Input = Input.Replace("&#253;", "y");
                Input = Input.Replace("&#254;", "p");
                Input = Input.Replace("&#255;", "y");

                Input = Input.Replace("&#338;", "OE");
                Input = Input.Replace("&#339;", "oe");
                Input = Input.Replace("&#352;", "S");
                Input = Input.Replace("&#353;", "s");
                Input = Input.Replace("&#376;", "Y");
                Input = Input.Replace("&#710;", "^");
                Input = Input.Replace("&#732;", "~");
                Input = Input.Replace("&#8194;", " ");
                Input = Input.Replace("&#8195;", " ");
                Input = Input.Replace("&#8201;", " ");
                Input = Input.Replace("&#8204;", "|");
                Input = Input.Replace("&#8205;", "|");
                Input = Input.Replace("&#8206;", "|");
                Input = Input.Replace("&#8207;", "|");
                Input = Input.Replace("&#8211;", "-");
                Input = Input.Replace("&#8212;", "-");
                Input = Input.Replace("&#8216;", "`");
                Input = Input.Replace("&#8217;", "`");
                Input = Input.Replace("&#8218;", "`");
                Input = Input.Replace("&#8220;", "``");
                Input = Input.Replace("&#8221;", "``");
                Input = Input.Replace("&#8222;", "``");
                Input = Input.Replace("&#8224;", "+");
                Input = Input.Replace("&#8225;", "++");
                Input = Input.Replace("&#8230;", "...");
                Input = Input.Replace("&#8240;", "0/00");
                Input = Input.Replace("&#8249;", "(");
                Input = Input.Replace("&#8250;", ")");
                Input = Input.Replace("&#8264;", "euro");
                Input = Input.Replace("&#x27;", "'");
                Input = Input.Replace("&#xB7;", "-");
                Input = Input.Replace("&#xBD;", "½");
                Input = Input.Replace("&#xE8;", "è");
                Input = Input.Replace("&#xE9;", "è");
                Input = Input.Replace("&#xF4;", "ô");
                Input = Input.Replace("&#xE4;", "ä");
                Input = Input.Replace("&#xF9;", "ù");
                Input = Input.Replace("&#xE5;", "å");


                return Input;

            }

            static internal string GetSubText(string strHtml, string strStart, string strEnd, string strStartSubString, string strEndSubString, string delimiter, int nStart, ref int nEnd)
            {
                int nStringStart = 0;
                string strSubItem = null;
                string strSubItems = null;
                string strSubItemsData = null;

                string strReturnValue = null;

                strSubItems = String.Empty;

                strSubItemsData = GetText(strHtml, strStart, strEnd, nStart, ref nStart);

                strSubItem = GetText(strSubItemsData, strStartSubString, strEndSubString, nStringStart, ref nStringStart);
                strSubItems = strSubItem;
                while (strSubItem != string.Empty)
                {
                    strSubItem = GetText(strSubItemsData, strStartSubString, strEndSubString, nStringStart, ref nStringStart);

                    if (strSubItem.Length > 0)
                    {
                        strSubItems += delimiter + strSubItem;
                    }
                }
                strReturnValue = strSubItems;

                nEnd = nStart;
                return strReturnValue;
            }

            static internal string GetText(string strData, string strStartString, string strEndString, int nStartPos, ref int nEndPos)
            {
                int nStart = strData.IndexOf(strStartString, nStartPos);
                if (nStart == -1)
                {
                    nEndPos = nStartPos;
                    return string.Empty;
                }
                nStart += strStartString.Length;

                string strEndSearchString = strEndString;

                int nEnd = 0;
                if (strEndSearchString.Length == 0)
                {
                    nEnd = strData.Length;
                }
                else
                {
                    nEnd = strData.IndexOf(strEndSearchString, nStart);
                }
                if (nEnd == -1)
                {
                    nEndPos = nStartPos;
                    return string.Empty;
                }
                nEnd -= nStart;

                string strResult = strData.Substring(nStart, nEnd);

                nEndPos = nStart + nEnd + strEndString.Length;
                return strResult;
            }

            static internal string StripHTML(string strHtml)
            {
                if (String.IsNullOrEmpty(strHtml))
                    return null;

                return (Regex.Replace(strHtml, "<[^>]*>", ""));
            }

            static internal string StripBlanks(string strText)
            {
                if (String.IsNullOrEmpty(strText))
                    return String.Empty;

                //strText = strText.Replace("\r", "");
                // strText = strText.Replace("\n", "");
                //strText = System.Text.RegularExpressions.Regex.Replace(strText, @"\s+", " ").Trim();
                //strText = strText.Trim();

                return System.Text.RegularExpressions.Regex.Replace(strText, @"\s+", " ").Trim();
            }

            static internal string RemoveBlanks(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    switch (c)
                    {
                        case '\r':
                        case '\n':
                        case '\t':
                        case ' ':
                            continue;
                        default:
                            sb.Append(c);
                            break;
                    }
                }
                return sb.ToString();
            }


            static internal string StripBlanks2(string strText)
            {
                if (String.IsNullOrEmpty(strText))
                    return String.Empty;

                //strText = strText.Replace("\r", "");
                // strText = strText.Replace("\n", "");
                //strText = System.Text.RegularExpressions.Regex.Replace(strText, @"\s+", " ").Trim();
                //strText = strText.Trim();

                return System.Text.RegularExpressions.Regex.Replace(strText, @"\s", " ").Trim();
            }

            static internal string GenreReplace(string strInput)
            {
                if (!string.IsNullOrEmpty(strInput))
                {
                    Section genres = GrieeX.GrieeXBase.Language.Sections.Where(c => c.Name == "Genres").FirstOrDefault();

                    if (genres != null)
                    {
                        foreach (GrieeX.GrieeXBase.Key item in genres.Keys)
                        {
                            strInput = strInput.Replace(item.Name, GrieeX.GrieeXBase.Language.FindKey("Genres", item.Name).Value);
                        }
                    }
                    //GrieeX.GrieeXBase.Section oSection = null;
                    //GrieeX.GrieeXBase.Key oKey = null;
                    //foreach (GrieeX.GrieeXBase.Section oSection_loopVariable in GrieeX.GrieeXBase.Language.Sections)
                    //{
                    //    oSection = oSection_loopVariable;
                    //    if (oSection.Name == "Genres")
                    //    {
                    //        foreach (GrieeX.GrieeXBase.Key oKey_loopVariable in oSection.Keys)
                    //        {
                    //            oKey = oKey_loopVariable;
                    //            strInput = strInput.Replace(oKey.Name, GrieeX.GrieeXBase.Language.FindKey("Genres", oKey.Name).Value);
                    //        }
                    //    }
                    //}
                }

                return strInput;
            }

            //static internal string RemoveDigits(string key)
            //{
            //    return Regex.Replace(key, @"\d", "");
            //}

            //static internal string GetYear(string key)
            //{
            //    return Regex.Match(key, @"\d\d\d\d").ToString();
            //}
            #endregion
        }

        public class SubTitle
        {

            private static string GetDefaultBrowserPath()
            {
                string key = @"htmlfile\shell\open\command";
                RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);

                // get default browser path 
                return ((string)registryKey.GetValue(null, null)).Split('"')[1];
            }

            public static void DivxPlanet(string strName)
            {
                strName = strName.Replace(", The", "");
                BrowserOpen("https://planetdp.org/movie/search?title=" + strName);
            }

            public static void TurkceAltyazi(string strName)
            {
                strName = strName.Replace(", The", "");
                BrowserOpen("https://turkcealtyazi.org/find.php?cat=sub&find=" + strName + "&year=0");
            }


            public static void OpenSubtitles(string strName)
            {
                strName = strName.Replace(", The", "");
                strName = strName.Replace(" ", "+");
                BrowserOpen("https://www.opensubtitles.org/tr/search2/sublanguageid-tur/moviename-" + strName);
            }

            private static void BrowserOpen(string Arguments)
            {
                Process p = new Process();
                p.StartInfo.FileName = GetDefaultBrowserPath();
                p.StartInfo.Arguments = Arguments;
                p.Start();
            }

        }

    }
}

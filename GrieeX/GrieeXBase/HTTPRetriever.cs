using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;


namespace GrieeX.GrieeXBase
{
    class HTTPRetriever
    {
        public class _GET
        {
            private _GET()
            {
            }

            public static string Retrieve(System.String url)
            {
                System.Uri responseUri;
                System.Uri uri = new Uri(url);
                return Retrieve(uri, System.Text.Encoding.UTF8, out responseUri);
            }

            public static string Retrieve(string url, Encoding objEncoding)
            {
                System.Uri responseUri;
                System.Uri uri = new Uri(url);
                return Retrieve(uri, objEncoding, out responseUri);
            }


            public static string Retrieve(System.Uri url, Encoding objEncoding, out System.Uri responseUri)
            {
                Stream objReceiveStream;
                StreamReader objStreamReader;
                //Encoding objEncoding;
                WebResponse objWebResponse;           
                HttpWebRequest objWebRequest;
                string strPage = string.Empty;

              

                responseUri = null;
                try
                {
                    objWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    objWebRequest.AllowAutoRedirect = true;
                    objWebRequest.UseDefaultCredentials = true;
         

                     //objWebRequest.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
       
                    //objEncoding = System.Text.Encoding.UTF8;

                    if (Settings.UseProxy == true)
                    {
                        WebProxy proxy = new WebProxy(Settings.ProxyServer, Settings.ProxyPort);
                        proxy.Credentials = new NetworkCredential(Settings.ProxyUserName, Settings.ProxyPassword);      

                        objWebRequest.Proxy = proxy;
                    }

                    objWebResponse = objWebRequest.GetResponse();
                    responseUri = objWebResponse.ResponseUri;
                    objReceiveStream = objWebResponse.GetResponseStream();
                    objStreamReader = new StreamReader(objReceiveStream, objEncoding);

                    strPage = objStreamReader.ReadToEnd();
                }

                catch (System.Exception ex)
                {
                    //XtraMessageBox.Show(ex.ToString());
                }

                return strPage;
            }
        }

        public class _POST
        {
            private _POST()
            {
            }

            public static string Retrieve(string url, bool bEncodingDefault)
            {
                System.Uri responseUri = null;
                System.Uri uri = new Uri(url);
                return Retrieve(uri, out responseUri, "", "", bEncodingDefault);
            }

            public static string Retrieve(string url, out System.Uri responseUri)
            {
                System.Uri uri = new Uri(url);
                return Retrieve(uri, out responseUri, "", "", true);
            }

            public static string Retrieve(string url, out System.Uri responseUri, string sPostName, string sPostData, bool bEncodingDefault)
            {
                System.Uri uri = new Uri(url);
                return Retrieve(uri, out responseUri, sPostName, sPostData, bEncodingDefault);
            }

            public static string Retrieve(System.Uri url, out System.Uri responseUri, string sPostName, string sPostData, bool bEncodingDefault)
            {
                Stream objReceiveStream;
                StreamReader objStreamReader;
                WebResponse objWebResponse;
                WebRequest objWebRequest;
                string strPage = string.Empty;

                responseUri = null;
                try
                {
                    objWebRequest = WebRequest.Create(url);

                    if (!string.IsNullOrEmpty(sPostData))
                    {
                        StringBuilder data;
                        byte[] byteData;

                        // Set type to POST 
                        objWebRequest.Method = "POST";

                        if (Settings.UseProxy == true)
                        {
                            WebProxy proxy = new WebProxy(Settings.ProxyServer, Settings.ProxyPort);
                            proxy.Credentials = new NetworkCredential(Settings.ProxyUserName, Settings.ProxyPassword);

                            objWebRequest.Proxy = proxy;
                        }


                        objWebRequest.ContentType = "application/x-www-form-urlencoded";

                        data = new StringBuilder();

                        //data.Append(sPostName + HttpUtility.UrlEncode(sPostData)) 
                        data.Append(sPostName + sPostData);

                        // Create a byte array of the data we want to send 
                        byteData = Encoding.Default.GetBytes(data.ToString());

                        // Set the content length in the request headers 
                        objWebRequest.ContentLength = byteData.Length;

                        // Write data 
                        objReceiveStream = objWebRequest.GetRequestStream();
                        objReceiveStream.Write(byteData, 0, byteData.Length);
                    }

                    // Get response 
                    objWebResponse = (HttpWebResponse)objWebRequest.GetResponse();

                    responseUri = objWebResponse.ResponseUri;

                    if (bEncodingDefault == true)
                    {
                        // Get the response stream into a reader 
                        objStreamReader = new StreamReader(objWebResponse.GetResponseStream(), Encoding.Default);
                    }
                    else
                    {
                        objStreamReader = new StreamReader(objWebResponse.GetResponseStream());
                    }

                    strPage = objStreamReader.ReadToEnd();
                }

                catch (System.Exception)
                {
                    //XtraMessageBox.Show(ex.ToString());
                }

                return strPage;
            }
        }
    }
}

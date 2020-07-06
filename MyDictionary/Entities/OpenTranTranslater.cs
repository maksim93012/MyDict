using System.IO;
using System.Net;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace MyDictionary
{
    class OpenTranTranslater : ITranslater
    {
        //http://opentran.net/dict/ru/en-ru/mother.html
        public IItem Translate(string source)
        {
            Item res;
            string text = GetHtml(source);
            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(text);
            IElement element = document.GetElementById("translation");
            INode node = element.FirstChild;
            string res_text = node.TextContent;
            res = new Item(source, res_text);
            return res;
        }

        private string GetHtml(string word)
        {
            HttpWebRequest request;
            WebResponse response=null;
            string res;
            try
            {
                request = WebRequest.CreateHttp(@"http://opentran.net/dict/ru/en-ru/" + word + ".html");
                response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        res = reader.ReadToEnd();
                    }
                }
            }
            finally
            {
                if(response!=null)response.Close();
            }
            return res;
        }
    }
}

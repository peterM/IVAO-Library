using System.Linq;

namespace MalikP.IvaoLibrary.Common.Parsers.DataExtractors.General
{
    public abstract class AbstractGeneralDataValueExtractor : IGeneralDataExtractor
    {
        public AbstractGeneralDataValueExtractor(string selector)
        {
            Selector = selector;
        }

        public string Selector { get; }

        public string ExtractValue(string[] data)
        {
            return ExtractValue(data, Selector);
        }

        protected string ExtractValue(string[] data, string selector)
        {
            var selectedLine = data.FirstOrDefault(d => d.StartsWith(selector));
            if (string.IsNullOrEmpty(selectedLine))
            {
                return "-1";
            }

            return GetValue(selectedLine);
        }

        protected string GetValue(string data)
        {
            return data.Split("=")[1].Trim();
        }
    }
}

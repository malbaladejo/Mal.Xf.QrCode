using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    public interface IScanDetailPageFactory
    {
        Page CreatePage(string code);
    }

    public class CodeBse
    {
        public CodeBse(string code)
        {
            this.Code = code;
        }

        public string Code { get; }
    }

    internal class EmailCode : CodeBse
    {
        public EmailCode(string code) : base(code)
        {
        }
    }

    internal class UrlCode : CodeBse
    {
        public UrlCode(string code) : base(code)
        {
        }
    }

    internal class KeyValueCode : CodeBse
    {
        private static readonly Regex regex = new Regex("([^:]+):([^;]+)");

        public KeyValueCode(string code) : base(code)
        {
            this.Codes = BuildCodes(code);
        }

        private static IReadOnlyDictionary<string, string> BuildCodes(string code)
        {
            var dictionary = new Dictionary<string, string>();
            var groups = code.Split(";".ToCharArray());
            foreach (var group in groups)
            {
                var codes = group.Split(":".ToCharArray());
                dictionary[codes[0]] = codes[1];
            }

            return dictionary;
        }


        public IReadOnlyDictionary<string,string> Codes { get; }
    }
}

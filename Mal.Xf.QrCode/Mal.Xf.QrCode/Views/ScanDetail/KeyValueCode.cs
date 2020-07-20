using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    internal class KeyValueCode : CodeBase
    {
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

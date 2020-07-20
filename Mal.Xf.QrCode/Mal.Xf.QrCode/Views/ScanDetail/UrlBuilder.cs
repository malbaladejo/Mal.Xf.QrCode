using System.Text.RegularExpressions;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    internal class UrlBuilder : ICodeBaseBuilder
    {
        private static readonly Regex regex = new Regex("https?:\\/\\/(www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\\+.~#?&//=]*)");

        public CodeBase Build(string code) => new UrlCode(code);

        public bool CanBuild(string code) => regex.IsMatch(code);
    }
}

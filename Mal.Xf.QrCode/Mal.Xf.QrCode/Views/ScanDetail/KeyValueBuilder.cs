using System.Text.RegularExpressions;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    internal class KeyValueBuilder : ICodeBaseBuilder
    {
        private static readonly Regex regex = new Regex("([^:]+):([^;]+)");

        public CodeBase Build(string code) => new KeyValueCode(code);

        public bool CanBuild(string code) => regex.IsMatch(code);
    }
}

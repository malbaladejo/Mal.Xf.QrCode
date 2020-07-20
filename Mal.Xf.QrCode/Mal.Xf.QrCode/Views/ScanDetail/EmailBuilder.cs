using System.Text.RegularExpressions;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    internal class EmailBuilder : ICodeBaseBuilder
    {
        private static readonly Regex regex = new Regex("[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,}");

        public CodeBase Build(string code) => new EmailCode(code);

        public bool CanBuild(string code) => regex.IsMatch(code);
    }
}

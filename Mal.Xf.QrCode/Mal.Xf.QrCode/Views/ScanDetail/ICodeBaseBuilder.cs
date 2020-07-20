namespace Mal.Xf.QrCode.Views.ScanDetail
{
    public interface ICodeBaseBuilder
    {
        bool CanBuild(string code);
        CodeBase Build(string code);
    }
}

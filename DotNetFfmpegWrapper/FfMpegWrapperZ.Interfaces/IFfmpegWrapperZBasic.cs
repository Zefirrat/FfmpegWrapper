namespace FfMpegWrapperZ.Interfaces
{
    public interface IFfmpegWrapperZBasic
    {
        void Concat(string path1, string path2);
        void Blur(string path);
        void Imposition(string path);
    }
}
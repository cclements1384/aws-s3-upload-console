
namespace AWSS3Uploader.Domain
{
    public interface IS3BucketService
    {
        bool Upload(string keyName, string filePath);
    }
}

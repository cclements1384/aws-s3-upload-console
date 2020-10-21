using Amazon.S3;
using Amazon.S3.Model;
using AWSS3Uploader.Domain;

namespace AWSS3Uploader
{
    public class S3BucketProvider : IS3BucketService

    {
        private readonly string _bucketName;
        /* TODO: pass this in */
        private readonly Amazon.RegionEndpoint _region;
    
        public S3BucketProvider(string bucketName)
        {
            _bucketName = bucketName;
            _region = Amazon.RegionEndpoint.USEast1;
        }


        public bool Upload(string keyName, string filePath)
        {
            var client = new AmazonS3Client(Amazon.RegionEndpoint.USEast1);

            PutObjectRequest putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = keyName,
                FilePath = filePath,
                ContentType = "text/plain"
            };

            PutObjectResponse response = client.PutObject(putRequest);

            return (response.HttpStatusCode.ToString() == "OK");
        }
    }
}

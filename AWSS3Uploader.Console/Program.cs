using System;

namespace AWSS3Uploader.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var bucketName = "jcctestupload";
            var keyName = "TEST.txt";
            var filePath = "C:\\ALPHA\\TEST.txt";

            var s3_bucket = new S3BucketProvider(bucketName);

            try
            {
                if (s3_bucket.Upload(keyName, filePath))
                {
                    System.Console.WriteLine($"{filePath} successfully uploaded to S3 bucket. Press any key to exit.");
                }
                var keypress = System.Console.ReadLine();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Error writing file to S3 bucket: {ex.Message}");
            }

        }
    }
}

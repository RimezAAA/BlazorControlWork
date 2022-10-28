using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace BlazorControlWork.Data
{
    public static class FileSystemService
    {
        static public void UploadImageToDb(string filename, FileStream fs)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            gridFS.UploadFromStream(filename, fs);
        }

        static public void DownloadToLocal()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("sss.jpg", fs);
            }
        }
    }
}

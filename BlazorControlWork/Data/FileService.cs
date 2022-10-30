using MongoDB.Driver;
using MongoDB.Driver.GridFS;
namespace BlazorControlWork.Data
{
    public static class FileService
    {
        static public void UploadImageToDb(string filename, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Files");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(filename, fs);
            }

        }
    }
}

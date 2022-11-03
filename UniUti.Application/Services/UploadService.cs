using System.Text.RegularExpressions;
using UniUti.Domain.Interfaces;
using Azure.Storage.Blobs;

namespace UniUti.Application.Services
{
    public class UploadService : IUploadService
    {
        public async Task<string> UploadBase64Image(string base64Image)
        {
            var fileName = Guid.NewGuid().ToString() + ".jpg";

            var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(base64Image, "");

            byte[] imageBytes = Convert.FromBase64String(data);

            var blobClient = new BlobClient("DefaultEndpointsProtocol=https;AccountName=uniutistorage;AccountKey=q4l/AXR2zFivq9ywEw2DMN1rYEY/OlSWs08UbxaQ19lCHm+x46nZRKpYTFv1GtSV9nFFNdUXSpnJ+AStqrqn2g==;EndpointSuffix=core.windows.net",
                "imagestorage", fileName);

            using (var stream = new MemoryStream(imageBytes))
            {
                await blobClient.UploadAsync(stream);
            }

            return blobClient.Uri.AbsoluteUri;
        }
    }
}

namespace UniUti.Domain.Interfaces
{
    public interface IUploadService
    {
        public Task<string> UploadBase64Image(string base64Imager);
    }
}

using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmuladorAzurite
{
    public class BlobService : IStorageService
    {
        public async Task Execute()
        {
            var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;";

            var client = new BlobContainerClient(connectionString, "images");
            var stream = await new HttpClient().GetStreamAsync("https://www.nopcommerce.com/images/thumbs/0024674_azure-blob-storage.png");

            var blob = client.GetBlobClient("AzureBlobStorage.png");
            await blob.UploadAsync(stream);

            Console.WriteLine($"Image {blob.Name} inserido com sucesso!");

        }
    }
}

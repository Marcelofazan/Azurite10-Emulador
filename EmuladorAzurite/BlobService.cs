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

            var options = new BlobClientOptions(BlobClientOptions.ServiceVersion.V2025_11_05);
            options.Diagnostics.IsLoggingEnabled = false;

            var client = new BlobContainerClient(connectionString, "images", options);

            using var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync("https://www.nopcommerce.com/images/thumbs/0024674_azure-blob-storage.png");

            var blob = client.GetBlobClient("AzureBlobStorage.png");

            await blob.UploadAsync(stream, overwrite: true);
            Console.WriteLine($"Image {blob.Name} inserido com sucesso!");

        }
    }
}

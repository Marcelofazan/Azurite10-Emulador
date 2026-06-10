using Azure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmuladorAzurite
{
    public class TableService : IStorageService
    {
        public Task Execute()
        {
            var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";

            var client = new TableClient(connectionString, "produtos");

            List<TableEntity> entities = [
                new("Roupa", "1") { { "nome", "Camiseta"}, { "preco", 50.65 }, { "quantidade", 15 } },
                new("Roupa", "2") { { "nome", "Short"}, { "preco", 25.60 }, { "quantidade", 5 } }
            ];

            entities.ForEach(async e =>
            {
                await client.AddEntityAsync(e);
                Console.WriteLine($"{e["nome"]} produto adicionado na tabela");
            });

            return Task.CompletedTask;
        }
    }
}

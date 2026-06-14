## ⚙️ Azurite10-Emulador
Exemplo da utilização do Emulador Azurite com Blob, Queue e Table utilizando Azure Storage Explorer em C# .NET 10.

#### Requisitos do Projeto

Faça o Download em :
- [Azure Storage Explorer](https://azure.microsoft.com/en-us/products/storage/storage-explorer)


Após instalação em Variáveis de Ambiente, clique em Editar as variáveis de ambiente do sistema.
Na lista de Variáveis do usuário, procure pela linha chamada Path e dê um duplo clique nela.
Clique no botão Novo do lado direito.

Cole o caminho exato da sua pasta do Azurite, o Visual Studio 2026 encontra-se nesse diretório:
```bash 
C:\Program Files\Microsoft Visual Studio\18\Community\Common7\IDE\Extensions\Microsoft\Azure Storage Emulator
```

Clique com Botão Inverso em **(Emulador Portas Padrão)** e escolha a opção **(Copiar Chave Primária)** 

#### ⚠️ Chave Key de conexão do Emulador

- Altere pela sua Chave Primária nos locais indicados 
```bash
var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=[SUA_CHAVE_PRIMIARIA];BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;";
var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=[SUA_CHAVE_PRIMIARIA];QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;";
var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=[SUA_CHAVE_PRIMIARIA];TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";
```

#### 🔄 Executar a aplicação

Para iniciar o emulador abra o Powershell ou Prompt de Comando como **Administrador** e Digite : **azurite**

- Botão inverso Atualizar em **(Emulador Portas Padrão)**


Crie as 3 opções , utilizando botão inverso em cada uma. 

Conteineres de Blob ->  Botão inverso -> Criar container de Blob , escreva 
```bash 
images
```
Filas de Espera ->  Botão inverso -> Criar Fila, escreva 
```bash 
queue1
```
Tabelas ->  Botão inverso -> Criar Tabela, escreva 
```bash 
produtos
```

Execute o projeto , após execução selecione cada opção e clique em Atualizar para que atualize as informações no Azure Storage Explorer.

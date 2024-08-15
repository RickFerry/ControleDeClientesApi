
### 1. **README.md para a API**

```markdown
# Controle de Clientes API

Este projeto é uma API para o controle de clientes e cobranças. Foi desenvolvida utilizando .NET Core com Entity Framework para a persistência de dados. A API permite criar, ler, atualizar e deletar informações de clientes, bem como gerar e gerenciar cobranças associadas a esses clientes.

## Tecnologias Utilizadas

- .NET Core 6
- Entity Framework Core
- SQL Server
- JWT para autenticação

## Estrutura do Projeto

```
/src
│
├── Controllers
│   ├── ClientesController.cs
│   ├── CobrancasController.cs
│   └── UsuariosController.cs
│
├── Data
│   ├── ApplicationDbContext.cs
│
├── Models
│   ├── Cliente.cs
│   ├── Cobranca.cs
│   └── Usuario.cs
│
├── Services
│   ├── IClienteService.cs
│   ├── ClienteService.cs
│   ├── ICobrancaService.cs
│   └── CobrancaService.cs
│
├── Startup.cs
└── Program.cs
```

## Instalação e Configuração

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/ControleDeClientesApi.git
    ```
2. Navegue até o diretório do projeto:
    ```bash
    cd ControleDeClientesApi
    ```
3. Restaure os pacotes NuGet:
    ```bash
    dotnet restore
    ```
4. Configure a string de conexão no arquivo `appsettings.json`:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=ControleClientesDb;User Id=sa;Password=yourpassword;"
    }
    ```
5. Execute as migrações para criar o banco de dados:
    ```bash
    dotnet ef database update
    ```
6. Inicie a aplicação:
    ```bash
    dotnet run
    ```

## Endpoints

### Autenticação

- **POST /api/usuarios/login**: Realiza login e retorna um token JWT.

### Clientes

- **GET /api/clientes**: Retorna todos os clientes.
- **POST /api/clientes**: Cria um novo cliente.
- **GET /api/clientes/{id}**: Retorna um cliente específico por ID.
- **PUT /api/clientes/{id}**: Atualiza as informações de um cliente existente.
- **DELETE /api/clientes/{id}**: Deleta um cliente.

### Cobranças

- **GET /api/cobrancas**: Retorna todas as cobranças.
- **POST /api/cobrancas**: Cria uma nova cobrança.
- **GET /api/cobrancas/{id}**: Retorna uma cobrança específica por ID.
- **PUT /api/cobrancas/{id}**: Atualiza as informações de uma cobrança existente.
- **DELETE /api/cobrancas/{id}**: Deleta uma cobrança.

## Autenticação

Esta API usa JWT para autenticação. Certifique-se de incluir o token JWT no header `Authorization` para acessar os endpoints protegidos.

## Testes

Você pode testar a API usando ferramentas como Postman ou cURL. Certifique-se de autenticar-se primeiro para obter um token JWT e usá-lo nos requests subsequentes.

## Contribuição

Sinta-se à vontade para abrir issues ou enviar pull requests. Todas as contribuições são bem-vindas!

## Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
```

### 2. **README.md para o Frontend**

```markdown
# Controle de Clientes Frontend

Este é o frontend da aplicação Controle de Clientes, desenvolvido em ReactJS. A aplicação permite gerenciar clientes e cobranças, se autenticar e visualizar os dados conforme necessário.

## Tecnologias Utilizadas

- ReactJS
- React Router
- Axios
- CSS

## Estrutura do Projeto

```
/src
│
├── components
│   ├── Header.js
│   ├── ClienteForm.js
│   ├── ClienteList.js
│   ├── CobrancaForm.js
│   ├── CobrancaList.js
│   └── LoginForm.js
│
├── styles
│   └── styles.css
│
└── App.js
```

## Instalação e Configuração

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/ControleDeClientesFrontend.git
    ```
2. Navegue até o diretório do projeto:
    ```bash
    cd ControleDeClientesFrontend
    ```
3. Instale as dependências:
    ```bash
    npm install
    ```
4. Configure a URL da API no arquivo `App.js`:
    ```javascript
    const API_URL = "http://localhost:5000/api";
    ```

## Rodando a Aplicação

Para rodar a aplicação em modo de desenvolvimento:

```bash
npm start
```

A aplicação estará disponível em `http://localhost:3000`.

## Componentes

### LoginForm

Componente de formulário de login que autentica o usuário na aplicação.

### ClienteForm

Formulário para adicionar ou editar informações de clientes.

### ClienteList

Lista de clientes, mostrando o nome, documento, telefone e endereço.

### CobrancaForm

Formulário para adicionar ou editar cobranças associadas aos clientes.

### CobrancaList

Lista de cobranças, mostrando a descrição, valor, data de vencimento e status de pagamento.

## Estilos (CSS)

Os estilos foram definidos no arquivo `src/styles/styles.css`, aplicando uma aparência consistente e agradável à aplicação.

## Testes

Você pode testar a aplicação acessando `http://localhost:3000` após iniciar o servidor.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
```

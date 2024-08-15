
---

# Controle de Clientes API

O **Controle de Clientes API** é uma aplicação desenvolvida em **Java** com o framework **Spring Boot** para o gerenciamento de informações de clientes. Ele oferece funcionalidades como adicionar, atualizar, listar e excluir clientes. Abaixo estão os detalhes sobre o projeto:

## Funcionalidades

1. **Adicionar um novo cliente**:
   - **Rota**: `POST /clientes`
   - **Corpo da requisição**: JSON contendo os dados do cliente (nome, e-mail, telefone, etc.)
   - **Exemplo**:
     ```json
     {
       "nome": "João Silva",
       "email": "joao@email.com",
       "telefone": "(11) 98765-4321"
     }
     ```

2. **Atualizar informações de um cliente existente**:
   - **Rota**: `PUT /clientes/{id}`
   - **Parâmetro de rota**: `id` (ID do cliente)
   - **Corpo da requisição**: JSON com os dados atualizados
   - **Exemplo**:
     ```json
     {
       "nome": "João da Silva",
       "email": "joao.novo@email.com"
     }
     ```

3. **Listar todos os clientes**:
   - **Rota**: `GET /clientes`
   - **Resposta**: Retorna uma lista de todos os clientes cadastrados

4. **Excluir um cliente**:
   - **Rota**: `DELETE /clientes/{id}`
   - **Parâmetro de rota**: `id` (ID do cliente a ser excluído)

## Tecnologias Utilizadas

- **Linguagem**: Java
- **Framework**: Spring Boot
- **Banco de Dados**: MySQL
- **Documentação da API**: Swagger (acessível em `http://localhost:8080/swagger-ui.html` após iniciar o servidor)

## Como Executar

1. Clone este repositório.
2. Configure as credenciais do banco de dados no arquivo `application.properties`.
3. Execute o projeto usando o comando `./mvnw spring-boot:run`.
4. Acesse a documentação da API conforme mencionado acima.

## Contribuição

Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novas funcionalidades. Abra uma **issue** ou envie um **pull request**!

---

# Sistema de Gestão de Produtos

Um sistema abrangente para gestão de produtos e suas variações, desenvolvido com uma arquitetura em camadas baseada nos princípios do Domain-Driven Design (DDD) e construído utilizando .NET.

## Funcionalidades

- **Gestão de Produtos:** Adicione, atualize e exclua produtos com vários atributos.
- **Gestão de Categorias:** Organize produtos em categorias.
- **Gerenciamento de Variações:** Administre variações de produtos como tamanho, cor e material.
- **Gestão de Preços:** Defina preços base e aplique descontos.

## Tecnologias Utilizadas

- **.NET 7.0**: Framework para o backend.
- **Entity Framework Core**: ORM para gerenciamento do banco de dados.
- **SQL Server**: Banco de dados.
- **Swagger**: Documentação da API.
- **AutoMapper**: Mapeamento de objetos.

## Arquitetura

O sistema é dividido em várias camadas para garantir escalabilidade, manutenibilidade e separação de responsabilidades:

1. **Camada de Domínio**: Contém a lógica de negócios e as entidades principais.
2. **Camada de Aplicação**: Gerencia os casos de uso e a lógica da aplicação.
3. **Camada de Infraestrutura**: Lida com a persistência de dados e integrações externas.
4. **Camada de Apresentação**: Camada de API usando ASP.NET Core.

## Como Começar

### Pré-requisitos

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Instalação

1. **Clone o repositório:**
    ```bash
    git clone https://github.com/GiovaniDamian/ProductManagementSystem.git
    cd ProductManagementSystem
    ```

2. **Configure o banco de dados:**
    - Atualize a string de conexão em `appsettings.json`.
    - Execute as migrações para configurar o esquema do banco de dados:
      ```bash
      dotnet ef database update
      ```

3. **Execute a aplicação:**
    ```bash
    dotnet run
    ```

4. **Acesse a documentação da API:**
    - Navegue até `http://localhost:{porta}/swagger` no seu navegador.

## Uso

- **Endpoints da API**: Use a interface Swagger fornecida para interagir com a API.
- **Interface de Administração**: Versões futuras incluirão uma interface web para administração.

## Contribuindo

1. Faça um fork do repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/{nome_feature}`).
3. Commit suas mudanças (`git commit -m 'Adiciona {nome_feature}'`).
4. Faça push para a branch (`git push origin feature/{nome_feature}`).
5. Abra um Pull Request.

## Licença

Distribuído sob a licença MIT. Veja `LICENSE` para mais informações.

## Contato

Giovani Damian Santos - [LinkedIn](https://www.linkedin.com/in/giovanidamian/) - giovanidamian@gmail.com

Link do projeto: [https://github.com/GiovaniDamian/ProductManagementSystem](https://github.com/GiovaniDamian/ProductManagementSystem)



## Imagens

Swagger:</br>
<img height="360em" src="https://github.com/user-attachments/assets/a8ac6f96-fffe-4f54-9ac3-a01cd68a7749"/></br>

Console:</br>
<img height="160em" src="https://github.com/user-attachments/assets/66c311ed-5070-4e94-99c9-270beac7c908"/>

POSTMAN: </br>
<img height="360em" src="https://github.com/user-attachments/assets/d252dd94-d6d7-4880-bff0-65d7da79489b"/>

# Sistema de Gest�o de Produtos

Um sistema abrangente para gest�o de produtos e suas varia��es, desenvolvido com uma arquitetura em camadas baseada nos princ�pios do Domain-Driven Design (DDD) e constru�do utilizando .NET.

## Funcionalidades

- **Gest�o de Produtos:** Adicione, atualize e exclua produtos com v�rios atributos.
- **Gest�o de Categorias:** Organize produtos em categorias.
- **Gerenciamento de Varia��es:** Administre varia��es de produtos como tamanho, cor e material.
- **Gest�o de Pre�os:** Defina pre�os base e aplique descontos.

## Tecnologias Utilizadas

- **.NET 7.0**: Framework para o backend.
- **Entity Framework Core**: ORM para gerenciamento do banco de dados.
- **SQL Server**: Banco de dados.
- **Swagger**: Documenta��o da API.
- **AutoMapper**: Mapeamento de objetos.

## Arquitetura

O sistema � dividido em v�rias camadas para garantir escalabilidade, manutenibilidade e separa��o de responsabilidades:

1. **Camada de Dom�nio**: Cont�m a l�gica de neg�cios e as entidades principais.
2. **Camada de Aplica��o**: Gerencia os casos de uso e a l�gica da aplica��o.
3. **Camada de Infraestrutura**: Lida com a persist�ncia de dados e integra��es externas.
4. **Camada de Apresenta��o**: Camada de API usando ASP.NET Core.

## Como Come�ar

### Pr�-requisitos

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Instala��o

1. **Clone o reposit�rio:**
    ```bash
    git clone https://github.com/GiovaniDamian/ProductManagementSystem.git
    cd ProductManagementSystem
    ```

2. **Configure o banco de dados:**
    - Atualize a string de conex�o em `appsettings.json`.
    - Execute as migra��es para configurar o esquema do banco de dados:
      ```bash
      dotnet ef database update
      ```

3. **Execute a aplica��o:**
    ```bash
    dotnet run
    ```

4. **Acesse a documenta��o da API:**
    - Navegue at� `http://localhost:{porta}/swagger` no seu navegador.

## Uso

- **Endpoints da API**: Use a interface Swagger fornecida para interagir com a API.
- **Interface de Administra��o**: Vers�es futuras incluir�o uma interface web para administra��o.

## Contribuindo

1. Fa�a um fork do reposit�rio.
2. Crie uma branch para sua feature (`git checkout -b feature/{nome_feature}`).
3. Commit suas mudan�as (`git commit -m 'Adiciona {nome_feature}'`).
4. Fa�a push para a branch (`git push origin feature/{nome_feature}`).
5. Abra um Pull Request.

## Licen�a

Distribu�do sob a licen�a MIT. Veja `LICENSE` para mais informa��es.

## Contato

Giovani Damian Santos - [LinkedIn](https://www.linkedin.com/in/giovanidamian/) - giovanidamian@gmail.com

Link do projeto: [https://github.com/GiovaniDamian/ProductManagementSystem](https://github.com/GiovaniDamian/ProductManagementSystem)



## Imagens

Swagger:</br>
<img height="360em" src="https://github.com/user-attachments/assets/a8ac6f96-fffe-4f54-9ac3-a01cd68a7749"/></br>

Console:</br>
<img height="160em" src="https://github.com/user-attachments/assets/66c311ed-5070-4e94-99c9-270beac7c908"/>
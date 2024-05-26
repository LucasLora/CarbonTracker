# Carbon Tracker

## Descrição

Carbon Tracker é um projeto desenvolvido para a faculdade com o intuito de ajudar as pessoas a se conscientizarem sobre os gastos que acabam prejudicando o meio ambiente, seria a pegada de carbono do usuário comparando com ele próprio e os demais integrantes de grupos que este faz parte. O projeto é totalmente local, não compartilhando dados entre usuários de diferentes computadores, ou seja, os dados não estão em um servidor ao qual o sistema acessa. O projeto foi construído com o pattern Model-View-Presenter com C# e Windows Forms. O banco de dados escolhido foi PostgreSQL, utilizando-se Npgsql para a conexão com o banco de dados.

## Funcionalidades

- **Rastreamento de Pegada de Carbono**: Registre e acompanhe suas atividades que geram emissões de carbono.
- **Comparações de Grupo**: Compare sua pegada de carbono com outros membros do seu grupo.
- **Armazenamento Local**: Todos os dados são armazenados localmente, garantindo a privacidade dos dados.
- **Interface de Usuário Amigável**: Desenvolvido com C# e Windows Forms para uma experiência de usuário intuitiva.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Framework**: Windows Forms
- **Padrão de Arquitetura**: Model-View-Presenter (MVP)
- **Banco de Dados**: PostgreSQL
- **Bibliotecas de Conexão**: Npgsql
  
## Instalação

## Pré-requisitos

- **.NET Framework**: Certifique-se de ter o .NET Framework instalado. Você pode baixá-lo [aqui](https://dotnet.microsoft.com/download/dotnet-framework).
- **PostgreSQL**: Certifique-se de ter o PostgreSQL instalado e em execução em sua máquina. Você pode baixá-lo [aqui](https://www.postgresql.org/download/).

### Passos

1. Clone este repositório para sua máquina local:
    ```bash
    git clone https://github.com/LucasLora/CarbonTracker.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd CarbonTracker
    ```

3. Abra o projeto no seu IDE preferido (por exemplo, Visual Studio).

4. Configure a string de conexão para o banco de dados PostgreSQL no arquivo de configuração.

5. Compile e execute o projeto a partir do seu IDE.

## Uso

1. **Login**: Faça login com as credenciais de administrador, que devem ser criadas no banco de dados, e crie os demais usuários.
2. **Cadastro de Atividades**: Cadastre suas atividades diárias que geram emissões de carbono.
3. **Visualização de Relatórios**: Acesse relatórios para visualizar e comparar sua pegada de carbono ao longo do tempo.
4. **Grupos**: Crie ou participe de grupos para comparar suas emissões com outros usuários.

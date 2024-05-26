# Carbon Tracker

## Descrição

Carbon Tracker é um projeto desenvolvido como parte de uma disciplina universitária com o objetivo de ajudar as pessoas a se conscientizarem sobre seus gastos que impactam negativamente o meio ambiente. Ele calcula a pegada de carbono do usuário, permitindo comparações com os próprios dados do usuário ao longo do tempo e com outros membros de grupos dos quais ele faz parte. O projeto é totalmente local, o que significa que os dados não são compartilhados entre usuários de diferentes computadores e não estão armazenados em um servidor central.

## Funcionalidades

- **Rastreamento de Pegada de Carbono**: Registre e acompanhe suas atividades que geram emissões de carbono.
- **Comparações de Grupo**: Compare sua pegada de carbono com outros membros do seu grupo.
- **Armazenamento Local**: Todos os dados são armazenados localmente, garantindo a privacidade dos dados.
- **Interface de Usuário Amigável**: Desenvolvido com C# e Windows Forms para uma experiência de usuário intuitiva.

## Arquitetura

O projeto foi desenvolvido utilizando o padrão Model-View-Presenter (MVP), que separa claramente a lógica de apresentação, a interface do usuário e a lógica de negócios, facilitando a manutenção e expansão do código.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Framework**: Windows Forms
- **Banco de Dados**: PostgreSQL
- **Conexão com o Banco de Dados**: Npgsql

## Instalação

### Pré-requisitos

- **.NET Framework**: Certifique-se de ter o .NET Framework instalado em seu computador.
- **PostgreSQL**: Instale e configure o PostgreSQL. Crie um banco de dados para o Carbon Tracker com o usuário administrador.

### Passos

1. Clone este repositório para sua máquina local

2. Navegue até o diretório do projeto

3. Configure a string de conexão no arquivo `app.config`:
    ```xml
    <connectionStrings>
        <add name="SqlConnectionString" connectionString="Host=localhost;Username=seuusuario;Password=suasenha;Database=carbontracker"/>
    </connectionStrings>
    ```

4. Abra o projeto no Visual Studio.

5. Restaure as dependências e compile o projeto.

6. Execute o aplicativo a partir do Visual Studio.

## Uso

1. **Login**: Faça login com as credenciais de administrador e crie os demais usuários.
2. **Cadastro de Atividades**: Cadastre suas atividades diárias que geram emissões de carbono.
3. **Visualização de Relatórios**: Acesse relatórios para visualizar e comparar sua pegada de carbono ao longo do tempo.
4. **Grupos**: Crie ou participe de grupos para comparar suas emissões com outros usuários.

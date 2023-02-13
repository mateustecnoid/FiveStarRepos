# FiveStarRepos

## Sobre este projeto
Este projeto foi escrito em C# e tem como objetivo se comunicar com a API do GitHub para obter e armazenar os repositórios com mais estrelas nas linguagens C#, JavaScript, Go, Python e JavaScript.

## Funcionalidades
- Importar novos repositórios
- Obter um repositório armazenado por id
- Obter uma lista paginada de repositórios

## Primeiros passos

### Instação

**Clonando o repositório**
```
$ git clone https://github.com/mateustecnoid/FiveStarRepos.git

$ cd FiveStarRepos
```

**Instalando dependências**

```
cd src\FiveStarRepos.API && dotnet build
```

```
$ dotnet run
```

```
$ cd  ..\FiveStarrepos-App && npm install
```

```
$ npm start
```

## Feito com

### Backend
- [.Net 6](https://learn.microsoft.com/pt-br/dotnet/core/introduction)
- [EF Core 6](https://learn.microsoft.com/pt-br/ef/core/)
- [FluentValidation](https://docs.fluentvalidation.net/en/latest/)
- [Refit](https://github.com/reactiveui/refit)
- [Swagger](https://swagger.io/)
- [xUnit](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test)
- [Moq](https://github.com/moq/moq4)


### Frontend
- [Angular 9](https://angular.io/)
- [Bootstrap 4.5.x](https://getbootstrap.com/docs/4.5/getting-started/introduction/)

## Notas:
- Sempre que o app for iniciado as migrations serão aplicadas automanticamente
- É possivel trocar as linguagens buscadas alterando o parametro "Linguagens" no [launchSettings.json](https://github.com/mateustecnoid/FiveStarRepos/blob/main/src/FiveStarRepos.API/Properties/launchSettings.json)
- A api foi publicada no azure e pode ser acessada através desse link: [clique aqui](https://fivestarrepos-api.azurewebsites.net/swagger/index.html).
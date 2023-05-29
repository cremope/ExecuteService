# Introdução
Repositório que contém a centralização das chamadas dos endpoints, onde qualquer projeto consegue instanciar a classe da API desejada e chamar os métodos passando os parâmetros necessários.
 
# Processo criação de nuget
Essa versão ainda não gera pacote nuget no site https://www.nuget.org/

# Processo de uso do ExecuteService
 1. Clonar o projeto através da [Url](https://github.com/cremope/ExecuteService.git)
 2. Referenciar a dll no projeto consumidor - Recomendado quando o desenvolvimento anda em conjunto com o projeto que está referenciando a dll.

# Tecnologias utilizadas
1. FrameWork Nunit - [Documentação](https://nunit.org/)
2. Biblioteca RestSharp - [Documentação](https://restsharp.dev/)

## Estrutura do projeto
Projeto possui duas pastas, sendo:

- Models -> Representa as models das API's separadas por projeto.
- Services -> Representa as API's separadas por projeto.

**Para incluir novos endpoints, seguir o seguinte fluxo:** 
	
 1. Criar a pasta do projeto - caso já exista - ignorar essa etapa.
 2. Criar a classe da API - caso já exista - ignorar essa etapa.
 3. Inserir novo método de execução do endpoint, utilizando os métodos de parametrização da classe - caso seja uma nova classe - Utiliza a classe ExecuteService.Service.PetStore.Controllers.Pet.cs como exemplo;
 4. Inserir nome no método seguindo o padrão do projeto, sendo:
	 - "MetodoRequisição_nomeDoEndpointQueEstaNoSwagger" - Ex: "Post_Pet";

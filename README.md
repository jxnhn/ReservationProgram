# 🏨 Reservation Program - Test Pyramid

Este projeto foi desenvolvido como parte do curso do professor **Bruno Honorato**, com foco em boas práticas de desenvolvimento de testes automatizados e no conceito da **Pirâmide de Testes**. A aplicação em si é propositalmente simples, servindo como base para exemplificar a cobertura de testes **unitários**, **de integração**, **de aceitação** e **de sistema**.

---

## 🧠 Sobre o Projeto

A aplicação simula um sistema de reservas baseado em três classes principais:

- `Room`: representa uma sala com capacidade máxima de pessoas.
- `Reservation`: representa uma reserva que utiliza uma sala existente.
- `RoomManager`: gerencia as salas disponíveis, funcionando como um banco **in-memory**.

---

## 🧾 Regras de Negócio

1. ❌ Não é possível fazer uma reserva que exceda a capacidade máxima da sala.  
2. ❌ Não é possível reservar uma sala cujo ID não exista.  
3. ❌ Não é possível reservar uma sala que já tenha sido reservada.

---

## 🧪 Testes Automatizados

Todos os testes foram desenvolvidos com **xUnit**, respeitando boas práticas como:

- Isolamento entre os testes  
- Uso de fixtures para criar uma sala válida padrão  
- Clareza e separação de responsabilidades  

---

## ✅ Testes de Aceitação

A camada de aceitação foi desenvolvida com **SpecFlow**, utilizando a sintaxe **Gherkin**, que permite descrever cenários em uma linguagem legível por todas as partes envolvidas no projeto, técnicas ou não.

---

## 📊 Cobertura de Testes

Foi utilizado o **Coverlet** para medir a cobertura dos testes automatizados.

### Como gerar o relatório de cobertura

A partir da raiz do projeto, execute:
```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=json

```
## 🚀 Como Rodar o Projeto

### ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

> Não é necessário instalar o xUnit, SpecFlow ou Coverlet manualmente — todos já estão referenciados nos arquivos de projeto e serão restaurados automaticamente.

---

### 📦 Passo a passo

```bash
1 - Clone o repositório
git clone https://github.com/seu-usuario/seu-repo.git
cd seu-repo

2 - Restaure os pacotes
dotnet restore

3 - Execute os testes
dotnet test
Você também pode executar diretamente pela aba TestExplorer no Visual Studio.

```
### 📊 Gerar Relatório de Cobertura

O projeto já inclui o `coverlet.collector` como dependência, portanto, você pode gerar a cobertura de testes com:

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=json
````
Esse comando cria um diretório TestResults dentro do projeto de testes, contendo arquivos de cobertura em JSON (e possivelmente outros formatos, dependendo da configuração).

Exemplo de saída:

./Reservation.Tests/TestResults/coverage.json

Você pode usar esse arquivo com ferramentas externas para análise visual da cobertura, como o ReportGenerator ou plugins de CI.

🧼 Projeto simples, limpo e direto ao ponto, com foco total na estrutura de testes e boas práticas.

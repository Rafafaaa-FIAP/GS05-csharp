# FutureWorkAPI

Uma API simples em **ASP.NET Core** para gerenciar carreiras emergentes
relacionadas ao futuro do trabalho.

## 🎯 Problema Que a API Resolve

Com as constantes mudanças no mercado de trabalho, é difícil mapear,
organizar e consultar novas carreiras que surgem devido à automação, IA
e transformações digitais.\
A **FutureWorkAPI** ajuda a registrar e consultar informações básicas
sobre carreiras emergentes, funcionando como uma base simples de dados
para estudos, integração com dashboards ou protótipos acadêmicos.

## 🚀 Funcionalidades

-   Criar carreiras
-   Listar carreiras
-   Consultar carreira por ID
-   Atualizar carreira
-   Excluir carreira

## 🛠️ Estrutura da API

A API possui: - Um **CareerController** - Um modelo **Career** com:\
- Id (int)
- Nome (string)
- Descricao (string)

## ▶️ Como Executar

1. Instale o SDK .NET 8+

2. No banco de dados rode o arquivo scripts.sql

3. No terminal, dentro da pasta do projeto, execute:

        dotnet run

4. A API será iniciada em:

        https://localhost:7053

5. o Swagger será iniciado em:

        http://localhost:5197/swagger

## 📦 Tecnologias Utilizadas

-   ASP.NET Core Web API
-   C#
-   SQL Server
-   Swagger

------------------------------------------------------------------------

## 📚 Objetivo Acadêmico

Este projeto foi desenvolvido para fins educacionais, auxiliando na
compreensão de: - Criação de APIs REST - Modelagem simples de domínio -
Estruturação de controllers e endpoints

## 🧑‍💻 Integrantes
* RM553377 - Enzo Rodrigues
* RM553266 - Hugo Santos
* RM553521 - Rafael Cristofali

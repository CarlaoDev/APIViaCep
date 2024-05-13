Neste projeto desenvolvi uma aplicaçao web em C# que permita ao usuário realizar login e gerenciar um CRUD de 
endereços, durante o cadastro do endereço é possivel informar um CEP para aplicação buscar os dados 
do endereço através da integração com a API do ViaCEP.

A tela de autenticação esta setada para funcionar com o user:"adm" e senha"123"
Bem desafiador de fato criar a implementação de autenticaçao de usuario. 

O banco de dados foi feito usando Entity Framework para interação com banco de dados SQL Server. 
Foram usados os seguintes comandos do Migration executados para criação do banco
----------------------------------
Add-Migration Criacao-Inicial -Context Contexto
Update-database -Context Contexto

Foi integrada a API ViaCep e colocado regras padroes de uso do CEP no padrao BR.

É nescessario os seguintes pacotes para ultilização do SQLServer:
------------------------------
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer


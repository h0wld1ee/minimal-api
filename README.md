# Minimal API - Gerenciamento de Veículos

API REST simples desenvolvida com ASP.NET Core Minimal APIs para cadastro e gerenciamento de veículos com autenticação.

## Sobre o Projeto

API com sistema de login e autenticação JWT, contendo dois perfis:
- Administrador (acesso total)
- Editor (apenas cadastro de veículos)

## Tecnologias Utilizadas

- C#
- ASP.NET Core Minimal APIs
- MySQL
- JWT (Autenticação e Autorização)

## Funcionalidades

- Cadastro e Login de administradores
- Geração de Token JWT
- CRUD de Veículos (Listar, Buscar, Cadastrar, Atualizar e Deletar) com restrição por perfil

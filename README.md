# 🍷 CP6 - Catálogo de Vinhos

## 👥 Integrantes

- **Eduardo Fedeli Souza** — RM550132  
- **Gabriel Torres Luiz** — RM98600  
- **Otávio Vitoriano Da Silva** — RM552012  

## 🧠 Tema
O tema escolhido foi um **Catálogo de Vinhos**, que simula uma loja virtual para gerenciamento de produtos.  
A aplicação permite **cadastrar, listar, listar individualmente, editar e remover vinhos**, oferecendo uma base simples para um sistema de e-commerce.

---

## 🧩 O que a API faz
Esta API foi desenvolvida em **ASP.NET Core Web API** e implementa as quatro operações básicas de um CRUD:
- **POST** → Cadastra um novo vinho  
- **GET** → Lista todos os vinhos ou busca um vinho específico por ID  
- **PUT** → Atualiza os dados de um vinho existente  
- **DELETE** → Remove um vinho do catálogo  

Os dados são armazenados **em memória (sem banco de dados)**, tornando a aplicação leve e ideal para testes e aprendizado.

---

## 🚀 Endpoints Disponíveis

| Método | Endpoint | Descrição |
|---------|-----------|------------|
| **GET** | `/api/produto` | Retorna todos os vinhos cadastrados |
| **GET** | `/api/produto/{id}` | Retorna um vinho específico pelo ID |
| **POST** | `/api/produto` | Cadastra um novo vinho |
| **PUT** | `/api/produto/{id}` | Atualiza um vinho existente |
| **DELETE** | `/api/produto/{id}` | Remove um vinho do catálogo |

---

## 🍇 Exemplo de JSON (POST)

```json
{
  "nome": "Cabernet Sauvignon Premium",
  "tipo": "Tinto Seco",
  "nacionalidade": "Argentina",
  "safra": 2021,
  "preco": 149.90,
  "descricao": "Vinho elegante, com notas de cereja e carvalho."
}
```

## 🧰 Tecnologias Utilizadas

- **C#**
- **.NET 8.0**
- **ASP.NET Core Web API**
- **Swagger (documentação automática)**
- **CORS (para permitir requisições externas)**

## 💡 Como Executar o Projeto

- **1️⃣ Clonar o repositório**
  git clone https://github.com/usuario/cp6.git

- **2️⃣ Acessar o diretório**
  cd cp6

- **3️⃣ Executar o projeto**
  dotnet run

- **4️⃣ Acessar no navegador**
  http://localhost:5000/swagger

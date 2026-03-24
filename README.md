# 📚 LibraryDev API

API RESTful para gerenciamento de livros, usuários e avaliações, com suporte a relatórios e integração externa para enriquecimento de dados.

---

## 🚀 Visão Geral

O **LibraryDev** é um projeto backend estruturado com foco em boas práticas de arquitetura, separação de responsabilidades e escalabilidade.

A aplicação permite:

* 📖 Cadastro e gerenciamento de livros
* 👤 Cadastro e gerenciamento de usuários
* ⭐ Registro de avaliações de livros
* 📊 Geração de relatórios
* 🌐 Integração com API externa para dados de livros

---

## 🏗️ Arquitetura

O projeto segue uma arquitetura em camadas inspirada em **Clean Architecture** e conceitos de **DDD (Domain-Driven Design)**.

```
📦 LibraryDev
├── 📁 API (Controllers)
├── 📁 Application (Services, Commands, Queries, Validators)
├── 📁 Domain (Entities, Interfaces)
├── 📁 Infrastructure (Repositories, Banco de Dados)
```

---

## 🧠 Camadas do Projeto

### 🔹 API (Camada de Entrada)

Responsável por expor os endpoints HTTP.

* Recebe requisições
* Encaminha para a camada de Application
* Retorna respostas ao cliente

**Controllers:**

* `LivroController`
* `UsuarioController`
* `AvaliacaoController`
* `RelatorioController`

---

### 🔹 Application (Regras de Negócio)

Camada central da aplicação.

Contém:

* Services (orquestração)
* Commands (operações de escrita)
* Queries (operações de leitura)
* Validators (validações)
* ViewModels (respostas)

---

### 🔹 Domain (Domínio)

Camada mais pura do sistema.

Contém:

* Entidades:

  * `Livro`
  * `Usuario`
  * `Avaliacao`
* Interfaces de repositório (Command e Query)
* Enumerações (ex: gênero de livro)

---

### 🔹 Infrastructure (Infraestrutura)

Implementações concretas de acesso a dados.

Contém:

* Repositórios
* Execução de queries
* Integração com banco de dados

---

## 🔄 Fluxo da Aplicação

```
Request → Controller → Service → Validator → Repository → Database
                                              ↓
                                          Response (ViewModel)
```

---

## 📌 Funcionalidades

### 📚 Livros

* Criar livro
* Atualizar livro
* Buscar livro por ID
* Listar livros
* Integração com API externa

---

### 👤 Usuários

* Criar usuário
* Atualizar usuário
* Buscar usuário
* Listar usuários

---

### ⭐ Avaliações

* Criar avaliação
* Atualizar avaliação
* Buscar avaliações por livro
* Buscar avaliação por ID

---

### 📊 Relatórios

* Relatório de livros lidos
* Consolidação de dados por usuário

---

## 📥 Endpoints (Resumo)

### 📚 Livros

| Método | Endpoint       | Descrição       |
| ------ | -------------- | --------------- |
| POST   | `/livros`      | Criar livro     |
| PUT    | `/livros/{id}` | Atualizar livro |
| GET    | `/livros/{id}` | Buscar por ID   |
| GET    | `/livros`      | Listar          |

---

### 👤 Usuários

| Método | Endpoint         | Descrição         |
| ------ | ---------------- | ----------------- |
| POST   | `/usuarios`      | Criar usuário     |
| PUT    | `/usuarios/{id}` | Atualizar usuário |
| GET    | `/usuarios/{id}` | Buscar por ID     |
| GET    | `/usuarios`      | Listar            |

---

### ⭐ Avaliações

| Método | Endpoint                      | Descrição           |
| ------ | ----------------------------- | ------------------- |
| POST   | `/avaliacoes`                 | Criar avaliação     |
| PUT    | `/avaliacoes/{id}`            | Atualizar avaliação |
| GET    | `/avaliacoes/{id}`            | Buscar por ID       |
| GET    | `/avaliacoes/livro/{livroId}` | Buscar por livro    |

---

### 📊 Relatórios

| Método | Endpoint                   | Descrição            |
| ------ | -------------------------- | -------------------- |
| GET    | `/relatorios/livros-lidos` | Relatório de leitura |

---

## 🧪 Validações

As validações estão centralizadas na camada **Application**, garantindo consistência antes da persistência.

Exemplos:

* Campos obrigatórios
* Formatos válidos
* Regras de negócio específicas

---

## 🌐 Integração Externa

A aplicação possui integração com serviço externo para obtenção de dados de livros.

Possíveis usos:

* Enriquecimento de cadastro
* Busca automática de informações

---

## 🗄️ Banco de Dados

O projeto inclui script SQL para criação das tabelas:

```
create_tables.sql
```

Entidades principais:

* Livros
* Usuários
* Avaliações

---

## ⚙️ Como Executar o Projeto

### 🔧 Pré-requisitos

* .NET (versão compatível com o projeto)
* SQL Server (ou banco configurado)
* IDE (Visual Studio / VS Code)

---

### ▶️ Passos

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/librarydev.git
```

2. Configure a string de conexão no `appsettings.json`

3. Execute o script SQL:

```sql
create_tables.sql
```

4. Execute a aplicação:

```bash
dotnet run
```

5. Acesse:

```
http://localhost:{porta}/swagger
```

---

## 📊 Boas Práticas Aplicadas

* ✅ Separação de responsabilidades
* ✅ Arquitetura em camadas
* ✅ Padrão CQRS (leve)
* ✅ Uso de DTOs (Commands/Queries/ViewModels)
* ✅ Validação centralizada
* ✅ Repositórios desacoplados
* ✅ Integração externa isolada

---

## 📌 Possíveis Evoluções

* Autenticação e autorização (JWT)
* Paginação e filtros avançados
* Cache de consultas
* Testes automatizados
* Logs estruturados
* CI/CD

---

## 👨‍💻 Autor

Desenvolvido por você 🚀

---

## 📄 Licença

Este projeto está sob a licença MIT.

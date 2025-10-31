# 🏨 Projeto-Hotel-WindowsForms

> Um sistema de gerenciamento de hotelaria em C# WinForms com quatro módulos principais: Cadastro de Hóspedes, Reservas (com geração de comprovante em PDF), Gerenciamento de Quartos e Controle de Pagamentos.

**Status do Projeto:** 🚧 Em Desenvolvimento 🚧 
*(ou ✅ Concluído ✅)*

---

## 📖 Sobre o Projeto

Este é um sistema desktop (Windows Forms) para gerenciamento hoteleiro. O objetivo é fornecer uma solução completa e intuitiva para administrar as operações diárias de um hotel, desde o primeiro contato com o hóspede até o fechamento de sua conta.

---

## 🚀 Funcionalidades Principais

O sistema é dividido em quatro módulos centrais:

### 1. 👥 Cadastro de Hóspedes
* Registro completo de informações pessoais dos hóspedes (Nome, CPF, Telefone, Endereço, etc.).
* Busca rápida, edição e exclusão de perfis de hóspedes.
* Histórico de hospedagens anteriores.

### 2. 📅 Reservas
* Criação de novas reservas com seleção de datas (Check-in e Check-out).
* Associação da reserva a um hóspede cadastrado e a um quarto disponível.
* **Geração de comprovante de reserva em formato PDF** para envio ao cliente.

### 3. 🛌 Gerenciamento de Quartos
* Painel visual (dashboard) com o status de todos os quartos.
* Alteração de status do quarto:
    * **🟢 Disponível**
    * **🔴 Ocupado**
    * **🟡 Em Manutenção/Limpeza**
* Cadastro de tipos de quartos (Standard, Deluxe, Suíte) e seus respectivos valores de diária.

### 4. 💳 Controle de Pagamentos
* Registro de pagamentos (parciais ou totais) associados a uma reserva.
* Lançamento de consumos extras (frigobar, restaurante) na conta do hóspede.
* Geração de recibos e fechamento de conta no momento do Check-out.

---

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído utilizando as seguintes tecnologias:

* **Linguagem:** C#
* **Plataforma:** .NET Framework (ou .NET 6+)
* **Interface:** Windows Forms (WinForms)
* **Banco de Dados:** [SQL Server / SQLite / MySQL - *Adicione o banco que você usou*]
* **Geração de PDF:** [iTextSharp / QuestPDF / etc. - *Adicione a biblioteca que você usou*]
* **IDE:** Visual Studio 2022

---

## 🏁 Como Rodar o Projeto

Siga os passos abaixo para executar o projeto em sua máquina local.

**Pré-requisitos:**
* Visual Studio 2019 ou mais recente
* SDK do .NET [versão que você usou]
* [Seu Banco de Dados] (Ex: SQL Server Management Studio)

**Instalação:**

1.  Clone o repositório:
    ```bash
    git clone [https://github.com/seu-usuario/Projeto-Hotel-WindowsForms.git](https://github.com/seu-usuario/Projeto-Hotel-WindowsForms.git)
    ```
2.  Abra o arquivo de solução (`.sln`) no Visual Studio.
3.  Configure a *connection string* (string de conexão) com o seu banco de dados no arquivo `App.config` (ou onde ela estiver).
4.  *Opcional: Se necessário, rode o script SQL (`database.sql`) para criar as tabelas do banco de dados.*
5.  Pressione `F5` ou clique no botão "Start" para compilar e executar o projeto.

---

## 📸 Screenshots

*(É altamente recomendado adicionar screenshots do seu sistema aqui para demonstrar o visual!)*

**Exemplo:**

| Tela de Login | Painel Principal |
| :---: | :---: |
| [Imagem da Tela de Login] | [Imagem do Painel Principal] |

| Cadastro de Hóspedes | Geração de PDF |
| :---: | :---: |
| [Imagem do Cadastro] | [Imagem do PDF] |


---

## 👨‍💻 Autor

**[Seu Nome Completo]**

* [Link do seu LinkedIn]
* [Link do seu GitHub]

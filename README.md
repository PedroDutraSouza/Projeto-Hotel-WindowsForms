# 🏨 Projeto-Hotel-WindowsForms

> Um sistema de gerenciamento de hotelaria em C# WinForms com quatro módulos principais: Cadastro de Hóspedes, Reservas (com geração de comprovante em PDF), Gerenciamento de Quartos e Controle de Pagamentos.

**Status do Projeto:** 🚧 Em Desenvolvimento 🚧 


---

## 📖 Sobre o Projeto

Este é um sistema desktop (Windows Forms) para gerenciamento hoteleiro. O objetivo é fornecer uma solução completa e intuitiva para administrar as operações diárias de um hotel, desde o primeiro contato com o hóspede até o fechamento de sua conta.

---

## 🚀 Funcionalidades Principais

O sistema é dividido em quatro módulos centrais:

### 1. 👥 Cadastro de Hóspedes
* Registro completo de informações pessoais dos hóspedes (Nome, CPF, Telefone, etc.).
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
* **Banco de Dados:** [*MySQL*]
* **Geração de PDF:** [*QuestPDF*]
* **IDE:** Visual Studio 2022

---

## 🏁 Como Rodar o Projeto

Siga os passos abaixo para executar o projeto em sua máquina local.

**Pré-requisitos:**
* Visual Studio 2022 ou mais recente
* SDK do .NET [4.8]
* [XAMPP] (Ex: SQL Server Management Studio)

**Instalação:**

1.  Inicie o **XAMPP Control Panel** e dê "Start" nos módulos **Apache** e **MySQL**.
2.  Acesse `http://localhost/phpmyadmin` no seu navegador e crie um novo banco de dados (`caribe_pallace`).
3.  *Copie o script SQL:* Abra o arquivo (`SQL.txt`) para dentro do banco `db_hotel` criado.
4.  Clone o repositório:
    ```bash
    git clone [https://github.com/seu-usuario/Projeto-Hotel-WindowsForms.git](https://github.com/seu-usuario/Projeto-Hotel-WindowsForms.git)
    ```
5.  Abra o arquivo de solução (`.sln`) no Visual Studio.
6.  Configure a *connection string* (string de conexão) com o seu banco de dados MySQL no arquivo `App.config` (ou onde ela estiver).
    * *Exemplo de connection string para MySQL:*
        ```xml
        <add name="SuaConnectionString" connectionString="Server=localhost;Database=db_hotel;Uid=root;Pwd=;" />
        ```
7.  Pressione `F5` ou clique no botão "Start" para compilar e executar o projeto.

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

## 👨‍💻 Autores

**[Pedro Dutra Paes Penteado Dâmaso de Souza]**
* [https://www.linkedin.com/in/pedro-dutra-a43170341/]
* [https://github.com/PedroDutraSouza?tab=repositories]

**[João Pedro Malta Caldeira]**
* [https://www.linkedin.com/in/joao-pedro-malta-caldeira-19a032329/]
* [Link do seu GitHub]

**[Thiago Henrique Salustiano Couto]**
* [https://www.linkedin.com/in/thiago-couto-8804b92a3/]
* [Link do seu GitHub]

**[Tarciene dos Santos Ferreira Borges]**
* [https://www.linkedin.com/in/tarciene-borges-santos/]
* [Link do seu GitHub]

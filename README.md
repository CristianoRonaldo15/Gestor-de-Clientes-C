# 👥 Projeto: Sistema de Gerenciamento de Clientes em C#

## 📌 Descrição
Este projeto é um **sistema de gerenciamento de clientes** desenvolvido em **C#**, utilizando uma aplicação de console.  
Com ele, é possível **adicionar, listar e remover clientes**, armazenando os dados em um arquivo local para persistência.  

O sistema foi desenvolvido com foco em **praticar conceitos de Programação Orientada a Objetos (POO)**, estruturas de dados, manipulação de arquivos e serialização em C#.

---

## ⚙️ Especificações Técnicas
- Aplicação em **C# (.NET)** baseada em console;  
- Utilização de **Structs** para representar clientes;  
- Persistência de dados em arquivo binário (`Clientes.dat`);  
- Menu interativo com opções para o usuário:  
  - Adicionar clientes  
  - Listar clientes cadastrados  
  - Remover clientes pelo ID  
  - Encerrar aplicação  

---

## 🛠️ Tecnologias Utilizadas
- **Linguagem:** C#  
- **Framework:** .NET 6.0 ou superior  
- **IDE:** Visual Studio / Visual Studio Code  
- **Recursos adicionais:**  
  - `List<T>` para armazenamento em memória  
  - `FileStream` e `BinaryFormatter` para persistência de dados  

---

## 📚 O que Aprendi
Durante o desenvolvimento deste sistema, pude reforçar conceitos essenciais de C# e de boas práticas no desenvolvimento de software:

- **Estruturas de Dados:** uso de `List<Cliente>` para gerenciar a coleção de clientes;  
- **Serialização Binária:** gravação e leitura de dados em arquivo local para persistência;  
- **Enumerações:** criação de `enum Menu` para organizar as opções do sistema;  
- **Tratamento de Erros:** implementação de verificações para entradas inválidas;  
- **Interação com o Usuário:** leitura de dados via `Console.ReadLine()` e exibição com `Console.WriteLine()`.  

---

## ▶️ Como Executar o Projeto
1. Clone este repositório:  
   ```bash
   git clone https://github.com/seuusuario/gestor-clientes.git
2. Abra o projeto no Visual Studio ou VS Code;

3. Compile e execute a aplicação;

4. Utilize o menu para adicionar, listar e remover clientes.

🚀 Próximos Passos (Possíveis Melhorias)

. Implementar busca de clientes por nome ou CPF;

. Adicionar validações mais robustas para entradas do usuário;

. Criar interface gráfica com Windows Forms ou WPF;

. Migrar para persistência com banco de dados (ex.: SQLite ou SQL Server);

. Implementar testes unitários.

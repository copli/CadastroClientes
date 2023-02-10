// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using CadastroClientes.Classes;

// Método construtor
PessoaFisica novaPf = new PessoaFisica();
novaPf.nome = "Adriano";
novaPf.cpf = 01234567890;
novaPf.dataNasc = new DateTime(2001, 01, 01);
novaPf.endereco = "Rua Niteroi, 1532";
novaPf.rendimento = 12000.00f;

Console.WriteLine(novaPf.nome);
Console.WriteLine(novaPf.cpf);
Console.WriteLine(novaPf.dataNasc);
Console.WriteLine(novaPf.endereco);
Console.WriteLine(novaPf.rendimento);

// Concatenação
Console.WriteLine("Nome do Cliente: " + novaPf.nome);

// Interpolação
Console.WriteLine($"Nome do Cliente: {novaPf.nome} - CPF: {novaPf.cpf}");
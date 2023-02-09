﻿//fazendo uso da classes
using Projetoc_.Classes;

//metodo construtor
Pessoafisica novaPessoafisica = new Pessoafisica();


//Atribuição de valores

novaPessoafisica.nome = "Thiago";
novaPessoafisica.cpf = 494745638;
novaPessoafisica.dataNac = new DateTime(192,01,01);
novaPessoafisica.endereco = "Rua dos bamdeirantes n-07";
novaPessoafisica.rendimento = 120000.00f; // para força ele a converter para float


//imprimindo
Console.WriteLine(novaPessoafisica.nome);
Console.WriteLine(novaPessoafisica.cpf);
Console.WriteLine(novaPessoafisica.dataNac);
Console.WriteLine(novaPessoafisica.endereco);
Console.WriteLine(novaPessoafisica.rendimento);



//concatenação
Console.WriteLine("NOME: " + novaPessoafisica.nome);
Console.WriteLine("CPF: " + novaPessoafisica.cpf);
Console.WriteLine("DATA NACIMENTO: " + novaPessoafisica.dataNac);
Console.WriteLine("ENDEREÇO: " + novaPessoafisica.endereco);
Console.WriteLine("RENDIMENTO: " + novaPessoafisica.rendimento);


//interpolação
Console.WriteLine($"NOME: {novaPessoafisica.nome}");
Console.WriteLine($"CPF: {novaPessoafisica.cpf}");
Console.WriteLine($"DATA NACIMENTO: {novaPessoafisica.dataNac}");
Console.WriteLine($"ENDEREÇO: {novaPessoafisica.endereco}");
Console.WriteLine($"RENDIMENTO: {novaPessoafisica.rendimento}");
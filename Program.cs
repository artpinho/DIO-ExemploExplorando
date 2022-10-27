using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("AL", "Alagoas");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]);





/*foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("--------------");
estados.Remove("MG");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "AL";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adcionar a chave: {chave}");
}*/










/*Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo da pilha o elemento {pilha.Pop()}");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}*/
























/*ueue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}*/















//new ExemploExcecao().Metodo1();
























/*try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Ocorreu uma erro na leitura do arquivo. Caminho não encontrado." + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
Console.WriteLine("Chegou até aqui");
}*/












/*string dataString = "2022-04-1700 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                                        "yyyy-MM-dd HH:mm",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
Console.WriteLine($"{dataString} não é uma data válida");
}*/
















/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonteario = 1582.40M;

Console.WriteLine(valorMonteario.ToString("N2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));*/







/*string numero1 = "10";
string numero2 = "20";

string resultado = (numero1 + numero2);
Console.WriteLine(resultado);*/






/*Pessoa p1 = new Pessoa(nome: "Artenir", sobrenome: "Pinho");
Pessoa p2 = new Pessoa(nome: "Gildo", sobrenome: "Paixão");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/





// Pessoa p1 = new Pessoa();
// p1.Nome = "Artenir";
// p1.Sobrenome = "Pinho";
// p1.Idade = 33;
// p1.Apresentar();
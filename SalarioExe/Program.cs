using SalarioExe;
int id = 0;
List<Funcionario> funcionarios = new List<Funcionario>();

for (int x = 0; x<3; x++) { 
Console.WriteLine("Digite nome do funcionário ");
string nome = Console.ReadLine();

Console.WriteLine("Digite Salario do funcionário ");
double salario = double.Parse(Console.ReadLine());
    funcionarios.Add(new Funcionario
    {
        Id = id,
        Nome = nome,
        Salario = salario
    });
    id++;
}
Console.WriteLine(funcionarios[0].Nome);
funcionarios.RemoveRange(1,1);
Console.WriteLine(funcionarios[1].Nome);



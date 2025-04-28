using SalarioExe;

void matriz() { 

    int[,] mat = new int[3, 3];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("Digite o valor da matriz");
            mat[i, j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Matriz: indice par");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if ((i / 2 == 0) && (j / 2 == 0)) {
                Console.Write(mat[i, j] + " indice par");
            }
            
        }
        Console.WriteLine();
    }
    Console.WriteLine("Matriz: valores par");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if ((mat[i,j] / 2 == 0))
            {
                Console.Write(mat[i, j] + " indice par");
            }

        }
        Console.WriteLine();
    }


}


void salario() {

    int id = 0;
    List<Funcionario> funcionarios = new List<Funcionario>();

    for (int x = 0; x < 3; x++)
    {
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
    funcionarios.RemoveRange(1, 1);
    Console.WriteLine(funcionarios[1].Nome);
}

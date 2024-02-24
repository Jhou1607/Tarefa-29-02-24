float[] salario = new float[5];
float verify = 1000;
float armz = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o salario " + (i+1) + ": ");
    if (!float.TryParse(Console.ReadLine(), out armz))
    {
        Console.WriteLine("Informe um salário válido");
        Environment.Exit(0);
    }
   
    salario[i] = (float)(armz < verify ? armz * 1.1 : armz);
    
}

Console.WriteLine("\n\n========Salários========\n");


for (int j = 0; j < 5; j++)
{
    Console.WriteLine("         R$ " + salario[j].ToString("0.00"));
}
Console.ReadLine();
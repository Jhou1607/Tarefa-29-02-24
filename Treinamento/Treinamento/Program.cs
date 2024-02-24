double[] salario = new double[10];
float maior = 0;
for (int i = 0; i < 10; i++)
{
     for (int j = 0; j < 10; j++)
     {
      Console.WriteLine("Digite o salario " + (j + 1) + "");
      salario[i] = double.Parse(Console.ReadLine());    

          if (salario[i] > maior)
          {
                maior = (int)salario[i];
           }
            
      }Console.WriteLine("O maior salário é: " + maior);
    break;
}
float[] valores = new float[10];
float aux = 0;

   for (int i = 0; i < 10; i++)
   {
    Console.Write("Insira o valor " + (i+1) + ": ");
    valores[i] = float.Parse(Console.ReadLine());
    aux = aux + valores[i];
   }
aux = aux / 10;
Console.WriteLine("A média dos valores ℝ é:" + (aux) +"");

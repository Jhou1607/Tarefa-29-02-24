﻿float[,] vet = new float[2,5];

for (int i = 0; i<2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("\nDigite o valor " + (j+1) + " do vetor " + (i+1)+": ");
        if (!float.TryParse(Console.ReadLine(), out vet[i, j]))
        {
            Console.WriteLine("\nDigite um valor válido!");
            Environment.Exit(1);
        }


    }
}

imprimir(somaVetor(vet),"Soma dos vetores");
imprimir(multiplicacaoVetor(vet),"Multiplicação dos vetores");
imprimir(divideVetor(vet),"Divisão dos vetores");
imprimir(diferencaVetor(vet),"Diferença dos vetores");
Console.ReadLine();

float[] somaVetor(float[,] vetor)
{
    float[] aux = new float[5];
    for (int j = 0; j < 5; j++)
    {    
        aux[j] = vetor[0,j] + vetor[1,j];

    }
    return aux;

}

float[] multiplicacaoVetor(float[,] vetor)
{
    float[] aux = new float[5];
    for (int j = 0; j < 5; j++)
    {
        aux[j] = vetor[0, j] * vetor[1, j];

    }
    return aux;

}

float[] divideVetor(float[,] vetor)
{
    float[] aux = new float[5];
    for (int j = 0; j < 5; j++)
    {
        aux[j] = vetor[0, j] / vetor[1, j];

    }
    return aux;
}

float[] diferencaVetor(float[,] vetor)
{
    float[] aux = new float[5];
    for (int j = 0; j < 5; j++)
    {
        aux[j] = vetor[0, j] - vetor[1, j];

    }
    return aux;
}

void imprimir(float[] auxiliar, string titulo)
{
    Console.WriteLine("\n\n"+titulo+"\n");
    for (int j = 0;j < 5; j++)
    {
        Console.WriteLine("Resultado["+(j+1)+"] = "+auxiliar[j].ToString("0.00"));
    }

}
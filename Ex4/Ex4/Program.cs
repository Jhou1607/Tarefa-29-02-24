int vetores;

Console.WriteLine("Digite o número de alunos: ");
vetores = int.Parse(Console.ReadLine());


float[] G1 = new float[vetores];
float[] G2 = new float[vetores];
float[] G3 = new float[vetores];

for (int i = 0;  i < vetores; i++)
    {
    Console.WriteLine("Digite a nota 1 do aluno: " + (i + 1) + "");
    G1[i] = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota 2 do aluno: " + (i + 1) + "");
    G2[i] = float.Parse(Console.ReadLine());
    G3[i] = (G2[i] + G1[i])/2;
    }
for (int i = 0; i < vetores; i++)
    {
    Console.WriteLine("As notas do aluno " + (i + 1) + ", G1, G2 e a média são, respectivamente = " + G1[i] + ", " + G2[i] + ", " + G3[i] +"");

}

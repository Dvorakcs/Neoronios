using Neuronios;

sinapse[] sinapses = new sinapse[]
{
    new sinapse { value = 1, peso = 0.2 },
    new sinapse { value = 0, peso = -0.1 },
    new sinapse { value = -1, peso = 0.4 },
    new sinapse { value = 0.5, peso = 0.1 }
};
Neuronio neuronio = new Neuronio(sinapses);

double[] Ys = new double[] { 0.4, 0.6, 0.1, 0.2 };

// Calcula a soma dos erros quadrados (D)
double valorD = neuronio.pesoStar(Ys, sinapses);

// Calcula as derivadas parciais ∂D/∂w_j
double[] derivadas = neuronio.CalcularDerivadas(Ys, sinapses);

Console.WriteLine("Soma dos erros quadrados (D): " + valorD);
Console.WriteLine("Derivadas parciais:");
for (int i = 0; i < derivadas.Length; i++)
{
    Console.WriteLine($"∂D/∂w_{i} = " + derivadas[i]);
}
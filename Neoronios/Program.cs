using Neoronios;


sinapse[] sinapses = new sinapse[]{
    new sinapse
    {
        value= 1,
        peso= 0.2,
    },
    new sinapse
    {
        value= 0,
        peso= -0.1,
    },
    new sinapse
    {
        value= -1,
        peso= 0.4,
    },
    new sinapse
    {
        value= 0.5,
        peso= 0.1,
    }
};
Neoronio neoronio = new Neoronio(sinapses);

double valor = neoronio.pesoStar(new double[] {0.4, 0.6, 0.1, 0.2},sinapses);
Console.WriteLine(valor);
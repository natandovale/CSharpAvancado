//Escrevendo Código em Execução
using System.Reflection.Emit;

var list = new List<int> { 1, 2, 3, 4, 5 };

var intType = typeof(int);
var assinatura = typeof(Func<int, int, int>);

Func<int, int, int> soma = Soma;

var dynamicMethod = new DynamicMethod("SomaCriadaEmExecucao", intType, new[] { intType, intType});

var ilGenerator = dynamicMethod.GetILGenerator();
ilGenerator.Emit(OpCodes.Ldarg_0);
ilGenerator.Emit(OpCodes.Ldarg_1);
ilGenerator.Emit(OpCodes.Add);
ilGenerator.Emit(OpCodes.Ret);

var somaEmExecucao = (Func<int, int, int>)dynamicMethod.CreateDelegate(assinatura);

Console.WriteLine("Soma de 1+2 definido em desenvolvimento é {0}", Soma(1, 2));
Console.WriteLine("Soma de 1+2 definido em Execução é {0}", somaEmExecucao(1, 2));
Console.WriteLine("Metodo com foreach", ForEachIL(list));

static int Soma(int valorA, int valorB)
{
    return valorA + valorB;
}

static int ForEachIL(List<int> l)
{
    int sum = 0;
    foreach (var item in l)
    {
        sum += item;
    }
    return sum;
}
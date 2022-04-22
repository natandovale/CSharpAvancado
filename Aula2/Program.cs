foreach (var i in EnumerableNumerosDe1a10())
{
    Console.WriteLine(i);
}

var enumeratorNumerosDe1A10 = EnumeratorNumerosDe1a10();

while (enumeratorNumerosDe1A10.MoveNext())
{
    Console.WriteLine(enumeratorNumerosDe1A10.Current);
}

static IEnumerable<int> EnumerableNumerosDe1a10()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
    yield return 6;
    yield return 7;
    yield return 8;
    yield return 9;
    yield return 10;
}

static IEnumerator<int> EnumeratorNumerosDe1a10()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
    yield return 6;
    yield return 7;
    yield return 8;
    yield return 9;
    yield return 10;
}

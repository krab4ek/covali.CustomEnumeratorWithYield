using System.Collections;

namespace covali.CustomEnumeratorWithYield;

public class Garage : IEnumerable
{
    private Car[] carArray = new Car[4];
    public Garage()
    {
        carArray[0] = new Car("Rusty", 20);
        carArray[1] = new Car("Clunker", 56);
        carArray[2] = new Car("Andy", 45);
        carArray[3] = new Car("Rsty", 29);

    }

    public object Current => throw new NotImplementedException();

    public IEnumerator GetEnumerator()
    {
        foreach (Car c in carArray)
            yield return c;
    }

}

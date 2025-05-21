using System.Text;

public class Zarzadzanie<T>
{
    private List<T> zarzadzani;
    public Zarzadzanie(List<T> zarzadzani)
    {
        this.zarzadzani = zarzadzani;
    }
    public int? PodajPozycje(T t)
    {
        if (t == null) throw new ArgumentNullException("Przekazano do metody PodajPozycje null!");
        for (int i = 0; i < zarzadzani.Count; i++)
        {
            if (zarzadzani[i].Equals(t))
            {
                return i;
            }
        }
        return null;
    }
    public void Sortuj()
    {
        if (zarzadzani == null || zarzadzani.Count == 0)
        {
            throw new InvalidOperationException("Lista do sortowania jest pusta lub null.");
        }
        zarzadzani.Sort();
    }
    public void Sortuj<U>(U u) where U : IComparer<T>
    {
        if (zarzadzani == null || zarzadzani.Count == 0)
        {
            throw new InvalidOperationException("Lista do sortowania jest pusta lub null.");
        }
        zarzadzani.Sort(u);
    }
    public class ZarzadzanieException : Exception
    {
        public ZarzadzanieException(string message) : base(message)
        {
        }
    }
    public delegate void Akcja<T>(T t);
    public void Modyfikuj(Akcja<T> akcja)
    {
        if (zarzadzani == null || zarzadzani.Count == 0)
        {
            throw new InvalidOperationException("Lista do modyfikacji jest pusta lub null.");
        }
        foreach (var el in zarzadzani)
        {
            akcja(el);
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var el in zarzadzani)
        {
            sb.AppendLine(el.ToString());
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
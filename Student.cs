public class Student : IComparable<Student>
{
    private string imie;
    private string nazwisko;
    private int numerIndeksu;
    private int rokStudiow;
    public int NumerIndeksu
    {
        get { return numerIndeksu; }
        set { numerIndeksu = value; }
    }
    public int RokStudiow
    {
        get { return rokStudiow; }
        set { rokStudiow = value; }
    }
    public Student(string imie, string nazwisko, int numerIndeksu, int rokStudiow)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.numerIndeksu = numerIndeksu;
        this.rokStudiow = rokStudiow;
    }
    public Student(Student student) : this(student.imie, student.nazwisko, student.numerIndeksu, student.rokStudiow)
    {
    }
    public override string ToString()
    {
        return $"Imie: {imie}, Nazwisko: {nazwisko}, Numer Indeksu: {numerIndeksu}, Rok Studiow: {rokStudiow}";
    }
    public override bool Equals(object obj)
    {
        if (!(obj is Student) && obj == null)
        {
            return false;
        }
        Student other = (Student)obj;
        return this.NumerIndeksu == other.NumerIndeksu;
    }
    public override int GetHashCode()
    {
        return NumerIndeksu.GetHashCode();
    }
    public int CompareTo(Student other)
    {
        if (other == null)
        {
            return 1;
        }
        return this.numerIndeksu.CompareTo(other.numerIndeksu);
    }
    public class StudentPoNazwiskuASCComparer : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            if (a == null || b == null)
            {
                return 0;
            }
            return String.Compare(a.nazwisko, b.nazwisko);
        }
    }
    public class StudentPoWiekDESCComparer : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {   
            if (a == null && b == null) return 0; 
            if (a == null) return 1;
            if (b == null) return -1;
            return b.rokStudiow.CompareTo(a.RokStudiow);
        }
    }

}
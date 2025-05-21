class Program
{
    public static void Main(string[] args)
    {
        // 1. Tworzenie studentów
        Student student1 = new Student("Jan", "Kowalski", 12345, 2);
        Student student2 = new Student("Anna", "Nowak", 23456, 1);
        Student student3 = new Student("Piotr", "Lewandowski", 34567, 4);
        Student student4 = new Student("Alicja", "Dąbrowska", 45678, 2);
        Student student5 = new Student("Kamil", "Mazurek", 56789, 1);

        // 2. Tworzenie listy studentów z kopiami
        List<Student> listaStudentow = new List<Student>
        {
            new Student(student1),
            new Student(student2),
            new Student(student3),
            new Student(student4),
            new Student(student5)
        };

        // 3. Tworzenie obiektu Zarzadzanie<Student>
        Zarzadzanie<Student> zarzadzanie = new Zarzadzanie<Student>(listaStudentow);

        // 4. Wyświetlenie informacji
        Console.WriteLine("Lista studentów:\n" + zarzadzanie);

        // 5. Zmiana numeru indeksu student1
        student1.NumerIndeksu = 12346;

        // 6. Wyświetlenie listy po zmianie numeru indeksu
        Console.WriteLine("\nPo zmianie numeru indeksu:\n" + zarzadzanie);

        // 7. Sortowanie według CompareTo (numer indeksu)
        zarzadzanie.Sortuj();

        // 8. Wyświetlenie po sortowaniu
        Console.WriteLine("\nPo sortowaniu według numeru indeksu:\n" + zarzadzanie);

        // 9. Sortowanie według nazwiska rosnąco
        zarzadzanie.Sortuj(new Student.StudentPoNazwiskuASCComparer());

        // 10. Wyświetlenie po sortowaniu według nazwiska
        Console.WriteLine("\nPo sortowaniu według nazwiska:\n" + zarzadzanie);

        // 11. Sortowanie według roku studiów malejąco
        zarzadzanie.Sortuj(new Student.StudentPoWiekDESCComparer());

        // 12. Wyświetlenie po sortowaniu według roku studiów
        Console.WriteLine("\nPo sortowaniu według roku studiów:\n" + zarzadzanie);

        // 13. Modyfikowanie studentów (zwiększenie roku studiów o 1)
        zarzadzanie.Modyfikuj(student => student.RokStudiow++);

        // 14. Wyświetlenie po modyfikacji
        Console.WriteLine("\nPo zwiększeniu roku studiów o 1:\n" + zarzadzanie);
    }
}
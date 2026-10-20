namespace Sistema_Biblioteca.Data;

public static class LibraryContextFactory
{
    public static LibraryContext Create()
    {
        return new LibraryContext();
    }
}

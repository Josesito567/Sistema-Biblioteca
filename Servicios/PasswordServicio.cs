using System.Security.Cryptography;

namespace Sistema_Biblioteca.Servicios;

public static class PasswordServicio
{
    private const int Iteraciones = 100_000;
    private const int TamanoSal = 16;
    private const int TamanoHash = 32;

    public static string CrearHash(string password)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(password);

        var sal = RandomNumberGenerator.GetBytes(TamanoSal);
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            sal,
            Iteraciones,
            HashAlgorithmName.SHA256,
            TamanoHash);

        return $"PBKDF2${Iteraciones}${Convert.ToBase64String(sal)}${Convert.ToBase64String(hash)}";
    }

    public static bool Verificar(string password, string hashAlmacenado)
    {
        if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(hashAlmacenado))
        {
            return false;
        }

        var partes = hashAlmacenado.Split('$');
        if (partes.Length != 4 || !partes[0].Equals("PBKDF2", StringComparison.OrdinalIgnoreCase) ||
            !int.TryParse(partes[1], out var iteraciones))
        {
            return false;
        }

        try
        {
            var sal = Convert.FromBase64String(partes[2]);
            var hashEsperado = Convert.FromBase64String(partes[3]);
            var hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
                password,
                sal,
                iteraciones,
                HashAlgorithmName.SHA256,
                hashEsperado.Length);

            return CryptographicOperations.FixedTimeEquals(hashCalculado, hashEsperado);
        }
        catch (FormatException)
        {
            return false;
        }
    }
}

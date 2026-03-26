

using System.Security.Cryptography;
using System.Text;

namespace CalorieTracker.Client.Helper;

public  class PasswordHashGenerator
{
    static void CreateHash(string password, out byte[] hash, out byte[] salt)
    {
        salt = RandomNumberGenerator.GetBytes(32);

        using var hmac = new HMACSHA256(salt);
        hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    static bool VerifyKey(string password, byte[] storedHash, byte[] storedSalt)
    {
        using var hmac = new HMACSHA256(storedSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return CryptographicOperations.FixedTimeEquals(computedHash, storedHash);
    }
}

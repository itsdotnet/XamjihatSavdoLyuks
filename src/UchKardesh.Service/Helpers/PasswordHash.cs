namespace UchKardesh.Service.Helpers;

public static class PasswordHash
{
	public static string Hash(this string password)
	{
		password = BCrypt.Net.BCrypt.HashPassword(password);
		return password;
	}

	public static bool Verify(this string hashedPassword, string password)
	{
		return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
	}
}

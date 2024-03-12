namespace CsuChhs.WebComponents.Apikey.Authentication
{
    public interface IApiKeyStore
    {
        string GetKey();

        string GetWriteKey()
        {
            return string.Empty;
        }
    }
}

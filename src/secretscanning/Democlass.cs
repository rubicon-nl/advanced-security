namespace advanced_security;
public class Democlass
{
    private readonly string _superSecretPAT = "nsmoqn7zrdew3mp37vjmuvd2dmujayqeir2qfhtw6rmkhdu67mfq";

    public string ExposeSecrets(){
        return _superSecretPAT;
    }
}

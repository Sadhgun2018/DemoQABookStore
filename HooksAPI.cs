[TestFixture]

public class AutenticationTests:BaseAPI
{
  private Authentication Client authClient;  
}

[setup]
public void setup(string url)
{
  authClient = new Authentication(url);
}

[Test]
public void LoginSuccess()
{
  var response = authclient.Authentication("Username","password");
  Assert.equal(httpstatuscode.OK, responce.statuscode );
}

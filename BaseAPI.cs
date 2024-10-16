
public abstract class APIBaseclass
{
  protected RestClient Client;
  public APIBaseService(string URL_API)
  {
    Client = new RestClient(URL_API);
  }
  protected RestResponse CreateRequest( string endpoint, Method POST)
  {
    Var request = new RestRequest(endpoint, POST)
      return request;
  }
}

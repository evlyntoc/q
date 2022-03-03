var client = new HttpClient();
var request = new HttpRequestMessage();
request.RequestUri = new Uri("https://localhost:3500/register");
request.Method = HttpMethod.Get;

request.Headers.Add("Accept", "*/*");
request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");

var response = await client.SendAsync(request);
var result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);
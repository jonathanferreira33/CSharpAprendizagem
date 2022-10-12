
using ConsumoApiViaCEP.Interface;
using ConsumoApiViaCEP.Reponse;
using Newtonsoft.Json;
using Refit;
using RestSharp;

try {

    //Consumo API Refit
    Console.WriteLine("Digite seu CEP:");
    string cepInformado = Console.ReadLine().ToString();
    var cepClient = RestService.For<ICEPApiService>("http://viacep.com.br");

    Console.WriteLine($"Consultando informações do CEP: {cepInformado}");

    CEPResponse Address = await cepClient.GetAddressAsync(cepInformado);

    Console.WriteLine(EnderecoFormatado(Address));

    Console.WriteLine("----------------------");
    Console.WriteLine("\n \n RestSharp");

    //Consumo API Restsharp
    var client = new RestClient();
    RestRequest request = new RestRequest("http://viacep.com.br/ws/{cep}/json")
        .AddUrlSegment("cep", $"{cepInformado}");
    var restResponse = await client.GetAsync(request);
    Console.WriteLine(restResponse.Content);
    Console.WriteLine("\n \n ou \n");

    string responseContent = restResponse.Content;
    var cepResponse = JsonConvert.DeserializeObject<CEPResponse>(responseContent);
    Console.WriteLine(EnderecoFormatado(cepResponse));


} catch (Exception ex) {
    Console.WriteLine($"Erro na consulta de cep: {ex.Message}");
}

string EnderecoFormatado(CEPResponse address) {
    return "\n" +
        $"Endereço: {address.Logradouro} \n" +
        $"Complemento: {address.Complemento} \n" +
        $"Bairro: {address.Bairro} \n" +
        $"CEP: {address.Cep} \n" +
        $"Cidade: {address.Localidade} \n" +
        $"DDD: {address.Ddd} \n" +
        $"IBGE: {address.Ibge} \n";
}

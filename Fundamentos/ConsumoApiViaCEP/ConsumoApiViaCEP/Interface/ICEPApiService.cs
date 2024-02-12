using ConsumoApiViaCEP.Reponse;
using Refit;

namespace ConsumoApiViaCEP.Interface {
    public interface ICEPApiService {
        
        [Get("/ws/{cep}/json")]
        Task<CEPResponse> GetAddressAsync(string cep);
    }
}

using System.Text.Json.Serialization;

namespace GerenciadorDividasCore.Models.Serialize
{
    public class Cliente
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("username")]
        public string Usuario { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public Endereco Endereco { get; set; }

        [JsonPropertyName("phone")]
        public string Telefone { get; set; }

        [JsonPropertyName("website")]
        public string Site { get; set; }

        [JsonPropertyName("company")]
        public Empresa Empresa { get; set; }
    }

    public class Endereco
    {
        [JsonPropertyName("street")]
        public string Rua { get; set; }

        [JsonPropertyName("suite")]
        public string Suite { get; set; }

        [JsonPropertyName("city")]
        public string Cidade { get; set; }

        [JsonPropertyName("zipcode")]
        public string CodigoPostal { get; set; }

        [JsonPropertyName("geo")]
        public Geo Geo { get; set; }

    }

    public class Empresa
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("catchPhrase")]
        public string Slogan { get; set; }

        [JsonPropertyName("bs")]
        public string Bs { get; set; }

    }

    public class Geo
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lng")]
        public string Lng { get; set; }

    }
}
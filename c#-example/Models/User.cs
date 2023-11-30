using Newtonsoft.Json;

namespace c__example;

public class User 
{
    [JsonProperty("email")]
    public required string Email {get; set;}
    [JsonProperty("name")]
    public required string Name {get; set;}
    [JsonProperty("password")]
    public required string Password {get; set;}
    [JsonProperty("accountNumber")]
    public required string AccountNumber {get; set;}
    [JsonProperty("balance")]
    public int Balance {get; set;}
    [JsonProperty("logged")]
    public bool Logged {get; set;}
}
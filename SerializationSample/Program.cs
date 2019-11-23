namespace SerializationSample
{
    public static class Program
    {
        const string json = "{\"AllowedGrantTypes\": [\"client_credentials\"]}";

        private static void Main()
        {
            // this works
            var objNewtonsoftJson = Newtonsoft.Json.JsonConvert.DeserializeObject<Client>(json);
            
            // this errors
            var objSystemTextJson = System.Text.Json.JsonSerializer.Deserialize<Client>(json);
        }
    }
}
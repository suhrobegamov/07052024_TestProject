long nomenclatureId = 148748593;
string url = $"https://www.wildberries.ru/catalog/{nomenclatureId}/detail.aspx";

try
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        Console.WriteLine((await response.Content.ReadAsStringAsync()));
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

HttpClient istemci = new HttpClient();

string sonuc = await istemci.GetStringAsync("http://localhost:5000/servis/Kitap");

Console.WriteLine(sonuc);
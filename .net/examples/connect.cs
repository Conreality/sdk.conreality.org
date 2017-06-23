// mcs -r:Npgsql -r:System.Data connect.cs && mono connect.exe

using Npgsql;

public class Connect {
  public static void Main() {

    using (var conn = new NpgsqlConnection("Host=localhost;Database=test")) {
      conn.Open();

      using (var cmd = new NpgsqlCommand("SELECT 42 AS answer", conn))
      using (var reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          System.Console.WriteLine(reader.GetString(0));
        }
      }
    }
  }
}

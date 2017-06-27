// mcs -r:Npgsql -r:System.Data lowlevel.cs && mono lowlevel.exe

using Npgsql;

public class Lowlevel {
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

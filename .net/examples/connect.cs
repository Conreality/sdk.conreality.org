// mcs -r:Npgsql -r:System.Data connect.cs && mono connect.exe

using Npgsql;

public class Connect {
  public static void Main() {

    using (var conn = new NpgsqlConnection("Database=test")) {
      conn.Open();

      // TODO
    }
  }
}

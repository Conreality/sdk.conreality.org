// c++ -o connect connect.cc `pkg-config --cflags --libs libpqxx libpq`

#include <pqxx/pqxx>
#include <cstdlib>   /* for EXIT_*, std::getenv() */
#include <string>    /* for std::string */

int main(int, char**) {
  std::string connstring("dbname=");
  connstring.append(std::getenv("USER"));

  pqxx::connection connection(connstring);

  pqxx::work transaction(connection);

  try {
    // TODO: do something useful
    transaction.exec("SELECT 1");

    transaction.commit();

    return EXIT_SUCCESS;
  }
  catch (const std::exception& e) {
    // TODO: handle the error

    transaction.abort();

    return EXIT_FAILURE;
  }
}

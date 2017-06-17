///usr/bin/env go run "$0" "$@"; exit "$?"

package main

import ("database/sql"; "fmt"; "os"; _ "github.com/lib/pq")

func main() {
  dbname := os.Getenv("USER")

  db, err := sql.Open("postgres", "sslmode=disable dbname=" + dbname)
  if err != nil { panic(err) }
  defer db.Close()

  rows, err := db.Query("SELECT 42 AS answer")
  if err != nil { panic(err) }
  for rows.Next() {
    var answer int
    rows.Scan(&answer)
    fmt.Println(answer)
  }
}

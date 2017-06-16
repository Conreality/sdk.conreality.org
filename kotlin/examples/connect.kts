#!/usr/bin/env kotlinc -script

import java.sql.DriverManager

Class.forName("org.postgresql.Driver").newInstance()

val dbName = System.getenv("USER") ?: "test"

val connection = DriverManager.getConnection("jdbc:postgresql:" + dbName)

val statement = connection.createStatement()

val resultSet = statement.executeQuery("SELECT 42 AS answer")

while (resultSet.next()) {
  println(resultSet.getInt("answer"))
}

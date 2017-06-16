#!/usr/bin/env elixir

dbname = System.get_env("USER") || "test"

{:ok, pid} = Postgrex.start_link(database: dbname)

Postgrex.query!(pid, "SELECT 1", [])

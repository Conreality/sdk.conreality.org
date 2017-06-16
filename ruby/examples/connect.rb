#!/usr/bin/env ruby

require 'pg'

connection = PG.connect(dbname: ENV['USER'] || 'test')

connection.transaction do
  connection.exec("SELECT 1") do |result|
    p result
  end
end

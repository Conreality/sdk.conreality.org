#!/usr/bin/env python3

import asyncio
import asyncpg
import os

async def run():
  dbname = os.getenv('USER') or 'test'
  conn = await asyncpg.connect(database=dbname)
  result = await conn.fetch('''SELECT 1''')
  print(result)
  await conn.close()

loop = asyncio.get_event_loop()
loop.run_until_complete(run())

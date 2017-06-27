#!/usr/bin/env python3

import asyncio
import asyncpg
import os

DBNAME = os.getenv('USER') or 'test'

async def run():
  conn = await asyncpg.connect(database=dbname)
  answer = await conn.fetch('''SELECT 42''')
  print(answer)
  await conn.close()

loop = asyncio.get_event_loop()
loop.run_until_complete(run())

#!/usr/bin/env python3

import conreality.sdk as sdk
import os

DBNAME = os.getenv('USER') or 'test'

client = sdk.Client(database=DBNAME)

print(client)

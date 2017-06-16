****************************************************
Conreality Software Development Kit (SDK) for Python
****************************************************

The Conreality SDK for Python is currently at a planning stage at:

https://github.com/conreality/conreality.py

.. note::

   Pending the release of a Conreality SDK for Python, you can integrate
   Python software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (e.g., via the Psycopg2_ or asyncpg_ libraries).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.py
   :language: python3

Frequently Asked Questions (FAQ)
================================

Does the Conreality SDK support Python 2.x?
-------------------------------------------

No, the Conreality SDK for Python targets exclusively Python 3.4.0 (which
was released in 2014) and newer versions of Python 3.

In case you cannot migrate from Python 2 to Python 3, we suggest integrating
your legacy Python software with Conreality games by issuing SQL commands
over the PostgreSQL network protocol (e.g., via the Psycopg2_ library).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _Psycopg2: https://github.com/psycopg/psycopg2
.. _asyncpg:  https://github.com/MagicStack/asyncpg

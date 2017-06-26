****************************************************
Conreality Software Development Kit (SDK) for Python
****************************************************

The Conreality SDK for Python is currently at an early development stage at:
https://github.com/conreality/conreality.py

.. note::

   Pending the release of a Conreality SDK for Python, you can integrate
   Python software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (e.g., via the Psycopg2_ or asyncpg_ libraries).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Python <https://www.python.org/>`__ 3.5+
* `asyncpg <https://pypi.python.org/pypi/asyncpg>`__ 0.11+
* `Lupa <https://pypi.python.org/pypi/lupa>`__ 1.4+ and
  `Lua <https://www.lua.org/versions.html#5.2>`__ 5.2
* `NumPy <https://pypi.python.org/pypi/numpy>`__ 1.13+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.py
   :language: python3

Connecting to the Master (without the SDK)
------------------------------------------

.. literalinclude:: examples/connect_asyncpg.py
   :language: python3

Installation
============

https://pypi.python.org/pypi/conreality

.. code-block:: console

   $ pip3 install conreality

Overview
========

.. py:currentmodule:: conreality.sdk

.. inheritance-diagram:: AsyncClient Client Session
   :parts: 1

.. inheritance-diagram:: Binary Event Message
   :parts: 1

.. inheritance-diagram:: Asset Camera Object Player Theater
   :parts: 1

Documentation
=============

.. py:module:: conreality.sdk

.. py:class:: Asset

.. py:class:: Binary

.. py:class:: Camera

.. py:class:: AsyncClient

.. py:class:: Client

.. py:class:: Event

.. py:class:: Message

.. py:class:: Object

.. py:class:: Player

.. py:class:: Session

.. py:class:: Theater

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Python SDK?
---------------------------------------------------------------

See https://github.com/conreality/conreality.py

Does the Python SDK also support Python 3.4?
--------------------------------------------

No, as the third-party dependencies we rely on (specifically, *asyncpg*)
require Python 3.5 at minimum.

Does the Python SDK also support Python 2.7?
--------------------------------------------

No, the Conreality SDK for Python targets exclusively Python 3.5 (which
was released in 2015) and newer versions of Python 3.

In case you cannot migrate from Python 2 to Python 3, we suggest integrating
your legacy Python software with Conreality games by issuing SQL commands
over the PostgreSQL network protocol (e.g., via the Psycopg2_ library).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _Psycopg2: https://github.com/psycopg/psycopg2
.. _asyncpg:  https://github.com/MagicStack/asyncpg

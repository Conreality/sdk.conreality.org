****************************************************
Conreality Software Development Kit (SDK) for Kotlin
****************************************************

The Conreality SDK for Kotlin is currently at a planning stage at:

https://github.com/conreality/conreality.kt

.. note::

   Pending the release of a Conreality SDK for Kotlin, you can integrate
   Kotlin software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (e.g., via the PgJDBC_ library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Kotlin <https://kotlinlang.org/>`__ 1.1+
* `PgJDBC <https://jdbc.postgresql.org/>`__ 42+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.kts
   :language: kotlin

Frequently Asked Questions (FAQ)
================================

.. _PgJDBC: https://github.com/pgjdbc/pgjdbc

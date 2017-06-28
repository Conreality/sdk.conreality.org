*************************************************
Conreality Software Development Kit (SDK) for C++
*************************************************

The Conreality SDK for C++ is currently at a planning stage at:
https://github.com/conreality/conreality-sdk

.. note::

   Pending the release of a Conreality SDK for C++, you can integrate
   C++ software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (via the libpq_ and/or libpqxx_ libraries).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `C++11 <https://en.wikipedia.org/wiki/C%2B%2B11>`__
  compiler and standard library
  (recent releases of Clang or GCC will work fine)
* libpq_
* libpqxx_

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.cc
   :language: c++

Installation
============

Reference
=========

.. describe:: #include <conreality.h>

.. code-block:: c++

   #include <conreality.h>

   using namespace conreality;

.. cpp:class:: conreality::client

.. cpp:class:: conreality::event

.. cpp:class:: conreality::message

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the C++ SDK?
------------------------------------------------------------

See https://github.com/conreality/conreality-sdk

Does the C++ SDK also support C++98 or C++03 compilers?
-------------------------------------------------------

No, the Conreality SDK for C++ targets exclusively C++11 (which was
released in 2011) and newer standards of C++.

In case you cannot migrate to C++11, we suggest integrating your legacy C++
software with Conreality games by issuing SQL commands over the PostgreSQL
network protocol (via the libpq_ and/or libpqxx_ libraries).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _libpq:   https://www.postgresql.org/docs/current/static/libpq.html
.. _libpqxx: https://github.com/jtv/libpqxx

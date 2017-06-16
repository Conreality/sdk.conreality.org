*************************************************
Conreality Software Development Kit (SDK) for C++
*************************************************

.. note::

   Until there is a dedicated Conreality SDK for C++, you can integrate
   C++ software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (via the libpq_ or libpqxx_ libraries).
   Refer to the documentation for the :doc:`Conreality SDK for SQL <sql>`.

.. _libpq:   https://www.postgresql.org/docs/current/static/libpq.html
.. _libpqxx: https://github.com/jtv/libpqxx

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: cxx/examples/connect.cc
   :language: c++

Frequently Asked Questions (FAQ)
================================

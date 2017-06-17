************************************************
Conreality Software Development Kit (SDK) for Go
************************************************

The Conreality SDK for Go is currently at a planning stage at:
https://github.com/conreality/conreality.go

.. note::

   Pending the release of a Conreality SDK for Go, you can integrate
   Go software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (e.g., via the `lib/pq`_ or `jackc/pgx`_
   libraries).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Go <https://golang.org>`__ 1.8+
* `github.com/lib/pq <https://godoc.org/github.com/lib/pq>`__
  or
  `github.com/jackc/pgx <https://godoc.org/github.com/jackc/pgx>`__

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.go
   :language: go

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Go SDK?
-------------------------------------------------------------

See https://github.com/conreality/conreality.go

Does the Go SDK also support Go releases prior to 1.8?
------------------------------------------------------

No, the Conreality SDK for Go targets exclusively Go 1.8+ and newer versions
of Go.

In case you cannot migrate to Go 1.8+, we suggest integrating your legacy
Go software with Conreality games by issuing SQL commands over the
PostgreSQL network protocol (e.g., via the `lib/pq`_ or `jackc/pgx`_
libraries).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _lib/pq:    https://github.com/lib/pq
.. _jackc/pgx: https://github.com/jackc/pgx

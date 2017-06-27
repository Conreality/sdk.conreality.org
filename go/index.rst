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

* `Go <https://golang.org>`__ 1.6+
* `github.com/lib/pq <https://godoc.org/github.com/lib/pq>`__
* `github.com/satori/go.uuid <https://godoc.org/github.com/satori/go.uuid>`__

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.go
   :language: go

Installation
============

.. code-block:: console

   $ go get github.com/conreality/conreality.go

Documentation
=============

https://godoc.org/github.com/conreality/conreality.go

.. code-block:: console

   $ go doc github.com/conreality/conreality.go

.. go:package:: conreality

.. code-block:: go

   import "github.com/conreality/conreality.go"

.. go:const:: Version

.. code-block:: go

   fmt.Printf("Conreality SDK for Go v%s\n", conreality.Version)

.. go:type:: Asset

.. go:type:: Binary

.. go:type:: Camera

.. go:type:: Client

.. go:func:: Connect(gameName string) (*Client, error)

.. code-block:: go

   var client, err = conreality.Connect("skynet")
   if err != nil {
     panic(err)
   }
   defer client.Disconnect()

.. go:func:: (client *Client) Begin() (*Scope, error)

.. code-block:: go

   var scope, err = client.Begin()
   if err != nil {
     panic(err)
   }
   defer scope.Commit()

.. go:func:: (client *Client) Disconnect() error

.. go:type:: Event

.. go:type:: Message

.. go:type:: Object

.. go:type:: Player

.. go:type:: Scope

.. go:func:: (scope *Scope) Abort() error

.. go:func:: (scope *Scope) Commit() error

.. go:func:: (scope *Scope) SendMessage(messageText string) (int64, error)

.. code-block:: go

   var messageID, err = scope.SendMessage("Greetings from Go!")
   if err != nil {
     panic(err)
   }
   fmt.Printf("Sent a message with ID #%d\n", messageID)

.. go:type:: Session

.. go:type:: Theater

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Go SDK?
-------------------------------------------------------------

See https://github.com/conreality/conreality.go

Does the Go SDK also support Go releases prior to 1.6?
------------------------------------------------------

No, the Conreality SDK for Go targets exclusively Go 1.6+ and newer versions
of Go.

In case you cannot migrate to Go 1.6+, we suggest integrating your legacy
Go software with Conreality games by issuing SQL commands over the
PostgreSQL network protocol (e.g., via the `lib/pq`_ or `jackc/pgx`_
libraries).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _lib/pq:    https://github.com/lib/pq
.. _jackc/pgx: https://github.com/jackc/pgx

************************************************
Conreality Software Development Kit (SDK) for Go
************************************************

The Conreality SDK for Go is currently at an early development stage at:
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
* `github.com/lib/pq
  <https://godoc.org/github.com/lib/pq>`__
* `github.com/pkg/errors
  <https://godoc.org/github.com/pkg/errors>`__
* `github.com/satori/go.uuid
  <https://godoc.org/github.com/satori/go.uuid>`__

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

Reference
=========

https://godoc.org/github.com/conreality/conreality.go

.. code-block:: console

   $ go doc github.com/conreality/conreality.go

.. go:package:: conreality

.. code-block:: go

   import "github.com/conreality/conreality.go"

.. go:const:: Version

.. code-block:: go

   fmt.Printf("Conreality SDK for Go v%s\n", conreality.Version)

.. go:type:: Action

.. go:func:: (action *Action) Abort() error

.. go:func:: (action *Action) Commit() error

.. go:func:: (action *Action) SendEvent(predicate string, subject, object *Object) (*Event, error)

.. code-block:: go

   var event, err = action.SendEvent("met", bob, alice)
   if err != nil {
     panic(err)
   }
   fmt.Printf("Sent an event: #%#v\n", event)

.. go:func:: (action *Action) SendMessage(messageText string) (*Message, error)

.. code-block:: go

   var message, err = action.SendMessage("Greetings from Go!")
   if err != nil {
     panic(err)
   }
   fmt.Printf("Sent a message: #%#v\n", message)

.. go:type:: Asset

.. go:type:: Binary

.. go:type:: Camera

.. go:type:: Client

.. go:func:: Connect(masterHost string) (*Client, error)

.. code-block:: go

   var client, err = conreality.Connect("skynet.local")
   if err != nil {
     panic(err)
   }
   defer client.Disconnect()

.. go:func:: (client *Client) Disconnect() error

.. go:func:: (client *Client) Login(agentUUID string, secret string) (*Session, error)

.. code-block:: go

   var session, err = client.Login("ff27a78c-a8b3-48a5-bf7c-41b22cf14333", "")
   if err != nil {
     panic(err)
   }
   defer session.Logout()

.. go:type:: Event

.. go:type:: Game

.. go:type:: Message

.. go:type:: Object

.. go:type:: Player

.. go:type:: Session

.. go:func:: (session *Session) Logout() error

.. go:func:: (session *Session) Game() *Game

.. go:func:: (session *Session) NewAction() (*Action, error)

.. code-block:: go

   var action, err = session.NewAction()
   if err != nil {
     panic(err)
   }
   defer action.Commit()

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

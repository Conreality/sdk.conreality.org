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

* Java 8
* `Kotlin <https://kotlinlang.org/>`__ 1.1+
* `PgJDBC <https://jdbc.postgresql.org/>`__ 42+
* `HikariCP <https://brettwooldridge.github.io/HikariCP/>`__ 2.6+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.kts
   :language: kotlin

Installation
============

Reference
=========

.. kt:package:: org.conreality.sdk

.. code-block:: kotlin

   import org.conreality.sdk

Classes
-------

.. kt:class:: Action

.. kt:property:: Action#isPending: Boolean

.. kt:property:: Action#isClosed: Boolean

.. kt:method:: Action#abort(): Unit

.. kt:method:: Action#close(): Unit

.. kt:method:: Action#commit(): Unit

.. kt:method:: Action#sendEvent(String, Object, Object): Event

.. kt:method:: Action#sendMessage(String): Message

.. kt:method:: Action#sendAudioMessage(ByteArray): Message

.. kt:method:: Action#sendAudioMessage(InputStream): Message

.. kt:method:: Action#beginAudioMessage(): BinaryOutputStream

.. kt:method:: Action#reportLocation(Location): Unit

.. kt:method:: Action#reportMotion(): Unit

.. kt:class:: Binary

.. kt:property:: Binary#id: Long

.. kt:property:: Binary#session: Session

.. kt:class:: Client

.. kt:property:: Client#gameURL: String

.. kt:property:: Client#connectionURL: String

.. kt:method:: Client#close(): Unit

.. kt:method:: Client#login(): Session

.. kt:method:: Client#login(String, String): Session

.. kt:method:: Client#login(UUID, String): Session

.. kt:class:: Event

.. kt:property:: Event#id: Long

.. kt:property:: Event#session: Session

.. kt:class:: Game

.. kt:property:: Game#session: Session

.. kt:class:: Location

.. kt:property:: Location#latitude: Double

.. kt:property:: Location#longitude: Double

.. kt:class:: Message

.. kt:property:: Message#id: Long

.. kt:property:: Message#session: Session

.. kt:class:: Object

.. kt:property:: Object#location: Location?

.. kt:property:: Object#session: Session

.. kt:property:: Object#uuid: UUID

.. kt:class:: Session

.. kt:property:: Session#agent: Object

.. kt:property:: Session#agentUUID: UUID

.. kt:property:: Session#client: Client

.. kt:property:: Session#id: Long

.. kt:property:: Session#isClosed: Boolean

.. kt:property:: Session#game: Game

.. kt:method:: Session#close(): Unit

.. kt:method:: Session#execute(body: (Action) -> T): T

Exceptions
----------

.. kt:class:: ConnectionException: SQLException

.. kt:class:: TransactionException: SQLException

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Kotlin SDK?
---------------------------------------------------------------

See https://github.com/conreality/conreality.kt

.. _PgJDBC: https://github.com/pgjdbc/pgjdbc

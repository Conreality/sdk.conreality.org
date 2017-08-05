****************************************************
Conreality Software Development Kit (SDK) for Kotlin
****************************************************

The Conreality SDK for Kotlin is currently at an early development stage at:
https://github.com/conreality/conreality.kt

.. note::

   Pending the release of a Conreality SDK for Kotlin, you can integrate
   Kotlin software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (e.g., via the PgJDBC_ library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Java 8
  <http://www.oracle.com/technetwork/java/javase/overview/java8-2100321.html>`__
* `Kotlin
  <https://kotlinlang.org/>`__ 1.1+
* `PgJDBC
  <https://jdbc.postgresql.org/>`__ 42+
* `HikariCP
  <https://brettwooldridge.github.io/HikariCP/>`__ 2.6+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.kts
   :language: kotlin

Installation
============

.. code-block:: kotlin

   // TODO

Reference
=========

.. kt:package:: org.conreality.sdk

.. code-block:: kotlin

   import org.conreality.sdk.*

Actions
-------

.. kt:class:: Action

.. kt:property:: Action#isPending: Boolean

.. kt:property:: Action#isClosed: Boolean

.. kt:method:: Action#abort(): Unit

.. kt:method:: Action#close(): Unit

.. kt:method:: Action#commit(): Unit

.. kt:method:: Action#sendEvent(String, Object, Object): Event

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#sendMessage(String): Message

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#sendAudioMessage(ByteArray): Message

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#sendAudioMessage(InputStream): Message

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#beginAudioMessage(): BinaryOutputStream

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#reportLocation(Location): Unit

.. code-block:: kotlin

   // TODO

.. kt:method:: Action#reportMotion(): Unit

.. code-block:: kotlin

   // TODO

Assets
------

Binaries
--------

.. kt:class:: Binary

.. kt:property:: Binary#id: Long

.. kt:property:: Binary#session: Session

Cameras
-------

Clients
-------

.. kt:class:: Client

.. kt:property:: Client#gameURL: String

.. kt:property:: Client#connectionURL: String

.. kt:method:: Client#close(): Unit

.. kt:method:: Client#login(): Session

.. code-block:: kotlin

   // TODO

.. kt:method:: Client#login(String, String): Session

.. code-block:: kotlin

   // TODO

.. kt:method:: Client#login(UUID, String): Session

Events
------

.. kt:class:: Event

.. kt:property:: Event#id: Long

.. kt:property:: Event#session: Session

Games
-----

.. kt:class:: Game

.. kt:property:: Game#session: Session

Locations
---------

.. kt:class:: Location

.. code-block:: kotlin

   // TODO

.. kt:property:: Location#latitude: Double

.. kt:property:: Location#longitude: Double

Messages
--------

.. kt:class:: Message

.. kt:property:: Message#id: Long

.. kt:property:: Message#session: Session

Objects
-------

.. kt:class:: Object

.. kt:property:: Object#location: Location?

.. kt:property:: Object#session: Session

.. kt:property:: Object#uuid: UUID

Players
-------

Sessions
--------

.. kt:class:: Session

.. kt:property:: Session#agent: Object

.. kt:property:: Session#agentUUID: UUID

.. kt:property:: Session#client: Client

.. kt:property:: Session#id: Long

.. kt:property:: Session#isClosed: Boolean

.. kt:property:: Session#game: Game

.. kt:method:: Session#close(): Unit

.. kt:method:: Session#execute(body: Action -> T): T

.. code-block:: kotlin

   // TODO

Theaters
--------

Exceptions
----------

.. kt:class:: ConnectionException: SQLException

.. kt:class:: TransactionException: SQLException

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Kotlin SDK?
---------------------------------------------------------------

See https://github.com/conreality/conreality.kt

Does the Kotlin SDK also support Kotlin releases prior to 1.1?
--------------------------------------------------------------

No, the Conreality SDK for Kotlin targets exclusively Kotlin 1.1+ and newer
versions of Kotlin.

Does the Kotlin SDK also support Java releases prior to Java 8?
---------------------------------------------------------------

No, the Conreality SDK for Kotlin targets exclusively `Java SE 8`_ and newer
versions of the Java platform and runtime environment (JRE).

.. _Java SE 8: https://en.wikipedia.org/wiki/Java_version_history#Java_SE_8
.. _PgJDBC:    https://github.com/pgjdbc/pgjdbc

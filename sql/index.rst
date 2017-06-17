*************************************************
Conreality Software Development Kit (SDK) for SQL
*************************************************

The Conreality SDK for SDK is currently under active development at:

https://github.com/conreality/conreality.sql

Prerequisites
=============

* `PostgreSQL <http://postgresql.org/>`__ 9.6+
  with the
  `uuid-ossp <https://www.postgresql.org/docs/current/static/uuid-ossp.html>`__
  extension
* `PostGIS <http://postgis.net/>`__ 2.3+
* `PL/Lua <https://github.com/pllua/pllua>`__ 1.1+

Examples
========

Tutorials
=========

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the SQL SDK?
------------------------------------------------------------

See https://github.com/conreality/conreality.sql

Does the SQL SDK also support other DBMSes than PostgreSQL?
-----------------------------------------------------------

No, the Conreality SDK for SQL targets exclusively PostgreSQL.

Reference
=========

Table Schema
------------

TODO: diagram

Function Reference
------------------

.. describe:: conreality.event_send(event_predicate text, event_subject text, event_object text)

.. describe:: conreality.message_send(message_sender text, message_text text)

.. describe:: conreality.object_is_located(object_uuid text)

.. describe:: conreality.object_is_immovable(object_uuid text)

.. describe:: conreality.object_is_moving(object_uuid text)

.. describe:: conreality.object_is_rotating(object_uuid text)

.. describe:: conreality.object_is_accelerating(object_uuid text)

.. describe:: conreality.object_is_active(object_uuid text)

.. describe:: conreality.object_is_inactive(object_uuid text)

.. describe:: conreality.object_invert_mass(object_uuid text)

.. describe:: conreality.player_register()

.. describe:: conreality.player_register(player_uuid uuid, player_nick text)

.. describe:: conreality.player_deregister(player_uuid uuid)

.. describe:: conreality.point_2d(x float, y float)

.. describe:: conreality.point_3d(x float, y float, z float)

.. describe:: conreality.point_gps(lon float, lat float)

.. describe:: conreality.session_start()

.. describe:: conreality.session_terminate()

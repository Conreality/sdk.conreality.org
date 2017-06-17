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

Registering a New Player
------------------------

.. code-block:: postgresql

   SELECT conreality.player_register()
     AS player_uuid;

Sending a Text Message
----------------------

.. code-block:: postgresql

   SELECT conreality.message_send(:message_sender, "Hello, world!")
     AS message_id;

Sending an Audio Message
------------------------

.. code-block:: postgresql

   -- TODO

Recording a Game Event
----------------------

.. code-block:: postgresql

   SELECT conreality.event_send(...) -- TODO
     AS event_id;

Retrieving a Camera Thumbnail
-----------------------------

.. code-block:: postgresql

   SELECT cf.data AS camera_thumbnail
     FROM conreality.camera_frame cf
     WHERE cf.uuid = :camera_uuid;

Finding Players Near a GPS Point
--------------------------------

.. code-block:: postgresql

   -- TODO

Finding Assets Currently Immobile
---------------------------------

.. code-block:: postgresql

   SELECT a.uuid FROM conreality.asset a
     WHERE NOT conreality.object_is_moving(a.uuid::text);

Measuring the Distance Between Objects
--------------------------------------

.. code-block:: postgresql

   SELECT conreality.distance(...); -- TODO

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

Determines whether this object has a nonzero position.

.. describe:: conreality.object_is_immovable(object_uuid text)

Determines whether this is an immovable physical object.

.. describe:: conreality.object_is_moving(object_uuid text)

Determines whether this object has a nonzero linear velocity.

.. describe:: conreality.object_is_rotating(object_uuid text)

Determines whether this object has a nonzero angular velocity.

.. describe:: conreality.object_is_accelerating(object_uuid text)

Determines whether this object has a nonzero linear acceleration.

.. describe:: conreality.object_is_active(object_uuid text)

Determines whether this object is currently active.

.. describe:: conreality.object_is_inactive(object_uuid text)

Determines whether this object is currently inactive.

.. describe:: conreality.object_invert_mass(object_uuid text)

Computes the inverse mass of this object.

.. describe:: conreality.player_register()

.. describe:: conreality.player_register(player_uuid uuid, player_nick text)

.. describe:: conreality.player_deregister(player_uuid uuid)

.. describe:: conreality.point_2d(x float, y float)

.. describe:: conreality.point_3d(x float, y float, z float)

.. describe:: conreality.point_gps(lon float, lat float)

.. describe:: conreality.session_start()

.. describe:: conreality.session_terminate()

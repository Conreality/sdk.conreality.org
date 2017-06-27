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

   SELECT conreality.message_send("Hello, world!")
     AS message_id;

Sending an Audio Message
------------------------

.. code-block:: postgresql

   -- TODO

Recording a Game Event
----------------------

.. code-block:: postgresql

   SELECT conreality.event_send("met",
     (SELECT o1.uuid
        FROM conreality.object o1
        WHERE o1.label = 'Bob'),
     (SELECT o2.uuid
        FROM conreality.object o2
        WHERE o2.label = 'Alice'))
     AS event_id;

Retrieving a Camera Thumbnail
-----------------------------

.. code-block:: postgresql

   SELECT cf.data AS camera_thumbnail
     FROM conreality.camera_frame cf
     WHERE cf.uuid = ...;

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

   SELECT conreality.distance_between(
     (SELECT o1.position
        FROM conreality.object o1
        WHERE o1.label = 'Alice'),
     (SELECT o2.position
        FROM conreality.object o2
        WHERE o2.label = 'Bob'))
     AS distance;

Plotting Current Target Positions
---------------------------------

.. code-block:: postgresql

   -- TODO

Tutorials
=========

Installation
============

https://github.com/conreality/conreality.sql/blob/master/src/schema.sh

::

   src/schema.sh | psql > /dev/null

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

.. sql:schema:: conreality

Data Type Reference
-------------------

.. sql:type:: binary_type

.. sql:type:: object_type

Table Schema
------------

TODO: diagram

Table Reference
---------------

.. sql:table:: asset

.. sql:table:: binary

.. sql:table:: camera

.. sql:table:: camera_frame

.. sql:table:: event

.. sql:table:: group

.. sql:table:: message

.. sql:table:: object

.. sql:table:: player

.. sql:table:: target

.. sql:table:: theater

View Reference
--------------

.. sql:view:: message_with_avatar

.. sql:view:: object_asset

.. sql:view:: object_camera

.. sql:view:: object_player

.. sql:view:: object_target

Function Reference
------------------

.. sql:function:: distance_between(p1 geometry, p2 geometry) float

.. sql:function:: distance_between(p1 geography, p2 geography) float

.. sql:function:: event_send(event_predicate text, event_subject text, event_object text) bigint

.. sql:function:: message_send(message_text text) bigint

.. sql:function:: message_send(message_sender text, message_text text) bigint

.. sql:function:: object_invert_mass(object_uuid text) float

Computes the inverse mass of this object.

.. sql:function:: object_is_accelerating(object_uuid text) boolean

Determines whether this object has a nonzero linear acceleration.

.. sql:function:: object_is_active(object_uuid text) boolean

Determines whether this object is currently active.

.. sql:function:: object_is_immovable(object_uuid text) boolean

Determines whether this is an immovable physical object.

.. sql:function:: object_is_inactive(object_uuid text) boolean

Determines whether this object is currently inactive.

.. sql:function:: object_is_located(object_uuid text) boolean

Determines whether this object has a nonzero position.

.. sql:function:: object_is_moving(object_uuid text) boolean

Determines whether this object has a nonzero linear velocity.

.. sql:function:: object_is_rotating(object_uuid text) boolean

Determines whether this object has a nonzero angular velocity.

.. sql:function:: player_deregister(player_uuid uuid) void

.. sql:function:: player_register() uuid

.. sql:function:: player_register(player_uuid uuid, player_nick text) uuid

.. sql:function:: point_2d(x float, y float) geometry

.. sql:function:: point_3d(x float, y float, z float) geometry

.. sql:function:: point_gps(lon float, lat float) geography

.. sql:function:: session_start() void

.. sql:function:: session_terminate() void

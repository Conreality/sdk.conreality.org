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

.. sql:type:: conreality.binary_type

.. sql:type:: conreality.object_type

Table Schema
------------

TODO: diagram

Table Reference
---------------

.. sql:table:: conreality.asset

.. sql:table:: conreality.binary

.. sql:table:: conreality.camera

.. sql:table:: conreality.camera_frame

.. sql:table:: conreality.event

.. sql:table:: conreality.group

.. sql:table:: conreality.message

.. sql:table:: conreality.object

.. sql:table:: conreality.player

.. sql:table:: conreality.target

.. sql:table:: conreality.theater

View Reference
--------------

.. sql:view:: conreality.message_with_avatar

.. sql:view:: conreality.object_asset

.. sql:view:: conreality.object_camera

.. sql:view:: conreality.object_player

.. sql:view:: conreality.object_target

Function Reference
------------------

.. sql:function:: conreality.distance_between(p1 geometry, p2 geometry)

.. sql:function:: conreality.distance_between(p1 geography, p2 geography)

.. sql:function:: conreality.event_send(event_predicate text, event_subject text, event_object text)

.. sql:function:: conreality.message_send(message_text text)

.. sql:function:: conreality.message_send(message_sender text, message_text text)

.. sql:function:: conreality.object_invert_mass(object_uuid text)

Computes the inverse mass of this object.

.. sql:function:: conreality.object_is_accelerating(object_uuid text)

Determines whether this object has a nonzero linear acceleration.

.. sql:function:: conreality.object_is_active(object_uuid text)

Determines whether this object is currently active.

.. sql:function:: conreality.object_is_immovable(object_uuid text)

Determines whether this is an immovable physical object.

.. sql:function:: conreality.object_is_inactive(object_uuid text)

Determines whether this object is currently inactive.

.. sql:function:: conreality.object_is_located(object_uuid text)

Determines whether this object has a nonzero position.

.. sql:function:: conreality.object_is_moving(object_uuid text)

Determines whether this object has a nonzero linear velocity.

.. sql:function:: conreality.object_is_rotating(object_uuid text)

Determines whether this object has a nonzero angular velocity.

.. sql:function:: conreality.player_deregister(player_uuid uuid)

.. sql:function:: conreality.player_register()

.. sql:function:: conreality.player_register(player_uuid uuid, player_nick text)

.. sql:function:: conreality.point_2d(x float, y float)

.. sql:function:: conreality.point_3d(x float, y float, z float)

.. sql:function:: conreality.point_gps(lon float, lat float)

.. sql:function:: conreality.session_start()

.. sql:function:: conreality.session_terminate()

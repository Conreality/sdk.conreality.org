**************************************************
Conreality Software Development Kit (SDK) for Ruby
**************************************************

The Conreality SDK for Ruby is currently at an early development stage at:
https://github.com/conreality/conreality.rb

.. note::

   Pending the release of a Conreality SDK for Ruby, you can integrate
   Ruby software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (via the Pg_ library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Ruby <https://www.ruby-lang.org/en/>`__ 2.2+
* `Pg <https://rubygems.org/gems/pg>`__ 0.21+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.rb
   :language: ruby

Installation
============

Reference
=========

.. rb:library:: conreality

.. code-block:: ruby

   require 'conreality'

.. rb:module:: Conreality

.. rb:class:: Asset

.. rb:class:: Binary

.. rb:class:: Camera

.. rb:class:: Client

.. rb:class:: Database

.. rb:class:: Event

.. rb:class:: Message

.. rb:class:: Object

.. rb:class:: Player

.. rb:class:: Session

.. rb:class:: Theater

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the Ruby SDK?
-------------------------------------------------------------

See https://github.com/conreality/conreality.rb

Does the Ruby SDK also support Ruby 1.9, 2.0, or 2.1?
-----------------------------------------------------

No, the Conreality SDK for Ruby targets exclusively Ruby 2.2.0 (which was
released in 2014) and newer versions of Ruby.

In case you cannot migrate to Ruby 2.2+, we suggest integrating your legacy
Ruby software with Conreality games by issuing SQL commands over the
PostgreSQL network protocol (via the Pg_ library).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _Pg: https://github.com/ged/ruby-pg

**************************************************
Conreality Software Development Kit (SDK) for Ruby
**************************************************

.. note::

   Pending the release of a Conreality SDK for Ruby, you can integrate
   Ruby software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (via the Pg_ library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.rb
   :language: ruby

Frequently Asked Questions (FAQ)
================================

Does the Conreality SDK support Ruby 1.9, 2.0, or 2.1?
------------------------------------------------------

No, the Conreality SDK for Ruby targets exclusively Ruby 2.2.0 (which was
released in 2014) and newer versions of Ruby.

In case you cannot migrate to Ruby 2.2+, we suggest integrating your legacy
Ruby software with Conreality games by issuing SQL commands over the
PostgreSQL network protocol (via the Pg_ library).
Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

.. _Pg: https://github.com/ged/ruby-pg

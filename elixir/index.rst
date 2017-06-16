****************************************************
Conreality Software Development Kit (SDK) for Elixir
****************************************************

The Conreality SDK for Elixir is currently at a planning stage at:

https://github.com/conreality/conreality.ex

.. note::

   Pending the release of a Conreality SDK for Elixir, you can integrate
   Elixir software with Conreality games by issuing SQL commands over the
   PostgreSQL network protocol (via the Postgrex_ library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.exs
   :language: elixir

Frequently Asked Questions (FAQ)
================================

.. _Postgrex: https://github.com/elixir-ecto/postgrex

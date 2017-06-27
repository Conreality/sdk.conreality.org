********
Concepts
********

This chapter introduces the most important concepts essential to integrating
third-party software with Conreality games.

*For game concepts essential to developing Conreality game scenarios, refer
to the Conreality Game Development Kit (GDK) manual.*

Terminology
===========

Master
------

A Conreality *master* is a game server on the local network that hosts a
game.

Client
------

A Conreality *client* is a software library for connecting to and
communicating with a Conreality master server. The Conreality SDKs for
various supported programming languages each implement and provide a
Conreality client.

A client implementation encapsulates the network protocol implementation,
remote procedure calling (RPC), and authentication/authorization.

In another sense, each game participant (players, as well as smart assets
such as robots and drones) is a client of the master server (as they each
make use of a Conreality client software library).

Session
-------

If a player or smart asset wishes to participate in a game, he/she/it will
make use of a client to establish an authenticated *session* with the master
server. A *login* event begins a session, and a *logout* event terminates
it.

Action
------

Authentication
==============

Authorization
=============

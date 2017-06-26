******************
sdk.conreality.org
******************

.. image:: https://img.shields.io/badge/license-Public%20Domain-blue.svg
   :alt: Project license
   :target: https://creativecommons.org/publicdomain/zero/1.0/

.. image:: https://img.shields.io/travis/conreality/sdk.conreality.org/master.svg
   :alt: Travis CI build status
   :target: https://travis-ci.org/conreality/sdk.conreality.org

|

This is the source repository for the
`Conreality Software Development Kit (SDK) <https://sdk.conreality.org/>`__
manual and website.

All materials herein are released into the
`public domain <https://creativecommons.org/publicdomain/zero/1.0/>`__.

Prerequisites
=============

* Python 3.5+
* `Sphinx
  <https://pypi.python.org/pypi/Sphinx>`__
* `Sphinx Bootstrap Theme
  <https://pypi.python.org/pypi/sphinx-bootstrap-theme/>`__
* `Graphviz
  <http://www.graphviz.org/Download..php>`__

::

   $ pip3 install -U sphinx
   $ pip3 install -U sphinx_bootstrap_theme
   $ brew install graphviz

Building the Manual
===================

::

   $ make html      # HTML output in .build/html/index.html
   $ make latexpdf  # PDF  output in .build/latex/conreality-sdk.pdf
   $ make epub      # EPUB output in .build/epub/conreality-sdk.epub

Publishing the Manual
=====================

::

   $ make clean html publish

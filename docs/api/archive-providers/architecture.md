---
# Mandatory fields.
title: architecture       # (Required) Very important for SEO.
description: Archive providers - architecture # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Archive providers - architecture

## Purpose

The purpose of the Archive Provider system is to fulfill the following requirements:

* Translate from a highly normalized database to a flat data model, suitable for multi-column lists and reports

* Contain significant business logic that affects what rows are fetched and how certain columns are calculated

* Allow columns that are more or less complexly derived from the underlying data

* Offer searchability (the ability to use columns to restrict the rows fetched) on as many columns as possible, including some of those that have a complex relationship to the database

* Generate minimal queries to avoid fetching unnecessary data

* Build up complex data streams from reusable building blocks

* Be extensible, both internally and for partners, in both the row and column dimensions

This is a fairly demanding set of requirements, and it reflects the fact that a lot of the functionality in SuperOffice is expressed through the two-dimensional lists, called *archives*, that you find throughout the application.

The present architecture, framework, and concrete implementation of the archive providers represents somewhat less than one man-year of design and programming, and contain about xxx lines of code. Of that, a large percentage is in base classes that contain common code, and another large chunk is in elementary building blocks that can be combined to form concrete providers.

When a new archive provider is required, it will in many (most?) cases be possible to reuse significant code from the existing system, either through base classes, helper objects, or pieces of existing providers.

The following information was written to explain how and why the system has been put together. There is extensive documentation in the code, that explains the usage of the particular classes, properties, and methods. This explains the whys and hows.

## Interface level

* [Interface definition and composition][5]
* [Data classes][6]
* [Client usage scenarios][7]
* [Metadata][8]

## Providers, extenders, and joiners

The above-listed sections are mostly at the level defined by the interfaces, and thus not bound to any particular implementation. NetServer contains a total of 58 providers, and the vast majority are implemented using a common set of base and helper classes. Most of the providers fetch data from the database, and most of the columns offered by these providers are trivially mapped to database fields. There are a total of about 300 source files with 27.000 lines of code.

To support this functionality, a modular architecture that builds up providers from reusable building blocks was designed and is available to use. This architecture has 5 major components:

* [Providers][1] - the outer level
* [Extenders][2] - one extender handles one table
* [Joiners][3] - compose multiple extenders in a tree structure
* [Base classes][4] - for providers, extenders, and joiners
* Independent [helper classes][4]

<!-- Referenced links -->
[1]: providers.md
[2]: extenders.md
[3]: joiners.md
[4]: base-and-helper-classes.md
[5]: interfaces.md
[6]: data-classes.md
[7]: scenarios.md
[8]: metadata.md

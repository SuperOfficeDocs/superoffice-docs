---
title: NetServer archive providers
uid: archive_providers
description: NetServer archive providers
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: concept
---

# NetServer archive providers

How to use archive providers for simple to complex data sources.

From low-level Objectified-SQL to higher-level business Entities, SuperOffice integrations have several ways to access to SuperOffice data. Complete access to the database through web services, however, is subject to all kinds of security threats and therefore is not a simple problem to solve. Archive providers were later introduced as a means to execute complex queries through web services in a secure and easy-to-use manner. This section describes what they are and how to use them.

## Terminology

An archive provider is a mechanism that delivers data in a form suitable for display or processing as a two-dimensional sheet, much like a spreadsheet. There are several terms used throughout the code that need to be precisely defined:

* A **row** is one row of data, typically displayed as one line. Data is delivered one row at a time to the client.

* Each row consists of one or more **columns**, where each column has a (predictable) name, and several kinds of content (display value, raw value, tooltip, ...)

* Each row also has a name, called an **entity**. The entity name is a string and can be thought of as defining a row type. A provider will always define at least one entity.

* The combination of entity and **primary key** (a 32-bit integer) uniquely identifies a row in the result from a provider

## What is an archive provider

Fundamentally, an archive provider is similar to a database view. They each have a unique name, expose a fixed-set of selectable fields, and mask their join logic. Underneath the hood lies a dynamic system that, based on the requested fields, creates absolute necessary joins only. This of course increases query performance and throughput.

An archive provider is determined by 3 main properties:

* Archive Name
* Available Entities
* Available Columns

**Entities** add a dimension that database views do not possess. They act as an additional **filtering** capability. For example, not all, but several archive providers return rows that are of multiple types. This means that a single query can return rows of details that represent several different types of rows like appointment, sale, and document. On providers that support multiple entities, it possible to tell the provider to only return one or two types of rows, and ignore the rest.

Executing complex queries requires a way to specify criteria, and archive providers do this with **archive restrictions**.

From situations that depend on constructing light-weight data models to performing complex aggregate queries, archive providers are an attractive tool in your tool-belt. They are easy to use data sources and work well for executing a wide variety of queries.

An **archive list** is the UI elements or GUI controls representing columns and restrictions (while the provider is the data source). They are not MDO lists, hence they never have any history.

## Why use an archive provider?

The functionality of an archive provider is basically searching on associate, contact, or project and retrieving any combination of a large number of available columns, arbitrarily sorted.

## Available archive providers

There is a long list of archive providers that give access to virtually the entire database.

The **Find** providers are some of the most common:

* FindAppointment Archive Provider
* FindContact Archive Provider
* FindDocument Archive Provider
* FindProject Archive Provider
* FindSale Archive Provider
* FindSelection Archive Provider

The reference section has a [complete list of archive providers][1].

Namespace is `SuperOffice.CRM.ArchiveLists`.

## Getting started

* [Encoded values][2]
* [How to perform an archive provider query][3]
* [Aggregation][4]

## Deep dive

* [Architecture][5]
* [Interface definition and composition][10]
* [Data classes][11]
* [Client usage scenarios][12]
* [Metadata][13]
* [Providers][6], [Extenders][7], and [Joiners][8]
* [Base and helper classes][9]

<!-- Referenced links -->
[1]: reference/index.md
[2]: encoded-values.md
[3]: how-to-query.md
[4]: data-aggregation.md
[5]: architecture.md
[6]: providers.md
[7]: extenders.md
[8]: joiners.md
[9]: base-and-helper-classes.md
[10]: interfaces.md
[11]: data-classes.md
[12]: scenarios.md
[13]: metadata.md

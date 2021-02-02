---
title: archive_providers
description: NetServer archive providers
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: concept
---

# NetServer archive providers

How to use archive providers for simple to complex data sources.

From low-level Objectified-SQL to higher-level business Entities, SuperOffice integrations have several ways to access to SuperOffice data. Complete access to the database through web services, however, is subject to all kinds of security threats and therefore is not a simple problem to solve. Archive providers were later introduced as a means to execute complex queries through web services in a secure and easy-to-use manner. This section describes what they are and how to use them.

## What is an archive provider

Fundamentally, an archive provider is similar to a database view. They each have a unique name, expose a fixed-set of selectable fields, and mask their join logic. Underneath the hood lies a dynamic system that, based on the requested fields, creates absolute necessary joins only. This of course increases query performance and throughput.

An archive provider is determined by three main properties:

* Archive Name
* Available Entities
* Available Columns

**Entities** add a dimension that database views do not possess. They act as an additional filtering capability. For example, not all, but several archive providers return rows that are of multiple types. This means that a single query can return rows of details that represent several different types of rows like appointment, sale, and document. On providers that support multiple entities, it possible to tell the provider to only return one or two types of rows, and ignore the rest.

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

## Namespace

* SuperOffice.CRM.ArchiveLists

## Continue reading

* [Encoded values][2]
* [How to perform an archive provider query][3]
* [Aggregation][4]

<!-- Referenced links -->
[1]: reference/index.md
[2]: encoded-values.md
[3]: how-to-query.md
[4]: data-aggregation.md

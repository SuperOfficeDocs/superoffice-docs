---
title: archive_providers
description: NetServer archive providers
author: Tony Yates
so.date: 11.17.2017
keywords:
---

# NetServer archive providers

How to use archive providers for simple to complex data sources.

From low-level Objectified-SQL to higher-level business Entities, SuperOffice integrations have several ways to access to SuperOffice data. Complete access to the database through web services, however, is subject to all kinds of security threats and therefore is not a simple problem to solve. Archive providers were later introduced as a means to execute complex queries through web services in a secure and easy-to-use manner. This article describes what they are and how to use them.

## What is an archive provider

Fundamentally, an archive provider is similar to a database view. They each have a unique name, expose a fixed-set of selectable fields and mask their join logic. Underneath the hood lies a dynamic system that, based on the requested fields, only creates joins that are absolutely necessary. This of course increases query performance and throughput.

An archive provider is determined by three main properties:

* Archive Name
* Available Entities
* Available Columns

Entities add a dimension that database views do not possess. They act as an additional filtering capability. For example, not all, but several archive providers return rows that are of multiple types. This means that a single query can return rows of details that represent several different types of rows like appointment, sale and document. On providers that support multiple entities, it possible to tell the provider to only return one or two types of rows, and ignore the rest.

Executing complex queries requires a way to specify criteria, and archive providers do this with Archive Restrictions.

There is a long list of archive providers that give access to virtually the entire database. Some of the most common are the Find providers.

* FindAppointment Archive Provider
* FindContact Archive Provider
* FindDocument Archive Provider
* FindProject Archive Provider
* FindSale Archive Provider
* FindSelection Archive Provider

Please [see the NetServer documentation][1] for a complete list of available archive providers.

From situations that depend on constructing light-weight data models to performing complex aggregate queries, archive providers are an attractive tool in your tool-belt. They are easy to use data sources and work well for executing a wide variety of queries.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-Reference.htm

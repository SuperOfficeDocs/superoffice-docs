---
title: rows      
description: SuperOffice database Rows layer
author: {github-id}             # Your GitHub alias.
keywords:
---

# Rows

All Rows are provided under the `SuperOffice.CRM.Rows` namespace.

A Row represents a row in a table of the database. Rows can contain and expose properties of basic data types only (String, Double, Int, and so on).

## Basic CRUD operations

To **create** a basic Row, you have to use the `CreateNew` method of the `Row` class (that you are going to create). Then you will want to populate its properties with data.

**Retrieving** data from a particular row of a table in the database can easily be done via Rows. Either by using the `Idx` class or the `CustomSearch`.

When data is retrieved through a Row, it is temporarily stored (**cashed**) in the instance. This instance can be used to make changes to the data, but the database is not affected until those changes are **updated** using the `Save()` method.

By using the `Delete()` method, we can delete a Row as well. In this case, it will **delete an entire row** from the database.

## Working with Rows through Entities

An Entity may have properties that are of the type Row. A property of row type directly refers to a particular row of a table.

For example, in the `Sale` Entity, the `Associate` property would refer to the `Associate` table and would contain the columns that are in the `Associate` table as its properties.

## Examples

* [Add list item using rows][1]

<!-- Referenced links -->
[1]: ../lists/add-list-item.md

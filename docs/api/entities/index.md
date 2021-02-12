---
title: entities      
description:                   
author: {github-id}             # Your GitHub alias.
keywords:
---

# Entities

This is the NetServer Entities layer, which uses Entities to represent business objects to the user of NetServer. All Entities are provided under the `SuperOffice.CRM.Entities namespace`.

Entities consist of properties, which can be of basic data types such as `String`, `Double`, and `Int` and of complex types specific to SuperOffice such `Entities`, `Entity Collections`, `Row`, and `Rows`.

Each Entity has its relevant Entity Collection. For example, the Appointment Entity has simple properties like ColorIndex and EndDate. It also has complex properties like Contact (a Contact Entity) and AppointmentText (a TextRow object).

We have divided the properties of an Entity as Basic properties, Entity properties, Row properties, EntityCollection properties and Rows properties.

We show how to perform CRUD operation on an Entity and its properties in multiple ways, but the result will be the same.

## Why use an Entity

Entities such as Contact, Person, and Sale represent business objects. The main advantage of this is that it will help you to convert a business scenario to an IT solution. Further, Entities consist of data collected from multiple tables with the appropriate relationship created, whereas in Row type it consists of data only single table, which would make it difficult for you when developing application solutions. These are some of the considerations to be noted when selecting to use Entities.

## Entity types

Following is a list of the existing entities and their relevant Collection Entities.

| Entity | Collection |
|---|---|
| Appointment | AppointmentCollection |
| Contact | ContactCollection |
| Document | DocumentCollection |
| Person | PersonCollection |
| Project | ProjectCollection |
| ProjectMember | ProjectMemberCollection |
| Sale | SaleCollection |
| Selection | SelectionCollection |

## Basic CRUD operations

To **create** a basic Entity, you have to use the `CreateNew` method of the `Entity` class (that you are going to create). Then you will want to populate its properties with data.

**Retrieving** data from a particular Entity in the database is done either by using the `GetFromIdx` class or the `CustomSearch`.

When data is retrieved through an Entity, it is temporarily stored (**cashed**) in the instance. This instance can be used to make changes to the data, but the database is not affected until those changes are **updated** using the `Save()` method.

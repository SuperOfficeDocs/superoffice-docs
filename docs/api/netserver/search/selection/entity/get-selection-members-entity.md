---
title: retrieve members of a specific selection
uid: get_selection_members_entity
description: How to retrieve members of a specific selection using entities
author: {github-id}
so.date: 05.11.2016
keywords: search,selectionmembers
so.topic: howto
# so.envir:
# so.client:
---

# How to retrieve members of a specific selection using entities

This example shows how to retrieve a Members Collection using an instance of the `Selection` class.

[!code-csharp[CS](includes/get-members-entity.cs)]

An instance of the `Selection` class is created from `selection_id` 58. It is an entity object for the `selection` table in the database and the objects represent full entities with both the base table objects and all related objects. Using `GetFromIdxSelectionId()`, it creates a new instance of the `Selection` object by querying the database table via the index `IDXSelId`. The intention is to make it easy to use efficient queries that match the database index.

Once we have created the instance, we may access the `SelectionMembers` property of the `Selection` entity, which is of Rows data type, and manipulate its content. The output produced by the above code is as follows.

| SelectionId | ContactId | Name | NameDepartment |
|---|---|---|---|
|58 | 2   | StateZeroDatabase  | StateZeroDatabase |
|58 | 43  | Uniformeffekter AS | Uniformeffekter AS, UAvdeling |
|58 | 123 | Japanese Company   | Japanese Company, Tokyo |

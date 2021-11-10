---
title: Update a person with a new name, address, position using services
uid: update_person_ws
description: How to update a person with a new name, address, position using NetServer services.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: person, contact, services, API api-services, GetPersonEntity, PersonAgent
so.topic: howto
# so.envir:
# so.client:
---

# Update a person with a new name, address, position using services

Let's discuss how we can update the name, address, and position of an existing person using NetServer services.

At the services layer, Person details can be updated only in one way: by using the `PersonAgent` and its `SavePersonEntity` method.

## Code

[!code-csharp[CS](includes/update-person-services.cs)]

## Walk-through

We need to use the `GetPersonEntity` method available in the `PersonAgent` to retrieve the `PersonEntity` that needs to be updated.

Once the Entity is retrieved, the properties that are exposed can be updated. The example shows how we can update different types of properties exposed by the `PersonEntity`.

Entity types consist of simple data types such as String, Boolean, DateTime, and int and complex data types consisting of types such as LocalizedFields and EntityElement types.

## Updating simple data types

Simple data types can be updated with basic statements as shown below.

[!code-csharp[CS](includes/update-person-services.cs?range=16-17)]

## Updating complex data types

However, complex data types cannot be modified in such a way. For example, if we need to update the `Address` property of the `Person` we need to first create a localized field array and store the new address in the declared variable. Only once this is done can it be assigned to the Address property of the `PersonEntity`.

[!code-csharp[CS](includes/update-person-services.cs?range=20-22)]

Another example of a complex type is properties, which are of entity element types. In the above example, we have created an `EntityElement` array and assigned values to the properties of the declared variable.

[!code-csharp[CS](includes/update-person-services.cs?range=29-32)]

Once the assignment is done, the created email can be added to `Emails` property of the `PersonEntity` by executing the statement below.

[!code-csharp[CS](includes/update-person-services.cs?range=35)]

The above would appear as a new email in the emails list of the Person. However, if we are required to modify an already existing email the goal could be archived as follows.

[!code-csharp[CS](includes/update-person-services.cs?range=38-39)]

Here we give the index of the Person’s Email location that needs to be changed.

[!code-csharp[CS](includes/update-person-services.cs?range=42)]

With the execution of the above statement, a value will be assigned to the `Position` property of the Person.

> [!NOTE]
> `Position` property uses pre-defined SuperOffice values, which are different from the title.

Once the required properties of the `PersonEntity` have been modified the modifications could be saved to the database with the execution of the below statement.

[!code-csharp[CS](includes/update-person-services.cs?range=45)]

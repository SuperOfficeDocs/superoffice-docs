---
title: Create a Contact using services
uid: create_contact_services
description: How to create a contact using services.
author: {github-id}
so.date: 11.04.2021
keywords: contact, company, services, API, api-services, ContactAgent, CreateDefaultContactEntity
so.topic: howto
# so.envir:
# so.client:
---

# Create a Contact using services

This example shows how to create a new contact and assign values to the properties of the entity through the NetServer Services layer.

## Code

[!code-csharp[CS](includes/create-contact-services.cs)]

## Walk-through

Here we have used a `ContactAgent` and the `CreateDefaultContactEntity` method to create a new contact entity with default values filled in. We first set some of the basic values like name and department.

Then we have set values to properties of complex data types such as `EntityElement[]` types, entity types such as `Associate`, entity collection types such as `Persons`, and `LocalizedField` types.

Finally, the newly created contact entity is saved to the database using the `SaveContactEntity` method of the agent. With this, a new record will be added to the contact table in the database with its fields set to values that have been assigned.

The entity is returned with the allocated ID filled in.

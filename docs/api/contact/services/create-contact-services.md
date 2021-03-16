---
# Mandatory fields.
title: create_contact_services       # (Required) Very important for SEO.
description: Create a contact using services  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 
keywords: api-services
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a Contact using services

This example shows how to create a new contact and assign values to its properties of the entity through the NetServer Services layer.

## Code

[!code-csharp[CS](includes/create-contact-services.cs)]

## Walk-through

Here we have used a `ContactAgent` and the `CreateDefaultContactEntity` method to create a new contact entity with default values filled in. We first set some of the basic values like name and department.

Then we have set values to properties of complex data types such as `EntityElement[]` types, entity types such as `Associate`, entity collection types such as `Persons`, and `LocalizedField` types.

Finally, the newly created contact entity is saved to the database using the `SaveContactEntity` method of the agent. With this, a new record will be added to the contact table in the database with its fields set to values that have been assigned.

The entity is returned with the allocated ID filled in.

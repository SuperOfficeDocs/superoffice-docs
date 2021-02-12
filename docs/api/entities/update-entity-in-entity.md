---
title: update_entity_in_entity
description: How to update an Entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Update an Entity through an Entity

There can be more than one way to update an Entity property that is exposed by another Entity.

## Update an Entity through a property exposed by another Entity

This example retrieves a Sale Entity by calling the `GetFromIdxSaleId` method. Then it accesses and modifies some basic properties of the Contact Entity through the Sale Entity.

[!code-csharp[CS](includes/update-entity-1.cs)]

### Business

The business property on the `Contact` of the `Sale` Entity is Row type. This means that it represents a row in the `Business` table.

In the example, a Business row is retrieved and assigned to the contact after which its properties are modified through the `Sale` Entity.

If the Sale Entity’s Contact has a `Business` already assigned, there is no need to create a new Business Row and assign it.

### Phones

The Sale Entity’s Contact has a property called `Phones`, which consists of multiple phone rows of type `PhoneRow`.

The example shows how to create a phone row and assign it to a Contact’s `Phones` property using the `Add` method.

The added values are modified through the `Sale` Entity by indexing the `Phones` property of the `Contact`.

### Persons

The `Persons` property is similar to the Phones property. However, it differs in that Persons consists of Entities of persons as opposed to Rows.

Using the `CreateNew` method, a new Person entity is created and assigned to the Sale Entity’s Contact’s Persons property. These statements can be avoided if the Contact’s Persons property already consists of data.

The next few statements relate to changing different types of properties contained in the `Persons` Entity through the Sale Entity.

> [!NOTE]
> The Sale entity is saved by calling `Save()` method. Any modifications made to properties such as Contact Entity and Person Entity above will also be saved.

## Update an Entity and assign it as a property of an Entity

This example creates a Business Row and modifies its values. It is then assigned to the Person Entity’s Business property.

[!code-csharp[CS](includes/update-entity-2.cs)]

### IsDirty

The `IsDirty` property of the modified contact is used to check whether any modifications happened, and only if so, to assign it to the Person Entity’s Contact property.

### Emails

The `Emails` property of the `Person` Entity may consist of any amount of email addresses that the person possesses. The data is of EmailRow type, thus we have to create an instance of EmailRow, assign values to it, and then assigned it to the Emails Property of the Person Entity.

## See also

* [Update a basic property of an Entity][1]
* [Update a Row through an Entity][2]

<!-- Referenced links -->
[1]: update-entity.md
[2]: ../rows/update-row-in-entity.md

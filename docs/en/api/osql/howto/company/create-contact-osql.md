---
uid: create-contact-osql
title: Create a contact through OSQL
description: How to create a contact through OSQL
keywords: contact, company, OSQL, API
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from: /en/company/howto/osql/create-contact-osql
---

# Create a contact through OSQL

[!include[import OSQL namespaces](../../../includes/using-osql.md)]

The following example shows how we could create a contact using OSQL.

## Code

[!code-csharp[CS](includes/create-contact-osql.cs)]

## Walk-through

After importing the required namespaces, you need to create a dataset of the required tables. In this case, the `contact` table.

[!code-csharp[CS](includes/create-contact-osql.cs?range=8)]

The next step is to create an instance of the `Insert` class that is used to update the `contact` table.

[!code-csharp[CS](includes/create-contact-osql.cs?range=11)]

After the `Insert` instance has been created the required field should be added with the `Add` method of the `FieldValuePairs` property exposed in the `Insert` class. The column name and the value should be passed as shown below:

[!code-csharp[CS](includes/create-contact-osql.cs?range=14-15)]

Once all required fields have been added, we create an `SoConnection` instance with the use of the `ConnectionFactory`, `GetConnection` method.

[!code-csharp[CS](includes/create-contact-osql.cs?range=29)]

Next, we create `SoCommand` and `SoTransaction` instances as shown below and assign the instantiated transaction to the `Transaction` property of the instantiated `SoCommand`.

[!code-csharp[CS](includes/create-contact-osql.cs?range=32-33,36-37)]

To execute the created insert statement we need to assign it to the `SqlCommand` property of the created `SoCommand` instance and then execute the `ExecuteNonQuery` method of it.

[!code-csharp[CS](includes/create-contact-osql.cs?range=40-41)]

Once the command has been executed, the transaction will be committed and the connection made to the database will be closed.

[!code-csharp[CS](includes/create-contact-osql.cs?range=44-45)]

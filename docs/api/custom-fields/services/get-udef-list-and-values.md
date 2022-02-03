---
title: Get all user-defined fields
uid: get_udef_list_and_values_services
description: How to display all user-defined fields using services.
author: Bergfrid Skaara Dias
so.date: 11.05.2021
keywords: udef, user-defined field, custom field, API, api-services, GetUserDefinedFieldList, UserDefinedFieldInfoAgent, UserDefinedFieldInfo
so.topic: howto
# so.envir:
# so.client:
---

# How to display all user-defined fields

This example shows how to get all the user-defined fields along with the field values on a given contact.

![02 -screenshot][img1]

## Code

[!code-csharp[CS](includes/get-udef-list-and-values-services.cs)]

## Walk-through

In the above example, we have used the `GetUserDefinedFieldList` method of `SuperOffice.CRM.Services.IUserDefinedFieldInfoAgent` to get the user-defined field list. This method returns information about all the user-defined fields on a particular owner type (such as project, contact, and person). We have specified Contact as the type, as shown below:

[!code-csharp[CS](includes/get-udef-list-and-values-services.cs?range=27)]

Then we loop through the `UserDefinedFieldInfo` collection to get the field label and the corresponding value for each user-defined field.  The contact entity has a string dictionary of user-defined data. The `ProgId` of the user-defined field is passed to the udef field data dictionary to get the corresponding field value:

[!code-csharp[CS](includes/get-udef-list-and-values-services.cs?range=32-37)]

<a href="../../assets/downloads/getalluserdefinedfieldsonacontact.zip" download>Click to download source code (zip)</a>

<!-- Referenced images -->
[img1]: media/image002.jpg

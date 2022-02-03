---
title: Set a user-defined list item on a Udef field
uid: set_udef_listitem_value_ws
description: How to set a user-defined list item on a Udef field using services
author: Bergfrid Skaara Dias
so.date: 11.05.2021
keywords: udef, user-defined field, custom field, API, api-services, ContactAgent, GetContactEntity, GetUserDefinedFieldFromProgId, SaveContactEntity, MDOAgent, MDOListItem
so.topic: howto
# so.envir:
# so.client:
---

# How to set a user-defined list item on a Udef field (services)

This example demonstrates how to set a user-defined list item value on a user-defined field on a given **contact** using Net Server services.

We will be using the user-defined field `Udlist one` and populate a list box with the list items for it. When an item is picked from the list box, the selected value is displayed. Clicking the **Save** button will set the selected value to the user-defined field `Udlist one` for the contact.

The following screenshot shows how the application displays the list of values for the given user-defined field.

![Application displays the list of values for the given user-defined field -screenshot][img1]

## Populate the list box

[!code-csharp[CS](includes/populate-listbox-services.cs)]

The above code segment shows how the population of the list box is done using the `GetList` method of `SuperOffice.CRM.Services.IMDOAgent`. This method accepts a custom list ID and returns the item array of the same:

[!code-csharp[CS](includes/populate-listbox-services.cs?range=27)]

Next, we have set the `MDOListItem` array as the data source for the list box:

[!code-csharp[CS](includes/populate-listbox-services.cs?range=30-32)]

## Set the user-defined field value

This section explains how the value selected on the list box is set as the user-defined field value.

[!code-csharp[CS](includes/set-udef-services.cs)]

We have retrieved the `UserDefinedFields` collection for the contact of interest. This is a dictionary that holds the user-defined field data as a key-value pair where the key string is the `ProgId` of the UdefField. Thus the selected value is filled against the `ProgId` of the UdefField `Udlist one` as shown below.

[!code-csharp[CS](includes/set-udef-services.cs?range=14-18)]

Finally, the `SaveContactEntity` method is called to update the contact entity.

<a href="../../assets/downloads/setudeflistitem.zip" download>Click to download source code (zip)</a>

<!-- Referenced images -->
[img1]: media/image003.jpg

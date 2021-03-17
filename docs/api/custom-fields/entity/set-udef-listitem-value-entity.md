---
# Mandatory fields.
title: set_udef_listitem_value_entity       # (Required) Very important for SEO.
description: How to set a user-defined list item on a Udef field using entities # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords: udefhelper
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to set a user-defined list item on a Udef field

This example demonstrates how to set a user-defined list item value on a user-defined field on a given **contact**.

We will be using the user-defined field `companydropdownlistbox` and populate a list box with the list items for it. When an item is picked from the list box, the selected value is displayed. Clicking the **Save** button will set the selected value to the user-defined field `companydropdownlistbox` for the contact.

The following screenshot shows how the application displays the list of values for the given user-defined field.

![01][img1]

## Populate the listbox

[!code-csharp[CS](includes/populate-listbox-entity.cs)]

The above code segment shows how the population of the list box is done. To get the list items, the base class for the list table should be identified. This is retrieved with the `ListTableId` property of the udef field. Based on that ID, the `Task` table is identified as the base class for getting the list items.

As shown below, the `TaskRows` are retrieved for the given table ID using the `GetFromCustomSearch` method of the `TaskRow` entity. Next, we have set the collection as the data source for the list box.

[!code-csharp[CS](includes/populate-listbox-entity.cs?range=29-30)]

## Set the user-defined field value

[!code-csharp[CS](includes/set-udef-entity.cs)]

We have used the `SetValue` method of the `UdefHelper` of the contact to set the selected value. This method accepts the `progId`, which is used to refer a particular field, and the value to set as the updated value for the field.

Next, the `Save` method of the `Contact` entity is used to update the contact entity.

<!-- [Source code SetUDefinedListItemOnUdefField (zip)](SetUDefinedListItemOnUdefField.zip) -->

<!-- Referenced images -->
[img1]: media/image001.jpg

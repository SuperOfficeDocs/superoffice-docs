---
# Mandatory fields.
title: create_contact_interest       # (Required) Very important for SEO.
description: How to add a new contact interest  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: interest,rows
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to add a new contact interest

You can extend the list of interests for a contact by creating and adding a new interest to that list. Here, we use the `SuperOffice.CRM.Rows` namespace.

When adding a new contact interest, new rows should be added to multiple tables such as `ContInt`, `ContactInterest`, `ConIntGroupLink`, and the `ContIntHeadingLink` table.

> [!NOTE]
> This is not the same as setting an existing interest on.

## Code

The code segment below shows us how to add an interest to an existing list.

[!code-csharp[CS](includes/add-interest.cs)]

## Walk-through

Above, we first create `ContIntRow` using the `CreateNew` method and assign values to its properties. Then we save it using the `Save` method available in the `ContIntRow` class.

Next, we create a `ContactInterestRow` and assign the ID of the earlier created `ContIntRow` to the `ContactInterestRow`’s `CinterestIdx`. We also assign the `ContactId` property to the ID of contact as well.

### ContIntGroupLinkRow

Next, we need to create a `ContIntGroupLinkRow`. Here we assign the group ID of the currently logged in associate. But if you wish to add multiple groups for which the contact interest will be visible, the following code segment may be useful.

```csharp
int[] groupIds = { 2, 3, 4, 5, 6 };
ContIntGroupLinkRows newContGrpLinkRows =
ContIntGroupLinkRows.GetFromIdxContIntId(newConInt.ContIntId);
foreach (int groupId in groupIds)
{
  ContIntGroupLinkRow newContGrpLinkRow = newContGrpLinkRows.AddNew();
  newContGrpLinkRow.SetDefaults();
  newContGrpLinkRow.GroupId = groupId;
  newContGrpLinkRow.Save();
}
```

### ContIntHeadingLinkRow

Finally, we need to create a `ContIntHeadingLinkRow`. This is necessary because the `ContInt` is defined as a sub-item, we would need to create a heading that it should fall under.

This is done calling `CreateNew()`in the `ContIntHeadingLinkRow` class and assigning values to its properties.

## Result

Once the example code is executed, the following rows will be added to the tables as shown below.

**ContInt table:**

![01][img1]

**ContactInterest table:**

![02][img2]

**ConIntGroupLink table:**

![03][img3]

**ContIntHeadingLink table:**

![04][img4]

<!-- Originally written for NetServer 3.0 -->

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/image003.jpg
[img4]: media/image004.jpg

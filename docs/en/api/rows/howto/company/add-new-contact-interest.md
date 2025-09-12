---
uid: create-contact_interest
title: How to add a new contact interest
description: How to add a new contact interest with rows.
keywords: company, contact, interest, API, row, ContIntRow, ContactInterestRow, ContIntGroupLinkRow, ContIntHeadingLinkRow
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/company/howto/row/add-new-contact-interest
  - /en/api/netserver/rows/howto/company/add-new-contact-interest
---

# How to add a new contact interest

When adding a new [contact interest][1], new rows should be added to multiple tables such as `ContInt`, `ContactInterest`, `ConIntGroupLink`, and the `ContIntHeadingLink` table. Here, we use the `SuperOffice.CRM.Rows` namespace.

> [!NOTE]
> This is not the same as setting an existing interest on.

## Code

The code segment below shows us how to add an interest to an existing list.

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;
using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieve a Contact
  Contact newContact = Contact.GetFromIdxContactId(10);

  //Create a new ContIntRow. Each row represents one row in the ContInt table.
  ContIntRow newConInt = ContIntRow.CreateNew();
  newConInt.SetDefaults();
  newConInt.ElementType = MDOListElementType.SubNode;
  newConInt.Name = "Sam's Interest";
  newConInt.Tooltip = "Sam's Interests";
  newConInt.Save();

  //Create a New ContactInterestRow. Each row represents one row in the ContactInterest table.
  ContactInterestRow newconIntRw = ContactInterestRow.CreateNew();
  newconIntRw.SetDefaults();
  newconIntRw.CinterestIdx = newConInt.ContIntId;
  newconIntRw.ContactId = newContact.ContactId;
  newconIntRw.EndDate = DateTime.MaxValue;
  newconIntRw.StartDate = DateTime.MinValue;
  newconIntRw.Save();

  //Create a new ContIntGroupLinkRow. Each row represents one row in the ContIntGroupLink table.
  // You would need to create a new row for each group that you require the interest to be visible for.
  ContIntGroupLinkRow newContGrpLink = ContIntGroupLinkRow.CreateNew();
  newContGrpLink.SetDefaults();
  newContGrpLink.ContIntId = newConInt.ContIntId;
  newContGrpLink.GroupId = SoContext.CurrentPrincipal.GroupId;
  newContGrpLink.Save();

  //Since the ContInt is defined as a SubItem, we need to give a header to fall under.
  //For this we create a new ContIntHeadingLinkRow. Each row represents one row in the ContIntHeadingLink table.
  ContIntHeadingLinkRow newContHeadingRow = ContIntHeadingLinkRow.CreateNew();
  newContHeadingRow.SetDefaults();
  newContHeadingRow.ContIntId = newConInt.ContIntId;

  //looking up and assigning the heading Id.                  
  newContHeadingRow.HeadingId = newContact.InterestHelper.HeadingItems[0].Heading.Id;
  newContHeadingRow.Save();
}
```

## Walk-through

Above, we first create `ContIntRow` using the `CreateNew` method and assign values to its properties. Then we save it using the `Save` method available in the `ContIntRow` class.

Next, we create a `ContactInterestRow` and assign the ID of the earlier created `ContIntRow` to the `ContactInterestRow`’s `CinterestIdx`. We also assign the `ContactId` property to the ID of contact as well.

### ContIntGroupLinkRow

Next, we need to create a `ContIntGroupLinkRow`. Here we assign the group ID of the currently logged-in associate. But if you wish to add multiple groups for which the contact interest will be visible, the following code segment may be useful.

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

This is done by calling `CreateNew()`in the `ContIntHeadingLinkRow` class and assigning values to its properties.

## Result

Once the example code is executed, the following rows will be added to the tables as shown below.

**ContInt table:**

| ContInt_id | name | rank | tooltip | deleted | registered | ...|
|---|---|---|---|---|---|---|
| 1 | Reference cust. | 1 | Referansekunde | 0 | 0 | |
| 2 | Prestige cust. | 2 | Prestisjekunde | 0 | 0 | |
| 3 | Big customer | 3 | Storkunde | 0 | 0 | |
| 4 | Sam's Interest | 0 | Sam's Interests | 0 | 1214207393 | |

**ContactInterest table:**

| contactinterest_id | contact_id | cinterest_idx | startDate | endDate | flags | registered |
|---|---|---|---|---|---|---|
| 6 | 1 | 4 | 0 | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 1 | 1 | 1 | 0 | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 2 | 4 | 2 | 0 | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |
| 3 | 9 | 3 | 0 | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |

**ConIntGroupLink table:**

| contintgrouplink | contint_id | group_id | registered | registered_associate | ... |
|---|---|---|---|---|---|
| 1 | 4 | 1 | 1214207393 | 103 | |

**ContIntHeadingLink table:**

| contintheadinglink | contint_id | heading_id | registered | registerred_ass | ... |
|---|---|---|---|---|---|
| 1 | 4 | 24 | 1214207393 | 103 | |

<!-- Originally written for NetServer 3.0 -->

<!-- Referenced links -->
[1]: ../../../../company/dev/index.md#interests

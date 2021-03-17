---
title: visiblefor_flag
description: VisibleFor flag
author: {github-id}
keywords: sentry
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# VisibleFor flag

In SuperOffice, you can restrict access to a data item using the `VisibleFor` flag in addition to the user group’s rights to data.

The `VisibleFor` flag and role-base security go hand in hand. When the flag is set it is a combination of role-base access rights and access rights that was activated due to setting the flag.

## Visibility levels

The `VisibleFor` flag can be set at 3 levels:

* All
* Group
* Associate

**Group** means the group that a particular associate belongs to in a given company defined in SuperOffice. For example, Administration, Marketing, Sales, or Service". You may have sufficient rights from the role to see something, but if the data is flagged with `VisibleFor=Associate`, the data may be seen only by the associate that owns the data.

## Example 1 (associate)

To explain the `VisibleFor` flag and how it affects data access rights, let's look at an example.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Security;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //create a sale
  Sale mySale = Sale.CreateNew();
  mySale.SetDefaults();
  //give the sale a heading
  mySale.Heading = "To Test VisibleFor Flag";
  //make the sales visible for property to associate so it will be set
  //to logged in associate
  EntityVisibleForHelper saleVisibleFor = mySale.VisibleForHelper;
  saleVisibleFor.VisibleFor = EntityVisibleForHelper.VisibleForType.Associate;
  //save the sale
  mySale.Save();
}
```

This creates a new sale and makes it visible for only the signed-in user (SAL0).

* SAL0 belongs to role 0, which has all the rights on all data (think administrator group)
* SAL0 belongs to the Marketing department in the company that they're employed at.

After executing the above code, this particular sale belongs to user SAL0.

Now, what will happen if we introduce another user (ANN), which also belongs to role 0 and the Marketing department? The new user will not be able to gain access to this sale even though she has all access to all the data in the database. Surprised? From the role she gets Create, Read, Update, and Delete (CRUD) rights for the data item. But because the `VisibleFor` flag is set, she doesn't get any rights. Thus, there is no common denominator between the two rights and ANN does not get any right at all on this sale.

## Example 2 (group)

Now we'll modify the code above and set the `VisibleFor` property to the **group** that user SAL0 belongs to:

```csharp
EntityVisibleForHelper saleVisibleFor = mySale.VisibleForHelper;
saleVisibleFor.VisibleFor = EntityVisibleForHelper.VisibleForType.Group;
```

This makes the sale visible for only the group members that belong to the same group as the authenticated user SAL0.

Now, if another user who belongs to the same group in the company and belongs to a role that has access rights to data that belongs to user group members he will have access to this sale. This happens because from the `VisibleFor` flag, we can explicitly say that this sale can be viewed by all the group members but that is only viewing the actual rights come from the role that a particular associate belongs to. If an associate belonging to the same group but belongs to a role that does not have rights to a sale other than Read, he will not be able to change any data on the sale.

## Example 3 (all)

Last, let’s discuss what will happen if the above sale `VisibleFor` property was set to *All* like this:

```csharp
EntityVisibleForHelper saleVisibleFor = mySale.VisibleForHelper;
saleVisibleFor.VisibleFor = EntityVisibleForHelper.VisibleForType.All;
```

In this situation, all associates that are listed in the system will be able to view this sale. But as before, the right to the data will be determined by the roles that each associate belongs to.

For example, if an associate belongs to a role that has the right only to view a sale, that associate will not be able to modify any of the data in the sale.

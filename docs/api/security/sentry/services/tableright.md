---
title: TableRight (services)
uid: sentry_tableright
description: Sentry in services - TableRight property
author: Bergfrid Dias
so.date: 12.02.2021
keywords: Sentry, SOAP, security, TableRight
so.topic: concept
so.area: api-services
---

# TableRight (services)

The `TableRight` property focuses on the table as a whole. It has mechanisms to determine whether the logged-in user has the rights to the table.

A typical use of this property is as follows: imagine you have a full form of fields that are of contact information. If a particular user logging in does not have the right to change data, you can make all the fields disabled.

Below is an example that demonstrates the use of this property.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("sal0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //retrieve the entity you want
    ContactEntity myEntity = contactAgent.GetContactEntity(4);

    //check to see if the user has the right to update the table.
    //if not disable the data fields
    if (!myEntity.TableRight.HasUpdate)
    {
      txtBusiness.Enabled = false;
      txtCategory.Enabled = false;
    }
  }
}
```

Here we have used the `TableRight` property to check whether the user has sufficient rights to the table. If he does not, we don’t let him update the data.

It’s easier to check the rights of the table than checking each field if you are trying to restrict updates to an entire table since it is easy checking the right of the table than checking each field by field.

> [!NOTE]
> If you let the user do some operation that the user does not have proper rights to, NetServer will throw errors so it is always good to check for data rights before we let a user do some operation.

## TableRight as enum

We recommend that you create an enum that looks like the code listed below. Feel free to copy this code and use it in your client. This is C# .NET, please modify to suit the language of choice.

[!code-csharp[CS](includes/ETableRight.cs)]

So let’s say that you get the value "51" in the `Right` property of the `TableRight`. The XML returned from our service would look like this:

```XML
<TableRight>
  <Right>51</Right>
  <Reason />
</TableRight>
```

So what does this value *51* tell us? In case you are unfamiliar with bit flags and how to calculate the value of them, I’ll run through it. We will start at the bottom of the list and subtract the value of the table right if it is smaller than or equal to our 16-bit integer `Right` value.

Using this algorithm, we find that `Uninitialized` is not a part of our table rights as it is larger than 51. `RestrictedUpdate` on the other hand is smaller than 51 and when subtracted we are left with 19. This means that `RestrictedUpdate` is a part of our table rights. `Filtering` is smaller than 19, which leaves us with 3 after adding `Filtering` to our table rights. Both `Delete` and `Insert` are larger than three, which leaves us with `Update` and `Select` as our final table rights. So 51 means that the user has the following table rights: Select, Update, Filtering, and RestrictedUpdate.

Programmatically, this is done more elegantly. The bitwise AND operator *&*, enable you to do this quite easily using the previously defined `ETableRight` enumeration. Let’s say that you want to verify that a user has Delete table rights. It would look something like this:

```csharp
ETableRight right;

if( (right & ETableRight.Delete) == ETableRight.Delete )
  //Delete something :)
```

What you do here is that you perform a logical bitwise AND operation on the bit representing Delete. If the result equals the value of Delete, that table right is present in the 16-bit integer representing the user's table rights.

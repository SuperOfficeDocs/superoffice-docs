---
title: Table rights in SOAP (3.1)
uid: soap_table_rights
description: Table rights in SOAP
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: 
---

# Table rights in SOAP (3.1)

We recommend that you create an enum that looks like the code listed below. Feel free to copy this code and use it in your client. This is C#.Net, please modify to suit the language of choice.

```csharp
[Flags]
public enum ETableRight
{
  /// <summary>
  /// The row should be hidden from the user.
  /// </summary>
  None = 0,
  /// <summary>
  /// The user is allowed to see the row.
  /// </summary>
  Select = 1,
  /// <summary>
  /// The user is allowed to modify the values in this row.
  /// Applies to rows with id > 0.
  /// Row with id = 0 needs insert rights instead.
  /// </summary>
  Update = 2,
  /// <summary>
  /// The user is allowed to add new rows to the table.
  /// Implies update rights on a row with id = 0.
  /// </summary>
  Insert = 4,
  /// <summary>
  /// The user is allowed to delete this row.
  /// </summary>
  Delete = 8,
  /// <summary>
  /// A flag used to indicate that some fields may be hidden.
  /// The user has no Select access, but he will have Filtering.
  /// Used on rows where the visibility flag may affect what the user can see
  /// (e.g.: private appointments).
  /// </summary>
  Filtering = 16,
  /// <summary>
  /// A hint flag used to indicate that some fields may not be updatable, even though
  /// the user has update access to the row.
  /// Used on rows where some fields are locked down by business rules or integrity constraints.
  /// (e.g.: the database owner contact.name field is read-only. An invitation's contact id is read-only)
  /// </summary>
  RestrictedUpdate = 32,
  /// <summary>
  /// Magic value to indicate not initialized
  /// </summary>
  Uninitialized = 128,
};
```

So let’s say that you get the value “51” in the `Right` property of the `TableRight`. The XML returned from our service would look like this:

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
ETableRight right ;

if( (right & ETableRight.Delete) == ETableRight.Delete )
  //Delete something :)
```

What you do here is that you perform a logical bitwise AND operation on the bit representing Delete. If the result equals the value of Delete, that table right is present in the 16-bit interger representing the user's table rights.

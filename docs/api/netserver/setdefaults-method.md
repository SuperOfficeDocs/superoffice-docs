---
# Mandatory fields.
title: netserver_setdefaults       # (Required) Very important for SEO.
description: SetDefaults method best practices # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords: entity,row
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SetDefaults method

Using the `SetDefaults` method when inserting data either to Entity or Row types, could be identified as a good practice.

If `SetDefault()` was not used, the programmer would have to make use of flow-control structures such as if-else blocks to handle situations where the user doesn’t enter any values.

## Example

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Creating a Contact Entity
  Contact newContact = Contact.CreateNew();

  //Sets default values - Good Practice
  newContact.SetDefaults();

  newContact.Name = "Jazz";
  
  //Creating instances of Row types
  EmailRow newEmail1 = EmailRow.CreateNew();
  newEmail1.EmailAddress = "ally@alley.com";
  newEmail1.Description = "Ally's E mail";
  EmailRow newEmail2 = EmailRow.CreateNew();
  newEmail2.EmailAddress = "Anakin@star.com";
  newEmail2.Description = "Anakin's test email";

  PhoneRow newPhone = PhoneRow.CreateNew();
  newPhone.Description = "Jazz's phone number";
   newPhone.Phone = "9771252307";

  //Adding the Row types to the Contact
  newContact.Emails.Add(newEmail1);
  newContact.Emails.Add(newEmail2);
  newContact.Phones.Add(newPhone);

  //Saving the Entity
  newContact.Save();
}
```

Here, we have created a new `Contact` Entity and used the `SetDefaults` method. Because of this, NetServer will fill certain properties of the Entity such as Updated date and Updated Associate.

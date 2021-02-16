---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: why_datadriven_data       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Why Data-Driven data # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Why data-driven data

In the SuperOffice application, we can have user-defined fields. When we have a set of fields that is constantly changing, we will face a problem with returning these fields in our web service methods because we cannot change web service methods when someone defines a new field. To avoid this situation, SuperOffice has introduced the concept of data-driven data in the NetServer.

In NetServer all the user-defined fields have been packed into a single property of entity by using a string dictionary. If we take the `contact` entity, it will have a property called `UserDefinedFields` which represents all the user-defined fields. In the context of the `contact` entity, this property will house all the user-defined fields of the contact entity as key-value pairs.

## Get all user-defined fields of an entity

The below example illustrates how we can retrieve the entire user-defined fields in the `contact` entity.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //get a contact you want
    ContactEntity contactEntity = contactAgent.GetContactEntity(43);

    //get the full set of UserDefinedFields to a string dictionary
    StringDictionary userDefinedFields = contactEntity.UserDefinedFields;
  }
}
```

From the above example, we have retrieved the entire set of user-defined fields that have been defined for a contact. If you define a user-defined field for the contact it is common for all the contacts. The values for each user-defined field will differ from contact to contact.

## Get valuer of a user-defined field

Now the question remains how we retrieve a value of a user-defined field. For this SuperOffice has provided us with an agent called `UserDefinedFieldInfoAgent`. By using this agent we can retrieve the values of any user-defined field.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //get a contact you want
    ContactEntity contactEntity = contactAgent.GetContactEntity(43);

    //get the full set of UserDefinedFields to a string dictionary
    StringDictionary userDefinedFields = contactEntity.UserDefinedFields;

    //create a User Defined Field Info Agent
    using(UserDefinedFieldInfoAgent udefAgent = new UserDefinedFieldInfoAgent())
    {
      //retrieve the User Defined Field Info for the given label text
      UserDefinedFieldInfo udefInfo = udefAgent.GetUserDefinedFieldFromFieldLabel("companyshorttext", 7);

      //retrieve the value using the progid of the field
      string valUdef = userDefinedFields[udefInfo.ProgId.ToString()]; 
    }
  }
}
```

In the above example, we can see that we have used the label text in the UI to retrieve the user-defined field info. The first parameter is the label text and the second parameter is to specify where this user-defined field exists. For example, in the contact or project table. The number is defined by NetServer below is a list of numbers that we can use.

* Contact – 7
* Project – 8
* Person – 9
* Sale – 10
* Appointment – 12
* Document - 13

When we have the field info we can retrieve the `progid` and then we can retrieve the value using that.

> [!NOTE]
> Using the label text to retrieve the field info can be bit messy since it can have trailing spaces, leading spaces and commas etc… that you may not notice. NetServer helps us by ignoring the trailing spaces, commas, and some other characters when searching. It is advised that you give extreme care when specifying the label text.

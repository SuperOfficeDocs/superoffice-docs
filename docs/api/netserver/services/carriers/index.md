---
uid: netserver-service-carriers
title: NetServer Service Carriers       
description: Carriers
author: AnthonyYates             # Your GitHub alias.
keywords:
so.topic: concept
---

# NetServer Service Carriers

A **carrier** is an object that will carry the data between the [Agent][1] and the NetServer services.

There are 2 kinds of carriers: simple read-only carriers and complex entity carriers. Complex entity carriers can be updated and sent back for saving to the database, while simple read-only carriers cannot be saved back to the database.

## Read-only carriers

A read-only carrier is a simple object. It exposes its properties primarily as simple string values. A read-only carrier will expose the country property as a country name and not as a country sub-object.

The advantage of the read-only carrier is its simplicity and you can avoid many overheads by working with an entity carrier.

Below is an example that displays how to load a read-only carrier using an Agent.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
Contact myContact = contactAgent.GetContact(4);
string myContactName = myContact.Name;
string myContactCategory = myContact.CategoryName;
string myContactWebUrl = myContact.URL;
```

In the above example, the `ContactAgent` will return a `Contact` read-only object through the `GetContact` method. These kinds of objects are what we call read-only carriers.

## Entity carriers

An entity carrier is an [entity][2] object. Unlike in read-only carriers, an entity carrier exposes its properties as objects that are populated with more detailed data. The properties will expose their properties since the properties in entity objects are objects themselves.

The example below displays how to load a `Contact` entity object using a `ContactAgent`.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();

ContactEntity myContact = contactAgent.GetContactEntity(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.Category.Value;
string myContactWebUrl = myContact.Urls.Length > 0 ? myContact.Urls[0].Value : "";
```

The above example displays how to retrieve a `Contact` entity through the `GetContactEntity` method of the `ContactAgent`.

<!-- Referenced links -->

<!-- Referenced links -->
[1]: ../agents/index.md
[2]: ../../entities/index.md

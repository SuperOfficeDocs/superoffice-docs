---
uid: crmscript-ns-classes
title: Working with NS classes in CRMScript
description: Example of how to work with NetServer classes in CRMScript.
keywords: CRMScript, NetServer, NSAgent, NSEntity, CreateDefaultDocumentEntity(), best practices
author: Eivind Fasting,
date: 05.20.2024
topic: howto
---

# Working with NS classes in CRMScript

Use a CRMScript entity datatype when available; only use NetServer agents when a suitable CRMScript entity datatype does not exist. For example, when creating a new company, you should use the `Company` class instead of the `NSContactAgent` class. The `Company` class is a CRMScript datatype, and it is more efficient than NetServer when used directly. The same goes for the `Customer`, `Ticket` and `Message` classes.

| Real World Object | CRMScript Entity | NetServer Entity   |
|-------------------|------------------|--------------------|
| Company           | Company          | NSContact          |
| Contact           | Customer         | NSPerson           |
| Ticket Request    | Ticket           | NSTicket           |
| Ticket Message    | Message          | NSTicketMessage    |

Using a NetServer entity is more expensive than using a CRMScript entity. When you use a NetServer entity, the system must send a request to the application server through proxy classes to fetch the entity. This does not happen when using a CRMScript entity.

When there is no other option, and you must use a NetServer agent, there is one key point to know when saving an entity: for each child entity only the child entity ID value is required.

```crmscript!
// Document entity
NSDocumentEntity doc;

// Document child entities
NSAssociate associate = doc.GetAssociate();
NSContact contact     = doc.GetContact();
NSPerson person       = doc.GetPerson();
NSProject project     = doc.GetProject();
NSSale sale           = doc.GetSale();
```

You should not fetch each child entity using an agent. Instead, simply set the ID value and assign the child entity. This is more efficient and reduces the number of requests to the server.

This following section illustrates the point by creating a new document entity and fetching child entities using agents.

## Simplified example

The following code invokes two agent methods, sending two distinct requests to the application server, `DocumentAgent.CreateDefaultDocumentEntity()` and `PersonAgent.GetPerson()`.

```crmscript!
String personId = 4;
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

NSPersonAgent persAgent;
doc.SetPerson(persAgent.GetPerson(personId.toInteger()));
```

The call trace for the above code is as follows:

![Incorrect use of CreateDefaultDocumentEntity() in CRMScript][img1]

**That is inefficient code.** The correct approach is to:

1. create the `NSPerson`
2. set the person ID value
3. assign the person to the document entity

The following code demonstrates the correct approach:

```crmscript!
String personId = "4";
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();
NSPerson person;
person.SetPersonId(personId.toInteger());
doc.SetPerson(person);
```

This only sends one request to the application server, `DocumentAgent.CreateDefaultDocumentEntity()`.

The call trace for the above code is as follows:

![Correct use of CreateDefaultDocumentEntity() in CRMScript][img2]

## How to write optimized CRMScript code

The following is a bad example, and demonstrates how **not** to creates a document entity:

```crmscript!
String personId = "1";
String associateId = "5";
String contactId = "1";
String saleId = "8";
Integer templateId = 5;

NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

doc.SetName(a.getValue("name"));
doc.SetHeader(a.getValue("name"));
doc.SetDate(getCurrentDateTime());

NSListAgent listAgent;
NSDocumentTemplate docTmpl = listAgent.GetDocumentTemplate(templateId);
doc.SetDocumentTemplate(docTmpl);

NSAssociateAgent assocAgent;
doc.SetAssociate(assocAgent.GetAssociate(associateId.toInteger()));

if (personId != "") {
  NSPersonAgent persAgent;
  doc.SetPerson(persAgent.GetPerson(personId.toInteger()));
}

if (contactId != "") {
  NSContactAgent contAgent;
  doc.SetContact(contAgent.GetContact(contactId.toInteger()));
}

if (saleId != "") {
  NSSaleAgent saleAgent;
  doc.SetSale(saleAgent.GetSale(saleId.toInteger()));
}

docAgent.SaveDocumentEntity(doc);
```

A better approach is to avoid the additional agent method requests, and use the ID values directly to set a new instance of each child entity, as shown below:

```crmscript!
String personId = "1";
String associateId = "5";
String contactId = "1";
String saleId = "8";
Integer templateId = 5;

NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

NSDocumentTemplate docTmpl;
docTmpl.SetDocumentTemplateId(templateId);
doc.SetDocumentTemplate(docTmpl);
doc.SetName("Document Name");
doc.SetHeader("Document Header");
NSAssociate associate;
associate.SetAssociateId(associateId.toInteger());
doc.SetAssociate(associate);


if (personId != "") {
NSPerson person;
person.SetPersonId(personId.toInteger());
doc.SetPerson(person);
}

if (contactId != "") {
NSContact contact;
contact.SetContactId(contactId.toInteger());
doc.SetContact(contact);
}

if (saleId != "") {
NSSale sale;
sale.SetSaleId(saleId.toInteger());
doc.SetSale(sale);
}

docAgent.SaveDocumentEntity(doc);
```

## Conclusion

When working with NetServer classes in CRMScript, it is important to use the CRMScript entities directly when possible.

Also, when creating a new entity, set the ID value directly on each child entity instead of using an agent fetch a new entity instance. This reduces the number of requests to the application server, and makes your code more efficient.

<!-- Referenced images -->
[img1]: ./media/create-default-documententity-wrong.png
[img2]: ./media/create-default-documententity-correct.png

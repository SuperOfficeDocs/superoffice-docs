---
uid: crmscript-ns-classes
title: Working with NS classes in CRMScript
description: Example of how to work with NetServer classes in CRMScript.
keywords: CRMScript, NetServer, NSAgent, NSEntity, CreateDefaultDocumentEntity(), best practices
author: Eivind Fasting,
so.date: 05.20.2024
so.topic: howto
---

# Working with NS classes in CRMScript

Use a CRMScript entity datatype when available; only use NetServer agents when a suitable CRMScript entity datatype does not exist. For example, when creating a new company, you should use the `Company` class instead of the `NSContactAgent` class. The `Company` class is a CRMScript datatype, and it is more efficient to use it directly. The same goes for the `Customer`, `Ticket` and `Message` classes.

| Real World Object | CRMScript Entity | NetServer Entity   |
|-------------------|------------------|--------------------|
| Company           | Company          | NSContact          |
| Contact           | Customer         | NSPerson           |
| Ticket Request    | Ticket           | NSTicket           |
| Ticket Message    | Message          | NSTicketMessage    |

When an entity is saved, only the child entity ID value is used. Therefore, instead of using an agent to instantiate a child entity by ID, simply set the ID value and assign the child entity. This is more efficient and reduces the number of requests to the server.

This following section illustrates the result of instantiating entities through the agents, and provides sample code that creates a new document entity.

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

**This is unnecessary!** The correct approach is to use the `NSPerson` instead, as shown below:

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

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

Generally, the NetServer agents should only be when absolutely necessary. When an entity is saved, the child entities' ID values are the only properties looked at, and it is overkill to use the agents to instantiate each child entity individually. This creates extra requests towards the API and will consume more resources to execute.

This page illustrates the result of instantiating entities through the agents, and provides sample code that creates a new document entity.

## Simplified example

The following code creates 2 separate requests towards our API: `DocumentAgent.CreateDefaultDocumentEntity()` and `PersonAgent.GetPerson()`.

```crmscript!
String personId = 4;
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

NSPersonAgent persAgent;
doc.SetPerson(persAgent.GetPerson(personId.toInteger()));
```

![Incorrect use of CreateDefaultDocumentEntity() in CRMScript][img1]

**This is unnecessary!** The correct approach is to use the `NSPerson` instead:

```crmscript!
String personId = "4";
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();
NSPerson person;
person.SetPersonId(personId.toInteger());
doc.SetPerson(person);
```

The above code does only one request towards our API: `DocumentAgent.CreateDefaultDocumentEntity()`.

![Correct use of CreateDefaultDocumentEntity() in CRMScript][img2]

> [!NOTE]
> The execution-time of each request will fluctuate in the example.

## Complete sample code

The following is a complete sample for creating a document entity by instantiating the agent for each child entity:

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

This is should be refactored into:

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

<!-- Referenced images -->
[img1]: ./media/create-default-documententity-wrong.png
[img2]: ./media/create-default-documententity-correct.png

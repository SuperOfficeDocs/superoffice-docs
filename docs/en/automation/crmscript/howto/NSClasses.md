---
uid: crmscript-nsclasses
title: NSClasses
description: Working with NSClasses in CRMScript
keywords: NSClasses, NSAgents, NSEntitites
author: Eivind Fasting,
so.date: 05.20.2024
so.version: 1
so.topic: howto
---

# Working with NSClasses in CRMScript

Generally the NetServer Agents should not be used unless absolutely necessary. When an entity is saved the child entities ID values are the only properties looked at, and its overkill to use the agents to instantiate each child entity individually. It creates extra requests towards the API and will consume more resources to execute.

This page contains a Simple Example, showing the result of instantiating entitites through the Agents, and a Full/working Example that creates a new DocumentEntity.

## Simple Example

```crmscript!
String personId = 4;
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

NSPersonAgent persAgent;
doc.SetPerson(persAgent.GetPerson(personId.toInteger()));
```

This will create 2 separate requests towards our API: DocumentAgent.CreateDefaultDocumentEntity() and PersonAgent.GetPerson().

[createDefaultDocumentEntity-wrong][1]

This is not necessary, and the correct approach would be using the NSPerson instead:

```crmscript!
String personId = "4";
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();
NSPerson person;
person.SetPersonId(personId.toInteger());
doc.SetPerson(person);
```

This will only do one request towards our API: DocumentAgent.CreateDefaultDocumentEntity().

[createDefaultDocumentEntity-correct][2]

> [!NOTE]
> The execution-time of each request will fluctuate in the example

## Full Example

The following is a complete sample for creating a documentEntity by instantiating the agent for each child entity:

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

<!-- Image links -->
[1]: ./includes/createDefaultDocumentEntity-wrong.png
[2]: ./includes/createDefaultDocumentEntity-correct.png
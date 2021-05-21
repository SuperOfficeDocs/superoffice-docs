---
title: How to create a new document in SO_ARC
uid: create_document_services
description: How to create a new document in SO_ARC from template
author: Tony Yates
so.date: 06.11.2008
so.topic: howto
so.category: document
so.area: api-services
keywords:
---

# How to create a new document in SO_ARC

To create a new document, create a `document` entity and set the document properties. In this example, we have used a specific document template on which the document is based. The owner of the document is set, followed by the associated person and project with which the document is connected.

[!code-csharp[CS](includes/create-document.cs)]

Once the property values are set, the document is persisted to the database using the `DocumentAgent.SaveDocumentEntity` method. This call creates a new `Document` record in the database and returns a `DocumentEntity` instance that now contains a document ID.

With a `Document` record in the database, you create the physical document and save it in the document archive. Do this using the `DocumentAgent.CreateNewPhysicalDocumentFromTemplate` method. Required input:

* contact
* person
* appointment
* sale
* selection
* project IDs
* the document ID

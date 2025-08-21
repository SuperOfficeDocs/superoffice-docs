---
uid: api-services-document-create
title: How to create a new document in SO_ARC
description: How to create a new document in SO_ARC from template.
keywords: document, API, services, document agent, DocumentAgent.SaveDocumentEntity, DocumentEntity, CreateNewPhysicalDocumentFromTemplate
author: Tony Yates
date: 06.11.2008
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: document
area: api-services
redirect_from:
  - /en/document/howto/services/create
  - /en/api/netserver/web-services/howto/document/services-create
---

# How to create a new document in SO_ARC

To create a new document, create a `document` entity and set the document properties. In this example, we have used a specific document template on which the document is based. The owner of the document is set, followed by the associated person and project with which the document is connected.

```csharp
public int CreateDocument()
{
  //create new instance
  using(DocumentAgent agent = new DocumentAgent())
  {
    // create a document entity
    DocumentEntity documentEntity = agent.CreateDefaultDocumentEntity();
  
    // set properties of document entity
    documentEntity.Attention = "Thomas O S";
    documentEntity.Header = "Test document";
    documentEntity.Name = "Test.doc";
    documentEntity.OurRef = "Our Reference";
    documentEntity.YourRef = "Your Reference";
    documentEntity.Description = "This is a new document entity created using IDocument Agent";
    documentEntity.Date = DateTime.Today;
    documentEntity.ExternalRef = "External Reference";
  
    // use the ListAgent to get the document template.
    // this will ensure all the correct properties are set, i.e. document plugin (autoeventid and archiveprovider)
    using(ListAgent listAgent = new ListAgent())
    {
      documentEntity.DocumentTemplate = listAgent.GetDocumentTemplate(1)
    }
    
    // set the owner of the document
    Associate owner = new Associate();
    owner.AssociateId = 110;
    documentEntity.Associate = owner;
  
  
    // set the person to whom the document is connected : optional
    Person person = new Person();
    person.PersonId = 12;
    documentEntity.Person = person;
  
    // set the contact associated with the document: can also be null
    Contact contact = new Contact();
    contact.ContactId = 4;
    documentEntity.Contact = contact;
  
    // set the project to which the document is connected  : optional
    Project project = new Project();
    project.ProjectId = 15;
    documentEntity.Project = project;

    // save the document record in the database
    DocumentEntity createdDocumentEntity = agent.SaveDocumentEntity(documentEntity);

    // create a physical document for the corresponding record and store it in the document archive
    agent.CreateNewPhysicalDocumentFromTemplate(
       createdDocumentEntity.Contact.ContactId, 
       createdDocumentEntity.Person.PersonId, 
       0, 
       createdDocumentEntity.DocumentId, 
       0, 
       0, 
       createdDocumentEntity.Project.ProjectId);

    return createdDocumentEntity.DocumentId;
  }
}
```

Once the property values are set, the document is persisted to the database using the `DocumentAgent.SaveDocumentEntity` method. This call creates a new `Document` record in the database and returns a `DocumentEntity` instance that now contains a document ID.

With a `Document` record in the database, you create the physical document and save it in the document archive. Do this using the `DocumentAgent.CreateNewPhysicalDocumentFromTemplate` method. Required input:

* contact
* person
* appointment
* sale
* selection
* project IDs
* the document ID

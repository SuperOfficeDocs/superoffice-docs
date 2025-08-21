---
uid: api-rest-generate-document
title: Generate a document
description: How to generate a document with REST.
keywords: document, API, REST, api/v1/Document/, api/v1/Agents/Document/SaveDocumentEntity, SetDocumentStreamFromId, CreateNewPhysicalDocumentFromTemplate
author: Bergfrid Skaara Dias
date: 07.11.2024
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/document/howto/agents-web-api/generate-document
  - /en/document/howto/rest/generate-document
  - /en/api/netserver/web-services/howto/document/rest-generate-document
---

# Generate a document

<!-- markdownlint-disable MD051 -->
## [RESTful REST API](#tab/generate-document-rest)

```javascript
var doc = {}
doc.Header = "Testing test";
doc.Name = "foo.doc";
doc.OurRef = "foo/1";
doc.YourRef = "bar/99";
doc.Description = "BAZ FTW";
doc.DocumentTemplate = { DocumentTemplateId = 2 };
doc.Contact = { ContactId = 25 };
doc.Person = { PersonId = 63, ContactId = 25, }; 
doc = Post("api/v1/Document", doc);
```

At this point, the document record has been created, but the content is not generated yet. We can either upload some content directly:

```javascript
id = res.DocumentId;
content = "This is some document content.";
Put("api/v1/Document/" + id + "/content", content)
```

Or we can use the document template to generate a fresh document for us:

```javascript
id = res.DocumentId;
Post("api/v1/Document/" + id + "/content")
content = Get("api/v1/Document/" + id + "/content")
```

## [HTTP RPC Agent API](#tab/generate-document-agent)

```javascript
var doc = {}
doc.Header = "Testing test";
doc.Name = "foo.doc";
doc.OurRef = "foo/1";
doc.YourRef = "bar/99";
doc.Description = "BAZ FTW";
doc.DocumentTemplate = { DocumentTemplateId = 2 };
doc.Contact = { ContactId = 25 };
doc.Person = { PersonId = 63, ContactId = 25 };
doc = Post("api/v1/Agents/Document/SaveDocumentEntity", doc);
```

At this point, the document record has been created, but the content is not generated yet. We can either upload some content directly:

```javascript
id = doc.DocumentId;
content = "This is some document content.";
var req = { DocumentId: id, Stream: content }
doc = Post("api/v1/Agents/Document/SetDocumentStreamFromId", req);
```

Or we can use the document template to generate a fresh document for us:

```javascript
id = doc.DocumentId;
var req = { DocumentId: id }
doc = Post("api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplate", req);
```

***

This will generate a new document based on the template and return the updated document object to us.

[!include[Pseudocode](../../../includes/note-javascripty.md)]

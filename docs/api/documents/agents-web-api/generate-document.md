---
title: Generate document
uid: generate_document_webapi
description: Generate a document
author: {github-id}
keywords: document, webapi, agents
so.topic: howto
# so.envir:
# so.client:
---

# Generate a document

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

This will generate a new document based on the template and return the updated document object to us.

---
title: Generate a document
uid: generate_document_rest
description: Generate a document
author: {github-id}
keywords: rest, document
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

This will generate a new document based on the template and return the generated content to us.

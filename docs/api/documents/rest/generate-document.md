---
# Mandatory fields.
title: generate_document       # (Required) Very important for SEO.
description: Generate a document # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: rest,document
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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

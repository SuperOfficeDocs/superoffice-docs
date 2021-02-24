---
# Mandatory fields.
title: add_document_template       # (Required) Very important for SEO.
description: Add a document template # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: document,webapi,agents
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Add a document template

We could call `SaveDocumentTemplateEntity` and `SaveDocumentTemplateStream` separately as the REST API does, or we can use the agent call that does both in a single call:

```javascript
content = "Hello {name}.";

var item = {}
item.Name = "Created by unit test";
item.Filename = "footemplate.txt";
item.Tooltip = "Unit Tests FTW";
item.SaveInDb = 1;
item.LoadTemplateFromPlugin = 0;

var req = { DocumentTemplateEntity: item, Stream: content }
item = Post("api/v1/Agents/List/SetDocumentTemplateStream", req)
```

At this point, the document template record has been created, and the content
has been written to the archive.

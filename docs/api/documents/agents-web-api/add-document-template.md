---
title: Add template
uid:  add_document_template_webapi_agents
description: How to add a document template using the WebAPI.
author: Bergfrid Dias
so.date: 11.18.2021
keywords: document, WebAPI, agents, SetDocumentTemplateStream, SaveDocumentTemplateEntity, SaveDocumentTemplateStream
so.topic: howto
# so.envir:
# so.client:
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

[!include[Pseudocode](../../includes/note-javascripty.md)]

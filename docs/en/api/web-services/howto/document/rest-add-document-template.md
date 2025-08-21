---
uid: api-rest-add-document-template
title: Add a document template
description: How to add a document template with REST.
keywords: document, API, REST, DocumentTemplate, api/v1/List/DocumentTemplate, api/v1/Agents/List/SetDocumentTemplateStream
author: Bergfrid Skaara Dias
date: 07.11.2024
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/document/howto/agents-web-api/add-document-template
  - /en/document/howto/rest/add-document-template
  - /en/api/netserver/web-services/howto/document/rest-add-document-template
---

# Add a document template

<!-- markdownlint-disable MD051 -->
## [RESTful REST API](#tab/add-template-rest)

```javascript
var item = {}
item.Name = "Created by unit test";
item.Filename = "footemplate.txt";
item.Tooltip = "Unit Tests FTW";
item.SaveInDb = 1;
item.LoadTemplateFromPlugin = 0;
item = Post("api/v1/List/DocumentTemplate", item)
```

At this point, the document template record has been created, but there is no content for the document template. We need to upload some document content to the new record:

```javascript
var id = item.DocumentTemplateId;
content = "Hello {name}.";
Put("api/v1/List/DocumentTemplate/" + id + "/content", content)
```

## [HTTP RPC Agent API](#tab/add-template-agent)

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

***

[!include[Pseudocode](../../../includes/note-javascripty.md)]

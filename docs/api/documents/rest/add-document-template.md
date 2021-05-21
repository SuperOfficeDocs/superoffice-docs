---
title: Add a document template
uid: add_document_template_rest
description: Add a document template
author: {github-id}
keywords: rest, document
so.topic: howto
# so.envir:
# so.client:
---

# Add a document template

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

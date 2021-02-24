---
# Mandatory fields.
title: add_document_template       # (Required) Very important for SEO.
description: Add a document template # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: rest,document
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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

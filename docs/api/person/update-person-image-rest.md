---
# Mandatory fields.
title: update_person_image       # (Required) Very important for SEO.
description: Update the person's picture # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: rest,person
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Update the person's picture

```javascript
id = 123;
content = ReadAllBytes("BillGates.jpg")
Put("api/v1/Person/" + id + "/image", content)
```

This will create or replace the person's image.

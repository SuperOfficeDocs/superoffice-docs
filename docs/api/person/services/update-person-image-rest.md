---
title: Update the person's picture
uid: update_person_image
description: Update the person's picture
author: {github-id}
keywords: rest, person
so.topic: howto
# so.envir:
# so.client:
---

# Update the person's picture

```javascript
id = 123;
content = ReadAllBytes("BillGates.jpg")
Put("api/v1/Person/" + id + "/image", content)
```

This will create or replace the person's image.

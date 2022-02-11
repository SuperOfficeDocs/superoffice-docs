---
title: Update the person's picture
uid: update_person_image
description: How to update the person's picture with the REST API.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: person, contact, services, API, REST
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

---
uid: update-person-image
title: Update the person's picture
description: How to update the person's picture with the REST API.
keywords: person, contact, services, API, REST
author: Bergfrid Skaara Dias
date: 11.04.2021
topic: howto
---

# Update the person's picture

```javascript
id = 123;
content = ReadAllBytes("BillGates.jpg")
Put("api/v1/Person/" + id + "/image", content)
```

This will create or replace the person's image.

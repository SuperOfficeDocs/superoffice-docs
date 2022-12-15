---
title: Display a person's picture
uid: get_person_image
description: How to display a person's picture using REST API.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: person, contact, services, API, REST, image
so.topic: howto
# so.envir:
# so.client:
---

# Display a person's picture

```html
<p>Person:
  <img src="/api/v1/Person/{{id}}/Image?ifBlank=SrNoPhoto">
</p>
```

This gets the person's image (if defined, or if blank, returns a placeholder image).

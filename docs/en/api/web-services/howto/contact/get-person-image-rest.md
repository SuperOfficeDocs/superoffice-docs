---
uid: get-person-image-ws
title: Display a person's picture
description: How to display a person's picture using REST API.
keywords: person, contact, services, API, REST, image
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/contact/howto/services/get-person-image-rest
  - /en/api/netserver/web-services/howto/contact/get-person-image-rest
---

# Display a person's picture

```html
<p>Person:
  <img src="/api/v1/Person/{{id}}/Image?ifBlank=SrNoPhoto">
</p>
```

This gets the person's image (if defined, or if blank, returns a placeholder image).

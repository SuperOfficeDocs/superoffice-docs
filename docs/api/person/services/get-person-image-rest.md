---
title: Display a person's picture
uid: get_person_image
description: Display a person's picture
author: {github-id}
keywords: rest, person
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

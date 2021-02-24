---
# Mandatory fields.
title: get_person_image       # (Required) Very important for SEO.
description:                    # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: rest,person
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Display a person's picture

```html
  <p>Person: 
     <img src="/api/v1/Person/{{id}}/Image?ifBlank=SrNoPhoto">
  </p>
```

This gets the person's image (if defined, or if blank, returns a placeholder image).

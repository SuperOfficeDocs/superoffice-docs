---
title: web_panels_template_var
description: Link to a web panel
author:
so.date:
keywords:
so.topic: howto
---

# Link to a web panel

You can **add a link** in your web panel that will load another panel when pressed.

The HTML `<a>` tag has multiple attributes. In addition to the **href** attribute, we can set the **target** attribute to specify *where* to open the link.

Syntax:

```html
<a target="_blank|_self|_parent|_top|framename">
```

* To open a link in a new browser window, set `target="_blank`
* To open a link **in your panel**, set `target=<window name>`

For example, `target="project.pdetails"` with link text *Show project info*.

<!-- Referenced links -->

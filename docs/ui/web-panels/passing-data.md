---
title: web_panels_template_var
description: Passing data to web panels with template variables
author:
so.date:
keywords:
so.topic: concept
---

# Passing data with template variables

You can use template variables to pass data to the destination page to tailor it to the client context. This could be information about the current contact, person, or project.

For example, instead of `http://www.search.com/search?q=SuperOffice`, we can use the template variable for *company name* - which is `<name>` - and type `http://www.search.com/search?q=<name>`

**Available variables:**

* [for CRM][4]
* [for Service][5]

Here's how it works:

1. Append the template variables to the URL when editing the web panel properties.
    * Type the URL without padding (no extra spaces). SuperOffice handles the URL encoding.
    * Separate the parameters with an ampersand `&`.

2. Write the code of the target webpage so that it does something useful with the template variables.

> [!TIP]
> You can also pass template variables as **hidden variables** in your [custom screens][6]. And then do something like this in the suitable load or creation script:

```crmscript
User u;
u.load(getVariable("activeUser").toInteger());
```

<!-- Referenced links -->
[3]: http://www.ietf.org/rfc/rfc2279.txt
[4]: https://community.superoffice.com/documentation/help/EN/CRM/8.5/UserHelp/index.htm#t=StandardCRM%2Fchap02%2FTemplate_variables.htm
[5]: https://community.superoffice.com/documentation/help/EN/CRM/8.5/UserHelp/index.htm#t=Service%2Ftopics%2FTemplate_variables.html
[6]: ../service-ui/custom-screens/index.md

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: iframe_idp_auth       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Unable to authenticate inside an iframe with IdP # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: authentication
so.topic: concept          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Unable to authenticate inside an iframe with IdP

If you embed your application as a web panel in SuperOffice, your application runs inside an iframe. The security model prevents loading the sign-in page of any registered identity provider inside an iframe to defend against [clickjacking][1].

> [!WARNING]
> This means that your web-panel application **will stop working** when a customer switches from basic username-password authentication to an identity provider.

If you get the following error, it could be caused by the iframe restriction:

```csharp
SuperOffice.Exceptions.SoSessionException: Authentication failed! ---> System.NullReferenceException: Object reference not set to an instance of an object.
at SuperOffice.SoContext.Authenticate(SecurityToken[] tokens)
```

It could also be that your users see the input fields for user credentials but are unable to type into them. In other words, the authentication simply stops responding.

We recommend that you handle this proactively and do the authentication in a pop-up dialog. We are exploring other options.

<!-- Referenced links -->
[1]: https://www.owasp.org/index.php/Clickjacking

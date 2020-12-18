---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: check_idp_domain       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Can I use my domain for federated sign-in? # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Can I use my domain for federated sign-in?

Before you start setting up federated sign-in with SuperID, you need to identify the provider and check if your domain name is viable to use as an IdP for SuperOffice CRM Online.

>[!NOTE]
> You can use either **G Suite Toolbox Dig** or **Microsoft OpenId record lookup tool** to check domain compatibility.

## G Suite Toolbox Dig

The **G Suite Toolbox** can be used to identify problems with G Suite services. **Dig** supports looking up MX records for both Google and Microsoft domains.

1. Go to [https://toolbox.googleapps.com/apps/dig/]()

2. Enter your domain name and select **MX.**

3. Look at the response: if you see **ANSWER** and that section lists at least 1 entry with **outlook**, **google**, or similar you should be good to go! For example:

```text
    ;ANSWER vg.no. 299 IN MX 5 ALT2.ASPMX.L.GOOGLE.COM.    
```

![DIG (DNS lookup)][img1]

## Microsoft OpenID record lookup tool

This tool supports Microsoft domains only.

1. Insert your domain name in the following URL and go to that page:

    ```text
         https://login.microsoftonline.com/YOURDOMAIN/.well-known/openid-configuration
    ```

2. If the answer includes **authorization\_endpoint** or similar you should be good to go! For example:

    ```text
        "authorization_endpoint":"https://login.microsoftonline.com/8e414aee-d6e1-4d13-98c8-d3876cd2b05/oauth2/authorize"
    ```

![orlok][img2]

**"error":"invalid\_tenant"** indicates this will not work for a Microsoft account

![orlerror][img3]

<!-- Referenced links -->
[1]: https://toolbox.googleapps.com/apps/dig/

[img1]: ./media/dig.png
[img2]: ./media/orlok.png
[img3]: ./media/orlerror.png

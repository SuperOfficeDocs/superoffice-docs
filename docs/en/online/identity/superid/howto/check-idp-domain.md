---
title: Check IdP domain
uid: check_idp_domain
description: Can I use my domain for federated sign-in?
author: SuperOffice Product and Engineering
keywords:
content_type: howto
index: true
---

# Can I use my domain for federated sign-in?

Before you start setting up federated sign-in with SuperID, you need to identify the provider and check if your domain name is viable to use as an IdP for SuperOffice CRM Online.

>[!NOTE]
> You can use either **Google Workspace Toolbox Dig** or **Microsoft OpenId record lookup tool** to check domain compatibility.

## Google Workspace Toolbox Dig

The **Google Workspace Toolbox** can be used to identify problems with Google Workspace services. **Dig** supports looking up MX records for both Google and Microsoft domains.

1. Go to [https://toolbox.googleapps.com/apps/dig/][1]

2. Enter your domain name and select **MX.**

3. Look at the response: if you see **ANSWER** and that section lists at least 1 entry with **outlook**, **google**, or similar you should be good to go! For example:

    ```text
    ;ANSWER vg.no. 299 IN MX 5 ALT2.ASPMX.L.GOOGLE.COM.
    ```

![DIG (DNS lookup) -screenshot][img1]

## Microsoft OpenID record lookup tool

This tool supports Microsoft domains only.

1. Insert your domain name in the following URL and go to that page:

    ```text
    https://login.microsoftonline.com/YOURDOMAIN/.well-known/openid-configuration
    ```

2. If the answer includes **authorization_endpoint** or similar you should be good to go! For example:

    ```text
    "authorization_endpoint":"https://login.microsoftonline.com/8e414aee-d6e1-4d13-98c8-d3876cd2b05/oauth2/authorize"
    ```

![orlok -screenshot][img2]

**"error":"invalid_tenant"** indicates this will not work for a Microsoft account

![orlerror -screenshot][img3]

<!-- Referenced links -->
[1]: https://toolbox.googleapps.com/apps/dig/

[img1]: media/dig.png
[img2]: media/orlok.png
[img3]: media/orlerror.png

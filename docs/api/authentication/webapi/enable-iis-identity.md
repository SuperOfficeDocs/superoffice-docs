---
title: Integrated with Active Directory
uid: webapi_auth_ad
description: WebAPI authentication Active Directory
author: Bergfrid Dias
so.date: 12.17.2021
keywords: authentication, AD, Active Directory, AuthorizeWithImplicit, IIS
so.topic: howto 
so.envir: onsite
---

# Integrated with Active Directory

## SuperOffice Users

To integrate with Active Directory, you need to set up your SuperOffice users as Active Directory users.

* *web.config* must define and configure the [ActiveDirectoryCredentialPlugin section][2].
* Your SuperOffice users need to be linked to Active Directory users.

## SuperOffice web.config

You must explicitly [enable the authentication methods][1] you want to use in the *web.config* file.

```XML
<WebApi>
  <add key="AuthorizeWithImplicit" value="true" />
</WebApi>
```

> [!NOTE]
> `AuthorizeWithImplicit` must be **true**; otherwise, the Active Directory authentication method will not work. It adds the `WWW-Authenticate: Negotiate` header that kicks off Windows authentication.

## IIS configuration

1. Open the IIS Configuration tool and select the SuperOffice application.

2. In IIS, navigate to the application hosting SuperOffice web client.

3. Enable Windows Authentication, and disable the others.

    ![iis-authentication-windows -screenshot][img1]

4. Click **Advanced Settings** to enable Kernel-mode authentication.

    ![iis-kernel-mode-auth -screenshot][img2]

5. Click **Providers** to ensure that **Negotiate** is the first enabled provider.

    ![iis-auth-providers -screenshot][img3]

Your SuperOffice and WebAPI are now accessible without logging in.

The HTTP.sys kernel driver will stop unauthenticated requests before they reach ASP.net and send back an ActiveDirectory response that the browser can use to log in using its windows identity.

Accessing `/api/v1/user/currentPrincipal` via Chrome or Edge should automatically log you in, and return the current user's info.

<!-- Referenced links -->
[1]: ../../netserver/config/webapi.md
[2]: ../../netserver/config/security.md

<!-- Referenced images -->
[img1]: media/iis-authentication-windows.png
[img2]: media/iis-kernel-mode-auth.png
[img3]: media/iis-auth-providers.png

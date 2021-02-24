---
title: web_api_auth_anon
description: Web API authentication anon
author: {github-id}
so.date: 
keywords: 
so.topic: concept 
---

# SuperOffice username and password

## IIS Configuration

Configure the SuperOffice IIS website for Anonymous access.

![iis-config-site][img1]

Open the IIS Authentication dialog.

Disable all except **Anonymous** authentication.

![iis-authentication-anonymous][img2]

This sets up the site so that anyone can access the application and the WebApi, but they will still need a valid SuperOffice username and password to access the site.

If you enable **Basic authentication** on the IIS site, then IIS will try to use any username+password passed in, and fail the call if the username and password are not valid Active Directory accounts (because that's where IIS checks its usernames and passwords).

The SuperOffice WebAPI can check usernames and passwords against the SuperOffice users without Basic authentication being enabled on IIS. We need to enable it for SuperOffice in *web.config*.

## SuperOffice Web.Config

You must explicitly enable the authentication methods you want to use in the *web.config* file.

```XML
<WebApi>
  <add key="AuthorizeWithUsername" value="true" />
</WebApi>
```

**AuthorizeWithUsername** must be `true` otherwise the **Basic** authentication method will not work.

## Testing Login

Accessing the SuperOffice webpage, you should see the login page, asking for a username and password.

![login-page][img3]

## Testing WebApi

If we access the `/api/`endpoint, we should get a page describing the WebAPI

![api-page][img4]

This page should require any login to access.

## Testing authentication

If we try to get some information out of the API, we should be asked to log in.

`GET /SuperOffice/api/v1/contact/2` should prompt for a username and password.

If we try to use the browser, we will get an error message: **401 Unauthorized**

![api-error][img5]

If we use [Postman][1], we can add the Authorization HTTP header to the request.

![api-postman-basic][img6]

This adds the `Authorization` header to the request, with the username:password base64 encoded:

![api-postman-header][img7]

```http
GET /SuperOffice/api/v1/Contact/2
Authorization: Basic YWRtMDo=
Accept: application/json
```

This returns the contact info

```json
{
    "TableRight": {
        "Mask": "RI, RestrictedUpdate",
        "Reason": "[SR_ACCESS_ASSOCCONT_DELETE]"
    },
    "FieldProperties": { ... },
    "ContactId": 2,
    "Name": "statezerodatabase",
    "Department": "",
    "OrgNr": "",
    "Number1": "",
    "Number2": "",
    "UpdatedDate": "2016-01-04T13:27:28",
    "CreatedDate": "2002-07-23T15:14:29",
    "Emails": [],
```

<!-- Referenced links -->
[1]: https://www.getpostman.com/

<!-- Referenced images -->
[img1]: media/iis-config-site.png
[img2]: media/iis-authentication-anonymous.png
[img3]: media/login-page.png
[img4]: media/api-page.png
[img5]: media/api-error.png
[img6]: media/api-postman-basic.png
[img7]: media/api-postman-header.png

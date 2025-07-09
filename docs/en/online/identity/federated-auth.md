---
title: Federated authentication
uid: federated_auth
description: "Introduction to federated authentication."
author: Bergfrid Dias
date: 27.02.2025
keywords: federated authentication, SuperID, identity provider, sign-in
content_type: concept
deployment: online
platform: web
index: true
---

# Online authentication

SuperOffice uses OAuth 2.0 / Open ID Connect for online authorization/authentication.

SuperID is the authentication page that acts as a federation gateway towards the following identity providers:

* SuperOffice Central-SuperId
* Google
* Microsoft 365

## Traditionally

To sign in to SuperOffice, you present a username and a password. SuperOffice checks the password against the hashed password in the database and lets you in if the two match.

![SuperOffice CRM Online log-in page][img1]

The SuperID sign-in page handles username + password sign-in towards a user’s tenant database.

![x][img2]

## Federation

This is fine when one is not using Google or Microsoft. However, when either Google or Microsoft 365 is used to log in, SuperOffice delegates authentication to the respective identity provider.

When SuperOffice needs to store documents in Google Docs or the Microsoft 365 cloud, SuperOffice needs an identity connection between your SuperOffice identity stored in SuperOffice and your Google/Microsoft 365 identity.

![x][img3]

This is called Federation – where SuperOffice and Google/Microsoft 365 share the same information about who you are and what you can do in each respective system.

Google explains how its login system works at [OpenID Connect page][1]. [Microsoft 365 is similar][2].

Both use the OAuth 2.0 protocol and both require that developers register their applications with their central registry. This registration makes it harder for hackers to steal the results of your login.

### Signing in to SuperOffice CRM Online as a user

SuperOffice is registered as an application with both Google and Microsoft 365, so that they know who we are when users are forwarded to login to their services, and thereby know where to send SuperOffice users back to once authentication succeeds.

When users want to log in to SuperOffice using Google or Microsoft 365, they first go to the SuperOffice login page. Once the user has filled in the username, we can check if their account is connected to Google or Microsoft 365 Identity Provider. If they are, a "Login with Google" or "Login with Office 365" button is shown instead of a password field.

When the button is clicked, SuperOffice sends that user to the expected Identity Provider login page with a request that includes the user details and SuperOffice application ID.

![x][img4]

If the user is already logged in to Google that day, the Google Identity Provider will detect that and return the user to SuperOffice with a set of identity claims. If the user is not signed in then the user will be presented with the Google sign-in form to authenticate.

![x][img5]

When signed in, Google checks to determine if the user has previously given SuperOffice access to their email address. If they have not, Google will present a 2nd screen asking for permission to share that email address with SuperOffice.

![x][img6]

Once the user has granted permission to share the email address, Google sends the information back to the SuperOffice sign-in page.

> [!NOTE]
> Google looks up the application ID and redirect URI sent from SuperOffice, and verifies they match corresponding entries in their records. This makes it hard for a 3rd party to intercept the authentication results.

![x][img4]

Finally, the SuperOffice sign-in page receives the user’s email and security token from Google and can call Google once again to verify that these are valid. Once the response is confirmed that SuperOffice knows what Google knows, SuperOffice successfully authenticates the use and the user is provided access to SuperOffice.

The process is nearly identical to Office 365.

<!-- Referenced links -->
[1]: https://developers.google.com/identity/openid-connect/openid-connect
[2]: https://learn.microsoft.com/en-us/exchange/client-developer/legacy-protocols/how-to-authenticate-an-imap-pop-smtp-application-by-using-oauth

<!-- Referenced images -->
[img1]: media/crm-log-in-page.png
[img2]: media/diagram-user-superid-database.png
[img3]: media/diagram-user-superid-database-googledata.png
[img4]: media/diagram-user-superid-database-googledata-annotation.png
[img5]: media/googlelogin-screen.png
[img6]: media/googleapprove.png

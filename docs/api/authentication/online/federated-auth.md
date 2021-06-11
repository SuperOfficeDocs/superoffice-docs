---
title: Federated authentication
uid: federated_auth
description: Federated authentication
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Federated authentication

SuperID is an authentication page that acts as a federation gateway towards the SuperOffice identity provider central-superid, Google, and Office 365.

## Traditionally

To sign in to SuperOffice, you present a username and a password. SuperOffice checks the password against the hashed password in the database and lets you in if the two match.

![SuperOffice CRM Online log-in page][img1]

The SuperID sign-in page handles username + passwords and checks them against the user’s SuperOffice database.

![x][img2]

## Federation

This is fine so long as SuperOffice is the most important thing in the universe.

When Google or Office365 are the most important things in the universe, we can’t use the password stored in the database anymore. The password is not accessible to us anymore. We can’t check it directly – we can just delegate the whole username/password problem to Google/Office365.

SuperOffice wants to access user information and store documents in the Google or Office365 cloud. For SuperOffice to access your part of the Google or Office365 cloud, there needs to be a link between your SuperOffice identity (stored in the SO database) and your Google/Office365 identity.

![x][img3]

This is called Federation – SuperOffice and Google/Office365 share the same idea about who you are.

Google explains how its login system works at [https://developers.google.com/accounts/docs/OAuth2Login][1]. [Office 365 is similar][2].

Both use the OAuth 2.0 protocol. Both require that developers register their applications with their central registry. This registration makes it harder for hackers to steal the results of your login.

### Signing in to SuperOffice CRM Online as a user

SuperOffice is registered as an application with both Google and Office 365 so that we can use their services for logging in, and get the authentication request sent back to us.

When a user wants to log in to SuperOffice using Google or Office 365, they first go to the SuperOffice login page where they are shown a login page. Once the user has filled in the username, we can check if their account is connected to Google or Office 365. If they are connected to Google, we show a "Login with Google" button instead of the password field.

The SuperOffice login page sends the user off to the Google login page, with a note to come back to the SuperOffice login page once Google has figured out who the user is.

![x][img4]

Hopefully, Google sees that the user is already signed in to Google, and returns to SuperOffice with a set of claims. If the user is not signed in then the user will see a Google sign-in form.

![x][img5]

Google then checks that the user has given the SuperOffice sign-in page access to their email address. If they haven’t done so before, they get a 2nd screen from Google, asking for permission to give access to SuperOffice.

![x][img6]

When Google is sure it knows who the user is, and the user has allowed the application making the request to access the user’s information, Google sends the information back to the application that made the request – in this case back to the SuperOffice sign-in page.

Note that Google checks the Google database for app registrations to find the correct URL to send this information back to. This makes it hard for a 3rd party to intercept the authentication results.

![x][img4]

The SuperOffice sign-in page receives the user’s email and security token from Google and can call Google to verify that these are valid. The SuperOffice sign-in page now knows what Google knows, and can, therefore, let you into the SuperOffice application.

<!-- Referenced links -->
[1]: https://developers.google.com/accounts/docs/OAuth2Login
[2]: http://blogs.msdn.com/b/exchangedev/archive/2014/03/25/using-oauth2-to-access-calendar-contact-and-mail-api-in-exchange-online-in-office-365.aspx

<!-- Referenced images -->
[img1]: media/crm-log-in-page.png
[img2]: media/diagram-user-superid-database.png
[img3]: media/diagram-user-superid-database-googledata.png
[img4]: media/diagram-user-superid-database-googledata-annotation.png
[img5]: media/googlelogin-screen.png
[img6]: media/googleapprove.png

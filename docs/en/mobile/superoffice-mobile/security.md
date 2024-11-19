---
title: Security
description: Mobile CRM security in CRM Online
author: Martin Pavlas
date: 01.15.2024
keywords: mobile, pocket
topic: concept
envir: online
client: mobile
---

# Mobile CRM security in SuperOffice CRM Online

This article describes the security and requirements in SuperOffice CRM Online for Mobile CRM.

## Client-side security

SuperOffice Mobile CRM is written in C# using .NET MAUI and is available for iOS and Android.

Mobile CRM client application is signed using various certificates from various vendors (Apple iOS Developer Certificate, Google Android Developer Certificate). A signed client application provides the end-user with a trust that the application is not altered in any way. It also provides a mechanism for giving trusted access to various features and APIs on the phone.

Mobile CRM uses local caching to speed up data access – this data is stored locally in the phone, but not commonly accessible on the mobile phone's file memory/file system.

### Local storage

Mobile CRM saves data that is accessed in a local SQLite database. This is for all data that is shown in the Mobile CRM application, except documents.

Data that the user does not have access to is not saved. The data is initially saved forever but is periodically updated when accessed again.

All local data is erased if Mobile CRM is removed from the device, connected to another tenant, or if a new user logs in.

Both [iOS][1] and [Android][2] have default support for encrypting all content if a pin code or password is used to lock the device.

Mobile CRM is using the built-in encryption features of the platform it is running on. NetServer authentication data is protected by additional encryption on top of the default OS encryption.

## Network and communication security

### Communication to CRM Online

Mobile CRM communicates to CRM Online over HTTPS/TLS, just as our web client.

It accesses the CRM Online tenants NetServer Web API (endpoint), which is based on REST (architecture) and uses [OAuth][4] for authentication.

![Mobile CRM: architecture -screenshot][img1]

### Communication to other services

The Mobile CRM also has:

* 2-way communication to SuperOffice Central Services (Microsoft Azure) for mobile services (currently used for business card scanner and push notifications functionality)

* 1-way communication to Microsoft App Center: crash logs and diagnostics data (Mobile CRM -> MS App Center)

* 1-way communication from Google and Apple: Push notifications (-> Mobile CRM, not sending, only receiving)

If IdP is set up towards a user's user account, the user will be forwarded to the IdP service to validate the user.

## Server-side security

See [CRM Online security article][5] on our Trust Center for detailed information.

### Authentication

**SuperID** is a sign-in service and a federation gateway towards the identity providers. The SuperID sign-in service has 2 levels - basic and federated. Either with a SuperOffice password or delegated to an identity provider (IdP).

The sign-in service determines how you get access to SuperOffice CRM Online and who manages your credentials.

**Identity provider (IdP)** - federated identity is a generic term for establishing a person's digital identity by delegating to a trusted 3rd party as opposed to a centralized domain of trust. It refers to where the user stores their credentials.

The trusted 3rd party is the identity provider (IdP).

**Password hash** - we [never store actual passwords][6], not even the encrypted version of them, in the CRM database or SuperID. Instead, we store a hash - an encrypted value that we can use to validate a password. We calculate the hash based on an industry-standard algorithm and store the random-looking string of characters. The transformation from a human-readable entered password to a hash is a one-way operation: we can't reconstruct the password, so resetting a password means generating a new hash for a new password.

## SuperID and sign-in

SuperOffice identity provider [SuperID][7], handling federation with other systems on behalf of all clients in Online (TrayApp/WebTools/MailLink, Pocket/Mobile, Crm.web, AppStore apps, and so on), has very good support for [OpenID Connect][4].

* We use industry-standard [OAuth 2.0][4] access tokens and refresh tokens representing a user signed in to an application.
* The access token is valid for 1 hour. The refresh token is valid for several years.
* Access tokens can't be shared between applications.
* The tokens are unique per user and application and are stored on the device.
* WebTools, MailLink, and the mobile client uses industry-standard OAuth 2.0 for Native Apps ([RFC 8252][9]).
* Fingerprint authentication  [is available only for SuperOffice Onsite customers][10]
* The login screen in Mobile CRM for online customers is the central website that is shared with the web client.

### Authentication and IdP

Mobile CRM will delegate authentication to SuperID. SuperID has [standard support for Google and Microsoft][11] and can offer custom implementations if needed.

Integration with Microsoft 365 and SharePoint requires that the user authenticates using Microsoft Entra ID (formerly Azure Active Directory).

Customers who use Citrix and Microsoft 365 often have a set-up where Microsoft Entra authentication is delegated to ADFS or other systems. We support this.

* SuperID will use a standard connector with Microsoft Entra ID.
* All clients, including TrayApp/WebTools/MailLink, Pocket/Mobile, Crm.web, AppStore apps, etc. will delegate authentication to SuperID.
* Login with Google will support the new Google security policy for mobile apps
* Users using IdP (Google / Microsoft 365), the IdP admin can retract token authorization (expire)

## Preferences

In SuperOffice Admin - Preferences - Global preferences:

* **Autologout time:** Time in minutes the application can be kept idle in the background before an automatic logout is performed. Default value = 0, means no timeout.
* **Diable autologin:** Prevent the Mobile CRM client from logging in automatically on startup. Default = No.

![Mobile CRM preferences -screenshot][img2]

## Config

As Mobile CRM can be used for both onsite installations and online tenants, the app needs to know which authentication service to use (CRM Online: True/False).

There are 3 initial ways to set Mobile CRM to connect to CRM Online:

* User select: User choice in Mobile CRM on the first initial start of the app.

* soprotocol: The soprotocol is used to automatically configure Mobile CRM to connect to CRM Online.

* QR-code: scan a QR-code in web-client, using the Mobile CRM app.

This will redirect the user to the CRM Online login page for authentication. The user will here need to authenticate to log in. Log in with the same email address and password you use for the SuperOffice CRM Online and you are ready to use SuperOffice Pocket CRM

![Mobile CRM: configuration -app-screen][img3]

## FAQ

## Can we set a session timeout and where can it be set?

Yes, set a value in Settings and maintenance preference **autologout time** (minutes).

## Can Mobile CRM be set up to be strictly read-only?

The access rights are set via Roles in Settings and maintenance, and will apply as same as Web client access.

## If the phone is stolen, do they have access to the CRM data?

In Settings and maintenance, the preference **disable autologin** can be set to force users to log in each time.

If not set, they still need to first be able to unlock the phone to start Mobile CRM. The user must change their SuperOffice CRM Online password to ensure to avoid possible data theft.

## Don't allow any software on mobile clients to cache customer data

Q: My Enterprise Security team will not allow any software on mobile clients that can show or cache customer data unless the software **uses Two Factor Authentication (2FA) or access over VPN only**

A: Enable IdP for all users, and enable 2FA for the IdP provider. No option to support VPN to CRM Online.

<!-- Referenced links -->
[1]:https://www.apple.com/business/docs/iOS_Security_Guide.pdf
[2]: https://source.android.com/security/encryption/full-disk
[4]: ../../api/authentication/online/index.md
[5]: https://www.superoffice.com/trust-center/cloud-security/
[6]: ../../identity-management/superid/user-accounts-and-passwords.md
[7]: ../../identity-management/superid/sign-in-services.md
[9]: https://tools.ietf.org/html/rfc5282
[10]: https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112935#2
[11]: ../../identity-management/superid/howto/federated-sign-in-guide.md

<!-- Referenced images -->
[img1]: media/imagevq62n.png
[img2]: media/imaged0zh.png
[img3]: media/imagexkoj.png

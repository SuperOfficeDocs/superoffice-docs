---
title: Service and Marketing
description: Email in Service and Marketing
author: Frode B
so.date: 09.12.2022
keywords: email, cURL, OAuth
so.topic: concept
# so.envir:
# so.client:
---

# Email in Service and Marketing

cURL *(default)* or NetServer is used for sending and receiving emails in the SuperOffice Service client and in the SuperOffice Marketing client.

## cURL mail

cURL uses libcurl, and supports a range of common Internet protocols.

cURL has a wide range of supported protocols, certificates and improved speed.

cURL is used for sending and receiving emails in the SuperOffice Service client.

cURL is enabled by default for ALL SuperOffice Service sites and installations, from version:

* CRM Online 8.0 (R26)
* SuperOffice 8.1 (available from SuperOffice 8.0 SR2)

### How to enable cURL

**Online:**

Enabled by default

**OnSite:**

8.1 and newer: Enabled by default

SuperOffice 8.0 SR2 -> 8.1
Change the value for `reg_id = 320` in the table registry

* Using cURL: value = "0" *(default)*
* Using NetServer: value = 2

> [!NOTE]
> The value will not be stored in the database (table "registry") until a value is entered the Mail setup dialogue in Service.

![ How to enable cURL -screenshot][img1]

This can be changed either by a SQL statement (requires access to SQL database) or by eJScript (requires access to **Developer Tools**).

### How to troubleshoot mail when using cURL

Error information will appear in each of incoming mail's receiving log and outgoing mail's sending log. This information will in most cases tell what's wrong.

#### How to open the incoming/outgoing log

1. Open **Mailboxes** by clicking on the wrench -> **E-mail**. Note: only available to Admin users.

    ![How to open the incoming/outgoing log -screenshot][img2]

2. Click on **Inbox for email** / **Outbox for email**

    ![How to open the incoming/outgoing log -screenshot][img3]

    Here you will see all items not sent or imported yet. (To also see already sent, check "show sent emails" bottom right.)

3. Click on an item in this list to open the mail's receiving/sending log.

The status, number of attempts, and last error message + possibly a more comprehensive error description below (big red square in picture) will help determine what has gone wrong sending the email.

![How to open the incoming/outgoing log -screenshot][img4]

## Connection and authentication

### Requirements for OAuth 2.0

* Onsite customers who use SuperOffice 8.5 R17 + SuperOffice G9 9.2 R10 or newer

* Unique/separate serial number for each site/DB to use OAuth/AccessGateway
  * Only the first site that tries to register with a given serial number will register successfully. Contact support to change site/DB.

* Microsoft 365 (Microsoft® Exchange Online)

* MX Record pointing to the Microsoft® Exchange Online server

* NetServer must use *Mailkit*
  * When OAuth 2.0 is used on a mailbox, it ignores the value in reg_id = 320, and uses NetServer to connect to the OAuth service.
  * NetServer must use Mailkit, not EasyMail.
  * Mailkit only supports IMAP (no POP support).
  * See [SuperOffice.Inbox Email][9] for more details.

### How to add the OAuth 2.0 feature

This feature is in General Availability (not in Pilot) in SuperOffice 10.0.3 (+ SuperOffice 8.5 R17).

**Online:**
N/A

**Onsite:**
For versions between G9 9.2 R10 and 10.0.3 you can add the feature via adding:

* a) a new sectionGroup 'FeatureToggles' with state
* b) a FeatureToggles section, with state and key="NewAuthentication"
* in the web.config file (ask your technical installation partner for assistance if needed)

<details>
<summary>Show details</summary>
a)

```xml
<configuration>
  <configSections>
    <sectionGroup name="SuperOffice">
      <sectionGroup name="FeatureToggles">
        <section name="State"
          type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
    <sectionGroup name="Security">
...
```

b)

```xml
<FeatureToggles>
  <State>
    <add key="NewAuthentication" value="True" />
  </State>
</FeatureToggles>
```

</details>

### How to use OAuth 2.0 in SuperOffice Service

When a mailbox is created in SuperOffice Service, and a Microsoft 365 (Microsoft® Exchange Online) email account is added, you will be redirected to Microsoft for authentication:

To create a new mailbox with OAuth 2.0:

1. Select System settings > E-mail. This takes you straight to the Mailboxes tab.
2. Click New mailbox. The Mailbox properties screen appears, with the Properties tab open.
3. In the Address field, enter the Microsoft 365 email account e-mail address you want to use for the mailbox.
    * If we recognize the UPN as an Microsoft 365 email account, we redirect you to Microsoft for authentication.
    * Completing authentication towards Microsoft will redirect you back to Mailboxes tab.
4. Click OK. The mailbox is created.

See the [help file][8] for more information.

To change authentication to OAuth 2.0 on an existing mailbox:

You do not have to delete and create a new mailbox just to change authentication.

1. Select System settings > E-mail. This takes you straight to the Mailboxes tab.
2. Click on mailbox you want to change. The Mailbox properties screen appears, with the Properties tab open.
3. Click "Change OAuth", this will trigger new dialog for setup of account.
    * If we recognize the UPN as an Microsoft 365 email account, we will redirect you to Microsoft for authentication.
    * Completing authentication towards Microsoft will redirect you back to Mailboxes tab.
4. Click OK. The mailbox is updated.

### How to troubleshoot when using OAuth

#### Credential is not recognized

For OAuth to be able to work, make sure you have user-credentials (UPN) that directly authorize you on the mailbox, not the email address or a user which has access to it as a *shared mailbox*.

> [!NOTE]
> Up to version 10.1.4: If we don't recognize the UPN you will be redirected to mailbox properties. Click Cancel -> redirect back to mailboxes tab. Fix and verify the UPN. Make sure your MX Record is pointing to the Microsoft® Exchange Online server. Try again.

<details>
<summary> What is UPN (User Principal Name)?</summary>
In Windows Active Directory, a User Principal Name (UPN) is the name of a system user in an email address format. A UPN (for example: john.doe@domain.com) consists of the user name (logon name), separator (the @ symbol), and domain name (UPN suffix).

A UPN is not the same as an email address. Sometimes, a UPN can match a user's email address, but this is not a general rule.

**To check or modify the UPN of a user:**

* [Microsoft Exchange Server][6]
* [Office 365][7]

</details>

**Work-around:**

A work-around can be to use the full on microsoft user name.

For example, if you have email address and login to Microsoft 365: support@company.com, enter  `support@company.mail.onmicrosoft.com` as the username in the Service mailbox dialog.

If the browser caches an existing valid authentication-cookie, this can result in a direct redirect back to Service without the needed user interaction to get the needed details back. Clear the cookies or use an incognito-session in the browser.

#### MX Record pointing to the Microsoft® Exchange Online server

Ensure that the MX record points to the Microsoft address. If the MX does not point to Microsoft, this is the cause of the problem, and your IT administrator needs to resolve this DNS issue.

**To check:**

1. Open **command**.
2. Type `nslookup` and press Enter.
3. Type `set type=mx` and press Enter.
4. Enter your domain.

**Work-around:**

Use this as a work-around when their MX record is not pointing to Microsoft.

You may avoid to change the existing MXs by just add a new temporary fake MX with a lower priority number, to outlook.microsoft.com:

`MX, pref=5, outlook.microsoft.com`

> [!TIP]
> URL trick for tech-wiz: To manually create a URL matching what supposed to be created (the URL that sends the customer to Microsoft (during the authentication process)), by catching the redirect in the browsers network tab - and manually run it in the browser.

#### Duplicate serial number

When the following error is observed when configuring OAuth:

```txt
Error
Sorry, there was an error : invalid_request
Invalid client_id
Request Id: 0...:0000000001
```

The typical scenario is that you have a separate test-environment on the same serial as your production-environment.

There is no support for 2 duplicate onsite-environments run OAuth 2.0 at the same time: this is due to a security mechanism only allowing one registration per serial number (This is by design). If you want to use this feature on 2 tenants - you need 2 unique serial numbers.

If you already know you used the same serial number more than once - you can let support know if it is ok to remove the old references to that serial number.

Reach out to support with the serial number you would like to "unlock" - for resolving the situation.
Fixing the "lock" to that serial number will only be temp - if you again uses it on both installations running on the same serial number.

**Example:**

For a customer who have 2 duplicate onsite-env. and already have OAuth 2.0 registered for "tenant a" and wish to change to use OAuth 2.0 to "tenant b":

* Alt. 1: 'create' a new serial number and change to this new serial number on "tenant b". You may now use OAuth 2.0 for "tenant b":
* Alt. 2: register a support request, where you submit the serial number for "tenant a" and request to delete it from OAuth/AccessGateway
  * to be able to to use this serial number for another tenant. When you get confirmation the serial number is deleted, you may use OAuth 2.0 for "tenant b".

> [!NOTE]
> The use of App Passwords is dependent on basic authentication. This type of authentication will be discontinued by Microsoft in October 2022.

<!-- Referenced links -->
[6]: https://www.codetwo.com/kb/upn/#exchange
[7]: https://www.codetwo.com/kb/upn/#office-365
[8]: https://community.superoffice.com/en/learning/admin-guide/service/request-setup/service-mailbox-setup/
[9]: ./inbox.html

<!-- Referenced images -->
[img1]: media/320curl.jpg
[img2]: media/e-mail.jpg
[img3]: media/outboxitem.jpg
[img4]: media/outboundlog.jpg

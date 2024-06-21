---
uid: email-soinbox
title: SuperOffice Inbox
description: SuperOffice Inbox
author: Bergfrid Dias
date: 03.21.2024
keywords: email
topic: concept
# envir:
# client:
---

# SuperOffice Inbox

SuperOffice Inbox (the integrated email client).
[How to configure your email setup in SuperOffice Inbox][5]

## MailKit

MailKit is a cross-platform .NET library for IMAP, POP3, and SMTP.

The main reason for using the MailKit library is a wider range of supported protocols, certificates, and improved speed.

MailKit is used by SuperOffice NetServer, for example, Inbox in the Sales client.

MailKit is enabled for CRM Online from version 8.0 (R23) and can be enabled manually on Onsite from version SuperOffice 8.0 SR3.

## How to enable MailKit

**Online:**

On by default - cannot be disabled/enabled

**Onsite:**

On by default on 8.1

1. Open the *web.config* file for your site.
2. Replace the value for Mail Reader and Sender to "MailKit".
3. Save *web.config*.
4. Recycle the application pool.

![Web.config settings -screenshot][img1]

## Number-of-days to download

SuperOffice Inbox downloads emails from your mailbox and stores them in the SuperOffice database.

**Online:**

[Submit a support request][3] to your local support team. They can change the value for your tenant.

**Onsite:**

If you want to change how many days to past we should download and store emails, you can add the following key in the [Mail section of the NetServer configuration][4].

```xml
<Mail>
  <Component>
    <add key="NumberOfDaysToDownload" value="30" />
  </Component>
</Mail>
```

Now the Inbox will download emails younger than 30 days only. If no value is set, it defaults to 180 days.

## How to troubleshoot MailKit

### Connection and authentication

#### OAuth 2.0

**Requirements:**

* CRM Online or Onsite customers who use SuperOffice G9 9.2 R10 or newer
* Microsoft 365 (Microsoft® Exchange Online)
* MX Record pointing to the Microsoft® Exchange Online server

**How to add the feature?**

We made that feature General Available with SuperOffice 10.0.3.

**Online:**
Enabled. Next time you log in to your Microsoft 365 (Microsoft® Exchange Online) email account in SuperOffice Inbox - you will be redirected to Microsoft for authentication.

**Onsite:**
For versions between G9 9.2 R10 and 10.0.3 you can add the feature by updating the *web.config* file (ask your technical installation partner for assistance if needed)

1. Add a new **sectionGroup** called `FeatureToggles` with state:

    ```xml
    <configuration>
    <configSections>
    <sectionGroup name="SuperOffice">
    <sectionGroup name="FeatureToggles">
        <section name="State" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </sectionGroup>
    <sectionGroup name="Security">
    ...
    ```

1. Add a FeatureToggles **section**, with state and `key="NewAuthentication"`:

    ```xml
    <FeatureToggles>
      <State>
        <add key="NewAuthentication" value="True" />
      </State>
    </FeatureToggles>
    ```

**How to log in:**

1. Log in to your Microsoft email account in SuperOffice Inbox
    Fill inn your Microsoft365 'User Princpal Name' (UPN) in the field "Email account".
2. Click **Next**.
    If we recognize the UPN as a Microsoft 365 email account, we redirect you to Microsoft for authentication.
3. Authenticate towards Microsoft and complete the login
    You will then be taken to the SuperOffice Inbox. Your email account is now set up to use OAuth 2.0 authentication

##### What is UPN (User Principal Name)?

In Windows Active Directory, a User Principal Name (UPN) is the name of a system user in an email address format. A UPN (for example: `john.doe@domain.com`) consists of the user name (logon name), separator (the @ symbol), and domain name (UPN suffix).

A UPN is not the same as an email address. Sometimes, a UPN can match a user's email address, but this is not a general rule.

###### How to check or modify the UPN of a user

Use the links below to learn how to check and change UPNs in various environments.

* [Microsoft Exchange Server][6]
* [Office 365][7]

#### Encrypted connection

**Outgoing:**

The better and more modern way is to use port 587 on outgoing mail. It starts unencrypted, but the connection is upgraded to encrypted (using STARTTLS) if the server supports it. Connections to 587 should not have the SSL checkbox, as it starts without encryption (and that checkbox will enforce encryption from the beginning of the connection).

If your server supports using port 587 on outgoing mail, using that port is much better than 465:

The normal behavior when the connection to port 465 (outgoing), is that the connection is wrapped in a secure connection. If you can [telnet][2] to that port, and get the result back in clear-text, ie. it is not encrypted. To troubleshoot SSL/encrypted connections, use Putty.

MailKit expects connections to port 465 to be encrypted.

**Incoming:**

Yet to be completed, please submit your experiences

### Logging

**Online:**

[Submit a support request][3] to your local support team. They can get in contact with our Online Operations team to activate the debug logging for email.

**Onsite:**

Read section [Mail logging][1].

<!-- Referenced links -->
[1]: ../../onsite/debug/web-client.md
[2]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=166
[3]: https://cs.superoffice.com/
[4]: ../../api/config/mail.md
[5]: learn/index.md
[6]: https://www.codetwo.com/kb/upn/#exchange
[7]: https://www.codetwo.com/kb/upn/#office-365

<!-- Referenced images -->
[img1]: media/mailkit.jpg

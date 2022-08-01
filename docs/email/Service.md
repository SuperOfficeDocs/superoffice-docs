---
title: Service and Marketing
description: Email in Service and Marketing using cURL mail
author: {github-id}
keywords: email,cURL
so.topic: concept
# so.envir:
# so.client:
---

# Email in Service and Marketing

cURL is used for sending and receiving emails in the SuperOffice Service client and in the SuperOffice Marketing client.

## cURL mail

cURL uses libcurl, and supports a range of common Internet protocols.

The main reason for using the new library is a wider range of supported protocols, certificates and improved speed.

cURL is used for sending and receiving emails in the SuperOffice Service client.

cURL is enabled by default for ALL SuperOffice Service sites and installations, from version:

* CRM Online 8.0 (R26)
* SuperOffice 8.1 (available from SuperOffice 8.0 SR2)

> [!NOTE]
> The value will not be stored in the database (table "registry") until after you have entered the Mail setup dialogue in Service.

## How to enable cURL

**Online:**

Enabled by default

**OnSite:**

8.1 and newer: Enabled by default

SuperOffice 8.0 SR2 -> 8.1
Change the value for `reg_id = 320` in the table registry

* Not using cURL: value = 2
* Using cURL: value = "0"

![x -screenshot][img1]

This can be changed either by a SQL statement (requires access to SQL database) or by eJScript (requires access to **Developer Tools**).

## Connection and authentication

### OAuth 2.0

**Requirements:**

* Onsite customers who use SuperOffice G9 9.2 R10 or newer
* Microsoft 365 (Microsoft® Exchange Online)
* MX Record pointing to the Microsoft® Exchange Online server

**How to add the feature?**

We made that feature General Available (iow. not in Pilot) with SuperOffice 10.0.3.

**Online:**
N/A

**Onsite:**
For versions between G9 9.2 R10 and 10.0.3 you can add the feature via adding:

* a) a new sectionGroup 'FeatureToggles' with state
* b) a FeatureToggles section, with state and key="NewAuthentication"
* in the web.config file (ask your technical installation partner for assistance if needed)

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

**How to log in:**

How to use the feature in SuperOffice Service?

Next time you create a mailbox in SuperOffice Service and add your Microsoft 365 (Microsoft® Exchange Online) email account  - you will be redirected to Microsoft for authentication.

To create a new mailbox:

1. Select System settings > E-mail. This takes you straight to the Mailboxes tab.
2. Click New mailbox. The Mailbox properties screen appears, with the Properties tab open.
3. In the Address field, enter the Microsoft 365 email account e-mail address you want to use for the mailbox.
    * If we recognize the UPN as an Microsoft 365 email account, we redirect you to Microsoft for authentication.
4. Click OK. The mailbox is created.

See the [help file][8] for more information.

#### What is UPN (User Principal Name)?

In Windows Active Directory, a User Principal Name (UPN) is the name of a system user in an email address format. A UPN (for example: john.doe@domain.com) consists of the user name (logon name), separator (the @ symbol), and domain name (UPN suffix).

A UPN is not the same as an email address. Sometimes, a UPN can match a user's email address, but this is not a general rule.

##### How to check or modify the UPN of a user

Use the links below to learn how to check and change UPNs in various environments.

* [Microsoft Exchange Server][6]
* [Office 365][7]

## How to troubleshoot mail when using cURL

Error information will appear in each of incoming mail's receiving log and outgoing mail's sending log. This information will in most cases tell what's wrong.

How to open the incoming/outgoing log:

1. Open **Mailboxes** by clicking on the wrench -> **E-mail**. Note: only available to Admin users.

    ![x -screenshot][img2]

2. Click on **Inbox for email** / **Outbox for email**

    ![x -screenshot][img3]

    Here you will see all items not sent or imported yet. (To also see already sent, check "show sent emails" bottom right.)

3. Click on an item in this list to open the mail's receiving/sending log.

The status, number of attempts, and last error message + possibly a more comprehensive error description below (big red square in picture) will help determine what has gone wrong sending the email.

![x -screenshot][img4]

<!-- Referenced links -->
[6]: https://www.codetwo.com/kb/upn/#exchange
[7]: https://www.codetwo.com/kb/upn/#office-365
[8]: https://community.superoffice.com/en/learning/admin-guide/service/request-setup/service-mailbox-setup/

<!-- Referenced images -->
[img1]: media/320curl.jpg
[img2]: media/e-mail.jpg
[img3]: media/outboxitem.jpg
[img4]: media/outboundlog.jpg

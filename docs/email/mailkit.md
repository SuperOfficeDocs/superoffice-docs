---
title: mailkit
description: MailKit
author: Bergfrid Dias
so.date: 12.09.2021
keywords: email
so.topic: concept
# so.envir:
# so.client:
---

# MailKit

MailKit is a cross-platform .NET library for IMAP, POP3, and SMTP.

The main reason for using the MailKit library is a wider range of supported protocols, certificates, and improved speed.

MailKit is used by SuperOffice NetServer, for example, Inbox in the Sales client.

MailKit is enabled for CRM Online from version 8.0 (R23) and can be enabled manually on Onsite from version SuperOffice 8.0 SR3.

The current version of MailKit is: 1.4.2.1

## How to enable MailKit

**Online:**

On by default - cannot be disabled/enabled

**OnSite:**

On by default on 8.1

1. Open the *web.config* file for your site.
2. Replace the value for Mail Reader and Sender to "MailKit".
3. Save *web.config*.
4. Recycle the application pool.

![x -screenshot][img1]

## Number-of-days to download

SuperOffice Inbox downloads emails from your mailbox and stores them in the SuperOffice database.

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

**OnSite:**

Read section [Mail logging][1]

<!-- Referenced links -->
[1]: ../onsite/debug/web-client.md
[2]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=166
[3]: https://cs.superoffice.com/
[4]: ../../../data-access/docs/netserver/config/mail.md

<!-- Referenced images -->
[img1]: media/mailkit.jpg

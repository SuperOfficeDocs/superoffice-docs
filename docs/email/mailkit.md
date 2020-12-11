---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mailkit       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: MailKit # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: email
so.topic: article             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# MailKit

MailKit is cross-platform .NET library for IMAP, POP3, and SMTP.

The main reason for using the MailKit library is a wider range of supported protocols, certificates and improved speed.

MailKit is used by SuperOffice Netserver, e.g. Inbox in the Sales client.

MailKit is enabled for CRM Online from version 8.0 (R23), and can be enabled manually on Onsite from version SuperOffice 8.0 SR3.

Current version of MailKit is: 1.4.2.1

## How to enable MailKit

**Online:**

On by default - cannot be disabled/enabled

**OnSite:**

On by default on 8.1

1. Open the web.config file for your site
2. Replace the value for Mail Reader and Sender to "MailKit".
3. Save the file web.config file
4. Recycle the application pool

![x][1]

## How to troubleshoot MailKit

### Connection and authentication

**Outgoing:**

The better and more modern way is to use port 587 on outgoing mail. It starts of unencrypted, but the connection is upgraded to encrypted (using STARTTLS) if the server supports it. Connections to 587 should not have the SSL checkbox, as it starts off without encryption (and that checkbox will enforce encryption from the beginning of the connection).

If your server support to use port 587 on outgoing mail, using that port is much better than 465:

The normal behavior when connection to port 465 (outgoing), is that the connection is wrapped in a secure connection. If you can [telnet][2] to that port, and get the result back in clear-text, ie. it is not encrypted. To troubleshoot SSL/encrypted connections, use Putty.

MailKit expects connections to port 465 to be encrypted.

**Incoming:**

Yet to be completed, please submit your experiences

### Logging

**Online:**

[Submit a support request][3] to your local support team. They can get in contact with our Online Operations team to activate the debug logging for email.

**OnSite:**

Read section [Mail logging][4]

<!-- Referenced links -->
[1]: media/mailkit.jpg
[2]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=166
[3]: https://cs.superoffice.com/
[4]: https://community.superoffice.com/en/technical/documentation/administration/config-ini/debugweb/

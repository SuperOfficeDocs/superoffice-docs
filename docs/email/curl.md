---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: curl       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: cURL mail # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: email
so.topic: article               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# cURL mail

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

N/A.

**OnSite:**

Change the value for `reg_id = 320` in the table registry

Not using cURL: value = 2
Using cURL: value = "0"

![x][img1]

This can be changed either by a SQL statement (requires access to SQL database) or by eJScript (requires access to **System design** and admin role).

## How to troubleshoot mail when using cURL

Error information will appear in each of incoming mail's receiving log and outgoing mail's sending log. This information will in most cases tell what's wrong.

How to open the incoming / outgoing log:

1. Open **Mailboxes** by cicking on the wrench -> **E-mail**. Note: only available to Admin users.

![x][img2]

2. Click on **Inbox for email** / **Outbox for email**

![x][img3]

Here you will see all items not sent / imported yet. (To also see already sent, check "show sent e-mails" bottom right.)

3. Click on an item in this list to open the mail's receiving / sending log.

The status, number of attempts, and last error message + possibly a more comprehensive error description below (big red square in picture) will help determine what has gone wrong sending the email.

![x][img4]

<!-- Referenced images -->
[img1]: media/320curl.jpg
[img2]: media/e-mail.jpg
[img3]: media/outboxitem.jpg
[img4]: media/outboundlog.jpg

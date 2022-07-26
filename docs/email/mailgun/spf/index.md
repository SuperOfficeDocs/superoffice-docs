---
title: spf
description:
author: {github-id}
keywords:
---

# SPF

## What is SPF?

An SPF record is a type of [Domain Name Service][1] (DNS) record that identifies which mail servers are permitted to send an email on behalf of your domain and/or can't send on behalf of your domain (whitelist and/or blacklist of IP / domains). Apply these restrictions by adding an [MX record][2] in your DNS zone.

## Why is it Important?

Today, nearly all abusive email messages carry fake sender addresses. Spammers send email from their mail servers but with your *domain* as the sending email. The victims whose addresses are being abused often suffer from the consequences, because their reputation gets diminished and they have to disclaim liability for the abuse or waste their time sorting out misdirected bounce messages.

## What is the purpose of SPF record?

The purpose of an SPF record is to prevent spammers from sending messages with forged *From Addresses* at your domain. Recipients can refer to the SPF record to determine whether a message purporting to be from your domain comes from an authorized mail server.

**More info:**

Google article [About SPF records][3]

## SuperOffice CRM Online SPF details

Most European CRM Online customers uses Mailgun EU IP addresses.

The SPF 'mailgun.org' includes:

* '_spf.mailgun.org' (ALL Mailgun US IP addresses)
* '_spf.eu.mailgun.org' (all Mailgun EU IP addresses).

<!-- markdownlint-disable MD044 -->
The SPF '_spf.online.superoffice.com' includes:

* 3 IP address (or ranges) of a Mailgun US cluster (the IP address we used to use while we were using Mailgun US)
* shortcut to SPF range '_spf.eu.mailgun.org' (all Mailgun EU IP addresses)

Non-DKIM: add SPF '_spf.online.superoffice.com'
<!-- markdownlint-restore -->

## SuperOffice CRM Online SPF details for DKIM-customers

When using DKIM, the SPF check requires to include SPF for 'mailgun.org' - to be able to send and receive emails in SuperOffice Service.

<!-- markdownlint-disable MD044 -->
So when using DKIM (and therefore SPF for 'mailgun.org'), you do not need '_spf.online.superoffice.com' (as this includes the same sub-selection as SPF 'mailgun.org' does: '_spf.eu.mailgun.org').
<!-- markdownlint-restore -->

DKIM: add SPF 'mailgun.org'

<!-- Referenced links -->
[1]: https://en.wikipedia.org/wiki/Domain_Name_System
[2]: https://en.wikipedia.org/wiki/MX_record
[3]: https://support.google.com/a/answer/33786?hl=en

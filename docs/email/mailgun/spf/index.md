---
title: spf
description:
author: {github-id} # Your GitHub alias.
keywords:
---

# SPF

## What is SPF?

An SPF record is a type of [Domain Name Service][1] (DNS) record that identifies which mail servers are permitted to send an email on behalf of your domain and/or can't send on behalf of your domain (whitelist and/or blacklist of IP / domains). Apply these restrictions by adding an [MX record][2] in your DNS zone.

## Why is it Important?

Today, nearly all abusive e-mail messages carry fake sender addresses. Spammers send email from their mail servers but with your ‘domain’ as the sending email. The victims whose addresses are being abused often suffer from the consequences, because their reputation gets diminished and they have to disclaim liability for the abuse or waste their time sorting out misdirected bounce messages.

## What is the purpose of SPF record?

The purpose of an SPF record is to prevent spammers from sending messages with forged ‘From Addresses’ at your domain. Recipients can refer to the SPF record to determine whether a message purporting to be from your domain comes from an authorized mail server.

**More info:**

Google article [About SPF records][3]

<!-- Referenced links -->
[1]: https://en.wikipedia.org/wiki/Domain_Name_System
[2]: https://en.wikipedia.org/wiki/MX_record
[3]: https://support.google.com/a/answer/33786?hl=en
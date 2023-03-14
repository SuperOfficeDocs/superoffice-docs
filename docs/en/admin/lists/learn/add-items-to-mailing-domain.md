---
uid: add-items-to-mailing-domain
title: Add items to Mailing Domain
description: Add items to the Mailing Domain list
author: HanneGunnarsson
so.date: 03.14.2023
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the Mailing domains list

When the global preference **Only use approved e-mail sending domains** is set to **Yes**, users will only be able to send e-mails from domains added to this list in SuperOffice CRM. It is therefore important to add approved domains with a valid SPF record to this list.

> [!NOTE]
> In order to use the Mailing Domain list, the global preference **Only use approved e-mail sending domains** must be set to **Yes**.

Here's how you add approved mailing domains to the list:

1. In **Settings and maintenance**, click **Lists** and select **Mailing domains** from the dropdown list.

1. Click **Add** to add a new approved domain.

1. Add the domain name and click **Save**. The system will conduct an SPF and MX lookup to check if the domain has valid SPF and MX records. If not, a warning will appear telling you that a valid SPF record is required for mailing domains. Click **OK** and try a different domain.

1. If the domain passes the SPF and MX lookup, it will be added to the list of approved domains, and users can send from this domain.

> [!NOTE]
> You can set up an SPF record for your domain to ensure that your organisation can send mailings with increased deliverability. (ONLINE ONLY)

[What is SPF?][1]

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/email/mailgun/spf/index.html

<!-- Referenced images -->

---
uid: help-en-add-items-to-mailing-domain
title: Add items to Mailing Domain
description: Add items to the Mailing Domain list
author: Hanne Gunnarsson
date: 03.14.2023
keywords: mailing, domain, SPF
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add items to the Mailing domains list

When the global preference **Only use approved e-mail sending domains** is set to **Yes**, users will only be able to send emails from domains added to this list in SuperOffice CRM. It is therefore important to add approved domains with a valid [Sender Policy Framework (SPF)][1] record to this list.

> [!NOTE]
> The global preference **Only use approved e-mail sending domains** in the **Marketing** group must be set to **Yes** in order to use the Mailing Domain list.

## Steps

1. In **Settings and maintenance**, click **Lists** and select **Mailing domains**.

1. Click **Add** to add a new approved domain.

1. Add the domain name and click **Save**. The system will conduct an SPF look-up to check if the domain has a valid SPF record. If not, a warning will appear telling you that a valid SPF record is required for mailing domains. Click **OK** and try a different domain.

1. If the domain passes the SPF look-up, it will be added to the list of approved domains, and users can send mailings from this domain.

> [!NOTE]
> You can set up an SPF record for your domain to ensure that your organisation can send mailings with increased deliverability (ONLINE ONLY). If your environment is ONSITE, an SPF look-up will not be conducted. But you can still use the list to provide your users with pre-set domains for **From** and **Reply to** addresses.

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/email/mailgun/spf/index.html

<!-- Referenced images -->

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: order_dkim_key       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: mailgun
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online              # online, web, win, pocket, or mobile
---

# Request DKIM key for eu.mailgun.org

> [!NOTE]
> To validate that you own the domain, you must submit an email address with the same domain as the domain you are requesting DKIM for.

## Process

1. Fill in the form and receive your DKIM key back.
2. Add the DKIM key as a text record to your DNS.
3. Validate your new DKIM record, to make sure it has propagated.
4. Please reply back to us, confirming the DKIM is valid.
5. We will update your CRM Online account to use the new settings.

More information in this [article][1]

## Required info

* Company name
* CRM Online Customer ID
* Your name
* Your email
* Domain name
* Reply-to address

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/administration/mailgun-options-and-security/order-setup-dkim/
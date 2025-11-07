---
uid: help-en-utm-parameters
title: UTM parameters
description: UTM parameters
keywords: UTM parameters
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# UTM parameters

There are five standard UTM parameters that you can add to the end of your campaign links:

## Standard UTM parameters

| Parameter | What it tells you | Example values | Analogy |
|---|---|---|---|
| **utm_source** | Identifies where the traffic originated. Helps you see which platform or referrer drove visitors to your site. | `google`, `linkedin`, `newsletter`, `trade_show` | The place they came from |
| **utm_medium** | Shows the marketing channel or method used to deliver the message. | `email`, `cpc`, `banner`, `organic`, `event` | The type of road they took |
| **utm_campaign** | Specifies the campaign, promotion, or theme that the link is associated with. | `spring_sale`, `ebook_launch`, `black_friday`, `q2_brand_ads` | The vehicle they used |
| **utm_term** | Captures the paid keyword used in search ads that led to the visit. | `crm+software`, `marketing+automation` | The signpost that guided them |
| **utm_content** | Differentiates multiple links or creative elements within the same ad or campaign. | `cta_button`, `header_banner`, `textlink_a` | The lane they chose |

## Best practices for UTM naming

Follow these guidelines to ensure consistent and accurate UTM tracking in SuperOffice and analytics tools.

* **Lowercase only:** Use lowercase for all UTM values to avoid duplicate entries.

* **Use underscores or hyphens:** Pick one separator and use it consistently (for example, `webinar_sept2025`).

* **Document your structure:** Create a simple guide so everyone on your team tags links the same way.

* **Automate tagging:** Use a UTM builder tool to reduce manual errors and enforce your convention.

* **Audit regularly:** Check your analytics for inconsistencies and clean up as needed.

* **Use a consistent naming format:** Agree on a campaign name format and apply it to all links.

**Example campaign name:**
`leadgen_smb_webinar_sept2025`

**Example tracking URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

To learn how these parameters are used to measure lead sources in SuperOffice CRM, see [Conversion tracking][1].

## Related content

* [Enable UTM tracking for form submissions][2]
* [UTM builder for SuperOffice forms][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

<!-- Referenced links -->
[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: https://utmbuilder.net

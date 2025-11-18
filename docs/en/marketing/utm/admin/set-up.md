---
uid: help-en-utm-setup
title: Set up UTM tracking
description: Learn how to enable and use UTM tracking in SuperOffice Marketing to capture lead sources.
keywords: enable UTM, conversion tracking, lead source
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Set up UTM tracking

UTM tracking lets SuperOffice capture the source, medium, and campaign that generated a lead. This setup ensures that every form submission can be traced back to the marketing activity that drove it.

You need to complete a **one-time setup** (by an administrator or web developer) and perform a few **recurring steps** for each campaign.

## Step overview

| Step | Who | Frequency | Purpose |
|---|---|---|---|
| **1. Enable UTM data transfer** | Administrator | One time | Allow forms to capture UTM data and store it in CRM fields. |
| **2. Add the UTM tracking script to your website** | Web developer | One time | Enable persistent UTM tracking across pages and sessions. |
| **3. Create UTM-tagged campaign links** | Marketer | For each campaign | Identify where traffic originates. |
| **4. Apply the UTM link in campaigns** | Marketer | For each campaign | Use the tagged links across ads, emails, and social media. |
| **5. Publish your form correctly** | Marketer | For each campaign | Ensure your form is published in a way that captures UTM data. |
| **6. Test and verify the setup** | Marketer | After initial setup and before each campaign | Confirm that tracking and data capture work correctly. |
| **7. Analyze and visualize results** | Marketer | After each campaign | Measure campaign performance in dashboards and reports. |

## <a id="enable"></a>1. Enable UTM data transfer

**Who:** Administrator

**When:** One time

Enabling UTM data transfer lets SuperOffice collect information about where visitors came from when they submit a form.

The data becomes available on both the **contact card** and **form submission** records.

1. Go to **Settings and maintenance** > **Marketing**.
1. Turn on **Enable UTM data transfer on form submissions**.

    ![The Marketing preferences page in SuperOffice Settings and maintenance, showing the option to enable UTM data transfer on form submissions and instructions for adding a UTM tracking script and campaign parameters. -screenshot][img1]

## <a id="script"></a>2. Add the UTM tracking script to your website

**Who:** Web developer or person managing your website

**When:** One time

This script enables persistent tracking. It listens for UTM parameters in the URL and stores them temporarily in the browser, so even if a visitor browses several pages before submitting a form, the first touch data is still recorded.

1. Copy the script below.
1. Paste it into your website's code directly after the `<head>` tag.
1. Publish the updated page.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Without the script, UTM data is still captured for direct form links but not for visitors who navigate between pages before submitting.

## <a id="build-url"></a>3. Create UTM-tagged campaign links

**Who:** Marketer

**When:** For each campaign

UTM parameters identify where your visitors come from, and how they engage with your campaigns.

You can add these parameters manually or use a UTM builder tool.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept

```

Use the [SuperOffice UTM builder for form pages][1] or [Google's Campaign URL Builder][4] to generate consistent campaign URLs and reduce manual errors.

**Standard parameters:**

utm_source, utm_medium, utm_campaign, utm_term, utm_content

For descriptions and naming conventions, see [UTM parameters][2].

## <a id="tag"></a>4. Apply the tagged URL in your campaigns

**Who:** Marketer

**When:** For each campaign

Use the tagged link wherever you promote your campaign, such as:

* Blog call-to-action buttons
* Email newsletters
* Facebook ads or retargeting
* Google Ads
* LinkedIn posts

## <a id="publish"></a>5. Publish your form correctly

**Who:** Marketer

**When:** For each campaign

SuperOffice can capture UTM data whether your form is **embedded** on your website or **hosted** by SuperOffice.

| Method | Description | Captures first touch? |
|---|---|---|
| **Embedded form** | Add the tracking script to your site and use a landing page URL with UTM tags. | <i class="ph ph-check-circle" aria-hidden="true"></i> Yes |
| **SuperOffice-hosted form (direct link)** | Add UTM parameters to the SuperOffice form URL. | <i class="ph ph-warning-circle" aria-hidden="true"></i> No |

> [!TIP]
> Do not link directly from your website to a SuperOffice-hosted form, as UTM tags will be lost between pages.

## <a id="test"></a>6. Test and verify the setup

**Who:** Marketer

**When:** After initial setup and before each new campaign

1. Click one of your campaign links.
1. Fill out and submit the form.
1. Open the new contact card in SuperOffice.
1. Confirm that the **source**, **medium**, and/or **campaign** fields contain data.

If data is missing, check that:

* The tracking script is correctly installed.
* The UTM parameters are spelled and formatted properly.
* The browser cookies are not blocked or cleared between visits.

## <a id="analyze"></a>7. Analyze and visualize results

**Who:** Marketer

**When:** After each campaign

Once data is captured, you can measure performance in dashboards and reports.

* View new leads by **first touch source** (which channel generated traffic).
* View new leads by **campaign** (which campaign generated conversions).
* Build a **dashboard tile** showing new leads by source, medium, or campaign for the current year.

Learn more about dashboards in [Marketing dashboards and reports][5].

<!-- Referenced links -->
[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-leads.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png

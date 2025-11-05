---
uid: help-en-form-publish
title: Publish form
description: Publish form
keywords: form, publish form, active form, embed form, pre-filled field, UTM builder, Add UTM tracking
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Publish forms

After creating a form and (if relevant) the form response, you can publish the form.

> [!NOTE]
> The **Publish** tab is a here-and-now workspace. Any values entered on this page, such as pre-filled fields or UTM parameters, are used only to generate the link or script you copy now.
> SuperOffice does **not save** these values permanently. If another user edits the page later, your previous values are replaced.

## Steps

1. Go to the **Forms** tab.

1. Click the form to open it in view mode.

1. Set the form to **Active** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> in the header.

1. Go to the **Publish** tab.

1. (optional) In the **Pre-populate with contact data** section, choose one or more fields to autofill with existing customer data from SuperOffice.

1. to add field identifiers to the link/JavaScript. Useful for [pre-filling form fields][1] with existing customer data from SuperOffice.

1. On the left side of the screen, select a publishing option for the form:

    * **Direct link**: A direct link to the form.
    * **Embed inline**: A script tag used to add the form on a web page.
    * **Embed as popup**: A button to open the form in a pop-up window on the web page.
    * **Embed as side tab**: A side tab with a button to hide/show the form.

1. Copy the links/tags into a newsletter, website or customer centre to publish it to your customers or prospects.

![Publish form, direct link -screenshot][img3]

## <a id="utm"></a>Add UTM tracking (Marketing Premium)

The built-in **UTM builder** generates a form link with [UTM parameters][4] so SuperOffice can capture where your leads come from when a visitor submits the form.

### Prerequisites and limitations

* You have a **Marketing Premium** user plan.
* An administrator has [enabled UTM data transfer for form submissions][6].
* UTM tracking is available only for the **Direct link** option. It is not applicable for embedded forms.

### Steps

1. In the **Publish** tab, select **Direct link** as the publishing option.

1. In the **Add UTM tracking** section, enter one or more UTM values such as **source**, **medium**, and **campaign**.

    ![Add UTM tracking fields in the form publish view -screenshot][img4]

    For details about each parameter and naming conventions, see [UTM parameters][4].

1. Copy the generated link from the field below.

1. Paste the link into your ad, email, or social post.

> [!TIP]
> Always copy and save the link immediately after creating it. Any later changes to the fields will generate a different link.

## What happens now?

A notification on the **Form submissions** tab indicates that you have [received form submissions][2], which might need to be [processed manually][3].

Forms can be deactivated manually, or are automatically deactivated at a specific date or when a specific number of submissions are received.

## Related content

* [Conversion tracking overview][5]
* [Set up UTM tracking][6] - in Settings and maintenance

<!-- Referenced links -->
[1]: form-prefilled.md
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png

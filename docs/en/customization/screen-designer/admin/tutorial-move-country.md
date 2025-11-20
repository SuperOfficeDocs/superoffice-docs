---
uid: help-en-tutorial-country-before-address
title: Tutorial - Front-load country
description: In this tutorial, you will learn how to move the country field on a company or contact.
keywords: country field, screen designer
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: tutorial
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: en
index: true
redirect_from:
  - /en/ui/screen-designer/tutorial-move-country
  - /en/customization/screen-designer/tutorial-move-country
---

# Tutorial - Front-load country

## Step 1: Purpose

In SuperOffice, addresses are formatted based on country and region. To encourage users to select country first, we are going to move that field to the top of the **Company** screen.

When you are done, it should look something like this:

![Company card -screenshot][img1]

[!include[Requirement](../../../includes/req-dev-tools.md)]

## Step 2: Open the Screen Designer

1. Go to **Settings and maintenance**.
1. Select **Screen Designer** from the navigator.

![Screen designer -screenshot][img2]

## Step 3: Open the layout in edit mode

1. Select **Company** at the top.
1. Select the **Main cards** tab directly below.
1. Select the default layout from the list.
1. Click <i class="ph ph-pencil-simple" aria-label="Edit layout"></i> at the bottom of the screen.

![Company layout in edit mode -screenshot][img3]

## Step 4: Update the fields

1. Select the **Company** tab in the preview.
1. Click to select the **Country** field.
1. Grab the **=** to the left of the field label, drag it to the top of the list, and drop it into the new position.

![Company layout in edit mode -screenshot][img4]

## Step 5: Save, publish, and test results

1. Click **Save + Publish**.
1. In another browser tab, sign out of SuperOffice. Then sign back in.
1. Go to the **Company** screen to see the result.

You might want to do this for the **Contact** screen too.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/tutorial-country-result.png
[img2]: ../../../../media/loc/en/customization/open-screen-designer.png
[img3]: ../../../../media/loc/en/customization/tutorial-country-layout-before.png
[img4]: ../../../../media/loc/en/customization/tutorial-country-layout-after.png

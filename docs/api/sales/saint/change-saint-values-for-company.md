---
# Mandatory fields.
title: change_saint_values_for_company      # (Required) Very important for SEO.
description: Changing a company's saint values  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Changing a company's saint values

Saint values are used in company and project cards in SuperOffice.

The following example demonstrates how SAINT values are changed.

## Code

[!code-csharp[CS](includes/change-saint-values-for-company.cs)]

## Walk-through

Initially, we have created a connection and retrieved SAINT values of the contact with `contact_id = 30` and `isSignalled = 1`. After retrieving the SAINT values we have changed the `isSignalled` field from 1 to 0. When it is set to 0, no image is displayed on the contact card. The following image shows how it appears in the windows client.

![01][img1]

**isSignalled = 0**

![02][img2]

**isSignalled = 1**

![03][img3]

<!-- Referenced images -->
[img1]: media/image001.jpg
[img3]: media/image003.jpg
[img3]: media/image002.jpg

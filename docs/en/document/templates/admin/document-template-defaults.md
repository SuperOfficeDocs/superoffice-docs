---
uid: help-en-document-template-defaults
title: Default values for new document templates
description: Default values for new document templates
keywords: number allocation, new counter, document template counter, default values
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/options/learn/number-allocation/document-template-defaults
language: en
---

# Default values for new document templates

You can specify [default][1] values for new document templates if required. This means that the value in the **Our Ref.** field in the **Document** dialog increases by 1 each time this exact template is used. If you do not check **Automatically create new counters for new document templates**, the same counter will be used for all document templates, so that the value in the **Our Ref.** field increases by 1 each time any template is used.

> [!NOTE]
> If the **Our Ref.** field in the **Document** dialog functions as a counter field depends on if the {snum} template variable is specified for the template in question. This is defined in the Lists screen: Click **Document template**, then double-click the document template under **Items** and edit the **Our reference (default)** field in the **Edit list item** dialog.

## Specify that new document templates will have their own counter

1. Go to Settings and maintenance and select <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Options**.

1. Select the **Number allocation** tab.

1. At the bottom of the tab, select **Automatically create new counters for new document templates**.

1. Click **Defaults**.

1. Check **Unique** if you want the counter values in the **Our Ref**. field to be unique. Useful when SuperOffice CRM users allocate values themselves.

1. Check **Allow blank** to permit empty counter fields. Useful when the counter values must be unique. If **Allow blank** is checked, this means that the requirement for unique values does not apply to empty fields.

1. Check **Read only** if you do not want SuperOffice CRM users to type values into the **Our Ref.** field themselves.

1. Check **Allocate** to use the automatic counter function, so that the system enters values in the **Our Ref.** field for you.

    [See the results of different combinations of these values][1].

1. Enter the value you want the counter to start at in the **Next number** field.

1. Click **Save**.

<!-- Referenced links -->
[1]: ../../../admin/options/configure-number-allocation.md

<!-- Referenced images -->

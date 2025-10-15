---
uid: help-en-ai-categorization-setup
title: Set up AI-based categorization
description: How to train and configure categorization in SuperOffice AI
keywords: AI, categorization, machine learning, training
author: digitaldiina
date: 10.15.2025
version: 11.5
content_type: tutorial
license: aiplatform, categorization
category: automation
topic: ai
deployment: online
platform: web
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: 
  - /en/ai/configuration-ai/getting-started
  - /en/ai/admin/index
---

# Set up AI-based categorization

Categorization uses machine learning to suggest categories for incoming requests based on their content. Before this feature can be used, the AI must be trained using a selection of existing requests.

> [!NOTE]
> Categorization requires the SuperOffice AI Platform and a **Categorization license**. SuperOffice AI is available for CRM Online only.

## 1. Create a selection of requests

You must first create a selection of requests in SuperOffice to train the AI model.

1. Click <i class="ph ph-list-magnifying-glass" aria-label="Find icon"></i> **Find** or go to **New** > **Selection**.

    ![New selection options in Sales client -screenshot][img1]

1. Choose **Request** as the selection type. Use **Find Request** or pick from **Typical searches**.

    ![Typical searches for request selection -screenshot][img2]

1. Define search criteria:
    1. Add filters to match the requests you want to use for training.
    2. Click **Find**.

    ![Request selection criteria -screenshot][img3]

1. Save the selection:
    1. Click **Save as selection**.
    2. Choose static or dynamic.
    3. Enter a name and click **Save**.

    ![Select selection type -screenshot][img4]
    ![Enter selection name -screenshot][img5]

> [!NOTE]
> Only the first 5000 requests in the selection will be analyzed.

## 2. Choose the selection in Settings and maintenance

1. Open **Settings and maintenance**.
1. Select **AI services** from the Navigator.
1. Under **Categorization**, open the dropdown and search for the selection name.
1. Select the correct request selection.

    ![Choose request selection in AI services -screenshot][img6]

## 3. Analyze the request selection

Once a valid selection is chosen, the **Analyze requests** button becomes active.

> [!NOTE]
> Large datasets may take hours or even days to analyze.

1. Click **Analyze requests** to start the training process.
1. When training is complete, the **Latest training** status will show *successfully trained model*.
1. If errors occur, review the message and create a new selection if needed.

    ![Training results and feedback -screenshot][img7]
    ![Training summary examples -screenshot][img8]

## 4. Enable suggestions

After successful training:

1. Select the checkbox **Use AI to suggest categories** to activate the feature.

    ![Checkbox to enable AI suggestions -screenshot][img9]

## 5. Result: category suggestions in requests

When enabled, users will see a suggested category in the request footer. Clicking the link applies the category to the request and removes the suggestion.

If there is no match, no suggestion will be shown.

## Re-train or change selection

You can re-analyze a new or updated selection at any time:

1. Go to **Settings and maintenance** > **AI services**.
1. Under **Categorization**, choose a new selection.
1. Click **Analyze requests** to train again.

## Related content

* [How to create a selection][1]
* [Request categorization][2]
* [Other AI services][3]

<!-- Referenced links -->
[1]: ../../search-options/selection/learn/create.md
[2]: ../learn/categorization.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/choose-new-selection.png
[img2]: ../../../media/loc/en/search-options/typical-request-searches.png
[img3]: ../../../media/loc/en/ai/find-request-search-criteria.png
[img4]: ../../../media/loc/en/ai/select-selection-type-dialog.png
[img5]: ../../../media/loc/en/ai/name-selection-input.png
[img6]: ../../../media/loc/en/ai/select-category-menu.png
[img7]: ../../../media/loc/en/ai/categorization-analysis.png
[img8]: ../../../media/loc/en/ai/categorization-summary.png
[img9]: ../../../media/loc/en/ai/use-ai-suggested-categories-checkbox.png

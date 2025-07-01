---
title: config categorization AI Services
description: How to setup and configure Categorization AI Service
author: AnthonyYates
keywords: AI
content_type: tutorial, howto
deployment: online
platform: web
index: true
---

# How to setup and configure Categorization AI Service

To be able to take advantage of these services, SuperOffice Service must be in use.

For the system to form an opinion on/learn how to automatically categorize between the selected categories the system needs to be trained. This trains the system into understanding how to categorize the selected tickets.

> [!NOTE]
> To be able to choose a selection of requests to teach the system how to categorize requests, you must first create a selection of requests in SuperOffice Sales.

The Machine-learning categorization service is enabled in Settings and maintenance:

## Step 1 - Create a selection of requests to use for analysis

1. Open the Sales client.

2. Create a selection of requests to use for analysis:
     * Click either <i class="ph ph-list-magnifying-glass" aria-label="Find icon"></i> or **New > Selection**.

    ![x -screenshot][img2]

3. Create a selection type: Request
    * Either click **Find Request** or choose a selection from **Typical searches**.

    ![x -screenshot][img3]

4. Update criteria:
    1. Select your criteria to match the selection for the request you want to use for analysis.
    2. Click **Find**.

    ![x -screenshot][img4]

5. Save selection
    1. Click **Save as selection**.
    2. Select "Static selection" or "Dynamic selection".
    3. Enter a name.
    4. Click **Save**.

    ![x -screenshot][img6]

    ![x -screenshot][img7]

> [!NOTE]
> There is a limit on 5000 requests. If the selection is larger, we only analyze the first 5000 requests.

## Step 2 - Choose the selection of requests to use for analysis

> [!NOTE]
> You must have created a selection of the request in the Sales client before continuing. See step 1 above.

1. Open Settings and maintenance.

2. Click **AI services** in the menu.

3. Under **Categorization**, choose the selection of requests to teach the system.

4. Click the drop-down to select an item.

5. Search for the name of the selection to choose it.

    ![x -screenshot][img10]

## Step 3 - Analyze requests

When a request selection has been chosen, the **Analyze Requests** button is enabled.

> [!NOTE]
> **This analysis will take time!** Large selection can take days.

1. Click **Analyze Requests** to start the analysis (send the selection to the analyze service).

2. When the **Latest training** says *successfully trained model*, the "Use AI to suggest categories" checkbox is enabled:

    ![x -screenshot][img11]

    * If you get an error here, you will need to train the dataset again based upon the feedback in the error message.

Here are some examples of the different feedback you can get for the latest training:

![x -screenshot][img12]

In case of errors and other experiences - we would like to get your input and feedback. Please post your experiences on the Pilot Forum.

## Step 4 - Select options

* Click the checkbox **Use AI to suggest categories** if you want the system to suggest categories.

![x -screenshot][img13]

## Step 5 - Done

The setup is complete. New requests will be analyzed to identify if there is a suggested category for them.

When the users navigate to a request, there will be a link if there is a suggested category, in the request footer with the text: Suggested category: "category/name". When a user clicks the link, the request will be updated with the suggested category, and the suggestion link disappears. If there is no suggested category by the AI - there will not be a suggestion link.

## Re-configure

1. Open Settings and maintenance.
2. Click AI services in the menu.
3. Under **Categorization**, click the dropdown for "select item".
4. Search for the name of the selection to choose it.
5. Click the **Analyze Requests** button to start the analysis.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: media/selection-option.png
[img3]: media/find-request-menu.png
[img4]: media/find-request-search-criteria.png
[img6]: media/select-selection-type-dialog.png
[img7]: media/name-selection-input.png
[img10]: media/select-category-menu.png
[img11]: media/categorization-analysis.png
[img12]: media/categorization-summary.png
[img13]: media/use-ai-suggested-categories-checkbox.png

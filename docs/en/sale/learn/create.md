---
uid: help-en-sale-create
title: Register a sale
description: Register sales in SuperOffice Sales to have all your opportunities and customer information in one place. This how-to guide will show you how to register sales.
keywords: create sale, new sale, add sale, register sale, sale
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Register a sale

You can create a sale in SuperOffice CRM using the **New** button on the top bar. Watch this video or follow the steps below to create a sale:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/7Am9pqMyHSA]

(video length - 2:10)

## Steps

1. Click **New** on the top bar and select **Sale**.

1. Enter a **sale title** (mandatory, marked in red). This is the main identifier for the sale.

    ![Sale tab showing basic fields in the Sale card -screenshot][img1]

1. Enter the **Amount and currency** to estimate the sale's value.

1. Choose the **Sale type** from the dropdown (mandatory). Sale types define the process and may include stages or guides. Values are predefined and set up in **Settings and maintenance**.

1. (Optional) Provide additional information in the **Sale** tab, such as:
    * Link the sale to a **Company**.
    * Associate the sale with an ongoing **Project**.
    * Adjust the expected close date for the sale.
    * Use the large text box to provide an optional description of the sale.
    * Select the current **Stage** of the sale (if applicable). Stages track the sale's progress.

    > [!NOTE]
    > If the sale type for the sale does not have any stages linked to it, the sale has the status **Open**.

1. Select the **Details** tab to add financial info, such as cost, profit, and competitors.

1. **Add more details:**
    * Go to the **More** tab to [enter custom fields][12].
    * Go to the **Note** tab to [add notes][11].
    * Go to the **Links** tab to [connect activities, documents, or websites][10] to the sale.

1. Click **Save** to store the sale. The sale card is now created.

## <a id="fields"></a>Key fields explained

The following fields are available in the Sale card. Some fields are filled automatically, while others require manual input.

> [!NOTE]
> Fields and layout may vary based on **Screen designer** configurations and other UI customizations.

<!-- markdownlint-disable-file MD051 -->
### [Sale tab](#tab/sale)

* **Title:** A mandatory field for identifying the sale.
* **Description:** Optional text box for summarizing the sale.
* **Sale type:** Predefined types that define the process, potentially linked to stages or sales guides. Set up in **Settings and maintenance**.
* **Stage:** Tracks the progress of the sale. Available stages depend on the selected sale type.
* **Amount and currency:** Estimated value of the sale. *(Currency must be activated in Settings and maintenance to use this option.)*
* **Probability:** The likelihood of the sale succeeding. Based on the current stage but can be updated manually.
* **Company:** The company associated with the sale.
* **Contact:** The contact person at the company linked to the sale.
* **Project:** Links the sale to an ongoing project.
* **Owner:** The user responsible for the sale. Defaults to the currently logged in user but can be updated.
* **Sale date:** The expected close date for the sale.
* **Next activity:** Automatically populated with the oldest uncompleted follow-up. Dates prior to today are highlighted in red.
* **Stalled checkbox:** Marks the sale as on hold and enables fields for **Re-open date** and **Reason (stalled)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Details tab](#tab/details)

The **Details** tab focuses on financial details of the sale.

* **Number:** Auto-generated sale ID.
* **Source:** Displays the sale's source.
* **Competitor:** Select a predefined competitor linked to the sale (only one).
* **Total cost:** Cost associated with the sale. Updates profit automatically.
* **Profit:** Profit calculated based on the sale amount and cost.
* **Credited:** Assigns the sale to a department responsible for it.

Values for *Competitor* and *Credited* are defined in Settings and maintenance.

### [Links and Note tabs](#tab/other)

* **Links tab**: Attach relevant activities, documents, or other sales.
* **Note tab**: Add free-text notes for tracking additional information.

***

## Related content

* [Create a quote][4]
* [Update a sale][1]
* [Working with sales guides][2]

<!-- Referenced links -->
[1]: update.md
[2]: sales-guides.md
[4]: ../../quote/learn/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/create-sale.png

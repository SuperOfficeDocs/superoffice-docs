---
uid: help-en-section-tabs-configure
title: Changing the column view
description: Changing the column view
keywords: section tab, archive, column
author: Bergfrid Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Configure columns

You can customize the columns in the section tabs to display precisely the information you need. You can change which columns are displayed, as well as their order and width.

By configuring columns, you can customize displayed information and work with CRM data the way you need. Learn how to configure columns with this video or follow the steps below (video length - 1:44):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IjlPSN-u0MA]

## Change the order of the columns

To change the order of the columns in a section tab, click and drag a column header to a new location.

## Add or remove column

1. Go to the section tab you want to edit.
2. Click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers. A dialog is displayed.
3. Select or deselect the relevant columns. Use the **Filter columns** fields to filter the columns that are displayed.
4. Click **OK**.

To reset the columns to the default view, click **Reset**.

## <a id="calculate"></a>Column calculations

You can perform calculations such as sum, average, or min/max on date and number fields.

1. On the section tab, click the cogwheel symbol to open settings.

1. In the dialog, go to the **∑ Sum** tab.

1. Select the columns you want to include in the calculation. Optionally, **enable grouping** to organize the data.

    ![Section tabs settings - sum of amount and enable grouping -screenshot][img2]

1. Choose which calculation to perform on each column. The available options will depend on the field type.

**Result:**

![Sales section tab - sum and grouping on amount -screenshot][img3]

> [!NOTE]
> If your organization uses multiple currencies, ensure you are working with consistent values in sales calculations. Use the **base currency** versions of the **Amount** and **Weighted Amount** fields to maintain accuracy.

![Sales section tab - sum of amount for base currency -screenshot][img5]

## Manually adjust column widths

1. Hold the mouse pointer over the vertical dividing line to the left or right of a column heading. The mouse pointer changes into a double vertical line with arrows.

1. Click down with the mouse button and drag the divider in the required direction to increase or decrease the column width. The column widths you set are retained between sessions.

> [!NOTE]
> You cannot adjust column widths manually if **Auto-fit column width** is active.

## Automatically adjust column widths

You can set columns widths to be adjusted automatically according to the content of the columns. When columns are added or removed, all column widths are adjusted to a best fit every time. If there are too many columns to fit within the available space, a horizontal scrollbar is displayed.

1. Go to the section tab you want to edit.
2. Click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers. A dialog is displayed.
3. Select **Auto-fit column width**.
4. Click **OK**.

## Related topics

* [Group lists][3]
* [Filter the section tabs][1]
* [Export content in the section tabs][2]

<!-- Referenced links -->
[1]: filter.md
[2]: export-archives.md
[3]: group.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/learn/section-tab-sum-amount.png
[img3]: ../../../media/loc/en/learn/group-sales-by-status.png
[img5]: ../../../media/loc/en/sale/currency-adjusted-sale-amount-calculation.png

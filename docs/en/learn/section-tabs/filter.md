---
uid: help-en-section-tabs-filter
title: Filter the section tabs
description: How to use filters in the section tabs.
keywords: section tab, filter
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: howto
language: en
audience: person
audience_tooltip: SuperOffice CRM
---

# Filter the section tabs

The section tabs in SuperOffice CRM can contain large amounts of data, such as contacts, activities, and sales.

A great way to find information quickly is by using filters. Filters reduce the amount of information you are looking at, making it faster to find what you are looking for.

You can filter the content of section tabs by adding criteria to one or more columns.

Filters are personal. The filters you use, are visible only for you and you can add and remove filters at any time.

Multiple filters can be active at the same time. If a section tab does not display the expected records, check your filter settings.

Learn how to customize views by configuring columns with this short video, or read the instructions below (video length - 2:10):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/HYYI4ZCl4S4]

## Options

| Option | Description |
|---|---|
| ![icon][img2] (the filter icon) | You can filter activities and sales section tabs by date, users, and groups. |
| Activities filters (checkboxes) | You can filter activities by type (pre-defined filters). Click the arrow and select what to. |
| ![icon][img3] (column filter) | Click the funnel icon on a column header to filter on that column. |

> [!NOTE]
> The column filter is not available in all section tabs. Not all columns can be filtered.

## Filter activities and sales

1. Go to the Company, Contact, Sale, or Project screen.

2. Select the **Activities** or **Sales** section tab.

3. Click the ![icon][img2] filter icon.

4. In the **From** box, specify from how far back in time you want to show activities or sales.

5. In the **To** box, specify for how far ahead in time you want to show activities or sales.

    Click the arrow to the right of the **To** box to open a list of possible time intervals. For example, to show all activities or sales defined for the next quarter.

6. Choose one of the following options:

    * To show the activities or sales for a specific group, select the required group in the **Groups** list. The members in the group will then be selected for you on the **Associates** list on the right.

    * To show activities or sales for one or more associates, select the required contacts in the **Associates** list. To select several, hold down the CTRL key as you select the people you want.

    * To show your own activities or sales, select **Mine**.

    * To show all activities or sales for all groups and associates, select **All**.

7. Click **OK**. The tabs will show all activities or sales that match the criteria you specified.

> [!TIP]
> Hold the mouse pointer over the ![icon][img2] filter icon to display the active filter settings.
>
> Click **Show count** at the lower right of the section tab, to see how many records are displayed. The number changes according to active filters.

## Activate the column filter

1. Click ![icon][img1] to the right of the column headers and select **Enable filter**.

    ![Click the Settings button on the archive you have selected. -screenshot][img11]

1. Click **OK**.

Now, all the columns in your archive have a funnel icon behind them.

## Add column filter

1. Open the section tab that contains the information you are looking for.

1. Click on the funnel icon of the column you wish to use to find the information you need.

    ![You can click the filter icon on the column and select wanted filter -screenshot][img12]

1. In the dialog, select the information you are looking for. Depending on the type of data in the column, do one of the following:

    * Enter text and press ENTER. The default filter type is "starts with".
    * Select an item from the list.
    * Select a date range.

    For example, if you are looking for a document created by one of your colleagues, select their name and the type of document you are looking for.

    ![Click Filter to set it and show the filtered archive -screenshot][img13]

1. Click **Filter**. The section tab is updated with the records that match the filter. Filtered columns are displayed in bold text.

1. Repeat the previous step to filter by a second column.

    ![See the archive with less entities.-screenshot][img14]

## Remove filter

1. To remove a filter you have selected, you click the funnel icon again and click **Clear**.

    The list of records in the archive is updated immediately.

## Reset the column filter

Click ![icon][img2] and **Reset** to reset the filter.

## Related topics

* [Grouping lists][1]
* [Filter the list of selection members][2]

<!-- Referenced links -->
[1]: group.md
[2]: ../../search-options/selection/learn/screen/index.md#filter

<!-- Referenced images -->
[img1]: ../../../../common/icons/cog-wheel.png
[img2]: ../../../../common/icons/filter-icon.png
[img3]: ../../../media/icons/filter-column.png

[img11]: ../../../media/loc/en/learn/archives-enable-filter.png
[img12]: ../../../media/loc/en/learn/getstarted-archives-filteron.png
[img13]: ../../../media/loc/en/learn/getstarted-archives-filter-ownersetting.png
[img14]: ../../../media/loc/en/learn/getstarted-archives-filter-owner.png

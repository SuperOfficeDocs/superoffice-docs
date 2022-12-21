---
uid: help-en-search-result-service
title: Manage the display of search results
description: Manage the display of search results in Service
author: SuperOffice RnD
so.date: 06.29.2022
keywords: search, Service
so.topic: howto
language: en
---

# Manage the display of search results

Clicking the element profile button ![icon][img3] in the search results list takes you to the **Edit element profile** screen. Here you can specify how the search results should be presented:

* **Entries per page**: In this list box, you specify how many records are to be displayed per page.
* Under **Columns**, you can choose which columns are displayed in the **Result** section of the screen.
* Under **Sample table**, you can see what the search results will look like with the current settings.

## <a id="add-column" />Add columns

1. [Open the search screen][1].

2. Perform a search by entering criteria and clicking the **Search** button, so that the **Result** section appears.

3. Click the element profile button ![icon][img3] on the far right of the column headings. The **Edit element profile** screen appears. This contains a list of the columns that have already been specified.

4. If there is a **View functions** button below the list, simply go to the next item. But if there is a **Show fields** button, click this first.

5. In the left-hand field below the list, enter the required column name.

6. Click the list button ![icon][img6] next to the next field on the right, and select which field in the database you want to get data from.

7. In the **Field size** list box, set the desired column width in characters.

8. Click **Add column**. The new column is added at the bottom of the column list.

    > [!TIP]
    > It is also displayed under **Sample table** below.

9. To move the column farther to the left of the table view, click the up arrow ![icon][img7] to the right of the relevant entry under **Columns**, until it is correctly positioned.

10. Click **OK**. The column is added.

## Add functions

You can also add functions, for example, a summary column in the search results table. We will use a concrete example to explain how this works. In the example below, we assume that you already have a search result consisting of requests and that you now want to add a column showing how long it took from a request being received to a request handler reading it.

1. First follow the procedure above for adding a column called, for example, "Read by request handler", which gets information from the **Read by owner** field in the database.
2. Use the up arrow ![icon][img8] to move this column until it is just below the **Created** (ticket.created_at) column.
3. Click the **View functions** button.
4. In the field on the far left below the list, enter the name you want to give the column that will contain the function.
5. In the list box on the right of the name field, select the **Time difference** function.
6. In the next list box, select **Column 3**, corresponding to the **Created** column.
7. In the next list box, select **Column 4**, corresponding to the **Read by request handler** column.
8. Click **Add column** The new column containing the **Time difference** function is added at the bottom of the column list.
9. To move the column farther to the left of the table view, click the up arrow ![icon][img8] to the right of the relevant entry under **Columns**, until it is correctly positioned.
10. Click **OK**. The column containing the function is added.

> [!TIP]
> You can use this example as a basis for adding columns containing other functions.

## Change the order of columns

Use the arrow buttons ![icon][img8] and ![icon][img9] to the right of the columns to move the various columns where you want.

## Edit columns

You can edit the information such as name and width about the existing columns.

1. Open the **Edit element profile** screen as described above.
2. To the right of the required column, click the pencil icon ![icon][img2]. The fields under the column overview show information specified for the selected column.
3. Edit the information as described under [Add columns](#add-columns) or [Add functions](#add-functions).
4. Click the **Update column** button.
5. Click **OK**. The changes are saved.

## Delete columns

Click the delete icon ![icon][img1] to the right of the required column. The column is removed immediately.

<!-- Referenced links -->
[1]: index.md#open

<!-- Referenced images -->
[img1]: ../../../../../common/icons/delete-red.png
[img3]: ../../../../../common/icons/settingstools.png
[img6]: ../../../../../common/icons/dropdown-arrow.png
[img7]: ../../../../media/icons/arrow-up.png
[img8]: ../../../../media/icons/service/rank-up.png
[img9]: ../../../../media/icons/service/rank-down.png
[img2]: ../../../../media/icons/edit.png

---
uid: help-en-selections-columns-service
title:  Manage columns in selections
description: How to manage columns in selections in Service.
author: SuperOffice RnD
so.date: 06.29.2022
keywords: selection
so.topic: howto
language: en
---

# Manage columns in selections

When you create or edit selections, you can adjust how many columns to display in the selection in question.

## Add columns

1. Open the **Edit selection** screen.

2. Go to the **Profile** tab. Under **Columns** is a list of the columns already specified.

3. If there is a **View functions** button below the list, simply go to the next item. But if there is a **Show fields** button, click this first.

4. In the left-hand field below the **Columns** list, enter the required column name (label).

5. In the next field, click the list button ( ![icon][img3] ), and select which field in the database you want to get data from.

6. In the **Field size** field, set the desired column width in characters.

7. Click **Add column**. The new column is added at the bottom of the column list.

    > [!TIP]
    > It is also displayed on the far right under **Sample table**.

8. To move the column farther to the left of the table view, click the up arrow ( ![icon][img4] ) to the right of the relevant entry under **Columns**, until it is correctly positioned.

9. Click **OK**. The column is added.

## Add functions

You can also add functions, for example, a summary column in the selection. We will use a concrete example to explain how this works. In the example below, we assume that you already have a selection based on the **Request** source table and that you now want to add a column showing how long it took from a request being received to a request handler reading it.

1. First follow the procedure above for adding a column called, for example, "Read by request handler", which gets information from the **Read by owner** field in the database.

2. Use the up arrow ( ![icon][img4] ) to move this column until it is just below the **Created** (ticket.create_at) column.

3. Click the **View functions** button.

4. In the field on the far left below the list, enter the name you want to give the column that will contain the function.

5. In the list box on the right of the name field, select the **Time difference** function.

6. In the next list box, select **Column 3**, corresponding to the **Created** column.

7. In the next list box, select **Column 4**, corresponding to the **Read by request handler** column.

8. Click **Add column**. The new column containing the **Time difference** function is added at the bottom of the column list.

9. To move the column farther to the left of the table view, click the up arrow ( ![icon][img4] ) to the right of the relevant entry under **Columns**, until it is correctly positioned.

10. Click **Execute**. The column containing the function is added in the **Result** tab.

> [!TIP]
> You can use this example as a basis for adding columns containing other functions.

## Change the order of columns

1. Open the **Edit selection** screen.
2. Go to the **Profile** tab. Under **Columns** is a list of the columns already specified.
3. Use the arrow buttons ( ![icon][img4] and ![icon][img5] ) to the right of the columns to move the various columns where you want.
4. Click **OK**. The changes are saved.

## Edit columns

You can edit the information about the existing columns, for example the name and column widths.

1. Open the **Edit selection** screen.
2. Go to the **Profile** tab. Under **Columns** is a list of the columns already specified.
3. To the right of the required column, click the edit icon ( ![icon][img2] ). The fields under the column overview show information specified for the selected column.
4. Edit the information as described under [Add columns](#add-columns) or [Add functions](#add-functions).
5. Click the **Update column** button.
6. Click **OK**. The changes are saved.

## Delete columns

1. Open the **Edit selection** screen.
2. Go to the **Profile** tab. Under **Columns** is a list of the columns already specified.
3. Click the delete icon ( ![icon][img1] ) to the right of the required column. The column is removed immediately.
4. Click **OK**. The changes are saved.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../..../common/icons/delete-red.png
[img2]: ../../../..../media/icons/edit.png
[img3]: ../../../../..../common/icons/dropdown-arrow.png
[img4]: ../../../..../media/icons/service/rank-up.png
[img5]: ../../../..../media/icons/service/rank-down.png

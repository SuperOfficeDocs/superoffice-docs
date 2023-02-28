---
uid: help-en-rms-search
title: rms search
description: rms search
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Search in SuperOffice Service

<details><summary>Try the shortcut search</summary>

## Shortcut search

To quickly access a specific record (such as a request or contact), function or screen in SuperOffice Service, use the "shortcut search":

1. Press **CTRL+SPACE** on your keyboard. The shortcut popup shows a fast searcher and all available menu items from the navigator, personal settings and system settings.
2. Enter a search term, such as a function name, request ID, contact name or menu item. The result updates dynamically as you type.
3. Select the result you want to open.

> [!TIP]
> You can also use the [keywords used in the quick search][1] to search for specific items like contacts or companies.

</details>

> [!TIP]
> There is also a [quick search option][1]. In addition, clicking the various [navigator buttons][2] gives you access to more search options.

## <a id="open" />Open the search screen

There are many different ways to bring up the search screen, depending on where in the system you are:

* You can select **Requests** > **Find requests** to [search for requests][3].
* You can use [predefined lists][4] to search for requests.
* You can select **Customers** > **Find contacts** or **Find companies** to search for contacts and companies.
* In the knowledge base, you can click the **Search** icon ![icon][img6] to the right of a folder name to search for different types of content.
* The search screen is used as the basis for creating some [types of selection][5].

## The Criteria screen

In the **Criteria** screen you enter the search criteria in the available fields. You can add additional fields by clicking **Add criteria**.

> [!TIP]
> You can also run an "empty" search, in other words a search where you do not enter any search criteria. This lets you display all records of the relevant type, such as requests.

When you click **Search**, a new screen opens with a list of the records that match these criteria.

The list below explains how to use the different types of field that can be displayed under **Criteria**:

| Field | How is it used? |
|:-----:|-----------------|
| ![icon][img7] | In an ordinary text field, you simply enter what you are searching for. |
| ![icon][img3] | If there is a list button next to the field, click the button and select an option from the list that appears. You can also start by typing text into the field and selecting from the list that appears. |
| ![icon][img4] | If there is a **Add** button next to a field, this means that you can have more possible values for a field. For example, you can specify that you want to search for requests owned by request handler A or requests owned by request handler B. |
| ![icon][img5] | You delete search criteria by clicking the delete icon to the right of the criterion in question. Click **Advanced view** to show this button. |

At the bottom of the **Criteria** screen, you have the following options:

* **Clear search fields**: When you click this button, the values entered in the fields in the search screen are cleared. This is a quick way of emptying all the fields.
* **Restore default**: When you click this button, all the [criteria you have added](#add-search-criteria) are removed.
* **Save as selection**: Click here to [create a selection consisting of the records that meet the specified criteria][6].
* **Advanced view**: Click here for access to more [advanced search options](#use-advanced-view).

## Add search criteria

The search screen always shows the most relevant criteria for what you are searching for, for example requests or contacts. But you can add more criteria yourself.

1. Click the **Add criteria** button in the **Criteria** screen. A dialog box displays with two empty fields.
2. In the **Input the label for the field here** field, you can enter a custom name for the field. Otherwise the default name is used.
3. In the **Choose field** list, select which field in the database the values are to be obtained from.
4. Click **OK**. The new criterion is added below the others.

> [!TIP]
> You can return to the original search criteria by clicking ![icon][img1] and selecting **Restore default**.

## The search results

When you have specified search criteria under **Criteria** and clicked **Search**, all the records that match the search criteria are displayed in a list. The first record in the list is selected by default and displayed in the preview section. Click a record in the list to show a preview.

[!include[How to preview search](../../../learn/includes/show-reading-pane.md)]

You can also open a record by double-clicking the relevant row.

If you click one of the column headings below **Result**, you get the following options:

* **Sort ascending**: Clicking here sorts the records in ascending order, for example, alphabetically if the column contains text, based on the column in question.
* **Sort descending**: Click here to sort the records in descending order, based on the column in question. If the column contains numbers (such as ID numbers), the highest is displayed at the top.
* **Group by**: For example, if you have the "Category" column containing the values "Sales", "Support" and "Invoices", the records are divided into three groups with these headings.
* **Functions**: If you click here you can choose between **Mathematical functions** and **Statistical functions**. An example of a mathematical function is summing a column consisting of numerical values. With regard to statistical functions, you can, for example, [add a column][7] showing request response times, and then use the **Average** statistical function to display the average response time for the displayed requests. If, instead, you select **Remove functions**, you remove any previously specified functions.

At the upper right corner of the search results list are the following buttons:

* **Update content** ![icon][img1]: Clicking this button updates the search result with any new records that also match the criteria.
* Click the ![icon][img2] menu button in the upper right corner to access the change the view options.
* **Edit element profile** ![icon][img8]: Clicking this button takes you to the **Edit element profile** screen, where you can determine [how the search results should be presented][8].

Under the list, you can click ![icon][img2] to access the following options:

* **Export**: Click here to export the list under **Result** to a file. You can choose from these formats: Excel, HTML and plain text.
* **Batch management**: If you select one or more records in the list, you can click this button and select an action to perform on all the selected records simultaneously.

## The preview section

This section of the screen displays the contents of the record selected in the list.

[!include[How to preview search](../../../learn/includes/show-reading-pane.md)]

## Use advanced view

If you click the ![icon][img2] menu button in the **Criteria** screen and select **Advanced view**, you gain access to more advanced search options. These are normally relevant only for experienced users. For example, you can specify that you want to search for all requests that do not have a specific owner, or all requests where one field is empty, instead of having a set value. The options displayed here will depend on the context of your search. For instance, different fields are shown when searching for requests compared with searching for contacts. Some of the available options are outlined below:

* At the top are checkboxes you can use to turn on or off the display of different items.
* For each individual search criterion, you can define operators. You do this by selecting the option you want in the list box to the right of the criterion. The operators available will depend on the type of criterion in question. For the **Category** criterion, you can choose between, for example, **Is one of** and **Is not one of**. For the **Request registered** criterion, you can select a time interval.
* You can also define operators between the search criteria. You do this by selecting either **And** or **Or** in the list boxes between the criteria.

To return to the ordinary view, click the **Simple view** button at the top of the screen.

<!-- Referenced links -->
[1]: quick-search.md
[2]: in-navigator.md
[3]: ../../../request/learn/find.md
[4]: ../../../request/learn/find.md#list
[5]: ../../selection/learn/in-service/index.md
[6]: ../../selection/learn/in-service/create-from-search.md
[7]: customize-presentation.md#add-column
[8]: customize-presentation.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/refresh.png
[img2]: ../../../../media/icons/btn-menu.png
[img4]: ../../../../media/icons/btn-add.png
[img7]: ../../../../media/icons/service/inputText.png
[img3]: ../../../../../common/icons/dropdown-arrow.png
[img5]: ../../../../../common/icons/delete-red.png
[img6]: ../../../../../common/icons/search-icon-black.png
[img8]: ../../../../../common/icons/settingstools.png

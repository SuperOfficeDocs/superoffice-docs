---
uid: help-en-search-criteria
title: Using search criteria
description: Using search criteria
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Use search criteria

You use search criteria to define what you are looking for, for example "companies with an address in Denmark". Search criteria are used in multiple places in SuperOffice CRM, for instance in the **Find** screen and when creating selections. But, regardless of what you are using the criteria for, you work with them in the same way.

Everywhere you can enter search criteria, you will find a criteria list containing the selected search criteria.

Typical searches are there to help you get started and create your own search of CRM data. After you’ve selected a typical search, you can add and edit the search criteria. And once you’ve created a useful search that you’d like to use again, you can save it as a selection.

Watch this video to learn how to do a typical search and modify it by adding new search criteria or follow the step-by-step guide below (video length – 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://youtu.be/gx-vXm-b_7g]

## Add search criteria

1. Go to the criteria list.
    * Click **Find** in the top bar. The criteria list is in the **Criteria** tab.
    * Or
    * Go to the required selection and select the **Criteria** tab.

2. Click the **Add** button.
    A new line is added to the criteria list and a list of fields to choose from is displayed.

3. Select the field you want to search for information in. You can also [enter the start of the name][2] in the appropriate field. There are different types of fields (click to expand):

    * <details><summary>Text field</summary>

        If the field you are searching in is a text field (such as a name), the search is made on text or numbers you enter. A list with the following options is displayed:

        [!include[Search criteria](../../learn/includes/list-search-criteria.md)]

        Select one of these options and then enter the search criteria in the text field on the right.

    </details>

    * <details><summary>Yes/No field</summary>

        If the field you are searching in is a Yes/No field, for example, the **No mailings** field in the **Company** screen, two radio buttons are displayed. You can choose between **Yes** and **No**.

    </details>

    * <details><summary>Date field</summary>

        If the field you are searching in is a date field, for example, the **Date** field in the **Document** dialog, a list box is displayed containing the following options:

        [!include[Search criteria](../../learn/includes/list-date-criteria.md)]

        Select the required option. Depending on what you select, the field is automatically filled with a date or date range, or you can enter the date you want. You can also select a date in the calendar which is displayed when you click the arrow button ![icon][img1].

    </details>

    * <details><summary>Number field</summary>

        If the field you are searching in contains a numerical value, for example, the **Amount** field in the **Sale** screen, a list box is displayed containing the following options:

        [!include[Search criteria](../../learn/includes/table-number-criteria.md)]

        Select the required option and enter the required numerical value in the text field on the right.

    </details>

    * <details><summary>List field</summary>

        If the field you are searching in is a field containing lists, for example, the **Business** field in the **Company** screen, a list box appears with the options **Is one of** and **Is not one of**.

        Click the **Select items** field to display the list of values.

        If the list is long, you can type text in the **Search criteria** fields to search for values.

        Click outside the list to close it.

    </details>

    * <details><summary>Status field</summary>

        If the field you are searching in is a status field, select the required status.

        The statuses are created and maintained in SuperOffice Settings and maintenance.

        * Status fields are only relevant if you have purchased a licence for and have enabled status monitors.

    </details>

    * <details><summary>Counter field</summary>

        Counters can be, for example, the number of sales in a period or the date of the last completed sale.

        <details><summary>Click here to see some examples of statuses.</summary>

        [!include[Examples](../../learn/includes/status-examples.md)]
        </details>

        Counter fields can be found under **Counters (SAINT)** in the list of criteria.

        The counters are created and maintained in SuperOffice Settings and maintenance.

        * Counter fields are only relevant if you have purchased a licence for and have enabled status monitors.

        To the right of the fields, you can click the links to specify additional criteria for the counters. The available options will depend on the type of record and counter you are working with.

        **SAINT type**: Here you choose the activity type you want to search for.
        **Status**: Here you choose the status of the record you want to search for.
        **Direction**: Here you can choose if the activity is incoming or outgoing.
        **Amount class**: Here you choose the sale's amount class.
        **Intention**: Here you choose the intention of the activity.

        Depending on what you selected above, a list box for a date field or a number field is displayed. These list boxes work as described above. Select the required option and enter the required numerical value or date in the text field.

4. Select values for the search criteria in the various fields on the line.

5. Click **Add** to add a new line, or click **Or** to add a new set of criteria.

## Change search criteria

To change a search criterion, click it and select a different one from the list that appears.

## Move search criteria

To move criteria (a line), click and drag ![icon][img2].

## Delete search criteria

To delete a search criterion, click ![icon][img3].

## Activate or deactivate search criteria

When you open the **Find** screen, it contains default search criteria or the search criteria you specified the last time you used the dialog. To use different search criteria than those shown, you have the following options:

* You can delete them by clicking ![icon][img3]
* You can deactivate one or more search criteria by leaving the value field empty. A deactivated search criterion remains in the criteria list and can be simply reactivated when needed.
* You can deactivate all the search criteria by clicking **Clear all**.

## Move search criteria up or down

To move criteria, click and drag ![icon][img2]. This has no practical effect on the search, but allows you to arrange the criteria in your preferred order. If some of the criteria are not being used, but you still want to keep them, you can move inactive criteria to the bottom if the list.

## Reset to default search criteria

The criteria lists contain a set of default criteria you can edit or remove as required. To reset the criteria list to the default criteria, click **Reset to default**.

## What would you like to do now?

* [Use the Find screen][1]

<!-- Referenced links -->
[1]: find-screen.md
[2]: using-fastsearcher.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/icons/criteria-move.png
[img3]: ../../../../common/icons/delete-circle-red.png

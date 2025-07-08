---
uid: help-en-search-criteria
title: Working with search criteria
description: How to add and modify search criteria
keywords: search, criteria, find
author: Bergfrid Dias
date: 05.25.2023
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Working with search criteria

You use search criteria to define what you are looking for, for example "companies with an address in Denmark". Search criteria are used in multiple places in SuperOffice CRM, for instance in the **Find** screen and when creating selections. But, regardless of what you are using the criteria for, you work with them in the same way.

Everywhere you can enter search criteria, you will find a criteria list containing the selected search criteria.

Typical searches are there to help you get started and create your own search of CRM data. After you have selected a typical search, you can add and edit the search criteria. And after you have created a useful search that you would like to use again, you can save it as a selection.

Watch this video to learn how to do a typical search and modify it by adding new search criteria or follow the step-by-step guide below (video length – 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

## Add search criteria

1. Go to the criteria list.
    * Click **Find** in the top bar. The criteria list is in the **Criteria** tab.
    * Or, go to the required selection and select the **Criteria** tab.

1. Click the **Add** button.
    A new line is added to the criteria list and a list of fields to choose from is displayed.

1. Select the field you want to search for information in. You can also [enter the start of the name][2] in the appropriate field. There are different types of fields:

    * [Text](#text)
    * [Yes/No](#yes-no)
    * [Date](#date)
    * [Number](#number)
    * [List](#list)
    * [Status](#status)
    * [Counter](#counter)

1. Select values for the search criteria in the various fields on the line.

1. Click **Add** to add a new line, or click **Or** to add a new set of criteria.

## Field types

### <a id="text"></a>Text field

If the field you are searching in is a text field (such as a name), the search is made on text or numbers you enter. A list with the following options is displayed:

* Starts with
* Contains
* Ends with
* Equals
* Is exactly
* Does not begin with
* Does not contain
* Does not end with
* Is not

Select one of these options and then enter the search criteria in the text field on the right.

### <a id="yes-no"></a>Yes/No field

If the field you are searching in is a Yes/No field, for example, the **No mailings** field in the Company screen, two radio buttons are displayed. You can choose between **Yes** and **No**.

### <a id="date"></a>Date field

If the field you are searching in is a date field, for example, the **Date** field in the **Document** dialog, a list box is displayed containing the following options:

* Before
* Equals
* After
* Between
* Before today
* Today
* After today
* This...
* This and next...
* Next...
* This and previous...
* Previous...
* This, previous and next...

Select the required option. Depending on what you select, the field is automatically filled with a date or date range, or you can enter the date you want. You can also select a date in the calendar which is displayed when you click <i class="ph ph-caret-down" aria-label="Chevron"></i>.

### <a id="number"></a>Number field

If the field you are searching in contains a numerical value, for example, the **Amount** field in the Sale screen, a list box is displayed containing the following options:

| Option | Description |
|---|---|
| = | Equals |
| &gt; | Greater than |
| &lt; | Less than |
| &gt;= | Greater than or equals |
| &lt;= | Less than or equals |
| &lt; &gt; | Does not equal |
| Between | The value lies between specified figures |

Select the required option and enter the required numerical value in the text field on the right.

### <a id="list"></a>List field

If the field you are searching in is a field containing lists, for example, the **Business** field in the Company screen, a list box appears with the options **Is one of** and **Is not one of**. For company and contact interests, the options are **Is equal**, **Is one of**, and **None of**.

1. Click the **Select items** field to display the list of values.
1. If the list is long, you can type text in the **Search criteria** fields to search for values.
1. Click outside the list to close it.

### <a id="status"></a>Status field

If the field you are searching in is a status field, select the required status.

The statuses are created and maintained in Settings and maintenance. Status fields are only relevant if you have purchased a licence for and have enabled status monitors.

### <a id="counter"></a>Counter field

[Counters][3] can be, for example, the number of sales in a period or the date of the last completed sale.

Counter fields can be found under **Counters (SAINT)** in the list of criteria.

1. To the right of the fields, click the links to specify additional criteria for the counters. The available options depend on the type of record and counter you are working with.

    * **SAINT type**: Choose the activity type you want to search for.
    * **Status**: Choose the status of the record you want to search for.
    * **Direction**: Choose if the activity is incoming or outgoing.
    * **Amount class**: Choose the sale's amount class.
    * **Intention**: Choose the intention of the activity.

1. Depending on what you selected above, a list box for a date field or a number field is displayed. These list boxes work as described above. Select the required option and enter the required numerical value or date in the text field.

The counters are created and maintained in Settings and maintenance. Counter fields are only relevant if you have purchased a licence for and have enabled status monitors.

## Manage list of criteria

The criteria lists contain a set of default criteria you can edit or remove as required.

When you open the **Find** screen, it contains default search criteria or the search criteria you specified the last time you used the dialog. To use different search criteria than those shown, you have the following options:

| Action | Steps |
|---|---|
| Move a criterion | Click <i class="ph ph-equals" aria-label="="></i> and drag the line. |
| Change a criterion | Click it and select a different one from the list that appears. |
| Deactivate one or more criteria | Leave the value field empty. |
| Deactivate all criteria | Click **Clear all**. |
| Delete a criterion | Click <i class="ph ph-x-circle" aria-label="X"></i>. |
| Reset the list | Click **Reset to default**. |

> [!NOTE]
> Moving a criterion has no practical effect on the search, but allows you to arrange the criteria in your preferred order. To keep unused (inactive) criteria, you can move them to the bottom if the list.
>
> A deactivated search criterion remains in the criteria list and can be reactivated when needed.

## Related content

* [The Find screen][1]
* [Selections][4]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md
[4]: ../selection/learn/index.md

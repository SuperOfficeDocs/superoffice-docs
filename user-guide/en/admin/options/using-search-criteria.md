---
uid: help-en-using-search-criteria
title: using search criteria
description: using search criteria
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

<!-- REUSE user\standardcrm\key-functions\using-search-criteria.md -->

# Use search criteria

You can add or edit search criteria in, for example, the **Find** dialog, the **Add/edit search criteria** dialog, and the criteria list in the **SAINT** screen.

## Add search criteria

In the list box, select the field you want to search for information in. The fields displayed depend on what the criteria list is to be used for. There are different types of fields. Click the field description for more information about the field type:

* <!-- Fix reuse ID=a2 -->

    If the field you are searching in is a text field, e.g. a name field, the search is made on text or numbers you enter. The list that is displayed may contain the following options:

  * Starts with
  * Does not start with
  * = / Equals
  * &lt;&gt; / Does not equal
  * Exact match
  * Contains
  * Does not contain
  * Ends with
  * Does not end with

    Select one of these options and then enter the search criteria in the appropriate text field.

* <!-- Fix reuse ID=a6 -->

    If the field you are searching in is a Yes/No field, two option buttons are displayed. You can choose between **Yes** and **No**.

* <!-- Fix reuse ID=a3 -->

    If the field you are searching in is a date field, a list box with the following options may be displayed:

  * Before
  * Equals
  * After
  * Between
  * To
  * From
  * Today
  * After today
  * Previous week
  * This week
  * Next week
  * Previous month
  * This month
  * Next month
  * Previous quarter
  * This quarter
  * Next quarter
  * This half
  * This year

    Select the option you require and then enter the required date in the date field, or select a date in the calendar that appears when you click the arrow button ( ![icon][img3] ) to the right of the date field.

* <!-- Fix reuse ID=a4 -->

    If the field you are searching in contains numerical values, a list box with the following options is displayed:

    | Symbol | Description |
    |---|---|
    | &lt; | Less than |
    | &gt; | More than |
    | = | Equals |
    | &lt;&gt; | Does not equal |
    | &gt;= | Greater than or equals |
    | &lt;= | Less than or equals |
    | Between | The value lies between specified figures |

    Select the required option and enter the required numerical value in the text field.

* <!-- Fix reuse ID=a5 -->

    If the field you are searching in is a field containing lists, a dialog appears with several fields that vary depending on the type of values involved. But all of them have a list box, where you will find, for example, the following options:

  * Is one of
  * Is not one of
  * Contains
  * Equals
  * Does not equal

    The list box can also contain user-defined values. Select the required option.

    Under the list box are two panes. In the left pane are values you can select from, and in the right pane are values you are adding.

    To add a value:

    Select the required value(s) in the pane on the left, and click the right arrow ( ![icon][img1] ). The selected value(s) are displayed under **Selected values** in the pane on the right.

    To remove a value:

    Select the required value(s) in the pane on the right, and click the left arrow ( ![icon][img2] ).

    To add all values:

    Click **Select all** ( ![icon][img4] ) at the bottom of the left-hand pane, and then click the right arrow ( ![icon][img1] ). The values are displayed under **Selected values** in the pane on the right.

    To remove all selected values:

    Click **Select all** ( ![icon][img4] ) at the bottom of the right-hand pane, and then click the left arrow ( ![icon][img2] ). All the selected values are removed.

* <!-- Fix reuse ID=a7 --> ( ![icon][img5] )

    > [!NOTE]
    > This option does not apply to status monitors.

    If the field you are searching in is a status field, you just need to select the required status.

    A status field may be displayed with two different icons:

    ![icon][img5] (updated) – the status is updated.

    ![icon][img6] (not updated) – the status is not updated, but can still be used in the search. A search on statuses that are not updated will however return data that are not updated. The status should be regenerated in Settings and maintenance before it is used in a search.

  * Status fields are only relevant if you have purchased a licence for and have enabled status monitors.

* <!-- Fix reuse ID=a1 --> ( ![icon][img7] ![icon][img8] )

    Counters can be, for example, the number of sales in a period or the date of the last completed sale. <!-- Fix reuse ID=a11 -->Click here to see examples of the use of counters in a search.

    Each counter field may be shown with two different icons, depending on whether or not the counter values are updated.

    | Entity | Updated | Not updated* |
    | Company | ![icon][img7] | ![icon][img10] |
    | Project | ![icon][img8] | ![icon][img9] |

    \*the counter values are not updated, but can still be used in the search. A search on counter values that are not updated will however return data that are not updated. The counter values should be regenerated in Settings and maintenance before they are used in a search.

  * Counter values are only relevant if you have purchased a licence for and have enabled status monitors.

    Under **Field** you will find one or more of these options, depending on whether you choose a counter field for sales or activities:

    **SAINT type**: Here you choose the activity type you want to search for.
    **With status**: Here you choose the status of the sale you want to search for.
    **Direction**: Here you can choose whether the activity is incoming or outgoing.
    **Amount class**: Here you choose the sale's amount class. See [Sale - Amount class][1].
    **Intention**: Here you choose the intention of the activity.

    Depending on what you have selected above, a list box for a date field or a number field is displayed. These list boxes work as described above. Select the required option and enter the required numerical value or date in the text field.

**Change search criteria:**

If you want to change a search criterion in the **Find** dialog, click it and select a different one from the list that appears, as described above.

<!-- Referenced links -->
[1]: ../lists/sale-amount-class.md

<!-- Referenced images -->
[img1]: ../../../media/icons/pil-hoeyre.bmp
[img2]: ../../../media/icons/pil-venstre.bmp
[img3]: ../../../media/icons/dialogboksknapper-pil-ned.bmp
[img4]: ../../../media/icons/admin/velg-alle.bmp
[img5]: ../../../media/icons/admin/status-aktiv.bmp
[img6]: ../../../media/icons/admin/status-inaktiv.bmp
[img7]: ../../../media/icons/admin/saint-counter-company.bmp
[img8]: ../../../media/icons/admin/saint-counter-project.bmp
[img9]: ../../../media/icons/admin/saint-counter-project-dis.bmp
[img10]: ../../../media/icons/admin/saint-counter-company-dis.bmp

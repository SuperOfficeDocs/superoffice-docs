---
uid: help-en-settings-search-criteria
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

In the list box, select the field you want to search for information in. The fields displayed depend on what the criteria list is to be used for. There are different types of fields (click to expand):

* <details><summary>Text field</summary>

    If the field you are searching in is a text field, e.g. a name field, the search is made on text or numbers you enter. The list that is displayed may contain the following options:

    [!include[Search criteria](../../includes/list-search-criteria.md)]

    Select one of these options and then enter the search criteria in the appropriate text field.

    </details>

* <details><summary>Yes/No field</summary>

    If the field you are searching in is a Yes/No field, two option buttons are displayed. You can choose between **Yes** and **No**.

    </details>

* <details><summary>Date field</summary>

    If the field you are searching in is a date field, a list box with the following options may be displayed:

    [!include[Search criteria](../../includes/list-date-criteria.md)]

    Select the option you require and then enter the required date in the date field, or select a date in the calendar that appears when you click the arrow button ![icon][img3] to the right of the date field.

    </details>

* <details><summary>Number field</summary>

    If the field you are searching in contains numerical values, a list box with the following options is displayed:

    [!include[Search criteria](../../includes/table-number-criteria.md)]

    Select the required option and enter the required numerical value in the text field.

</details>

* <details><summary>List field</summary>

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

  </details>

* <details><summary>Status field</summary>

    > [!NOTE]
    > This option does not apply to status monitors.

    If the field you are searching in is a status field, you just need to select the required status.

    A status field may be displayed with two different icons:

    ![icon][img5] (updated) – the status is updated.

    ![icon][img6] (not updated) – the status is not updated, but can still be used in the search. A search on statuses that are not updated will however return data that are not updated. The status should be regenerated in Settings and maintenance before it is used in a search.

  * Status fields are only relevant if you have purchased a licence for and have enabled status monitors.

</details>

* <details><summary>Counter field</summary>

    Counters can be, for example, the number of sales in a period or the date of the last completed sale.

    <details><summary>Click here to see some examples of statuses.</summary>

    [!include[Examples](../../includes/status-examples.md)]

    </details>

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
[1]: ../../sale/admin/add-amount-class.md

<!-- Referenced images -->
[img1]: ../../../media/icons/arrow-right.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../../common/icons/dropdown-icon.png
[img4]: ../../../media/icons/merk-alle.bmp
[img5]: ../../../media/icons/admin/status-aktiv.bmp
[img6]: ../../../media/icons/admin/status-inaktiv.bmp
[img7]: ../../../media/icons/admin/saint-counter-company.bmp
[img8]: ../../../media/icons/admin/saint-counter-project.bmp
[img9]: ../../../media/icons/admin/saint-counter-project-dis.bmp
[img10]: ../../../media/icons/admin/saint-counter-company-dis.bmp

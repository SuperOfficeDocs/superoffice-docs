---
uid: help-en-using-search-criteria
title: Using search criteria
description: Using search criteria
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Use search criteria

You use search criteria to define what you are looking for, e.g. "companies with an address in Denmark". Search criteria are used in a number of places in SuperOffice CRM, for instance in the **Find** screen and when creating selections. But, regardless of what you are using the criteria for, you work with them in the same way.

Everywhere you are able to enter search criteria, you will find a criteria list containing the selected search criteria. Click these links to find out more about search criteria:

[Add search criteria](Using-search-criteria.md#AddSearchCriteria)

[Change search criteria](Using-search-criteria.md#EditSearchCriteria)

[Move search criteria](Using-search-criteria.md#Move-search-criteria)

[Delete search criteria](Using-search-criteria.md#DeleteSearchCriteria)

[Activate or deactivate search criteria](#Activating-or-deactivating-search-criteria)

[Move search criteria up or down (change order)](Using-search-criteria.md#Criteria-change-order)

[Reset to default search criteria](Using-search-criteria.md#Default-driteria)

## Add search criteria

1. Go to the criteria list.  
    <!-- Fix reuse ID=a1 -->
    The criteria list can be found in the following different locations, all depending on what you want to use the search criteria for:

    * Dynamic selection:  
        Go to the required selection and select the **Criteria** tab.
    * The **Find** screen:  
        Click **Find** in the top bar (see [Use the Find screen](Find-dialog.md)). The criteria list is in the **Criteria** tab.
2. Click the **Add** button.  
    A new line is added to the criteria list and a list of fields to choose from is displayed.
3. Select the field you want to search for information in. You can also enter the start of the name in the appropriate field (see [FastSearcher](Using-FastSearcher.md)). There are different types of fields. Click the field description for more information about the field type:
    * <!-- Fix reuse ID=a7 -->
        If the field you are searching in is a text field (e.g. a name field), the search is made on text or numbers you enter. A list with the following options is displayed:

        * Starts with
        * Contains
        * Ends with
        * Equals
        * Between
        * Does not begin with
        * Does not contain
        * Does not end with
        * Is not

        Select one of these options and then enter the search criteria in the text field on the right.
    * <!-- Fix reuse ID=a6 -->
        If the field you are searching in is a Yes/No field, e.g. the **No mailings** field in the **Company** screen, two radio buttons are displayed. You can choose between **Yes** and **No**.
    * <!-- Fix reuse ID=a3 -->
        If the field you are searching in is a date field, e.g. the **Date** field in the **Document** dialog, a list box is displayed containing the following options:

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

        Select the required option. Depending on what you select, the field at the far right of the line is automatically filled with a date or date range, or you can enter the date you want. You can also select a date in the calendar which is displayed when you click the arrow button ( ![icon](../media/Dialogboksknapper-pil-ned.bmp) ).
    * <!-- Fix reuse ID=a4 -->
        If the field you are searching in contains a numerical value, e.g. the **Amount** field in the **Sale** screen, a list box is displayed containing the following options:

        <table style=" vertical-align:top; width:100%; max-width:89.811%;" data-cellspacing="0">
        
        <tbody>
        <tr>
        <td><p>=</p></td>
        <td><p>Equals</p></td>
        </tr>
        <tr>
        <td><p>&gt;</p></td>
        <td><p>Greater than</p></td>
        </tr>
        <tr>
        <td><p>&lt;</p></td>
        <td><p>Less than</p></td>
        </tr>
        <tr>
        <td><p>&gt;=</p></td>
        <td><p>Greater than or equals</p></td>
        </tr>
        <tr>
        <td><p>&lt;=</p></td>
        <td><p>Less than or equals</p></td>
        </tr>
        <tr>
        <td><p>&lt; &gt;</p></td>
        <td><p>Does not equal</p></td>
        </tr>
        <tr>
        <td><p>Between</p></td>
        <td><p>The value lies between specified figures</p></td>
        </tr>
        </tbody>
        </table>

        Select the required option and enter the required numerical value in the text field on the right.
    * <!-- Fix reuse ID=a5 -->
        If the field you are searching in is a field containing lists, e.g. the **Business** field in the **Company** screen, a list box appears with the options **Is one of** and **Is not one of**.

        Click the **Select items** field to display the list of values.

        If the list is long, you can type text in the **Search criteria** fields to search for values.

        Click outside the list to close it.
    * <!-- Fix reuse ID=a9 -->
        If the field you are searching in is a status field, you just need to select the required status.

        The statuses are created and maintained in SuperOffice Settings and maintenance.

        * Status fields are only relevant if you have purchased a licence for and have enabled status monitors.
    * <!-- Fix reuse ID=a10 -->
        Counters can be, for example, the number of sales in a period or the date of the last completed sale. <!-- Fix reuse ID=a2 -->.

        ## Companies/contacts

        <table>
        
        <tbody>
        <tr>
        <td><p>Status name</p></td>
        <td><p>Criteria</p></td>
        <td><p>Explanation</p></td>
        <td><p>Task</p></td>
        </tr>
        <tr>
        <td><p>Expensive customer</p></td>
        <td><p>**Number of activities** of type **Marketing** in period is high.</p>
        <p>**Number of sales** with status **Sold** in period is low.</p></td>
        <td><p>You have undertaken a lot of marketing towards the customer, but this has led to few or no sales.</p></td>
        <td><p>Plan an internal meeting to find out what can be done to make the customer profitable.</p></td>
        </tr>
        <tr>
        <td><p>Neglected customer</p></td>
        <td><p>**Number of activities** with direction **Outgoing** in period is low.</p></td>
        <td><p>You have had very little contact with the customer.</p></td>
        <td><p>Plan a phone call with the customer to maintain customer relations.</p></td>
        </tr>
        <tr>
        <td><p>Sleeping customer</p></td>
        <td><p>**Number of activities** with direction **Incoming** in period is low or zero.</p>
        <p>**Number of activities** with direction **Outgoing** in period is high.</p></td>
        <td><p>You are trying to get into contact with the customer, but are getting little or no response.</p></td>
        <td><p>Arrange a meeting with the customer to find out why they do not want to communicate.</p></td>
        </tr>
        </tbody>
        </table>

        ## Projects

        <table>
        
        <tbody>
        <tr>
        <td><p>Status name</p></td>
        <td><p>Criteria</p></td>
        <td><p>Explanation</p></td>
        <td><p>Task</p></td>
        </tr>
        <tr>
        <td><p>Neglected project</p></td>
        <td><p>**Project status** is set to ongoing.</p>
        <p>**Date of last activity** (follow-up) is older than 14 days.</p></td>
        <td><p>The project is active, but there have not been any activities for the last 2 weeks.</p></td>
        <td><p>Plan a project meeting to get the wheels turning.</p></td>
        </tr>
        <tr>
        <td><p>Unprofitable project</p></td>
        <td><p>**Number of sales** (completed) is zero.</p>
        <p>**Project status** is completed or stopped.</p></td>
        <td><p>The project is complete, but nothing has been sold.</p></td>
        <td><p>Plan an internal meeting to find out why no sales were achieved.</p></td>
        </tr>
        </tbody>
        </table>

        Counter fields can be found under **Counters (SAINT)** in the list of criteria.

        The counters are created and maintained in SuperOffice Settings and maintenance.

        * Counter fields are only relevant if you have purchased a licence for and have enabled status monitors.

        To the right of the fields, you can click the links to specify additional criteria for the counters. The available options will depend on the type of record and counter you are working with.

        **SAINT type**: Here you choose the activity type you want to search for.

        **Status**: Here you choose the status of the record you want to search for.

        **Direction**: Here you can choose whether the activity is incoming or outgoing.

        **Amount class**: Here you choose the sale's amount class.

        **Intention**: Here you choose the intention of the activity.

        Depending on what you have selected above, a list box for a date field or a number field is displayed. These list boxes work as described above. Select the required option and enter the required numerical value or date in the text field.
4. Select values for the search criteria in the various fields on the line.
5. Click **Add** to add a new line, or click **Or** to add a new set of criteria. (See [Use the Find screen](Find-dialog.md).)

## Change search criteria

If you want to change a search criterion, click it and select a different one from the list that appears.

## Move search criteria

To move criteria (a line), click and drag ![icon](../media/criteria-move.png).

## Delete search criteria

To delete a search criterion, click ![icon](../media/criteria-remove.png).

## Activate or deactivate search criteria

When you open the **Find** screen, it contains default search criteria or the search criteria you specified the last time you used the dialog. If you want to use different search criteria than those shown, you have the following options:

* you can delete them by clicking ![icon](../media/criteria-remove.png)
* you can deactivate one or more search criteria by leaving the value field empty. A deactivated search criterion remains in the criteria list and can be simply reactivated when needed.
* you can deactivate all the search criteria by clicking **Clear all**.

## Move search criteria up or down

To move criteria, click and drag ![icon](../media/criteria-move.png). This has no practical effect on the search, but allows you to arrange the criteria in your preferred order. If some of the criteria are not being used, but you still want to keep them, you can move inactive criteria to the bottom if the list.

## Reset to default search criteria

The criteria lists contain a set of default criteria you can edit or remove as required. If you want to reset the criteria list to the default criteria, click **Reset to default**.

## What would you like to do now?

[Use the Find screen](Find-dialog.md)

---
uid: help-en-adding-members-to-static-selections
title: Adding members to static selections
description: Adding members to static selections
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Add members to static selections

When you have created a static selection (see [Creating static selections](Creating-static-selections.md)), you can always add additional members to that selection. This can be done from any list containing the relevant records, such as search results and section tabs.

<!-- Fix reuse ID=a1 -->

You can add new members to an open static selection as follows:

1. Click the **Add members** button below the list of members. The dialog **Add all members matching** opens.
2. Edit the criteria as described in [Use the Find screen](../chap01/Find-dialog.md).
3. Click **OK**. Matching members are added to the selection.

**Tip**: To copy members from another selection, see [Copy into selections](Copying-into-selections.md).

There are simple rules for members of selections.

* Members are always unique, which means that the same record cannot be entered twice in the same selection.
* You cannot enter the same company both with and without a contact. This means that if a company is entered without a contact and you then try to enter it with a contact, the entry without a contact is removed from the selection.

## To add records to a static selection

1. Go to a list of the records you want to add to a selection (search results or a section tab).

2. Select one or more records on the list.

    > [!NOTE]
    > If you want to add several records, use **Shift** or **Ctrl** + click.

3. Right-click the records and select **Add to selection** on the menu which appears.

4. Select one of these options:
    * **Add to existing static selection**: select this option to add the selected records to an existing static selection. In this case, specify the required selection. Do this either by clicking the arrow and selecting the required selection in the displayed list box, or by typing in the whole or the beginning of the selection name.  
        <!-- Fix reuse ID=a11 -->
        The list of selections will be limited to the following:

        * Existing *static* selections (not dynamic selections or combined selections)

        * Selections matching the records you are adding (if you have selected sales, only selections of sales will be displayed)

        If the list is empty, there are no existing selections of this type.
    * **Add to new static selection**: select this option add the selected records to a new static selection.
    * In the **Selection name** field, enter the name of the selection. This field is mandatory.
    * In the **Category** field, choose the type of selection you require. Click the arrow to display a predefined list of alternatives.
    * In the **Visible for**, choose whether the selection will be visible to everyone, only you or visible to everyone in a user group that the owner belongs to..
    * (only relevant for selections of companies/contacts) If you check the **Company is unique** check box, only one record will be added for each unique company among the selected contacts. So if you have selected 10 contacts that belong to a total of 3 companies, only the 3 companies will be added to the selection,

5. Click **OK**. The selection is updated.

## What would you like to do now?

[Copy into selections](Copying-into-selections.md)

[Perform tasks using selections](Performing-tasks-using-selections.md)

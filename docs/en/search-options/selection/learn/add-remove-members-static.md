---
uid: help-en-selection-static-members
title: Add and remove members in static selections
description: How to manage members in static selections.
keywords: selection, member
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/search-options/selection/learn/update/add-remove-members-static
---

# Add and remove members in static selections

When you have created a static selection, you can always add additional members to that selection. This can be done from any list containing the relevant records, such as search results and section tabs.

> [!TIP]
> You can also [copy members from another selection][3].

There are simple rules for members of selections.

* Members are always unique, which means that the same record cannot be entered twice in the same selection.

* You cannot enter the same company both with and without a contact. This means that if a company is entered without a contact and you then try to enter it with a contact, the entry without a contact is removed from the selection.

## Add members to an open static selection

1. Click the **Add members** button below the list of members.

2. In the **Add all members matching** dialog, [edit the criteria][2].

3. Click **OK**. Matching members are added to the selection.

## Add members to existing static selection

Use this option to add the selected records to an existing static selection.

1. Go to a list of the records you want to add to a selection (search results or a section tab).

2. Select one or more records on the list.

    To add several records, use **Shift** or **Ctrl** + click.

3. Right-click the records and select **Add to selection** on the menu that appears.

4. Select **Add to existing static selection**. Specify the required selection by clicking the arrow and selecting the required selection in the displayed list box, or by typing in the whole or the beginning of the selection name.

    > [!NOTE]
    > The list of selections is limited to:
    >
    > * Existing *static* selections (not dynamic selections or combined selections)
    >
    > * Selections matching the records you are adding (if you select sales, only selections of sales are displayed)
    >
    > If the list is empty, there are no existing selections of this type.

5. Click **OK**. The selection is updated.

## Add members to new static selection

1. Go to a list of the records you want to add to a selection (search results or a section tab).

2. Select one or more records on the list.

    > [!NOTE]
    > To add several records, use **Shift** or **Ctrl** + click.

3. Right-click the records and select **Add to selection** on the menu that appears.

4. Select **Add to new static selection**.

5. In the **Selection name** field, enter the name of the selection. This field is mandatory.

6. In the **Category** field, choose the type of selection you require. Click the arrow to display a predefined list of alternatives.

7. In the **Visible for** field, choose if the selection should be visible to everyone, only you or visible to everyone in a user group that the owner belongs to.

8. For selections of companies/contacts: If you check the **Company is unique** check box, only one record will be added for each unique company among the selected contacts. So if you selected 10 contacts that belong to 3 companies, only the 3 companies will be added to the selection.

9. Click **OK**. The selection is updated.

## <a id="remove"></a>Remove members using search criteria

1. Go to the required static selection. For example, [use the Find screen][2].

1. Click the **Remove members** button in the tab.

1. In the **Remove members matching** dialog, specify the desired [criteria][5].

1. Click **OK**. All members that satisfy the specified search criteria are removed.

## Remove a specific member

1. Go to the required static selection.

1. Select one or more entries in the list of members.

1. Right-click and select **Remove**. The members are instantly removed from the active selection.

## Related content

* [Copy into selections][3]
* [Perform tasks using selections][4]

<!-- Referenced links -->
[2]: ../../learn/find-screen.md
[5]: ../../learn/search-criteria.md
[3]: copy-members-to.md
[4]: ../../../learn/getting-started/index.md

<!-- Referenced images -->

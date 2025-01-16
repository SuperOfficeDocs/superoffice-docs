---
uid: help-en-bulk-update
title: Bulk update
description: Bulk update
author: SuperOffice RnD
date: 06.29.2022
keywords: bulk update
topic: howto
language: en
---

# Update multiple records (bulk update)

Bulk update allows you to change values across multiple records of the same type. You can perform the bulk update on all or selected records in section tabs (archives), selections and the **Find** screen. This task can also be used to delete multiple records.

1. Open the selection, section tab (archive) or search results (**Find** screen) containing the records you want to update.

2. Selections: Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and select **Bulk update**.
    or
    Select the records you want to update, right-click them and select **Bulk update...**.
    The **Bulk update** dialog opens. In the bottom of this dialog you can see the type of record and how many records to be updated. Example: Number of contacts in queue for bulk update: 7.

    > [!NOTE]
    > If the selection contains both companies and contacts, there will be two tabs: **Company** and **Contact**.

3. Select a field to update in the **Field** column. You can also type the name in the field. As you type each letter, the list below displays all matches relevant to the selected records.

4. Select an action in the **Action** column. The available actions depends on the type of field you selected in the previous step. Examples:

    * **Check**: Check or uncheck a checkbox.
    * **Toggle**: Uncheck a checked checkbox and vice versa.
    * **Search and replace**: [Find a text and replace it](#search-and-replace).
    * **Regex**: Update a field using [regular expressions](#regex).
    * **Set**: Apply a new value to the field.
    * **Clear**: Clear any value from the field.
    * List actions: Select or clear single or multiple values for list fields.
    * Activity link actions: Add, remove or replace activity links or clear all activity links.

5. To add more fields to be updated, click **Add** and repeat steps 3 and 4.

6. Make sure you select (<i class="ph ph-check" aria-hidden="true"></i>) the fields you want to update and unselect the fields you DO NOT want to update.

7. Click **Update**. The **Confirm** dialog opens, showing a summary of the updates.

8. Click **Yes** to implement the changes to the selected records.

    > [!CAUTION]
    > Once an update is applied, it cannot be undone. However, you can stop the update while it is in progress. Any records that have not yet been updated will remain unchanged.

9. Click **LOG** to show the change log. If any records were not updated, the reason is listed in the **Reasons why** column.

10. Click **Close**.

## <a id="search-and-replace"></a>Search and replace

The action type **Search and replace** allows you to find a specific text in a field and replace it.

1. Select **Search and replace** in the **Action** column.
2. Enter the text to be replaced in the **Find** field.
3. Enter the replacement text in the **Replace with** field.
4. Optional: Click **Options** and select settings for case-sensitivity and whole/partial word search.

## <a id="regex"></a>Regular expressions

The action type **Regex** allows you to use regular expressions to update a field.

1. Select **Regex** in the **Action** column.
2. Enter the expression in the **Expression** field.
3. Enter the replacement text in the **Replace with** field.
4. Optional: Click **Options** and select settings for the regular expression.

## Examples

## Update company categories

You want to categorize your customers according to sales amounts. Create company categories called "Customer A", "Customer B" and "Customer C" in SuperOffice CRM. For "Customer A" you can create a selection of companies with sales amounts over EUR 50 000 last year. Use **Bulk update** to update the category for these customers to "Customer A". Repeat this process for the other companies.

## Update company post code and post city

Post codes and post cities in Norway have changed. Use **Bulk update** to update the addresses.

## Update contact

You discover that the contact field **Position** is rarely used. To at least start the task of filling in this field for all contacts, you want to find everyone that have director in the title. Create a selection of all contacts that contain the word "director" in the **Title** field. Use **Bulk update** to set the field **Position** to **Management**.

## Update project

You want to clean up all the "old" projects that have not been set to completed. Create a selection of all your old projects, for example all projects created more than 2 years ago and that has not been updated in the last year. Use **Bulk update** to set the **Completed** status for these projects to **Yes**.

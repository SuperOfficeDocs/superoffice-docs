---
uid: help-en-find-dialog
title: Find dialog
description: Find dialog
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Use the Find screen

To search for records and data in SuperOffice CRM, you use the **Find** screen.

> [!NOTE]
> If you have a licence for SuperOffice Integration Server, you can search for products in existing quotes. If you have a licence for SuperOffice Service, you can search for requests.

* To find out how the search features works: Click [Search for information in SuperOffice CRM](#Searching-for-information-in-SuperOffice-CRM).

* To find out what you can do with the search results: Click [Work with search results](#Working-with-search-results).

* To see specific examples of how to use the search features: Click [The search facility in SuperOffice CRM](#Search-examples)

## Search for information in SuperOffice CRM

To use the search function in SuperOffice CRM:

1. Click the **Find** button on the [top bar](Buttons-in-the-menu-bar.md). ![icon](../media/GlobalMenu-Find.png)
2. Click the type of record you want to search for, or click **Typical searches** to display a list of predefined searches. The **Criteria** tab opens.
3. The **Find** screen contains predefined search criteria, or the search criteria you used last time. Click ![icon](../media/criteria-remove.png) to remove any criteria you do not want to use.
    *or* If you want to add new search criteria, click the **Add** button. A new line is added to the criteria list.
4. In the first list box on the line, select the field you want to search for information in. You can also enter the start of the name in the appropriate field (see [FastSearcher](Using-FastSearcher.md)).  
    Here you could, for example, select **Contact** and **Last name** if you wanted to search for contacts, or **Project** and **Event date** if you wanted to search for projects. There are different types of fields. These are described under [Use search criteria](Using-search-criteria.md).
5. Select values for the search criteria in the next fields on the line.
6. You can click **Add** below the criteria list again to specify more search criteria. A new line is added to the criteria list and you can repeat steps 4 and 5.
7. To move criteria, click and drag ![icon](../media/criteria-move.png).
8. Click **Or** to add a another set of criteria.
9. When you have specified and activated the search criteria you want, click the **Find** button. The **Results** tab opens with the search results which match the search criteria you have specified.

> [!TIP]
> If, for example, you want to search for all companies, you can use the percent sign (%) when entering search criteria for **Company**. For more information about how to use search criteria, see [Use search criteria](Using-search-criteria.md).

## Work with search results

Once you have followed the above procedure, and search results are displayed in the **Results** tab, you have several options available:

Open the record

To open one of the records, double-click it. For example, double-clicking a contact displays the **Contacts** section tab with that contact highlighted.

Display a record in the side panel

Use the side panel to quickly browse through the search results. If you have searched for contact, select **Contacts** in the list at the top of the side panel. You can then click on each contact in the **Results** tab to preview them.

See [The side panel](Navigating-in-the-mini-card.md).

Perform tasks on the search results

The **Task** button contains tasks such as sending e-mails, mass-editing and exporting. Which tasks are displayed depends on what type of records are displayed.

See [Perform tasks using selections](../chap04/Performing-tasks-using-selections.md).

Add records to a selection

Click the **Save as selection** button. See [Create selections](../chap04/Create-selections.md).

Select records, right-click, and select **Add to selection**. See [Add members to static selections](../chap04/Adding-members-to-static-selections.md).

## The search facility in SuperOffice CRM

There are effectively no limits on what you can search for in SuperOffice CRM. The following specific examples of the search options in action are intended to provide you with tips on searching. In each case, we firstly describe a specific search requirement and then explain in detail how to perform the search. You can use these examples as inspiration for creating your own searches:

[Example 1: search for profitable customers](#Search-example-1)

[Example 2: search for customers in Denmark who you are responsible for](#Search-example-2)

[Example 3: search for sold sales](#Search-example-3)

[Example 4: search for projects you have participated in during the last year](#Search-example-4)

[Example 5: search for marketing initiatives undertaken](#Search-example-5)

## Example 1: search for profitable customers

Imagine that you are a sales department manager and you want to make a presentation to the rest of management, showing what you have achieved since the last meeting. You want to focus on profitable customers, i.e. customers you have recently sold a lot to. This is how to find them:

1. Click the **Find** button.

2. Click **Find company**.

3. If the **Criteria** tab contains any criteria, click ![icon](../media/criteria-remove.png) to delete them or **Clear all** to clear the criteria data.

4. Click **Add**.

5. In the list that appears, select the field you want to search for information in. First click **Sale** (![icon](../media/criteratype-sale.png)), and then **Amount**.

6. In the list box to the right of **Amount**, click the arrow (![icon](../media/Dialogboksknapper-pil-ned.bmp)) and select **&gt;** (greater than).

7. In the last field on the line, enter the minimum amount, e.g. "100 000".

8. You have now specified that you want to find companies with sales above the amount you entered, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. In the list that appears, select the field you want to search for information in. First click **Sale** (![icon](../media/criteratype-sale.png)), and then **Registered date**.

11. In the second list box, click the arrow (![icon](../media/Dialogboksknapper-pil-ned.bmp)) and select **Between**.

12. In the third list box, specify the start date of the period you want, and in the fourth list box, the end date.

13. You have now specified that you want to find companies with sales over 100 000 within the period you defined. But, we also want to restrict the search to sales with the status **Sold**.

14. Click **Add**.

15. In the list that appears, enter "Status" in order to FastSearch in the field.

16. From the list that is displayed, select **Sale** -** Status** (with the sale icon ![icon](../media/criteratype-sale.png) in front of it).

17. In the second list box, select **Is one of**.

18. Click the **Select items** field to the right of the **Is one of** field and select **Sold**.

19. You have now specified that you want to find companies with sales above a specific amount, within a specific date range and that have status **Sold**.

20. Click the **Find** button below the **Criteria** tab..

21. All the results which match the search criteria you have specified are displayed in the **Results** tab.

    > [!TIP]
    > If you get too many or too few hits, you can adjust the search criteria by selecting different values in the various list boxes.

22. You then decide what you want to use the search results for. Here are some suggestions:

    * To open one of the records, double-click it. It is then displayed in the **Company** screen.

    * Preview each company in the side panel. Select **Preview** in the list at the top of the side panel. You can then click on each company in the **Results** tab to preview them. See [The side panel](Navigating-in-the-mini-card.md).

    * You can create a selection containing these customers, by clicking **Save as selection** and following the procedure under [Create selections](../chap04/Create-selections.md).

## Example 2: search for customers in Denmark who you are responsible for

Imagine you are going to attend a conference in Denmark. When you are there, you also want to use the opportunity to visit some customers. You start your planning by searching for all customers in Denmark who you are responsible for. To do this:

1. Click the **Find** button.

2. Click **Find company**.

3. If the **Criteria** tab contains any criteria, click ![icon](../media/criteria-remove.png) to delete them or **Clear all** to clear the criteria data.

4. Click **Add**.

5. In the list that appears, select the field you want to search for information in: First click **Company** ( ![icon](../media/criteratype-company.png) ), and then **Country**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Denmark**.

8. You have now specified that you want to find companies in Denmark, but we have not quite finished. We want to restrict the search to companies in Denmark who you are responsible for.

9. Click **Add**.

10. In the list that appears, select the field you want to search for information in: First click **Company** ( ![icon](../media/criteratype-company.png) ), and then **Our contact**.

11. In the second list box, select **Current user**. Your name is displayed in the last field on the line.

12. You have now specified that you want to find companies in Denmark for which you are the contact.

13. Click the **Find** button below the **Criteria** tab..

14. All the results which match the search criteria you have specified are displayed in the **Results** tab.

    > [!TIP]
    > If you get too many or too few hits, you can adjust the search criteria by selecting different values in the various list boxes.

15. You then decide what you want to use the search results for. Here are some suggestions:

    * To open one of the records, double-click it. It is then displayed in the **Company** screen.

    * Preview each company in the side panel. Select **Preview** in the list at the top of the side panel. You can then click on each company in the **Results** tab to preview them. See [The side panel](Navigating-in-the-mini-card.md).

    * You can create a selection containing these customers, by clicking **Save as selection** and following the procedure under [Create selections](../chap04/Create-selections.md).

## Example 3: search for sold sales

Let's assume you are the manager of a company and want to find out what types of sales work well for you, and why, with a view to achieving more of the same. You start by searching for sales with the status **Sold**. To do this:

1. Click the **Find** button.

2. Click **Find sale**.

3. If the **Criteria** tab contains any criteria, click ![icon](../media/criteria-remove.png) to delete them or **Clear all** to clear the criteria data.

4. Click **Add**.

5. In the list that appears, select the field you want to search for information in: First click **Sale** ( ![icon](../media/criteratype-sale.png) ), and then **Status**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Sold**. You have now specified that you want to search for completed sales.

8. Click the **Find** button below the **Criteria** tab..

9. All the results which match the search criteria you have specified are displayed in the **Results** tab.

10. You then decide what you want to use the search results for. Here are some suggestions:
    * To open one of the records, double-click it. It is then displayed in the **Sale** screen.

    * Preview each sale in the side panel. Select **Preview** in the list at the top of the side panel. You can then click on each sale in the **Results** tab to preview them. See [The side panel](Navigating-in-the-mini-card.md).

    * You can create a selection containing these sales, by clicking **Save as selection** and following the procedure under [Create selections](../chap04/Create-selections.md).

## Example 4: search for projects you have participated in during the last year

Imagine that the time for your pay review is approaching and you think you deserve to be better rewarded for your efforts. To show your boss how energetic and versatile you are, you want to tell him about the projects you have been involved in in the last year. This is how to find them:

1. Click the **Find** button.

2. Click **Find sale**.

3. If the **Criteria** tab contains any criteria, click ![icon](../media/criteria-remove.png) to delete them or **Clear all** to clear the criteria data.

4. Click **Add**.

5. In the list that appears, select the field you want to search for information in: First click **Contact** ( ![icon](../media/criteratype-contact.png) ), and then **Last name**.

6. In the second list box, select **Equals**.

7. In the third field, enter your last name.

8. You have now specified that you want to find projects you have participated in, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. In the list that appears, select the field you want to search for information in: First click **Project** (![icon](../media/criteratype-project.png)), and then **From date**.

11. In the second list box, select **After**.

12. In the third list box, enter the start date for the period you require.

13. You have now specified that you want to find projects you have participated in, from a specific date up to today.

14. Click the **Find** button below the **Criteria** tab..

15. All the results which match the search criteria you have specified are displayed in the **Results** tab.

    > [!TIP]
    > If you get too many or too few hits, you can adjust the search criteria by selecting different values in the various list boxes.

16. You then decide what you want to use the search results for. Here are some suggestions:

    * To open one of the records, double-click it. It is then displayed in the **Project** screen.

    * Preview each project in the side panel. Select **Preview** in the list at the top of the side panel. You can then click on each project in the **Results** tab to preview them. See [The side panel](Navigating-in-the-mini-card.md).

    * You can create a selection containing these projects, by clicking **Save as selection** and following the procedure under [Create selections](../chap04/Create-selections.md).

## Example 5: search for marketing initiatives undertaken

Imagine that you are a marketing department manager and you want to brainstorm about future marketing initiatives. As a basis for this, you want to get an overview of the marketing-related follow-ups you have done in the previous quarter. To do this:

1. Click the **Find** button.

2. Click **Find sale**.

3. If the **Criteria** tab contains any criteria, click ![icon](../media/criteria-remove.png) to delete them or **Clear all** to clear the criteria data.

4. Click **Add**.

5. In the list that appears, select the field you want to search for information in: First click **Follow-up** (![icon](../media/criteratype-followup.png)), and then **Intention**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Marketing**.

8. You have now specified that you want to find marketing-related follow-ups, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. In the list that appears, select the field you want to search for information in. First click **Follow-up** (![icon](../media/criteratype-followup.png)), and then **End date**.

11. In the second list box, select **Previous**.

12. In the third list box, enter 1.

13. In the fourth list box, select **Quarter(s)**.

14. You have now specified that you want to find follow-ups intended for marketing, in the last quarter, but we are still not quite finished. We also want to restrict the search to completed follow-ups.

15. Click **Add**.

16. In the list that appears, select the field you want to search for information in. First click **Follow-up** ( ![icon](../media/criteratype-followup.png) ), and then **Completed**.

17. Check **Yes**. You have now specified that you want to find follow-ups set as **Completed**.

18. Click the **Find** button below the **Criteria** tab..

19. All the results which match the search criteria you have specified are displayed in the **Results** tab.

    > [!TIP]
    > If you get too many or too few hits, you can adjust the search criteria by selecting different values in the various list boxes.

20. You then decide what you want to use the search results for. Here are some suggestions:

    * To open one of the records, double-click it. It is then displayed on the **Activities** section tab in the **Company** screen.

    * Preview each follow-up in the side panel. Select **Preview** in the list at the top of the side panel. You can then click on each follow-up in the **Results** tab to preview them. See [The side panel](Navigating-in-the-mini-card.md).

    * You can create a selection containing these follow-ups, by clicking **Save as selection** and following the procedure under [Create selections](../chap04/Create-selections.md).

## What would you like to do now?

[Perform tasks](../chap04/Performing-tasks-using-selections.md)

[Use freetext search](Freetext-search.md)

[Use FastSearcher](Using-FastSearcher.md)

[Use the history list](Using-the-history-list.md)

[Use search criteria](Using-search-criteria.md)

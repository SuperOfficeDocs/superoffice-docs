---
uid: help-en-find-screen
title: Find screen
description: How to find all items of a specific type that match conditions, run a predefined search, or save a search as a selection.
author: SuperOffice RnD
so.date: 05.25.2023
keywords: search, find, typical, criteria, or, selection
so.topic: howto
language: en
---

# The Find screen

To search for records and data in SuperOffice CRM, use the **Find** screen.

There are effectively no limits to what you can search for in SuperOffice CRM. At the end of this section, we have included examples to provide you with tips on searching.

> [!NOTE]
> If you have a licence for SuperOffice Integration Server, you can search for products in existing quotes. If you have a licence for SuperOffice Service, you can search for requests.

## Search for information in SuperOffice CRM

1. Click the **Find** button on the [top bar][1].

    ![Find button][img2]

2. Click the type of record you want to search for, or click **Typical searches** to display a list of predefined searches. The **Criteria** tab opens.

3. The **Find** screen contains predefined search criteria, or the search criteria you used last time. Do one of the following:

    * Click ![icon][img3] to remove any criteria you do not want to use.
    * Click the **Add** button to add new search criteria. A new line is added to the criteria list.

4. In the first list box on the line, select the field you want to search for information in. You can also [enter the start of the name in the appropriate field][2]. There are [different types of fields][3].

    For example, select **Contact** and **Last name** to search for contacts, or **Project** and **Event date** to search for projects.

5. Select values for the search criteria in the next fields on the line.

6. You can click **Add** below the criteria list again to specify more search criteria. A new line is added to the criteria list and you can repeat steps 4 and 5.

7. To move criteria, click and drag ![icon][img4].

8. Click **Or** to add a another set of criteria.

9. When you have specified and activated the search criteria you want, click the **Find** button. The **Results** tab opens with the results matching the search criteria.

> [!TIP]
> If, for example, you want to search for all companies, you can use the percent sign (%) when [entering search criteria][3] for **Company**.

## <a id="or" />Broaden your search using the OR function

The Find feature allows you to perform a search by combining search criteria with the value operator "OR" between them. This way you can search for two sets of independent data and save it in one selection.

Let us take a look at some practical examples of how you can use the OR function. You can search for all customers who bought "Product A" and customers who did not buy "Product B" to boost your cross-sales. Or you can search for all large customers based in Liverpool or Manchester, so you can contact them about an upcoming event in one of these cities.

Watch this video to learn how to create a search using the OR function (video length - 4:08):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

## <a id="results" />Work with search results

After following the above steps, and search results are displayed in the **Results** tab, you have several options available:

* **Open the record:** To open one of the records, double-click it. For example, double-clicking a contact displays the **Contacts** section tab with that contact highlighted.

* **Display a record in the side panel:** Use the [side panel][4] to quickly browse through the search results. If you have searched for contact, select **Contacts** in the list at the top of the side panel. You can then click on each contact in the **Results** tab to preview them.

* **Perform tasks on the search results:** The **Task** button contains tasks such as:

  * Send a mailing and create activities
  * Manage the information in your selection
  * Print out or export your data
  * Delete the information in your selection from your CRM database

    ![A list of possible tasks you can use your search result for -screenshot][img10]

    Which tasks are displayed depends on what type of records are displayed. [Read more][7]

* **Add records to a selection:** Click the **Save as selection** button. See [Create selections][8].

* Select records, right-click, and select **Add to selection**. See [Add members to static selections][9].

## <a id="ex1" />Example 1: search for profitable customers

As a sales department manager, you want to give a presentation to the rest of management, showing what you have achieved after the last meeting. You want to focus on profitable customers (customers you have recently sold a lot to).

1. Click the **Find** button.

2. Click **Find company**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Click **Add**.

5. [!include[Select field](includes/select-field.md)] First click **Sale** ![icon][img5], and then **Amount**.

6. In the list box to the right of **Amount**, click the arrow ![icon][img1] and select **&gt;** (greater than).

7. In the last field on the line, enter the minimum amount. For example, "100 000".

8. You have now specified that you want to find companies with sales above the amount you entered, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. [!include[Select field](includes/select-field.md)] First click **Sale** ![icon][img5], and then **Registered date**.

11. In the second list box, click the arrow ![icon][img1] and select **Between**.

12. In the third list box, specify the start date of the period you want, and in the fourth list box, the end date.

13. You have now specified that you want to find companies with sales over 100 000 within the period you defined. But, we also want to restrict the search to sales with the status **Sold**.

14. Click **Add**.

15. In the list that appears, enter "Status" to FastSearch in the field.

16. From the list that is displayed, select **Sale** - **Status** (with the sale icon ![icon][img5] in front of it).

17. In the second list box, select **Is one of**.

18. Click the **Select items** field to the right of the **Is one of** field and select **Sold**.

19. You have now specified that you want to find companies with sales above a specific amount, within a specific date range and that have status **Sold**.

20. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

21. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex2" />Example 2: search for customers in Denmark who you are responsible for

Imagine you are going to attend a conference in Denmark. When you are there, you also want to use the opportunity to visit some customers. You start your planning by searching for all customers in Denmark who you are responsible for.

1. Click the **Find** button.

2. Click **Find company**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Click **Add**.

5. [!include[Select field](includes/select-field.md)] First click **Company** ![icon][img6], and then **Country**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Denmark**.

8. You have now specified that you want to find companies in Denmark, but we have not quite finished. We want to restrict the search to companies in Denmark who you are responsible for.

9. Click **Add**.

10. [!include[Select field](includes/select-field.md)] First click **Company** ![icon][img6], and then **Our contact**.

11. In the second list box, select **Current user**. Your name is displayed in the last field on the line.

12. You have now specified that you want to find companies in Denmark for which you are the contact.

13. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

14. [!include[Explore results](includes/use-results.md)]

## <a id="ex3" />Example 3: search for sold sales

Let's assume you are the manager of a company and want to find out what types of sales work well for you, and why, with a view to achieving more of the same. You start by searching for sales with the status **Sold**.

1. Click the **Find** button.

2. Click **Find sale**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Click **Add**.

5. [!include[Select field](includes/select-field.md)] First click **Sale** ![icon][img5], and then **Status**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Sold**. You have now specified that you want to search for completed sales.

8. [!include[Click Find](includes/run-search.md)]

9. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex4" />Example 4: search for projects you have participated in during the last year

Imagine that the time for your pay review is approaching and you think you deserve to be better rewarded for your efforts. To show your boss how energetic and versatile you are, you want to tell them about the projects you have been involved in in the last year.

1. Click the **Find** button.

2. Click **Find sale**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Click **Add**.

5. [!include[Select field](includes/select-field.md)] First click **Contact** ![icon][img7], and then **Last name**.

6. In the second list box, select **Equals**.

7. In the third field, enter your last name.

8. You have now specified that you want to find projects you have participated in, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. [!include[Select field](includes/select-field.md)] First click **Project** ![icon][img8], and then **From date**.

11. In the second list box, select **After**.

12. In the third list box, enter the start date for the period you require.

13. You have now specified that you want to find projects you have participated in, from a specific date up to today.

14. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

15. [!include[Explore results](includes/use-results.md)]

## <a id="ex5" />Example 5: search for marketing initiatives undertaken

Imagine that you are a marketing department manager and you want to brainstorm about future marketing initiatives. As a basis for this, you want to get an overview of the marketing-related follow-ups you have done in the previous quarter.

1. Click the **Find** button.

2. Click **Find sale**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Click **Add**.

5. [!include[Select field](includes/select-field.md)] First click **Follow-up** ![icon][img9], and then **Intention**.

6. In the second list box, select **Is one of**.

7. Click the **Select items** field to the right of the **Is one of** field, and select **Marketing**.

8. You have now specified that you want to find marketing-related follow-ups, but we have not quite finished. We also want to specify a period.

9. Click **Add**.

10. [!include[Select field](includes/select-field.md)] First click **Follow-up** ![icon][img9], and then **End date**.

11. In the second list box, select **Previous**.

12. In the third list box, enter 1.

13. In the fourth list box, select **Quarter(s)**.

14. You have now specified that you want to find follow-ups intended for marketing, in the last quarter, but we are still not quite finished. We also want to restrict the search to completed follow-ups.

15. Click **Add**.

16. [!include[Select field](includes/select-field.md)] First click **Follow-up** ![icon][img9], and then **Completed**.

17. Check **Yes**. You have now specified that you want to find follow-ups set as **Completed**.

18. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

19. [!include[Explore results](includes/use-results.md)]

## What would you like to do now?

* [Perform tasks][7]
* [Use free-text search][5]
* [Use FastSearcher][2]
* [Use the history list][6]
* [Use search criteria][3]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[4]: ../../learn/getting-started/main-screen/side-panel.md
[2]: in-navigator.md
[3]: search-criteria.md
[5]: freetext-search.md
[6]: ../../learn/basics/history.md
[7]: ../selection/learn/howto/index.md
[8]: ../selection/learn/create/index.md
[9]: ../selection/learn/update/add-remove-members-static.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/loc/en/learn/find.png
[img3]: ../../../../common/icons/delete-circle-red.png
[img4]: ../../../media/icons/criteria-move.png
[img5]: ../../../../common/icons/singlecolour/sale.png
[img6]: ../../../../common/icons/singlecolour/contact.png
[img7]: ../../../../common/icons/singlecolour/person.png
[img8]: ../../../../common/icons/singlecolour/project.png
[img9]: ../../../../common/icons/singlecolour/appointment.png
[img10]: ../../../media/loc/en/search-options/task-menu.png

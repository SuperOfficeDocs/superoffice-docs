---
uid: help-en-admin-listcategories-newcategory
title: admin listCategories newCategory
description: admin listCategories newCategory
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create categories

To create a new category:

1. Select ![icon][img2] &gt; **Categories**. The **Categories** screen appears.
    You can also go to the **Requests** screen in SuperOffice Settings and maintenance and select the **Categories** tab.

2. Click the **New category** button. This takes you to the **Category properties** screen.

3. In the **Properties** tab, enter the following information:
    * **Name**: Enter a descriptive name for the category.
    * **External name**: Here you enter the category name to display to the customer. This field is mandatory, unless the category is internal.
    * **Subcategory of**: If this is to be a subcategory of another category, select the parent category you require.
    * **Category administrator**: Select who is to be responsible for the requests in this category. In the **Assignment method** tab, you can specify that requests are to be assigned to the category manager if no other members of the category are available. Normally, the role of category administrator should be filled by a departmental manager.
    * **Internal**: If you check here, the category will not be visible in SuperOffice Customer Centre.
    * **Show category in status view**: If you check here, this category will be displayed under **Status** on the **Dashboard**. For more information about this, see [Hyperlinks to categories][1].
    * **Only members have access**: If you check here, the category will only be accessible to members of the category.
    * **Send notification to members about new request**: If you check here, all members of the category will receive notification of new requests in this category.
    * **Take ownership when replying**: If you check here, the user who replies to a request in this category, will be set as the owner of the request.
    * **Send notification about new request to e-mail address**: Enter an e-mail address.
    * **Default status for new request**: Here you choose the default status to appear in the **Request** screen. This setting will override [user preferences][2], unless you select **User-defined**.
    * **Default status for new message**: Here you choose the default status to appear in a new message. This setting will override [user preferences][2], unless you select **User-defined**.

4. In the **Members** tab, you specify which users are to be members of the category. Select a user in the **User** list at the bottom and click ![icon][img1].

    > [!TIP]
    > If **Weighted assignment** is selected as assignment method for the requests in this category, you can use the weighting for each individual user to determine the assignment of new requests. The users with the highest weighting will be assigned most requests. You cannot use weighted assignment for category members from [user groups][3].

5. In the **Reply template** tab, select the reply template to use in messages sent to customers and others, for requests belonging to this category. This can be a reply template specifically created for this category, to give all replies from a category (such as support or accounting) a uniform appearance. For more on reply templates, see [Work with reply templates][4].
    <!-- Fix reuse ID=a2 -->
    [!include[Reply templates with different layout](../../includes/custom-replytemplate.md)]

    > [!TIP]
    > Check **Apply to subcategories** if you want the selected reply template to also be used for any subcategories. This assumes however that the template is not overridden by settings made in the subcategories.

6. In the **Assignment method** tab, enter the following information: Select an assignment type:

    * **Even assignment**: Assigns requests evenly among the members of the category.
    * **Weighted assignment**: Assigns requests based on the weightings specified for members of the category. The weighting system can be explained by an example: If contact A has a weighting of 1, contact B a weighting of 2 and contact C a weighting of 5, then over the course of 8 requests each of these contacts will be assigned the same number of requests as their weighting indicates.
    * **To user with fewest open requests**: Assigns new requests to the category members who has the fewest active requests.
    * **Do not assign**: Does not assign requests to specific users, but places all requests in a queue as default. Either under **Requests &gt; Unassigned requests** (default) or in the queue system **Get next request in queue** (see [How to set up Get next request in queue][5]).

    * **Only assign to logged in users**: Assigns requests only to users who are logged in to SuperOffice Service.

    * **Assign to category administrator if no one is available**: Assigns requests to the category manager if no other users are available.

    * **Reassign requests on new message if user is not present**: Reassigns requests when a new message arrives on a request and the user is not available.

    * **Assign to our service contact if available**: If the relevant company or contact has a request handler specified as **Our contact**, and this user is available, the request is assigned to this user. If **Our contact** is not specified, or the user is not available, the request is assigned in accordance with the usual assignment rules.

    * **Assignment quarantine**: Enter the number of minutes you want to override assignment for and give all requests from the same customer to one user. In this way, you can ensure that when customers send two requests one after the other to the same address, the requests go to the same request handler. If you enter -1, this functionality is disabled and all requests will be assigned in accordance with the usual assignment rules.

7. Click **OK**. The category is created.

## What would you like to do now?

* [Search for requests in categories][6]

<!-- Referenced links -->
[1]: ../../../dashboard/service/index.md#hyperlinks-to-categories
[2]: editUser.helpSettings.md
[3]: listUsers.listUsergroups.md
[4]: ../reply-templates/index.md
[5]: ../request/get-next-request-in-queue.md
[6]: listCategories.searchTickets.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
[img2]: ../../../../media/icons/globalmenu-settings-small.png

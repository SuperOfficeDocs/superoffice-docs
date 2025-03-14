---
uid: help-en-request-category-create
title: Create request category
description: Create request category
keywords: add request category, create request category, new request category, request category, Categories tab, request, category
author: Hanne Gunnarsson
date: 01.15.2025
version: 10.5
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Create request category

1. In Settings and maintenance, click the **Requests** button in the navigator and select the **Categories** tab.

1. Click the **Add** button.

1. Enter a descriptive name for the category in the field **Category name** above the tabs.

1. In the **Properties** tab, enter the following information:

    * **Internal or external**: If you check **Internal**, the category will not be visible in SuperOffice Customer Centre.

    * **External name**: Here you enter the category name to display to the customer. This field is mandatory, unless the category is internal.

    * **Subcategory of**: If this should be a subcategory of another category, select the parent category you require.

    * **Category administrator**: Select who is responsible for the requests in this category. In the **Assignment method** tab, you can specify that requests are to be assigned to the category manager if no other members of the category are available. Normally, the role of category administrator should be filled by a departmental manager.

        * **Show category in status view**: If checked, this category is displayed under **Status** on the **Dashboard**.
        * **Only members have access**: If checked, the category is accessible only to members of the category.
        * **Send notification to members about new request**: If checked, all members of the category will receive notification of new requests in this category.

    * **Send notification about new request to email address**: Enter an email address.

    * **Take ownership when replying**: If checked, the user who replies to a request in this category is set as the owner of the request.

    * **Default status for new request**: Here you choose the default status to appear in the **Request** screen. This setting will override [user preferences][1], unless you select **User-defined**.

    * **Default status for new message**: Here you choose the default status to appear in a new message. This setting will override [user preferences][1], unless you select **User-defined**.

    * **Merge outbound emails for this category with reply template**: Select the reply template to use in messages sent to customers and others, for requests belonging to this category. This can be a reply template specifically created for this category, to give all replies from a category (such as support or accounting) a uniform appearance.

        * Check **Apply to subcategories** if you want the selected reply template to also be used for any subcategories. This assumes however that the template is not overridden by settings made in the subcategories.

1. In the **Members** tab, you specify which users are to be members of the category. Select a user in the **User** list at the bottom and click **Add**.

    > [!TIP]
    > If **Weighted assignment** is selected as assignment method for the requests in this category, you can use the weighting for each individual user to determine the assignment of new requests. The users with the highest weighting will be assigned most requests. You cannot use weighted assignment for category members from user groups.

1. In the **Assignment method** tab, enter the following information:

    * Select an assignment type:

        * **Even**: Assigns requests evenly among the members of the category.
        * **Weighted**: Assigns requests based on the weightings specified for members of the category.

            Example: If contact A has a weighting of 1, contact B a weighting of 2 and contact C a weighting of 5, then over the course of 8 requests each of these contacts will be assigned the same number of requests as their weighting indicates.

        * **To user with fewest open requests**: Assigns new requests to the category members who has the fewest active requests.
        * **Do not assign**: Does not assign requests to specific users, but places all requests in a queue as default. Either under **Requests** > **Unassigned requests** (default) or in the queue system **Get next request in queue**.

    * **Only assign to logged in users**: Assigns requests only to users who are logged in to SuperOffice Service.

    * **Assign to category administrator if no one is available**: Assigns requests to the category manager if no other users are available.

    * **Reassign requests on new message if user is not present**: Reassigns requests when a new message arrives on a request and the user is not available.

    * **Assign to our service contact if available**: If the relevant company or contact has a request handler specified as **Our contact**, and this user is available, the request is assigned to this user. If **Our contact** is not specified, or the user is not available, the request is assigned in accordance with the usual assignment rules.

    * **Assignment quarantine**: Enter the number of minutes for which you want to override assignment and assign all requests from the same customer to one user. In this way, you can ensure that when customers send two requests in a row to the same email address, the requests go to the same request handler. If you enter -1, this functionality is disabled and all requests will be assigned in accordance with the usual assignment rules.

1. Click **Save**. The category is created.

## Related content

* [How to set up Get next request in queue][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/index.md
[3]: ../next-in-queue.md

<!-- Referenced images -->

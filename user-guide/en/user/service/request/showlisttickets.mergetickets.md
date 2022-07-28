---
uid: help-en-ticket-showlisttickets-mergetickets
title: ticket showListTickets mergeTickets
description: ticket showListTickets mergeTickets
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Merge requests

You can merge two or more requests. For example, if multiple contacts in the same company have reported the same technical issue (via phone, web forms and e-mail), you can merge these requests into one request which will be processed. Contacts and messages from all merged requests will be kept.

> [!NOTE]
> You can also search for and select requests to merge from the search results screen. Then click ![icon][img1] in the lower left corner and select **Batch management** &gt; **Merge**.

To merge requests:

1. Open one of the requests you want to merge. (See [Process requests](listTicket.md).)
2. Click ![icon][img1] and select **Merge**. In the screen that opens, a table shows the fields that must be merged. Now you need to find the request to merge with this one.
3. In the search field, start typing a request name or enter a request ID. Enter **%** to display all requests.
4. Select a request from the list of search results. The selected request opens in a new column in the table.
5. To add more requests, repeat the previous steps.
6. For each row (field) in the table, you must select which request data should be kept. Click ![icon](../../../../media/icons/service/btn-selectall.png) **Choose** to select all fields in a column. The unselected data in this table will be overwritten.
    * Messages from all merged requests will be kept.
    * Contacts from all merged requests will be kept, and the main contact will be inherited from the selected request ID.
7. Click **OK**. The requests are merged.

The requests that have been overwritten (i.e. the request IDs have been overwritten) will no longer be available in favourites and history lists and regular search. If you enter an overwritten request ID in the quick search field (see [Use quick search](../search/useQuickSearch.md)), you are redirected to the merged request.

## What would you like to do now?

[Reply to customer](showListTickets.addMessage.md)

[Ask another request handler for help.](showListTickets.askForHelp.md)

[Forward messages to external parties](showListTickets.forward.md)

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png

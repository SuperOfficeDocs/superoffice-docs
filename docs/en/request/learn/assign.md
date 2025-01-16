---
uid: help-en-request-assign
title: Assignment methods
description: Assignment methods for requests
keywords: automatic assignment, assignment method, assign request, request
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 01.15.2025
version: 10.5
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Automatic assignment methods for requests

For a request to be your responsibility, your name must appear in the request's **Owner** field. This can be set manually, for example when the [request is created][2]. But it may also be the result of automatic assignment of requests. Such assignment depends on the category the request belongs to, and the assignment method specified for this category.

## Assignment methods

| Method | Description |
|---|---|
| Even assignment | Assigns requests evenly among the members of the category. |
| Weighted assignment | Assigns requests based on the [weightings][3] specified for members of the category. |
| To user with fewest open requests | Assigns new requests to the category members who has the fewest active requests. |
| Do not assign | Does not assign requests to specific request handlers, but puts all requests in a queue as **Unassigned**. |

Let us illustrate these assignment methods with three users and three incoming requests.

![Request assignment methods -screenshot][img1]

### Even

Assigns requests evenly among category members in a round-robin fashion.

![Request assignment methods, even -screenshot][img2]

### Weighted

Assigns requests based on specified weightings for each category member. For example, if member A has a weight of 1, member B has 2, and member C has 5, over 8 requests, they will be assigned proportionally.

Requests are assigned probabilistically based on their weights.

![Request assignment methods, weighted][img3]

| Request | Random value | Assigned to |
|---|:-:|---|
| First request | 7 | Member C |
| Second request| 2 | Member B |
| Third request | 5 | Member C |

![Request assignment methods, weighted -screenshot][img4]

### User with fewest open requests

Assigns new requests to the member with the fewest active requests.

| Request | Condition | Assigned to |
|---|---|---|
| First request | Members B and C have the fewest requests | Member C |
| Second request| Member B has the fewest requests | Member B |
| Third request | All members have the same number of requests | Member B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Do not assign

Does not assign requests to specific members. All requests are placed in a queue by default.

![Request assignment methods, do not assign -screenshot][img6]

**Get next request in queue**: If the queue system is set up for your company, you can click this option to get the next unassigned request in the queue for the category you belong to.

## Specify assignment method for category

A request handler with category administration rights can specify the assignment method for categories:

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Select **Requests** > **Categories**.
1. Select the required category.
1. Select the **Assignment method** tab.
1. Select the appropriate options.
1. Click **OK**.

## Example

<!-- markdownlint-disable-next-line MD034 -->
Imagine that your company has created a category for each department in the company: User support, Sales, Accounts, and so on. And you have also specified that all emails sent to support@company.com should be automatically assigned to the "User support" category. All the staff in the user support department are members of this category. For this category they have set the **Even assignment** method. This means that all the members of the category will get the same number of requests, and each of the members will continuously receive new requests in their **Own open requests** screen. If, alternatively, they had selected the **Do not assign** method, the members would have had to go into the **Unassigned requests** screen themselves to [take ownership of new requests][4].

## Related content

* [Process a request][1]
* [Create a request][2]
* [Accept a request][4]
* [Ask another request handler for help (transfer)][5]
* [How to set up Get next request in queue][6]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[4]: accept.md
[5]: transfer.md
[6]: ../admin/next-in-queue.md
[3]: ../admin/category/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/assign-requests.png
[img2]: ../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../media/loc/en/request/assign-requests-not.png

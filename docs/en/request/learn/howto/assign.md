---
uid: help-en-request-assign
title: Assignment methods
description: Assignment methods for requests
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: request
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
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

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Specify assignment method for category

A request handler with category administration rights can specify the assignment method for categories:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Select **Requests** > **Categories**.
1. Select the required category.
1. Select the **Assignment method** tab.
1. Select the appropriate options.
1. Click **OK**.

## Example

Imagine that your company has created a category for each department in the company: User support, Sales, Accounts, and so on. And you have also specified that all emails sent to support@company.com should be automatically assigned to the "User support" category. All the staff in the user support department are members of this category. For this category they have set the **Even assignment** method. This means that all the members of the category will get the same number of requests, and each of the members will continuously receive new requests in their **Own open requests** screen. If, alternatively, they had selected the **Do not assign** method, the members would have had to go into the **Unassigned requests** screen themselves to [take ownership of new requests][4].

## What would you like to do now?

* [Process a request][1]
* [Create a request][2]
* [Accept a request][4]
* [Ask another request handler for help (transfer)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->

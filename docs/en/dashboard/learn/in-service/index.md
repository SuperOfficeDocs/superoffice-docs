---
uid: help-en-dashboard-in-service
title:  Dashboards in Service
description:  Dashboards in Service
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dashboard
so.topic: help
language: en
---

# Dashboards in Service

A dashboard can contain up to four tiles (panels) that provide an instant overview of requests and request statistics in SuperOffice Service. The content of the tiles can be individually customized, for different roles or globally.

> [!NOTE]
> By default, only one dashboard tab exists. It is called **Dashboard**. It contains four tiles with pre-defined charts. You can select which tiles you want to display here. You can also [create your own dashboards][1] with the tiles/charts of your choice.

## Choose the content of the tiles

If you or your role have sufficient rights, you can choose the content you want to display in the tiles on the dashboard.

1. Click the title text of a tile, or click **Blank** if the tile is empty.

2. Select the content you want from the list.

You can choose to display, for example:

* Statistics about requests
* Statuses of your own requests
* Own active requests
* Unassigned requests

Find out more about this below.

## Statistics

You can choose from a range of different chart types, such as open requests per request handler or status, created requests per week or month and response time. If you hold the mouse pointer over the different parts of the charts, more detail is displayed.

## Status

This tile displays the following information about your requests:

* Number of open requests, including number of unread requests and number of requests with new information
* Number of closed requests
* Number of postponed requests
* Number of unassigned requests
* Number of requests in the favorites list

If the number of a specific type of request is greater than 0, you can click the row in question to display detailed information about these requests.

## Hyperlinks to categories

If specified under **Settings** > **Categories**, the **Status** tile on the dashboard also contains hyperlinks to categories and information about how many requests there are in each category.

A user with category administration rights can do the following:

1. Select ![icon][img1] **System settings > Categories**.
2. Select the required category.
3. Select the **Properties tab**.
4. Check **Show category in status view**.
5. Click **OK**.

Depending on the rights you have in the system, the **Status** tile may also show the following information:

* **Unpublished FAQ entries**: If the company's SuperOffice Service installation has a licence for SuperOffice Customer Centre, any unpublished FAQ entries will also be displayed here. These must be approved by a user with publishing rights.

    A user with publishing rights can check **Publish in the FAQ entry editing screen**.

* **System messages**: Any messages from the system concerning errors or email blocking are displayed at the bottom of the **Status** tile. You can open a message by clicking it.

## Own open requests

Shows requests that belong to you and that have the **Open** status. In other words, this list contains the requests you are responsible for dealing with.

## Unassigned requests

Lists requests that no-one is assigned responsibility for. To [take responsibility for one of the requests][2], it is important you click **Accept request**. Otherwise, someone else might answer the request at the same time.

## What would you like to do now?

* [Create a dashboard][1]
* [Assign requests][3]
* [Create requests][4]
* [Find requests][5]
* [Process requests][6]

<!-- Referenced links -->
[1]: ../create.md#service
[2]: ../../../request/learn/howto/accept.md
[3]: ../../../request/learn/howto/assign.md
[4]: ../../../request/learn/howto/create.md
[5]: ../../../request/learn/find.md
[6]: ../../../request/learn/howto/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/settings-small.png

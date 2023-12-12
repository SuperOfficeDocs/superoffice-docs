---
uid: help-en-request-type
title: Request type
description: Request type
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: request, type
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Request type

All requests that are registered in SuperOffice have a type. The default type is "Request". To view, add, update, and delete request types go to **Settings and maintenance**.

> [!NOTE]
> This feature requires a Service Premium user plan (to create and update request types) and a Development Tools site license to define screen layouts based on request types in the Screen Designer. (Available in pilot only.)

## Why use request types?

The main benefit of request types is efficient support. A specific request type targets a set of attributes needed for a specific process.

## Example

The finance team utilizes requests to manage incoming invoice claims, necessitating the visibility of the invoice number as a designated field. Conversely, the inbound sales team employs requests to address incoming leads. In instances where a request pertains to a lead, the invoice number holds no relevance and should remain entirely omitted from view.

## Where can I find the request types?

* In **Settings and maintenance**, select **Requests** in the navigator and then the **Request types** tab.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Settings

| Setting | Description |
|---|---|
| Name | The name of the request type. |
| Description | Explains the purpose of the request type.|
| Icon | Used as a visual label to show the type. Choose from a set of pre-defined options. Default: ticket icon.|
| Use as default | Indicates if this is the default type of new requests. |
| Available statuses | A subset of request statuses that are relevant for this type. Used to filter the dropdown list in the UI. Empty field means all statuses are available. |
| Default status | The [status][4] set when an agent creates a new request. Takes precedence over other preferences. Mandatory if **Available statuses** is set. |
| Available priorities | A subset of request priorities that are relevant for this type. Used to filter the dropdown list in the UI. Empty field means all priorities are available. |
| Default priority | The [priority][3] set when an agent creates a new request. Takes precedence over other preferences. Mandatory if **Available priorities** is set. |
| Reply template | The [reply template][5] that will be used when an agent replies to a request of this type. |

## Related content

* [Create request type][1]
* [Delete request type][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->

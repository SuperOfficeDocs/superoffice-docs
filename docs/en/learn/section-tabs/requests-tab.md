---
uid: help-en-section-tab-requests
title: Requests tab
description: Learn how to view, add, and manage Service requests in SuperOffice CRM, helping you efficiently track customer interactions across companies and contacts.
keywords: requests tab, section tab, request archive, ticket archive
author: Bergfrid Skaara Dias
date: 03.11.2025
version: 10.5.3
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Requests tab

The **Requests** section tab in SuperOffice CRM allows users to view and manage [Service requests][1] (tickets) associated with specific entities, such as companies and contacts. This guide provides a unified overview of how to access and interact with request records, improving the ability to handle customer interactions efficiently.

![Requests section in company -screenshot][img1]

## Availability of the Requests section tab

The **Requests** section tab is available for:

| Entity | Description of the Requests section tab |
|---|---|
| [Company][9] | Displays all requests linked to the company, with options to view and manage the details. |
| [Contact][10] | Shows requests associated with the contact, allowing for more personalized support. |

## <a id="columns"></a>Requests tab columns overview

The **Requests** section tab contains the following columns to provide key information about each request:

| Column | Description |
|---|---|
| Request ID | Unique identifier for the request. |
| Title | The title or subject of the request. |
| Created | The date when the request was initially logged. |
| Last changed | The date when the request was last updated. |
| Closed at | The date when the request was closed. |
| Owner | The person responsible for handling the request. |
| Category | The category of the request. |
| Full name | The full name of the contact associated with the request. |
| Company | The company associated with the request. |
| Status | The current status of the request (such as Open, Closed, Pending). |
| Tags | Tags used to categorize or add metadata to the request.|

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## View requests in the Requests section tab

1. Go to the relevant screen, such as Company or Contact.

1. Click on the **Requests** tab to see all requests linked to the entity.

1. Double-click a request in the list to open it in a separate window and access full details.

### Include closed requests

To include closed requests in the list, check the **Closed** box at the bottom of the section tab. This provides a complete view of both open and closed requests associated with the entity.

## Creating a request

1. In the **Requests** section tab, click **Add** to create a new request for the contact.

1. Fill in the request details as needed. The **Contact** field is prefilled based on the person you were viewing.

1. Click **Save** to register the request.

## Editing a request

To edit a request directly from the **Requests** section tab:

1. Locate and double-click the request you want to work on.

1. In the window that opens, click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) to begin updating the request details.

## Additional tips

* **Tracking requests:** Monitor open issues and ensure timely responses.

## Related content

* [How to create a request][2]
* [Managing customer requests in SuperOffice CRM][3]
* [Group columns and summarize amounts][5]

<!-- Referenced links -->
[1]: ../../request/learn/index.md
[2]: ../../request/learn/create.md
[3]: ../../request/learn/reply.md
[5]: configure-columns.md#calculate
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/requests-detail.png

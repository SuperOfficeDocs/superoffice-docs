---
# Mandatory fields.
title: bulk_update_api         # (Required) Very important for SEO.
description: Bulk update API - How to change large numbers of records in bulk. # (Required) Important for SEO.
author: Tony Yates
so.date: 06.23.2017
keywords: data-access, bulk-update
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online         # online, web, win, pocket, or mobile
---

# Bulk update API

Easily update multiple entities at once.

## Introduction

Imagine you have a selection of contacts where the company category is set to "Customer", and for some reason, you need to uncheck the Stop checkbox on each one. Assuming there are hundreds of companies that need to be changed, this could potentially take a user some hours to complete.

Thankfully with SuperOffice 8.1, the Windows client ( & Web Client v8.3) has a new feature that allows users with the proper functional right to select one or more rows in an archive control and update one or more of their fields in a single bulk update.

The following figure shows a company’s list of contacts archive, with several people selected and the context menu displayed. The menu shows the new **Bulk Update** option near the bottom.

**Selection results:**

![x][img1]

Sticking with the original idea to update a list of company Stop checkbox, the next figure displays the bulk update dialog which allows a user to select the Company Stop property and Set it to No. When the **Update** button is clicked, a background job is created that iterates over each selected company and to Set the `Stop` property to No, leaving it unchecked in the SuperOffice UI.

**Bulk update dialog:**

![x][img2]

> [!TIP]
> **For Windows clients**, there is a switch to enable a more advanced view of bulk update operation results. Add this setting to your *souser.ini*: `[BulkUpdate]`<br>`ResultsArchive=1`<br>This will open the dialog with a **Results** view giving you running feedback while the job is running.

While this is very interesting for SuperOffice Windows client users, how do we perform the same action in code?

NetServer contains a new namespace called `SuperOffice.CRM.BulkUpdate`, which is where all the new bulk update functionality resides.

Prior to the Bulk Update API, users had to open each entity and update them manually. As shown in this article that is no longer the case, and third-party applications are also able to take advantage of this system using the APIs.

Bulk Update is not to be taken lightly. It’s a very powerful tool that can save users hours of manual data entry, but can also create havoc if used improperly. I recommend running all your tests on backups or on a test database to ensure you get the expected results.

In these pages, we will discuss Bulk Update, explain the new types and how to work with them, and show in code how your applications can also begin to leverage this powerful functionality.

## Getting started

First, there are a few [practical details][2] to know before we will move on to the code.

Then you should read:

* [Field value info][5]
* [Operations and values][3]
* [Entities and field types][4]

After that, you should be all set for exploring the [NetServer Core examples][6].

## Bulk Update using NetServer Web Services API

The web client version 8.3 introduced support for bulk update via  web services. exist to facilitate this functionality in the web client or distributed architectures. It is, however, on the roadmap! When you see bulk update in the web client, then you know the web services are available to facilitate this functionality. [View reference][1].

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-Agents-BulkUpdate\_Agent-BulkUpdate\_Agent.htm
[2]: using-bulk-update.md
[3]: operations-and-values.md
[4]: entities-field-types.md
[5]: field-value-info.md
[6]: ns-core-examples.md

<!-- Referenced images -->
[img1]: media/image001.png
[img2]: media/image004.jpg

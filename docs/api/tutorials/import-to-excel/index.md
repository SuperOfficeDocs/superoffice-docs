---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: import_to_excel       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to import data into Excel # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so-date: 15 Oct 2020
keywords:
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to import data into Excel

A common question is "how do I import SuperOffice data into Microsoft Excel?", and the answer is using web API OData queries.

Below is a walk-though how to perform this task. The presented example is kept simple and only imports a list of company names and departments. You can of course make much more complex queries, but should first know more about [OData in general][1], and how SuperOffice exposes [OData with Archive providers][2].

Excel version used in this example:

![x][img1]

## Importing OData into Excel

In Excel select the Data menu item, then select From Web. Click the Advanced option to expand the dialog. Fill in the required URL to SuperOffice, including the path the web API endpoint. Use the **Add part** button to add query string parameters to the URL. In this case, OData query parameters to specify the desired fields.

The headers define the credentials and desired format returned. This example uses the Basic username and password credential type in the Authorization header. I'll expand on the Authorization header later in this post.

![x][img2]

Click **OK**. As long as authorization successed, the Record Tool window appears. This tool allows transformation of the data received from the endpoint. Most SuperOffice OData queries return at least three properties; `odata.metadata`, `odata.nextLink` and `value`. The *value* property is an array containing the query results. To access the data within the array, right-click the *value* row and select **Drill Down**.

![x][img3]

The drill down adds another tranformational step to the **APPLIED STEPS** list (in the lower right of the window). This action creates another list of items called Records. Each record contains the select fields entered in the query. To see the fields, we need to apply one more transformational step. Right-click the List row and select **To Table**.

![x][img4]

The To Table dialog appears. There is no need to change these settings. Click **OK**.

![x][img5]

The Power Query Editor appears, which presents the opportunity to select what columns to display in the final output. Click the field selection icon to display the field list.

![x][img6]

In the checkbox list, **select** the desired fields for display, then click **OK**.

![x][img7]

The column data appears, and the function textbox presents an opportunity to change the header names for the columns. When ready to view the final output of the applied transformation steps, click **Close & Load**.

![x][img8]

The data appears in the Excel sheet as expected, with the Query (or queries) on the right.

![x][img9]

## Authentication Options

As shown in the [web api documentation][3], only certain Authorization headers types can be used in the different SuperOffice environments, onsite vs. online.

![x][img10]

The Basic credentials used in this blog example uses the username and password, however, the format is required to be formatted as username and password separated with a colon. Then it is [base64 encoded][4].

`username:password => dXNlcm5hbWU6cGFzc3dvcmQ=`

To obtain a Bearer access token, you'll need a registered application that can get these for you. If you don't have one, first register as an [online developer][5], then you will received instructions to register an application. If you don't have the infrastructure to create an online application, use the [helper application][5] to sign in online as an application and obtain an access token. Remember to use the helper application redirect URL when registering your application.

<!-- Referenced links -->
[1]: https://www.odata.org/documentation/odata-version-2-0/uri-conventions/
[2]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-REST-Search.htm
[3]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-Authentication-Authentication.htm
[4]: https://www.base64encode.org/
[5]: https://community.superoffice.com/en/developer/create-apps/resources/developer-registration/
[6]: ../authentication/helper-application.md

<!-- Referenced images -->
[img1]: media/odata-1.png
[img2]: media/odata-2.png
[img3]: media/odata-3.png
[img4]: media/odata-4.png
[img5]: media/odata-5.png
[img6]: media/odata-6.png
[img7]: media/odata-7.png
[img8]: media/odata-8.png
[img9]: media/odata-9.png
[img10]: media/odata-10.png
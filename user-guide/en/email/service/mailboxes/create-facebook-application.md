---
uid: help-en-admin-listfilters-listfilters-editfacebookapplication
title: admin listFilters listFilters editFacebookApplication
description: admin listFilters listFilters editFacebookApplication
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
so.envir: onsite
---

# Create Facebook applications

If you want to interact with your customers via Facebook, you will want to create a link between SuperOffice Service and a user wall or page on Facebook. Messages and comments posted to the wall will then be imported into SuperOffice Service as requests (in the same way as e-mail is imported). When the request handler responds to one of these messages, the reply is posted to Facebook.

## Step 1: Set up an application on Facebook

> [!NOTE]
> This assumes that you have developer access to Facebook. To get developer access:
> Log in to Facebook; Go to [https://developers.facebook.com][1]; Click **Register** and follow the instructions.

Firstly, you need to set up an application on Facebook in cooperation with the user or owner of the page you want to receive messages from. [!include[To do this](../../../includes/to-do-this.md)]

1. Open a browser and log in to Facebook.
2. Go to <https://developers.facebook.com>.
3. See [Facebook integration on SuperOffice Community][2] on how to proceed.
4. When you have created the application in Facebook, go to the next step.

## Step 2: Set up a Facebook account in SuperOffice Service

Now you need to set up a Facebook account in SuperOffice Service.

[!include[To do this](../../../includes/to-do-this.md)]

[!include[Go to email](../includes/goto-email.md)]

1. Click the **New Facebook application** button. The **Properties for Facebook application** screen appears.

1. In the **Application ID** field, enter the value you noted down from the **Application ID** field in Facebook.

1. If you want to import messages from a page, enter that page's ID in the **Page ID** field.

1. In the **Category** list box, select to which category messages from the Facebook application should belong.

1. In the **Priority** list box, select which priority to assign to requests from this Facebook application.

1. In the **Interval** list box, select how often SuperOffice Service is to get messages from this Facebook application.

1. In the **Customer language** list box, specify which language is to be used for the customers who send messages to this Facebook application. For more details about this, see [Customer languages][3].

1. In the **E-mail fields** field, enter a comma-separated list of e-mail fields (headers) to be displayed in the request message, for example, To and Cc.

1. Click **OK**. The Facebook account is created.

## Related topics

* [Facebook integration on SuperOffice Community][2]

<!-- Referenced links -->
[1]: https://developers.facebook.com
[2]: ../../../../../docs/service/config/set-up-facebook-integration.md
[3]: ../../../settings/options/custlangs/index.md

<!-- Referenced images -->

---
uid: help-en-email-filter-create
title: Email filters
description: Create email filters
keywords: email, email filter, filter
author: digitaldiina
date: 11.27.2025
version: 11.6
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
redirect_from:
  - /en/email/service/learn/email-filters/delete-email-filter
  - /en/email/service/learn/email-filters/create-email-filter
---

# Email filters

## Create email filter

1. [!include[Go to email](includes/goto-email.md)]

1. Select the **Email filters** tab.

1. Click **New email filter**. The **Properties for email filter** screen appears.

1. In the **Filter** tab, you can specify which emails are to be filtered, by entering the following information:

    * **Description**: Enter a brief description of the email filter.
    * **Priority**: In this list box, you select the filter's priority. A value of 100 is the highest priority and 1 the lowest.
    * **Script**: Here you can select a [script or macro][1] to be run by this filter.

1. Select what the filter applies to:

    * **All incoming email**: If you select this option, the email filter is used for all incoming emails.
    * **Email which contains**: If you select this option, emails containing the fixed expression (regexp) specified in the fields to the right will trigger the email filter. You can choose between the email header and/or email body.

1. In the **Find regular expressions** tab, you can define regular expressions that find text in emails, and save them as variables. To assign the value from a regular expression to a variable named myVariable, use the following format: myVariable = &lt;regexp&gt;.

1. In the **Set links** tab, you can specify how incoming email is linked to a request and/or a contact on the basis of the email content:
    * **Link to contact where**: To link the generated request to a contact based on information from the email, select one of the contact fields from the list, and then enter a regular expression that returns the value that identifies the contact.
    * **Link to request where**: Here you can link the email to an existing request based on a regular expression that extracts data from the email.

1. In the **Set values** tab, you can add or replace values for contacts, companies and requests, based on the content of the email:
    1. In the list box on the left, select the required field for the contact, company or request.

    2. In the field on the right, enter one of the following:
        * the regular expression that finds the value to be specified
        * a fixed value (must be prefixed with =)

    3. If you check **Replace**, the value that is found replaces an existing value.

    4. Click **Add** to add the value.

        > [!TIP]
        > You can delete a value again by selecting it and clicking <i class="ph ph-x-circle" aria-label="Remove icon"></i>.

1. In the **Set properties** tab, you can set specific properties for requests that are generated from emails that match the current filter. See properties below.

1. In the **Email response** tab, you can create different emails to be sent when the filter is triggered. Here you can enter the following information:
    * **Send reply template**: Here you can select which [reply template][2] should be sent if the filter is triggered.
    * **... to contact**: If checked, the selected reply template is sent back to the contact.
    * **... to**: If checked, the selected reply template is sent to the email address specified in the field on the right.
    * **Suggest FAQ entries from**: If checked, the system will [suggest FAQ entries based on the text][3] in incoming emails. The suggested entries are available as template variables and can therefore be reused in the selected reply template. You can also specify which branch of the FAQ tree to search in, by specifying the folder you want.
    * **Block auto-reply**: If checked, the system will not reply automatically to this email.

1. In the **Email boxes** tab, you can select which mailboxes the filter applies to.

1. Click **OK**. The email filter is created.

## Properties for generated requests

* **Set owner**: If checked, you can select which user will be assigned emails processed by this filter.

* **Set category**: If you check here and select a category, email processed by this filter will end up in the specified category.

* **Request type:** If you check here and select a type, email processed by this filter will be assigned the specified [request type][4].

* **Set priority**: If you check here and select a priority, email processed by this filter will be assigned the specified priority.

* **Set access level**: If you check here and select an access level from the list box, email processed by this filter will be assigned the specified access level. If you select **External**, the generated request will be accessible in SuperOffice Customer Centre.

* **Set messages**: If you check here and select a reply template, the request message will be set up in accordance with the selected template, merged with all the fixed expressions that are found. You can use this to present a form, which is sent by email, and is much tidier. This message will replace the original email.

* **Close request**: If checked, the request is closed immediately and assigned the status **Closed**.

* **Ignore From address**: If checked, SuperOffice Service ignores the original sender address. The request will then not be linked to a contact unless other rules in the email filter create a link to a contact.

* **Block email**: If checked, the email is not imported into SuperOffice Service. It is added instead to the list in the **Blocked email** tab.

* **Permanently delete email**: If checked, the email is deleted permanently.

    > [!NOTE]
    > It is not possible to restore emails that have been permanently deleted.

* **Forward to**: If you check here and enter an email address, the email will be forwarded to this address.

* **Include debug information in the message**: If checked, the message will include debug data that you can use to check that the email filter is working correctly.

* **Mark email as bounced**: If checked, email processed by this filter will be marked as bounced. This may be relevant for emails received from postmaster, mailer-daemon, and so on.

## <a id="delete"></a>Delete email filter

1. Select the **Email filters** tab.

1. Click the required email filter. The **Properties for email filter** screen appears.

1. Click the **Delete** button at the bottom of the screen.

1. Click **OK** to confirm. The email filter is removed from SuperOffice Service.

<!-- Referenced links -->
[1]: ../../../customization/macros-and-scripts/admin/index.md
[2]: ../../../knowledge-base/learn/reply-templates/index.md
[3]: ../../../knowledge-base/learn/reply-templates/create.md#faq
[4]: ../../../request/admin/type/index.md

<!-- Referenced images -->

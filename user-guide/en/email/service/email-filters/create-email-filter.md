---
uid: help-en-email-filter-create
title: Create email filters
description: Create email filters
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create email filters

To create a new email filter:

[!include[Go to email](../includes/goto-email.md)]

1. Select the **E-mail filters** tab.

1. Click **New e-mail filter**. The **Properties for e-mail filter** screen appears.

1. In the **Filter** tab, you can specify which e-mails are to be filtered, by entering the following information:

    * **Description**: Enter a brief description of the e-mail filter.
    * **Priority**: In this list box, you select the filter's priority. A value of 10 is the highest priority and 1 the lowest.
    * **Script**: Here you can select a script or macro to be run by this filter. See [Macros and scripts][1].

1. Select whether to apply this filter for all incoming e-mail or only e-mails matching specific criteria:

    * **All incoming e-mail**: If you select this option, the e-mail filter is used for all incoming e-mails.
    * **E-mail which contains**: If you select this option, e-mails containing the fixed expression (regexp) specified in the fields to the right will trigger the e-mail filter. In the list box on the far right, you can choose between the e-mail header and/or e-mail body.

1. In the **Find regular expressions** tab, you can define regular expressions that find text in e-mails, and save them as variables. To assign the value from a regular expression to a variable named myVariable, use the following format: myVariable = &lt;regexp&gt;.

1. In the **Set links** tab, you can specify how incoming e-mail is linked to a request and/or a contact on the basis of the e-mail content:
    * **Link to contact where**: Here you can link the generated request to a contact based on information from the e-mail. You define these by selecting one of the contact fields in the left-hand list box, and then entering a regular expression that returns the value that identifies the contact.
    * **Link to request where**: Here you can link the e-mail to an existing request based on a regular expression that extracts data from the e-mail.

1. In the **Set values** tab, you can add or replace values for contacts, companies and requests, based on the content of the email:
    1. In the list box on the left, select the required field for the contact, company or request.

    2. In the field on the right, enter one of the following:
        * the regular expression that finds the value to be specified
        * a fixed value (must be prefixed with =)

    3. If you check **Replace**, the value that is found replaces an existing value.

    4. Click **Add** to add the value.

        > [!TIP]
        > You can delete a value again by selecting it and clicking the delete icon ( ![icon][img1] ).

1. In the **Set properties** tab, you can set specific properties for requests that are generated from e-mails that match the current filter:

1. In the **E-mail response** tab, you can create different e-mails to be sent when the filter is triggered. Here you can enter the following information:
    * **Send reply template**: Here you can select which [reply template][2] should be sent if the filter is triggered.
    * **... to contact**: If you check here, the selected reply template is sent back to the contact.
    * **... to**: If you check here, the selected reply template is sent to the e-mail address specified in the field on the right.
    * **Suggest FAQ entries from**: If you check here, the system will suggest FAQ entries based on the text in incoming e-mails. The suggested entries are available as template variables and can therefore be reused in the selected reply template (see [Create reply template with automatic FAQ reply][3]). You can also specify which branch of the FAQ tree to search in, by specifying the folder you want.
    * **Block auto-reply**: If you check here, the system will not reply automatically to this e-mail.

1. In the **E-mail boxes** tab, you can select which mailboxes the filter applies to.

1. Click **OK**. The e-mail filter is created.

<!-- Referenced links -->
[1]: ../../../user/service/automation/index.md
[2]: ../../../user/service/reply-templates/index.md
[3]: ../../../user/service/reply-templates/autofaq.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/btn-delete-admin.png

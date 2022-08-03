---
uid: help-en-admin-listfilters-listmsfilter-newmsfilter
title: admin listFilters listMSFilter newMSFilter
description: admin listFilters listMSFilter newMSFilter
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create e-mail filters

To create a new e-mail filter:

1. Click the **Requests** button in the navigator and select the **E-mail** tab.

2. Select the **E-mail filters** tab.

3. Click **New e-mail filter**. The **Properties for e-mail filter** screen appears.

4. In the **Filter** tab, you can specify which e-mails are to be filtered, by entering the following information:

    * **Description**: Enter a brief description of the e-mail filter.
    * **Priority**: In this list box, you select the filter's priority. A value of 10 is the highest priority and 1 the lowest.
    * **Script**: Here you can select a script or macro to be run by this filter. See [Macros and scripts][1].
5. Select whether to apply this filter for all incoming e-mail or only e-mails matching specific criteria:

    * **All incoming e-mail**: If you select this option, the e-mail filter is used for all incoming e-mails.
    * **E-mail which contains**: If you select this option, e-mails containing the fixed expression (regexp) specified in the fields to the right will trigger the e-mail filter. In the list box on the far right, you can choose between the e-mail header and/or e-mail body.
6. In the **Find regular expressions** tab, you can define regular expressions that find text in e-mails, and save them as variables. To assign the value from a regular expression to a variable named myVariable, use the following format: myVariable = &lt;regexp&gt;.

7. In the **Set links** tab, you can specify how incoming e-mail is linked to a request and/or a contact on the basis of the e-mail content:
    * **Link to contact where**: Here you can link the generated request to a contact based on information from the e-mail. You define these by selecting one of the contact fields in the left-hand list box, and then entering a regular expression that returns the value that identifies the contact.
    * **Link to request where**: Here you can link the e-mail to an existing request based on a regular expression that extracts data from the e-mail.

8. In the **Set values** tab, you can add or replace values for contacts, companies and requests, based on the content of the e-mail:
    1. In the list box on the left, select the required field for the contact, company or request.

    2. In the field on the right, enter one of the following:
        * the regular expression that finds the value to be specified
        * a fixed value (must be prefixed with =)

    3. If you check **Replace**, the value that is found replaces an existing value.

    4. Click **Add** to add the value.

        > [!TIP]
        > You can delete a value again by selecting it and clicking the delete icon ( ![icon][img1] ).

9. In the **Set properties** tab, you can set specific properties for requests that are generated from e-mails that match the current filter:

    * **Set owner**: If you check here, you can select which user will be assigned e-mails processed by this filter.

    * **Set category**: If you check here and select a category, e-mail processed by this filter will end up in the specified category.

    * **Set priority**: If you check here and select a priority, e-mail processed by this filter will be assigned the specified priority.

    * **Set access level**: If you check here and select an access level from the list box, e-mail processed by this filter will be assigned the specified access level. If you select **External**, the generated request will be accessible in SuperOffice Customer Centre.

    * **Set messages**: If you check here and select a reply template, the request message will be set up in accordance with the selected template, merged with all the fixed expressions that are found. You can use this to present a form, which is sent by e-mail, and is much tidier. This message will replace the original e-mail.

    * **Close request**: If you check here, the request is closed immediately and assigned the status **Closed**.

    * **Ignore From address**: If you check here, SuperOffice Service ignores the original sender address. The request will then not be linked to a contact unless other rules in the e-mail filter create a link to a contact.

    * **Block e-mail**: If you check here, the e-mail is not imported into SuperOffice Service. It is added instead to the list in the **Blocked e-mail** tab.

    * **Permanently delete e-mail**: If you check here, the e-mail is deleted permanently.

        > [!NOTE]
        > It is not possible to restore e-mails that have been permanently deleted.

    * **Forward to**: If you check here and enter an e-mail address, the e-mail will be forwarded to this address.

    * **Include debug information in the message**: If you check here, the message will include debug data that you can use to check that the e-mail filter is working correctly.

    * **Mark e-mail as bounced**: If you check here, e-mail processed by this filter will be marked as bounced. This may be relevant for e-mails received from postmaster, mailer-daemon, etc.

10. In the **E-mail response** tab, you can create different e-mails to be sent when the filter is triggered. Here you can enter the following information:
    * **Send reply template**: Here you can select which reply template should be sent if the filter is triggered.
    * **... to contact**: If you check here, the selected reply template is sent back to the contact.
    * **... to**: If you check here, the selected reply template is sent to the e-mail address specified in the field on the right.
    * **Suggest FAQ entries from**: If you check here, the system will suggest FAQ entries based on the text in incoming e-mails. The suggested entries are available as template variables and can therefore be reused in the selected reply template. You can also specify which branch of the FAQ tree to search in, by specifying the folder you want.
    * **Block auto-reply**: If you check here, the system will not reply automatically to this e-mail.

11. In the **E-mail boxes** tab, you can select which mailboxes the filter applies to.

12. Click **OK**. The e-mail filter is created.

<!-- Referenced links -->
[1]: ../../../user/service/automation/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/btn-delete-admin.png

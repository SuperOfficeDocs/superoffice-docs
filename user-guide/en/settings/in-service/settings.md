---
uid: help-en-service-settings-system-settings
title: Settings
description: Settings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service, settings
so.topic: help
language: en
---

# Settings

The **Settings** tab in the **System** screen contains the following options:

* **System administrator**: The email address of the person who is responsible for operation of SuperOffice Service. This must be an email address that is not imported/processed by SuperOffice Service.

* **Default From address**: The system's default email sender address. This address will normally be overridden by the addresses entered into mailboxes. This must be an email address that is imported into SuperOffice Service. For example, support@company.com.

* **Internal URL**: The base address for access to the SuperOffice Service system.

* **External URL**: The base address for external access to the SuperOffice Service system.

* **Cgi-Bin path**: The path to the folder where SuperOffice Service's Cgi-Bin application files reside. This path must have a leading folder separator sign (slash), but not a trailing one. For example, */bin* or */Scripts*.

* **Email tag**: The email tag which, in conjunction with the request number, creates a unique key for the subject in emails that are sent out from SuperOffice Service. You must not change this value unless you know what you are doing! If this value is changed, received emails will not be correctly linked to existing requests.

* **New status when accepting a request**: Select which status to use when a request is accepted by a user.

* **Send email notification of open requests**: Specifies if email about open requests is sent to the users. If you select **User can choose**, users can activate or deactivate email notification from ![icon][img1] **Personal settings** > **Settings** > **Notification**.

* **Number of days before notification**: Specifies how many days must pass before email notification about old requests is sent to the users. You can also specify the time of day that the notification should be sent.

* **System clock**: Select if to use a 24-hour or 12-hour (am/pm) clock in the system. User-specific clocks (for example, display of requests) are controlled by each individual user's settings, and not by this value.

* **Default style for outbound email**: Here you can define a default style to be used for emails in HTML format. For example: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimum score for FAQ search result (in percent)**: In reply templates that are sent to customers, you can add [automatic suggestions for FAQ entries][1] to help the customer to resolve the request themselves. In this field you can define how high a degree of correlation there must be between the customer's request and an FAQ entry for an FAQ entry to be added to the reply to the customer. If you define too low a value here, it is likely that the customer will receive many FAQs that are not relevant to the request. If a customer's requests correlates to a key word in an FAQ entry, the FAQ entry will always be included.

* **Default font in editor**: Select which font, font size and formatting to use as default for message registration.

* **Cross-post time frame in minutes**: Here you enter a number of minutes and if two or more emails arrive from the same contact within this period, the requests will be sent to the same request handler, if possible.

* **External access level as default**: If checked, external access level will be the default for new requests and messages. The alternative is internal access level as default.

* **Do not send email to new contacts**: If checked, email will not be sent to newly registered contacts.

* **Automatically create contact for new inbound request**: If checked, SuperOffice will automatically create a new person if it does not recognize an email address in an inbound request. This option can be disabled for GDPR compliance.

* **Enable editing of messages**: If checked, the user will be allowed to edit messages.

* **<!-- onsite--> Use user authentication from web server**: If checked, SuperOffice Service allows user authentication deriving from the web server (Microsoft IIS).

* **<!-- onsite--> Use customer authentication from web server**: If checked, SuperOffice Service allows user authentication deriving from the customer centre web server (Microsoft IIS).

* **<!-- onsite--> Online on the Internet**: Check here if SuperOffice Service is available on the Internet. This will control parts of the functionality available in SuperOffice Service, since some functionality actually requires the solution to be online.

* **Track all links**: Check here to track all links in mailings.

<!-- Referenced links -->
[1]: ../../request/reply-templates/create.md#faq

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png

---
uid: help-en-admin-editinfo-settings
title: admin editInfo settings
description: admin editInfo settings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Settings

The **Settings** tab in the **System** screen contains the following options:

* **System administrator**: The e-mail address of the person who is responsible for operation of SuperOffice Service. This must be an e-mail address that is not imported/processed by SuperOffice Service.

* **Default From address**: The e-mail address which is to be the system's default sender address. This address will normally be overridden by the addresses entered into mailboxes. This must be an e-mail address that is imported into SuperOffice Service, e.g. support@company.com.

* **Internal URL**: The base address for access to the SuperOffice Service system.

* **External URL**: The base address for external access to the SuperOffice Service system.

* **Cgi-Bin path**: The path to the folder where SuperOffice Service's Cgi-Bin application files reside. This path must have a leading folder separator sign (slash), but not a trailing one, e.g.: /bin or /Scripts.

* **E-mail tag**: The e-mail tag which, in conjunction with the request number, creates a unique key for the subject in e-mails that are sent out from SuperOffice Service. You must not change this value unless you know what you are doing! If this value is changed, received e-mails will not be correctly linked to existing requests.

* **New status when accepting a request**: Select which status is to be used when a request is accepted by a user.

* **Send e-mail notification of open requests**: Specifies whether e-mail about open requests is sent to the users. If you select **User can choose**, users can activate or deactivate e-mail notification from ![icon][img1] **Personal settings** &gt; **Settings** &gt; **Notification**.

* **Number of days before notification**: Specifies how many days must pass before e-mail notification about old requests is sent to the users. You can also specify the time of day that the notification should be sent.

* **System clock**: Select whether to use a 24-hour or 12-hour (am/pm) clock in the system. User-specific clocks (display of requests etc.) are controlled by each individual user's settings, and not by this value.

* **Default style for outbound e-mail**: Here you can define a default style to be used for e-mails in HTML format. For example: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimum score for FAQ search result (in percent)**: In reply templates that are sent to customers, you can add automatic suggestions for FAQ entries that might help the customer to resolve the request him or herself. In this field you can define how high a degree of correlation there must be between the customer's request and an FAQ entry for an FAQ entry to be added to the reply to the customer. If you define too low a value here, it is likely that the customer will receive many FAQs that are not relevant to the request. If a customer's requests correlates to a key word in an FAQ entry, the FAQ entry will always be included. See [Create reply template with automatic FAQ reply](document.replyTemplates.autoFAQ.md).

* **Default font in editor**: Here you can select which font, font size and formatting will be the default for message registration.

* **Cross-post timeframe in minutes**: Here you enter a number of minutes and if two or more e-mails arrive from the same contact within this period, the requests will be sent to the same request handler, if possible.

* **External access level as default**: If you check here, external access level will be the default for new requests and messages. The alternative is internal access level as default.

* **Do not send e-mail to new contacts**: If you check here, e-mail will not be sent to newly registered contacts.

* **Automatically create contact for new inbound request**: If you check here, SuperOffice will automatically create a new person if it does not recognize an e-mail address in an inbound request. This option can be disabled for GDPR purposes.

* **Enable editing of messages**: If you check here, the user will be allowed to edit messages.

* **![icon](../../media/OnPremises.png) Use user authentication from web server**: If you check here, SuperOffice Service allows user authentication deriving from the web server (Microsoft IIS).

* **![icon](../../media/OnPremises.png) Use customer authentication from web server**: If you check here, SuperOffice Service allows user authentication deriving from the customer centre web server (Microsoft IIS).

* **![icon](../../media/OnPremises.png) Online on the Internet**: Check here if SuperOffice Service is available on the Internet. This will control parts of the functionality available in SuperOffice Service, since some functionality actually requires the solution to be online.

* **Track all links**: Check here to track all links in mailings.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: ../../../../media/icons/globalmenu-personalsettings-small.png

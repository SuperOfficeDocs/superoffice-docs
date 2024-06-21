---
title: Introduction
uid: microsoft_365_document_integration
description: About Microsoft 365 Document Integration
author: {github-id}
keywords:
topic: concept
---

# About Microsoft 365 Document Integration

The Microsoft 365 Integration app integrates the document management features of Microsoft 365 SharePoint so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Microsoft 365 services all in one place.

[!include[Microsoft 365 app is deprecated](includes/deprecated.md)]

Simply sign in to SuperOffice using your Microsoft 365 login details and then open, edit and store documents in Microsoft 365 SharePoint directly from SuperOffice.

> [!NOTE]
> Microsoft has changed their product name Office 365 to Microsoft 365.

![Login with Microsoft 365 -screenshot][img1]

Read more details in our App Store: Microsoft 365 integration (unpublished)

If you do not require Microsoft 365 SharePoint’s document management features, and only wish for using Microsoft 365 for login purposes (federated login or Multi-factor authentication (MFA/2FA)) you don't need this document integration.

Read more here: [SuperOffice identity management][2]

## Integration overview

This section outlines how the integration works and what components are required and interacting.

### Description of integration

Integrating SuperOffice CRM Online against Microsoft 365 enables the following functionality:

* Using Microsoft 365's online capabilities for viewing, create, and edit files on the go (if file-type is supported by Microsoft 365 SharePoint).
* Signing in to SuperOffice CRM Online with a Microsoft 365 account.
* Using Microsoft 365 SharePoint to store documents and templates in the document archive.
* Using Microsoft 365 SharePoint to edit documents in the document-archive (if file-type is supported by Microsoft 365 SharePoint).

Read more about the [technical description in this article][3].

### Component overview

The integration consists of these main components:

* SuperOffice CRM Online
* SuperOffice Federation Gateway (`http://superid.superoffice.com/`)
* Microsoft 365 subscription
* Microsoft 365 SharePoint
* SuperOffice SharePoint App (SharePoint add-in) (our app acts as an add-in in SharePoint to be able to upload and download files in the cloud, and to authenticate users)

The authorization process will grant rights to an app registered with Microsoft 365 SharePoint called *SuperOffice SharePoint App*. The SuperOffice Federation Gateway handles secure communication between SuperOffice SharePoint App located in Microsoft 365 SharePoint, SuperOffice Online, and other parties (like SuperOffice MailLink).

**Step 1** is needed for setting up SharePoint to be able to use SharePoint’s document management features so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Microsoft 365 services all in one place. The site collection created within this step will also be used for adding the SuperOffice SharePoint app.

* If this is not a service you plan to use - you may skip step 1.7. ("template" folders and read access of root folder is enough).

**Step 2** is needed for creating new blank documents, spreadsheets, and presentations in SuperOffice CRM Admin's **Add template** > **Create a new template** (from a SharePoint template).

* If this is not a service you plan to use - you may skip it, and skip the SharePoint settings to *allow user to run custom scripts* - since you do not need to create new content types.

**Step 3** is needed for the authentication of users and is the basis for enabling the other services.

**Step 4** is needed for enabling your SuperOffice tenant to store templates and documents in SharePoint.

<!-- Referenced links -->
[2]: ../../../../identity-management/overview.md
[3]: ../../overview.md

<!-- Referenced images -->
[img1]: media/sign-in.png

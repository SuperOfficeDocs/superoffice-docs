---
title: Cloud document integration
uid: cloud_document_integration
description: Microsoft 365 and Google Workspace document integration in SuperOffice CRM
author: Bergfrid Dias
so.date: 06.20.2022
keywords: document
so.topic: concept
so.envir: cloud
so.client: online
---

# Microsoft 365 and Google Workspace document integration in SuperOffice CRM

<!-- This document will provide technical documentation about a specific area (Microsoft 365 and Google Workspace integration in SuperOffice CRM) of the SuperOffice CRM concept. The document is public and serves the purpose of documenting technology, architecture, security, and privacy matters. SuperOffice AS-->

SuperOffice CRM can integrate with Google Workspace and Microsoft 365. These integrations are referred to as cloud documents integrations. The integrations allow users (associates) to be authenticated by the cloud document service providers and documents to be managed by the respective cloud document service provider. The integrations use the extensibility provided by [SuperOffice NetServer plugins][4]. This extensibility is available to partners.

## Technical description

The architecture in the integration consists of 3 main components in SuperOffice CRM. First of all, we have the **login page** which delegates the authentication to the cloud document service provider and extracts the token from the authentication response from the cloud document service provider. The login page will also request the necessary access tokens required by the document plugin from the cloud document service provider. The **authentication plugin** validates the received token and matches it against existing identities in the database. The **document plugin** handles the creation, modification, and deletion of documents between SuperOffice CRM and the cloud document service provider. Both Microsoft 365 and Google Workspace use delegated authorization with OAuth-inspired protocols. The next sections discuss the differences between the Microsoft 365 and Google Workspace integrations.

All documents written in SuperOffice will be stored in the provider's cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

## Microsoft 365

A trust relationship must be established between SuperOffice CRM and Microsoft 365 to have access to both authentication and document management. The trust is established by creating an app/add-in in Office Store or SharePoint Application Library. Microsoft 365 assigns a client ID (application ID) with one or more client secrets to each app. All communications between SuperOffice CRM and Microsoft 365 will contain this client ID.

Authentication between SuperOffice CRM and Microsoft 365 is performed using the common [WS-Federation 1.2 endpoint][2] in Azure AD. The received SAML token in SuperOffice CRM is validated against Microsoft's public certificate to ensure that the token is issued by Microsoft.

Document management uses the SharePoint .NET Framework client object model (CSOM) and a provider-hosted app.

All document methods are using OAuth-based access tokens per user. These tokens are retrieved using the Authorization Code grant flow in [OAuth 2.0][2]. Both access and refresh tokens are stored encrypted in the customer database.

## Google Workspace

The integration with Google Workspace shares many of the same concepts as the Microsoft 365 integration. A trust relationship is established through application registration. Google Workspace uses the protocol [OpenID Connect][3] for both authenticating and for acquiring the necessary tokens for document management.

The document plugin uses the [Drive Service APIs][1] provided by Google for document management. One major difference between the Microsoft 365 and Google Workspace integration is that there are individual access tokens per user in Microsoft 365, but in the Google integration, the users share the same access token. This access token is granted by a system user. The reason behind this difference is how documents are shared between users in Google and Microsoft 365.

The Google Workspace Integration app integrates the document-management features of Google Drive with CRM Online so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Google Workspace services all in one place.

Simply sign in to SuperOffice using your Google login details and then open, edit and store documents in Google Workspace directly from SuperOffice.

To start using the Integration, setup consists of 2 steps:

1) How to set up [Google Workspace][5] to integrate to CRM Online.

2) How to configure the document templates for use, is documented in this article.

## Document templates

In standard CRM Online, all templates are stored in CRM Online storage ("SO Archive") and are set to save the files users create also in CRM Online storage ("SO Archive").

Even with the integration set up - you may still use "SO Archive" for your templates and documents - but then without the benefits of Microsoft 365 or Google Workspace services.

> [!NOTE]
> There is one selection for where to store the template: **Store template in:** and one selection for where to store the file created based on this template: **Document stored in:**.
>
> For most users, the important choice is **Document stored in:** because this is the criteria for where the document is created, and how it is opened (Word Online / Google Drive).

If you want to change where the original templates store new documents created - you can do this by changing the original template property "Document stored in:". This will not move the template itself.

If you want to move the template from CRM Online storage (SO Archive) to Google / Microsoft 365, click **Add** in Document Template list -> Choose "Copy an existing document template file".

Use a descriptive title for the template, and use "Header" to group templates. This makes it easier for the end-user to understand which files save and opens the files in Drive / Word Online.

## SuperOffice CRM Online and SuperID with Cloud document service providers

SuperOffice CRM installations in Online delegate the authentication to SuperID, which supports authentication with Google Workspace and Microsoft 365. SuperID functions as the component login page. All Online installations share the same registered application in both Microsoft 365 and Google Workspace. Note that none of the online installations have access to the client secret.

## Privacy and other considerations

All communication with Microsoft 365 and Google Workspace is over HTTPS/TLS-connections on both client and server-side.

The users’ passwords/credentials are not stored in SuperOffice CRM when using integrations with Microsoft 365 and Google Workspace. Since the authentication is delegated to a trusted cloud document service provider, it’s up to the cloud document service provider to decide how the user is authenticated.

Documents that have been marked as cloud documents are stored and handled at the discretion of the cloud document service provider. Temporary copies of the documents can be stored in the file storage of SuperOffice CRM for caching purposes.

These described integrations are optional per CRM installation.

## How do I use Cloud Office with document handling?

SuperOffice CRM Online can integrate with Google Workspace and Microsoft 365 (SharePoint) document handling.

1. Sign up for the [Google Workspace Integration][6] application in our App Store.

2. [Set up Google Workspace Integration specific][5]

3. [Configure Cloud Office document handling][7]

<!-- Referenced links -->
[1]: https://developers.google.com/drive/v2/reference/files
[2]: https://msdn.microsoft.com/en-us/library/office/fp142384.aspx
[3]: https://openid.net/specs/openid-connect-core-1_0.html
[4]: ../../api/plugins/index.md
[5]: g-suite/set-up.md
[6]: g-suite/index.md
[7]: g-suite/configure.md

---
title: Cloud document integration
uid: cloud_document_integration
description: Microsoft 365 SharePoint and Google Workspace document integration in SuperOffice CRM
author: Bergfrid Dias
date: 06.20.2022
keywords: document
topic: concept
envir: cloud
client: online
---

# Microsoft 365 SharePoint and Google Workspace integration in SuperOffice CRM

<!-- This document will provide technical documentation about a specific area (Microsoft 365 SharePoint and Google Workspace integration in SuperOffice CRM) of the SuperOffice CRM concept. The document is public and serves the purpose of documenting technology, architecture, security, and privacy matters. SuperOffice AS-->

SuperOffice CRM can integrate with Microsoft 365 SharePoint and Google Workspace. These integrations are referred to as cloud documents integrations. The integrations allow users (associates) to be authenticated by the cloud document service providers and documents to be managed by the respective cloud document service provider. The integrations use the extensibility provided by [SuperOffice NetServer plugins][4]. This extensibility is available to partners.

## Technical description

The architecture in the integration consists of 3 main components in SuperOffice CRM. First of all, we have the **login page** which delegates the authentication to the cloud document service provider and extracts the token from the authentication response from the cloud document service provider. The login page will also request the necessary access tokens required by the document plugin from the cloud document service provider. The **authentication plugin** validates the received token and matches it against existing identities in the database. The **document plugin** handles the creation, modification, and deletion of documents between SuperOffice CRM and the cloud document service provider. Both Microsoft 365 SharePoint and Google Workspace use delegated authorization with OAuth-inspired protocols. The next sections discuss the differences between the Microsoft 365 SharePoint and Google Workspace integrations.

All documents written in SuperOffice will be stored in the provider's cloud and available to open and edit in SuperOffice CRM Online.

## Microsoft 365 SharePoint documents

Open, edit, and store documents in Microsoft 365 SharePoint directly from SuperOffice.

All documents you write or archive from SuperOffice will be stored in your SharePoint Online repository, where you have total control forever. These documents can also be accessed by everyone in your company. Even those who do not use SuperOffice.

Activating SharePoint Online Documents makes SharePoint Online the preferred document repository for all your documents.

A self-service UI to provision and configure SharePoint as SO repository from SuperOffice Settings and maintenance.

## Google Workspace

A trust relationship between SuperOffice CRM and Google Workspace is established through application registration. Google Workspace uses the protocol [OpenID Connect][3] for both authenticating and for acquiring the necessary tokens for document management.

The document plugin uses the [Drive Service APIs][1] provided by Google for document management. With Google integration, the users share the same access token. This access token is granted by a system user.

The Google Workspace Integration app integrates the document-management features of Google Drive with CRM Online so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Google Workspace services all in one place.

Simply sign in to SuperOffice using your Google login details and then open, edit and store documents in Google Workspace directly from SuperOffice.

To start using the Integration, setup consists of 2 steps:

1) How to set up [Google Workspace][5] to integrate to CRM Online.

2) How to configure the document templates for use, is documented in this article.

### Document templates

In standard CRM Online, all templates are stored in CRM Online storage ("SO Archive") and are set to save the files users create also in CRM Online storage ("SO Archive").

Even with the Google integration set up - you may still use "SO Archive" for your templates and documents - but then without the benefits of Google Workspace services.

> [!NOTE]
> There is one selection for where to store the template: **Store template in:** and one selection for where to store the file created based on this template: **Document stored in:**.
>
> For most users, the important choice is **Document stored in:** because this is the criteria for where the document is created, and how it is opened.

If you want to change where the original templates store new documents created - you can do this by changing the original template property "Document stored in:". This will not move the template itself.

If you want to move the template from CRM Online storage (SO Archive) to Google, click **Add** in Document Template list -> Choose "Copy an existing document template file".

Use a descriptive title for the template, and use "Header" to group templates. This makes it easier for the end-user to understand which files save and opens the files in Google Drive.

## SuperOffice CRM Online and SuperID with Cloud document service providers

SuperOffice CRM installations in Online delegate the authentication to SuperID, which supports authentication with Google Workspace and Microsoft 365. SuperID functions as the component login page. All Online installations share the same registered application in both Microsoft 365 and Google Workspace. Note that none of the online installations have access to the client secret.

## Privacy and other considerations

All communication with Microsoft 365 and Google Workspace is over HTTPS/TLS-connections on both client and server-side.

The users’ passwords/credentials are not stored in SuperOffice CRM when using integrations with Microsoft 365 and Google Workspace. Since the authentication is delegated to a trusted cloud document service provider, it’s up to the cloud document service provider to decide how the user is authenticated.

Documents that have been marked as cloud documents are stored and handled at the discretion of the cloud document service provider. Temporary copies of the documents can be stored in the file storage of SuperOffice CRM for caching purposes.

These described integrations are optional per CRM installation.

<!-- Referenced links -->
[1]: https://developers.google.com/drive/v2/reference/files
[3]: https://openid.net/specs/openid-connect-core-1_0.html
[4]: ../../api/plugins/index.md
[5]: g-suite/set-up.md

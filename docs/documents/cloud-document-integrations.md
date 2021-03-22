---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cloud_document_integrations       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:  MS Office 365 and Google G Suite document integration in SuperOffice CRM
 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# MS Office 365 and Google G Suite document integration in SuperOffice CRM

*This document will provide technical documentation about a specific area (MS Office 365 and Google G Suite integration in SuperOffice CRM) of the SuperOffice CRM concept. The document is public and serves the purpose of documenting technology, architecture, security and privacy matters. SuperOffice AS*

## Introduction

SuperOffice CRM can integrate with Google G Suite and Microsoft Office 365. These integrations are referred to as cloud documents integrations. The integrations allow users (associates) to be authenticated by the cloud document service providers and documents to be managed by the respective cloud document service provider. The integrations use the extensibility provided by SuperOffice NetServer plugins (SuperOffice AS, 2016). This extensibility is available to partners.

## Technical description

### Overall technical description

The architecture in the integration consists of 3 main components in SuperOffice CRM. First of all, we have the _login page_ which delegates the authentication to the cloud document service provider and extracts the token from the authentication response from the cloud document service provider. The login page will also request the necessary access tokens required by the document plugin from the cloud document service provider. The _authentication plugin_ validates the received token and match it against existing identities in the database. The **document plugin** handles the creation, modification, and deletion of documents between SuperOffice CRM and the cloud document service provider. Both Office 365 and G Suite use delegated authorization with OAuth-inspired protocols. The next sections discuss differences between the Office 365 and G Suite integrations.

### Office 365

A trust relationship must be established between SuperOffice CRM and Office 365 to have access to both authentication and document management. The trust is established by creating an app/add-in in Office Store or SharePoint Application Library. Office 365 assigns a client ID (application ID) with one or more client secrets to each app. All communications between SuperOffice CRM and Office 365 will contain this client ID.

Authentication between SuperOffice CRM and Office 365 is performed using the common WS-Federation 1.2 endpoint in Azure AD as described in (Microsoft, 2015). The received SAML token in SuperOffice CRM is validated against Microsoft public certificate to ensure that the token is issued by Microsoft.

Document management uses the SharePoint .NET Framework client object model (CSOM) and a provider-hosted app.

All document methods are using OAuth-based access tokens per user. These tokens are retrieved using the Authorization Code grant flow in OAuth 2.0 (Microsoft, 2015). Both access and refresh tokens are stored encrypted in the customer database.

### G Suite

The integration with Google G Suite shares many of the same concepts as the Office 365 integration. A trust relationship is established through application registration. G Suite uses the protocol OpenId Connect (OpenId Foundation, 2016) for both authentication and for acquiring the necessary tokens for document management.

The document plugin uses the Drive Service APIs provided by Google (Google, 2016) for document management. One major difference between the Office 365 and G Suite integration is that there are individual access tokens per user in Office 365, but in the Google integration, the users share the same access token. This access token is granted by a system user. The reason behind this the difference in how documents are shared between users in Google and Office 365.

### SuperOffice CRM Online and SuperId with Cloud document service providers

SuperOffice CRM installations in Online delegate the authentication to SuperId, which supports authentication with G Suite and Office 365. SuperId functions as the component login page. All Online installations share the same registered application in both Office 365 and G Suite. Note that none of the online installations have access to the client secret.

## Privacy and other considerations

All communication with Office 365 and G Suite is over HTTPS/TLS-connections on both client and server-side.

The users’ passwords/credentials are not stored in SuperOffice CRM when using integrations with Office 365 and G Suite. Since the authentication is delegated to a trusted cloud document service provider, it’s up to the cloud document service provider to decide how the user is authenticated.

Documents that have been marked as cloud documents are stored and handled by the discretion of the cloud document service provider. Temporary copies of the documents can be stored in the file storage of SuperOffice CRM for caching purposes.

These described integrations are optional per CRM installation.

## Bibliography

* [Google, 2016. Drive REST API v2][1]
* [Microsoft, 2015. Authorization and authentication of SharePoint Add-ins][2]
* [OpenId Foundation, 2016. OpenID Connect Core 1.0 incorporating errata set 1][3]
* [SuperOffice AS, 2016. Plugin system][4]

<!-- Referenced links -->
[1]: https://developers.google.com/drive/v2/reference/files
[2]: https://msdn.microsoft.com/en-us/library/office/fp142384.aspx
[3]: https://openid.net/specs/openid-connect-core-1_0.html
[4]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/getting-started/patterns.md

---
title: Securing ERP Connectors for SuperOffice Online
uid: erp_security
description: Securing ERP Connectors for SuperOffice Online
author: {github-id}
keywords: sync
so.topic: concept
so.envir: cloud
so.client: online
---

# Securing ERP Connectors for SuperOffice Online

In 2017, SuperOffice expanded its online API offering and announced the availability of the [Database Mirroring API][1]. This new API performs database replication-like functionality – mirroring a subset of the online tenants' database through a web service to a remote database.

This new capability, which operates in a very similar fashion as ERP Sync Connectors, has an added layer of security by demanding that the web service first authenticate the calling SuperOffice service before executing pending tasks.

Authentication begins with [PKI][2] at SuperOffice. Prior to beginning the mirroring operation, SuperOffice creates a security **JSON web token (JWT)** and signs it with a certificate. The security token is then sent as a request to the database mirror web service where the token must be validated by the Database Mirroring implementation. Once validated, the Database Mirroring service creates and signs its' own JWT security token, using the customer's private key, and sends the signed token back to SuperOffice. Once the response is validated by SuperOffice with the customer's public key, the Database Mirroring cycle begins. Only JWT tokens are supported for this process. **SAML** tokens are **not** supported.

![authenticationsequencediagram][img1]

With more and more ERP Connectors now becoming available in SuperOffice Online, SuperOffice has released the same secure way to work with ERP Connectors. The way forward does require a small change in online tenant ERP Sync Connector settings, which is to simply change the Sync Connector URL property.

No longer should the Sync Connector URL property define an actual URL, but instead be prefixed with `app://` followed by an application identifier.

![editsyncconnector-new -screenshot][img2]

The way the infrastructure works is as follows:

1. EIS sends the customer tenants ERP Connector URL setting (`app://[applicationid]`) to the Application Authorization Service (AAS).
2. AAS creates a signed JWT security token and sends it to be authenticated by the ERP Connector.
3. The ERP Connector replies with a signed JWT token and is validated by the AAS.
4. AAS sends the customer tenant the ERP Connectors URL.
5. EIS begins to synchronize data with the ERP Connector.

![autherpsyncconnector][img3]

So what is an application identifier? An application identifier is a unique ID that represents an application in the SuperOffice Online App Store. There are standard apps that use ERP Connectors, and there are custom apps that use ERP Connectors as well. Both types of App Store applications have a unique application identifier associated with each one.

<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/mirroring/index.yml
[2]: https://en.wikipedia.org/wiki/Public_key_infrastructure

<!-- Referenced images -->
[img1]: media/authenticationsequencediagram.png
[img2]: media/editsyncconnector-new.png
[img3]: media/autherpsyncconnector-600px.png

---
uid: superid-certificates
title: SuperID certificates
description: Introduction to SuperID certificates for SuperOffice CRM Online.
keywords: SuperID, certificate, PKI, trust type, PeerTrust, SuperIdTokenHandler
author: AnthonyYates, Eivind Fasting
date: 06.18.2024
content_type: concept
deployment: online
category: api
---

# SuperID certificates

Public Key Infrastructure (PKI) certificates are absolutely necessary in today's connected world. SuperOffice CRM Online requires that all applications support a secure SSL environment. There are various ways to ensure that your applications are able to exchange information with SuperOffice CRM Online in a safe and secure manner.

**Certificates** are necessary to validate SuperOffice CRM Online issued tokens to partner application for the [3 online environments][1]: SuperOffice Online Development (SOD), Stage, and Production.

The different environments have different certificates used for signing and [validating security tokens][2].

## Certificate dependency tree

![SuperOffice certificate dependency tree][img1]

SuperOffice Online **Root Certificate Authority (CA)** is the root container for all SuperOffice Online certificates.

**Environmental certificates** establish a trust for their environment of responsibility: Development, stage, or production. Each environmental certificate depends on the SuperOffice Online Root CA and cannot be used without it.

At the lowest level, the **subject certificates** establish trust for each environment's login services.

* each environmental certificate has a dependency on each federated login certificate
* each federated login certificate depends on its corresponding environmental certificate

[Download certificates][5]

## Supported trust types

There are 3 main types of certificate trust:

* Chain
* Peer
* None

SuperOffice Online supports both PeerTrust and None.

### PeerTrust

The `SuperIdTokenHandler` class is responsible for validating security tokens. By default, the handler is configured to use PeerTrust.

1. The handler looks up the source certificate thumbprint in the application settings.

2. The handler tries to find a certificate with a matching thumbprint in the **Trusted People** certificate store of the local computer. The source thumbprint must be defined in the application configuration settings.

    ```xml
    <appSettings>
      ...
      <add key="SuperIdCertificate" value="16b7fb8c3f9ab06885a800c64e64c97c4ab5e98c" />
    </appSettings>​​
    ```

3. If a match is found, the next step is to validate the certificate.

    If no certificate with a matching thumbprint is found, the [ID4037][3] exception is thrown:

    `"ID4037: The key needed to verify the signature could not be resolved from the following security key identifier 'SecurityKeyIdentifier."`

    This means that no certificate with a matching thumbprint was found. The only known reasons this might happen are:

    * The certificates are not [configured correctly][4].
    * There are hidden characters in the value field - such as an "&shy;" character.

> [!NOTE]
> If you deploy your application in a restricted environment where you don't have access to the certificate store, such as Azure or similar, you can [override][6] the default resolver to validate the JWT security token directly instead.

<!-- Referenced links -->
[1]: ../../../../developer-portal/getting-started/app-envir.md
[2]: ../validate-security-tokens.md
[3]: ../troubleshooting/index.md
[4]: configure.md
[5]: ../../../../../assets/downloads/api/superofficeonlinecertificates.zip
[6]: override-resolver.md

<!-- Referenced images -->
[img1]: media/certificateheirarchy.png

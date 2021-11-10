---
title: How to configure certificates
uid: configure_certificate_store
description: How to configure certificates in the Windows certificate store
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# How to configure certificates in the Windows certificate store

Let's look at how to configure your certificates in a Windows certificate store. This is necessary to enable your application to validate all SAML and JWT tokens issued by SuperOffice CRM Online.

In this procedure, you will need the 3 SuperOffice [development environment certificates][1]

![x][img1]

You find these in the [certificates download][2]. *SuperOfficeOnline.crt* is stored in the *RootCertificate* folder, the 2 trusted people certificates are stored in the *environment* folder.

This procedure **must be completed on all computers that will be hosting your application in all 3 environments**: [development, stage, and production][3]. If you don't have access to the certificate store, you need to implement a [programmatic override][4] to validate the certificates.

## Import root and environment certificates

**Pre-requisites:**

* you have [added the Certificates snap-in][5]

**To import certificates:**

1. Open the Microsoft Management Console (MMC).

2. Select **Certificates (Local Computer)**.

3. Start the certificate import wizard:

    1. Right-click **Trusted Root Certification Authorities**
    2. Point to **All Tasks**
    3. Select **Import**
    4. Click **Next**

    ![x -screenshot][img2]

4. Select the certificate file from disk and click **Next**.

    ![x -screenshot][img3]

5. Select **Place all certificates** and click **Next**.

    ![x -screenshot][img4]

6. Click **Finish**.

    ![x -screenshot][img5]

> [!NOTE]
> Remember to step through this procedure for both *SuperOfficeRoot.crt* and the *SuperOffice{Environment}.crt* certificates!

## Import subject (login) certificates

**Pre-requisites:**

* you have added the Certificates snap-in
* you have imported the root and environment certificates

**To import subject certificates:**

1. Open the Microsoft Management Console (MMC).

2. Select **Certificates (Local Computer)**.

3. Start the certificate import wizard:

     1. Right-click **Trusted People**
     2. Point to **All Tasks**
     3. Select **Import**
     4. Click **Next**

4. Select *SuperOfficeFederatedLogin.crt* from disk and click **Next**.

5. Select **Place all certificates** and click **Next**. Then click **Finish**.

## How do I verify that certificates are configured correctly?

On the computer in each hosting environment:

1. Open MMC.
2. Select **Certificates (Local Computer)**.
3. Select the certificates folder of **Trusted People**.
4. Select the federated login certificate for your environment.
5. Verify the hierarchy on the **Certificate Path** tab.
6. Verify the thumbprint on the **Details** tab.

![x -screenshot][img6]

> [!NOTE]
> Following image shows Stage certificate

![x -screenshot][img7]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../assets/downloads/superofficeonlinecertificates.zip
[3]: ../../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
[4]: override-resolver.md
[5]: add-certificate-snap-in.md

<!-- Referenced images -->
[img1]: media/certificates.png
[img2]: media/welcomewizard.png
[img3]: media/certificateimport.png
[img4]: media/certificateimport2.png
[img5]: media/completeimportwizrd.png
[img6]: media/certificatechain.png
[img7]: media/certthumbprint.png

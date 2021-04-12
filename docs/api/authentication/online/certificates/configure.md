---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: configure_certificate_store   # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to configure certificates in the Windows certificate store # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: howto  # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud   # cloud or onsite
so.client: online   # online, web, win, pocket, or mobile
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

    ![x][img2]

4. Select the certificate file from disk and click **Next**.

    ![x][img3]

5. Select **Place all certificates** and click **Next**.

    ![x][img4]

6. Click **Finish**.

    ![x][img5]

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

![x][img6]

![x][img7]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../assets/downloads.md
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

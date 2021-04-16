---
title: Prepare IIS
uid: prepare_iis
description: Prepare IIS web server
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# Prepare web server

SuperOffice uses Windows Communication Foundation (WCF). This means WCF must be installed on the same server as the NetServer web services is installed.

## Preparing IIS for NetServer web services

> [!TIP]
> See [system requirements][1].

### Make sure ASP.Net support is installed in IIS

**If not:**

1. Go to the Control Panel > Programs and click **Turn Windows features on or off**.

2. Then go to the **Role** for IIS and install ASP.Net support using **Add Role Services**.

![asp][img1]

### Make sure IIS 6 Metabase Compatibility is installed in the correct location

**IIS 6 Metabase Compatibility** must be installed under **IIS 6 Management Compatibility** under **Management Tools**. This is needed in the web installer to choose sites.

![metabase][img2]

Plus any authentication methods that you wish to use.

> [!NOTE]
> Forms authentication must not be used; we have made our own forms authentication.

## For Service and Marketing the following features must be turned on

### Make sure CGI support is installed in IIS

**If not:**

1. Go to the Control Panel > Programs and click **Turn Windows features on or off**.

2. Then go to the **Role** for IIS and install CGI support using **Add Role Services**

3. Start **Internet Information Services (IIS) Manager**.

4. Click the server name and double click **ISAPI and CGI Restrictions**.

    ![IIS][img3]

5. Click **Edit Feature Settings..** and check **Allow unspecified CGI modules**.

    ![Allow unspecified CGI modules][img4]

    If you do not want to **Allow unspecified CGI modules** it is also possible to use "Add..." to add each CGI file separately. This, however, requires you to make sure any new CGI files from Customer Service are added here.

6. Click **Add...**, navigate to the *\[Service installation\]\\www\\scripts* folder and add one by one all .exe files in this folder. For each write some description and tick **Allow extension path** to execute.

![add cgi][img5]

<!-- Referenced links -->
[1]: ../../requirements/iis.md

<!-- Referenced images -->
[img1]: media/asp.png
[img2]: media/metabase.png
[img3]: media/isapi-cgi-restricitons-1.png
[img4]: media/isapi-cgi-restricitons-2.png
[img5]: media/add-cgi.png

---
title: Compression
uid: zip_on_rest
description: ZIP compression on REST
author: {github-id}
keywords:
topic: howto
envir:
client: pocket
---

# ZIP compression on REST

Since SuperOffice 8.5 R01 we added support for ZIP compression on REST API.

This can be utilized by Pocket CRM client, which has now support for REST to be able to offer compression and thus higher speed in its contact with NetServer.

To be able to use IIS dynamic compression, you will need:

* Pocket client >= 9.0.4
* NetServer >= 8.5.7066 (8.5 R01)

Basic Authentication needs to be disabled on the IIS website. SuperOffice Web installer will do it for you since 8.1 R02.

These new features should work in both online and onsite, and onsite remote installations as long as the site is correctly configured, and minimum versions are met.

## How to enable Json compression on web servers

1. Add/install required server role in Server Manager console.

    ![image0yyx.png -screenshot][img1]

2. Enable dynamic content compression in IIS on server-level.

    * In IIS Manager click on the server name and choose Compression from the IIS section.

    ![imagehqgzohc.png -screenshot][img2]

3. Configure compression for content type JSON.

    1. In IIS Manager, click on the server name and choose **Configuration Editor** from the Management section. From the drop-down list on the top of the page, select **system.webServer** and under that **httpCompression**.
    2. Find the **dynamicTypes** option and click **Edit item** from the **Actions** menu on the right side.
    3. In the new dialog, click **Add** in the Actions menu, set **Enabled** to True and to the **mimeType** enter `application/json`.

    ![imageeahwm.png -screenshot][img3]

Now the REST calls will be compressed.

<!-- Referenced links -->
[img1]: media/image0yyx.png
[img2]: media/imagehqgzohc.png
[img3]: media/imageeahwm.png

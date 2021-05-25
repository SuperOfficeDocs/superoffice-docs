---
title: Create a web service client with NetBeans
uid: reate_ws_client_java
description: How to create a web service client with NetBeans
author: {github-id}
so.date:
keywords:
so-topic: howto
---

# Create a web service client with NetBeans

The following code has been created using NetBeans IDE 5.5 and explanations are based on the above IDE.

To use a web service in a Java application we are required to create a web service client. For that, we need to get the WSDL file.

1. From the **Projects** window or **Files** window, right-click a node in the project and select **New > File/Folder**. The **New File** wizard appears.

2. Under **Categories**, select *Web Services*; under **File Types**, select *Web Service Client*; then click **Next**.

3. To access the WSDL file, click **WSDL URL**, then type or paste the web service's URL. The file will be downloaded when you finish the wizard.

    > [!NOTE]
    > If you are behind a corporate firewall, click **Proxy Settings** and set your proxy host and port number.

4. Complete the wizard.

    ![01][img1]

    Once the **Finish** button has been clicked and returned to the development environment the added web service can be seen on the left side of the screen on both the Files and Projects tabs.

The added web service client seen on the **projects** tab:

![02][img2]

In the **files** tab, once the client has been loaded, it will allow the programmer to see the class file and Java files available.

![03][img3]

**Next:** [Create the secret][1]

<!-- Referenced links -->
[1]: create-secret-java.md

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/image003.jpg

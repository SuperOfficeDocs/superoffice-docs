---
title: Configure Web Reporter
uid: config_web_reporter
description: Configure Web Reporter
author: {github-id}
keywords:
topic: howto
envir: onsite
client: web
---

# Configure Web Reporter

After the configuration of the application, the Reporter configuration should start automatically.

![x -screenshot][img1]

> [!TIP]
> You can start the configuration manually by selecting Start > All Programs > SuperOffice > SuperOffice Web > Product Configuration (instance name), where "instance name" is the name of the instance you want to configure (also referred to as the application title).

The **impersonate user** can either be:

* a domain user with read/write access to the document archive and rights to log on to the web server or
* a local user on both the web server and the archive server with the same user name and password, and with read/write access to the document archive.

The latter will be the case for workgroups or other situations where a domain controller is not available to the server running Web or the server holding the document archive.

**In the Reporter dialog:**

![x -screenshot][img2]

1. Add an ODBC data source and type the name in the ODBC field.

2. Enter the table prefix of the database.

3. In the **Domain** field, specify the name of the domain if a domain user has been specified, or the name of the local computer Web is installed on if you have specified a local user.

4. The **User** and **Password** fields should contain the user name and password for the user being impersonated

    * Click the **Validate** button to verify that you have entered the password correctly.

5. In the SuperOffice Product Configuration Complete dialog, you get a summary of the installation settings you have selected.

    ![x -screenshot][img3]

    * You may click **Back** to go back and make any necessary changes.
    * When you are done, click **Finish**.

> [!TIP]
> If you encounter problems, consider [turning on debug logging][1] and check the [troubleshooting guide][2].

<!-- Referenced links -->
[1]: debug.md
[2]: troubleshooting.md

<!-- Referenced images -->
[img1]: media/reporter1.png
[img2]: media/reporter2.png
[img3]: media/reporter3.png

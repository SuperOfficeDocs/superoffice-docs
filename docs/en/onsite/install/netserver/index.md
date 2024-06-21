---
title: Install NetServer
uid: install_ns_web_services
description: How to install NetServer web services
date: 12.08.2021
author: Bergfrid Dias
keywords:
topic: howto
envir: onsite
client: web
---

# Install NetServer / web services

NetServer is always installed, but for some scenarios, we recommend it is installed as remote web services.

> [!NOTE]
> This page describes a separate installation of SuperOffice NetServer / web services. For full installation of SuperOffice Web, please [follow the install guide][2].

[!include[Remote NetServer](../../includes/remote-netserver-web.md)]

## Before you begin

* Download the Web installer package

## Install

1. Upon launching the installer, you might be prompted to install some prerequisites, install these by clicking the **Install** button.

2. To start the installation, you need to accept the license agreement.

3. Specify the SuperOffice Web Application name and select the destination folder where you want to install it. If you chose to split the installation into one SuperOffice Web and one SuperOffice NetServer installation it is recommended to choose a name that correlates to the type of installation.

4. Select the second setup type if you want to split SuperOffice Web and SuperOffice NetServer into two separate installations, either because you want to install them on different servers or just want to split the application.

5. In the next dialog select the first option to install the NetServer application server with Web Services.

6. In the next dialog select the website and/or virtual directory for your installation and specify a name for the new virtual directory, by default it will take the name you wrote in the dialog from step 3. We recommend you chose a name that correlates to the type of installation, like *SuperOfficeNetServer*.

7. Click **Install** to begin the installation process.

8. Check **I would like to launch CRM.web Configuration** to start the Product Configuration for your installation and click **Finish**.

9. Read the `Welcome` section and click **Next**.

10. On the `Database driver` section, choose the database system for the database you installed on with server setup and click **Next**.

11. In the [Database settings][3] section fill in the fields to configure your connection to the database. Click the **Test connection** to be sure that the configuration is correct. The user here must be a database system user. When it works, click **Next**.

12. In the [Document Settings][4] section you need to enter the **Archive Path** to the folder you created in the SuperOffice CRM Server installation. You also need a temporary path. If you need the application to impersonate a user, check the **Impersonate User** checkbox and fill in the credentials for a user with access to the file server where the SuperOffice Archive (SO_ARC) is located. Validate and click **Next**.

    > [!NOTE]
    > We recommend using the Impersonate user to give access to both the temporary area and document area (so_arc).
    >
    > If you choose to not use the recommended setting, the application pool identity must be given sufficient rights.

13. Leave the `Security` section as is.

14. In the [Globalization][5] section, choose your country in the **Application country code** if it exists. If not, choose English.

15. Click **Next** on the following sections until you get to the **Finish** button. Click it to create the configuration file. Choose **Encrypt configuration** to encrypt the system user name and password in the *web.config* file. Click **Finish**.

16. SuperOffice [product configuration for Reporter][1] is opened. Click **Next** on the welcome screen.

17. A 32-bit ODBC system data source must be available on the server where SuperOffice NetServer is running. Add the name of the ODBC, and include the database prefix, typically CRM7.

18. Click **Finish** to finalize the installation.

<!-- Referenced links -->
[1]: ../../reporter/config.md
[2]: ../web-client/index.md
[3]: ../../../api/config/data.md#database
[4]: ../../../api/config/documents.md
[5]: ../../../api/config/globalization.md

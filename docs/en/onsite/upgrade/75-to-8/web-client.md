---
title: Upgrade SuperOffice Web
uid: upgrade_web_client_to_8
description: Upgrade SuperOffice Web to version 8
author: {github-id}
keywords:
topic: howto
envir: onsite
client: web
---

# Upgrade SuperOffice Web

These are the recommended steps for upgrading from SuperOffice 7 Web to SuperOffice 8 Web.

## Before you begin

* Check the [system requirements][3] for SuperOffice 8 Web.
* [Upgrade your database][1] to version 8 using *ServerSetup.exe*.
* If using remote NetServer for Web: [upgrade the NetServer][2] used by Web to version 8.
* Download and unzip the Web installer package on your server.

[!include[ALT](../../../includes/warn-upgrade-all-to-same-version.md)]

**Using remote NetServer web services?**

We recommend using the same NetServer for both CRM Web and Service for a more lean administration.

## Run the Web installer

1. Upon launching the installer, you might be prompted to install some prerequisites, install these by clicking the **Install** button.

2. To start the installation you need to accept the license agreement.

3. Specify the SuperOffice 8 Web Application name and select the destination folder where you want to install it. If you chose to split the installation into one SuperOffice Web and one SuperOffice NetServer installation it is recommended to choose a name that correlates to the type of installation.

    > [!NOTE]
    > Our [recommended scenario (#2)][4] does not require you to split web and NetServer web services.

4. Select the first option if you want to install both SuperOffice Web and SuperOffice NetServer on the same application. Select the second setup type if you want to split SuperOffice Web and SuperOffice NetServer into two separate installations, either because you want to install them on different servers or just want to split the application.

5. In the next dialog select the website and/or virtual directory for your installation and specify a name for the new virtual directory, leave the default **SuperOffice** or if you want to install SuperOffice Web or SuperOffice NetServer (web services) on the root level of a website you can leave the virtual directory name blank (only recommended if you have good knowledge of IIS works).

6. If the dropdown under select website is blank, you need to [turn on the Windows feature][6] "IIS 6 Management Compatibility and IIS 6 Management Console" under **Turn Windows features on or off**.

7. Click **Install** to begin the installation process.

8. Check **I would like to launch CRM.web Configuration** to start the Product Configuration for your installation and click **Finish**.

9. Read the **Welcome** section and click **Next**.

10. On the **Database driver** section, choose the database system for the database you installed on with server setup and click **Next**.

11. In the **Database settings** section fill in the fields to configure your connection to the database. Click the **Test connection** to be sure that the configuration is correct. The user here must be a database system user. When it works, click **Next**.

12. In the **Document Settings** section you need to enter the **Archive Path** to the folder you created in the SuperOffice CRM Server installation. You also need a temporary path. We recommend you add an impersonate user with sufficient rights to read and write to both SO_Arc and the temp area. Check the **Impersonate User** checkbox and fill in the credentials for a user with access to the file server where the SuperOffice Archive (SO_ARC) is located. Validate and click **Next**.

13. Leave the **Security** section as is. Tick **Expose NetServer web services** to use the NetServer web services with Service.

14. In the **Globalization** section, choose your country in the **Application country code** if it exists. If not, choose English.

15. Click **Next** on the following sections until you get to the **Finish** button. Click it to create the configuration file. Choose **Encrypt configuration** to encrypt the system user name and password in the *web.config* file. Click **Finish**.

16. SuperOffice product configuration for Reporter is opened. Click **Next** on the welcome screen.

17. A 32-bit ODBC system data source must be available on the server where SuperOffice NetServer is running. Add the name of the ODBC, and include the database table prefix.

18. Click **Finish** to finalize the installation.

[Back to upgrade overview][5]

<!-- Referenced links -->
[1]: crm-server.md
[2]: netserver.md
[3]: ../../requirements/index.md
[4]: ../../security/deployment-scenarios.md
[5]: index.md
[6]:../../install/iis/index.md

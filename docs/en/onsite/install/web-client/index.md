---
title: Install SuperOffice Web
uid: set_up_web_client
description: Install SuperOffice Web
author: {github-id}
date: 09.12.2023
keywords:
topic: howto
envir: onsite
client: web
---

# Install SuperOffice Web

SuperOffice CRM Web and Service must be installed on the same hostname from version 8.1.

> [!NOTE]
> All SuperOffice products must be installed on the same domain, under different directories. For example, `https://socrm.myorganization.com/sales` and `https://socrm.myorganization.com/service`.

[!include[Remote NetServer](../../includes/remote-netserver-web.md)]

## Before you begin

* Install the SuperOffice CRM Server to set up or upgrade the database.
* A SuperOffice database must be available, to install see [CRM Server][1].
* NetServer Web Services may be installed separately to use with [Customer Service][2] and [Pocket CRM][3].
* Consider the [security][4] of your upcoming installation.
* Prepare the [web server][5].
* Have an IIS website where you want to install SuperOffice. If you do not have the site set up, using the [Service installer][2] will create it for you.

[!include[Warning legacy](../../includes/warn-web-client-https.md)]

## Install

**Download the Web installer package, extract the content and run setup.exe.**

1. Upon launching the installer, you might be prompted to install some prerequisites, install them by clicking the "Install" button.

2. To start the installation you need to accept the license agreement.

3. Specify the SuperOffice Web Application name and select the destination folder where you want to install it. If you chose to split the installation into one SuperOffice Web and one SuperOffice NetServer installation it is recommended to choose a name that correlates to the type of installation.

4. Select the first option if you want to install both SuperOffice Web and SuperOffice NetServer on the same application. Select the second setup type if you want to split SuperOffice Web and SuperOffice NetServer into two separate installations, either because you want to install them on different servers or just want to split the application. Please note our [recommended scenario (#2)][7] does not require you to split web and NetServer web services.

5. In the next dialog select the website and/or virtual directory for your installation and specify a name for the new virtual directory, leave the default "SuperOffice" or if you want to install SuperOffice Web or SuperOffice NetServer (web services) on the root level of a website you can leave the virtual directory name blank (only recommended if you have good knowledge of IIS works).

6. If the dropdown under select website is blank you need to on the Windows feature "IIS 6 Management Compatibility and IIS 6 Management Console" under "Turn Windows features on or off".

7. Click **Install** to begin the installation process.

8. Check **I would like to launch CRM.web Configuration** to start the Product Configuration for your installation and click **Finish**.

9. Read the **Welcome** section and click **Next**.

10. On the **Database driver** section, choose the database system for the database you installed on with server setup and click **Next**.

11. In the [Database settings][14] section fill in the fields to configure your connection to the database. Click the **Test connection** to be sure that the configuration is correct. The user here must be a database system user. When it works, click **Next**.

12. In the [Document Archive][6] section you need to enter the **Archive Path** to the folder you created in the SuperOffice CRM Server installation. You also need a Temporary Path.

    * Make sure the Temporary Part is a local path, not a UNC path, otherwise you can get performance issues or errors while working with documents. **We recommend you add an impersonate user with sufficient rights to read and write to both SO_Arc and the temp area.** Check the **Impersonate User** checkbox and fill in the credentials for a user with access to the file server where the SuperOffice Archive (SO_ARC) is located. Validate and click **Next**.

    * More than one archivepath? You need to edit *web.config* and add more Archive Paths under the [Documents section][6]:

    ```xml
    <Documents>
    <!-- Location of SO_ARC -->
    <add key="ArchivePath" value="E:\SuperOffice\SO_ARC" />
    <add key="ArchivePath2" value="E:\SuperOffice\SO_ARC2" />
    ```

13. On the [Security][12], click to generate keys for the Symmetric key and Symmetric secret text. The **Expose NetServer web services** is ticked by default, this allows you to use the NetServer web services with Service.

14. In [AD integration][12], you may add information about your Active Directory where you want to pick users from. Note that the user added needs read rights to pick up the users.

15. In the [Globalization][15] section, choose your country in the **Application country code** if it exists. If not, choose English.

16. In [Diagnostics][10], make sure the impersonate user from the document archive chapter has sufficient rights to writhe to the folder where **Log to file** points.

17. Click **Next** on the following sections until you get to the **Finish** button. Click it to create the configuration file. Choose **Encrypt configuration** to encrypt the system user name and password in the *web.config* file. Click **Finish**.

18. SuperOffice [product configuration for Reporter][9] is opened. Click **Next** on the welcome screen.

19. A 32-bit ODBC system data source must be available on the server where SuperOffice NetServer is running. Add the name of the ODBC, and include the database prefix, typically CRM7.

20. Click **Finish"** to finalize the installation.

[Previous][11] | [Back to guide][1]

<!-- Referenced links -->
[1]: ../guide.md
[2]: ../../../service/install/index.md
[3]: ../../../mobile/pocket-crm/deploy.md
[4]: ../../security/secure-deployment-guide.md
[5]: ../iis/index.md
[6]: ../../../api/config/documents.md
[7]: ../../security/deployment-scenarios.md
[9]: ../../reporter/config.md
[10]: ../../../api/config/diagnostics.md
[11]: ../../../service/install/index.md
[12]: ../../../api/config/security.md
[14]: ../../../api/config/data.md#database
[15]: ../../../api/config/globalization.md

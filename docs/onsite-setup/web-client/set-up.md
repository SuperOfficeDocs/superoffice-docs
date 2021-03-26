---
title: set_up_web_client
description: Install SuperOffice Web
author: {github-id} # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide
so.envir: onsite                # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Install SuperOffice Web

SuperOffice CRM Web and Service must be installed on the same hostname from version 8.1.

> [!NOTE]
> All SuperOffice products must be installed on the same domain, under different directories. For example, `https://socrm.myorganization.com/sales` and `https://socrm.myorganization.com/service`.

## Before you begin

The server where you install SuperOffice Web needs to have an internet connection and access to our Licence server on [https://license.superoffice.com][8].

* Install the SuperOffice CRM server to set up or upgrade the database.
* A SuperOffice 8 CRM server database must be available, to install see [CRM Server][1].
* NetServer Web Services may be installed separately to use with [Customer Service][2] and [Pocket CRM][3].

* Consider the [security][4] of your upcoming installation.
* Instal the CRM Server so the database is set up using ServerSetup.exe.
* Prepare the [web server][5].
* Have an IIS website where you want to install SuperOffice. If you do not have the site set up, using the [Service installer][6] will create it for you.

## Install

**Download the web installer package, extract the contents and run setup.exe.**

1. Upon launching the installer, you might be prompted to install some prerequisites, install these by clicking the "Install" button.

2. To start the installation you need to accept the license agreement.

3. Specify the SuperOffice 8 Web Application name and select the destination folder where you want to install it. If you chose to split the installation into one SuperOffice Web and one SuperOffice NetServer installation it is recommended to chose a name that correlates to the type of installation.

4. Select the first option if you want to install both SuperOffice Web and SuperOffice NetServer on the same application. Select the second setup type if you want to split SuperOffice Web and SuperOffice NetServer into two separate installations, either because you want to install them on different servers or just want to split the application. Please note our [recommended scenario (#2)][7] does not require you to split web and NetServer web services.

5. In the next dialog select the website and/or virtual directory for your installation and specify a name for the new virtual directory, leave the default "SuperOffice" or if you want to install SuperOffice Web or SuperOffice NetServer (web services) on the root level of a website you can leave the virtual directory name blank (only recommended if you have good knowledge of IIS works).

6. If the dropdown under select website is blank you need to on the Windows feature "IIS 6 Management Compatibility and IIS 6 Management Console" under "Turn Windows features on or off".

7. Click **Install** to begin the installation process.

8. Check **I would like to launch CRM.web Configuration** to start the Product Configuration for your installation and click **Finish**.

9. Read the **Welcome** section and click **Next**.

10. On the **Database driver** section, choose the database system for the database you installed on with server setup and click **Next**.

11. In the **Database settings** section fill in the fields to configure your connection to the database. Click the **Test connection** to be sure that the configuration is correct. The user here must be a database system user. When it works, click **Next**.

12. In the **Document Archive** section you need to enter the **Archive Path** to the folder you created in the SuperOffice CRM Server installation. You also need a Temporary Path.

    * Make sure the Temporary Part is a local path, not UNC path, otherwise you can get performance issues or errors while working with documents. **We recommend you add an impersonate user with sufficient rights to read and write to both SO\_Arc and the temp area.** Check the **Impersonate User** checkbox and fill in the credentials for a user with access to the file server where the SuperOffice Archive (SO\_ARC) is located. Validate and click **Next**.

    * More than one archivepath? You need to edit *web.config* and add more Archive Paths under the Documents section:

    ```xml
    <Documents>
    <!-- Location of SO_ARC -->
    <add key="ArchivePath" value="E:\SuperOffice\SO_ARC" />
    <add key="ArchivePath2" value="E:\SuperOffice\SO_ARC2" />
    ```

13. On the **Security**, click to generate keys for the Symmetric key and Symmetric secret text. The **Expose NetServer WebServices** is ticked by default, this allows you to use the NetServer WebServices with Service.

14. In **AD integration**, you may add information about your Active Directory where you want to pick users from. Note that the user added needs read rights to pick up the users.

15. In the **Globalization** section, choose your country in the **Application country code** if it exists. If not, choose English.

16. In **Diagnostics**. make sure the impersonate user from the document archive chapter has sufficient rights to writhe to the folder where **Log to file** points.

17. Click **Next** on the following sections until you get to the **Finish** button. Click it to create the configuration file. Choose **Encrypt configuration** to encrypt the system user name and password in the *web.config* file. Click **Finish**.

18. SuperOffice product configuration for Reporter is opened. Click **Next** on the welcome screen.

19. A 32-bit ODBC system data source must be available on the server where SuperOffice NetServer is running. Add the name of the ODBC, and include the database prefix, typically CRM7.

20. Click **Finish"** to finalize the installation.

<!-- Referenced links -->
[1]: ../crm-server/setup-guide.md
[2]: ../service/set-up-guide.md
[3]: ../../mobile/pocket-crm/install-onsite.md
[4]: ../security/secure-deployment-guide.md
[5]: ../crm-server/iis-web-server/prepare.md
[6]: ../service/set-up-guide.md
[7]: ../security/deployment-scenarios.md
[8]: https://license.superoffice.com/

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: install_ns_web_services       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Install NetServer / web services

Netserver is always installed, but for some scenarios, we recommend it is installed as remote web services.

## Before you begin

* Download the web installer package

[!include[download](../../includes/download-sw.md)]

## Install

1. Upon launching the installer, you might be prompted to install some prerequisites, install these by clicking the **Install** button.

2. To start the installation, you need to accept the License agreement.

3. Specify the SuperOffice 8 Web Application name and select the destination folder where you want to install it. If you chose to split the installation into one SuperOffice Web and one SuperOffice NetServer installation it is recommended to chose a name that correlates to the type of installation.

4. Select the second setup type if you want to split SuperOffice Web and SuperOffice NetServer into two separate installations, either because you want to install them on different servers or just want to split the application.

5. In the next dialog select the first option to install NetServer application server with Web Services.

6. In the next dialog select the website and/or virtual directory for your installation and specify a name for the new virtual directory, by default it will take the name you wrote in the dialog from step 3. We recommend you chose a name that correlates to the type of installation, like *SuperOfficeNetServer*.

7. Click **Install** to begin the installation process.

8. Check **I would like to launch CRM.web Configuration** to start the Product Configuration for your installation and click **Finish**.

9. Read the `Welcome` section and click **Next**.

10. On the `Database driver` section, choose the database system for the database you installed on with server setup and click **Next**.

11. In the `Database settings` section fill in the fields to configure your connection to the database. Click the **Test connection** to be sure that the configuration is correct. The user here must be a database system user. When it works, click **Next**.

12. In the `Document Settings` section you need to enter the **Archive Path** to the folder you created in the SuperOffice CRM Server installation. You also need a temporary path. If you need the application to impersonate a user, check the **Impersonate User** checkbox and fill in the credentials for a user with access to the file server where the SuperOffice Archive (SO\_ARC) is located. Validate and click **Next**.

    * **Impersonate user:** We recommend using the Impersonate user to give access to both the temporary area and document area (so\_arc).<br>If you choose to not use the recommended setting, then the application pool identity must be given sufficient rights.

13. Leave the `Security` section as is.

14. In the `Globalization` section, choose your country in the **Application country code** if it exists. If not, choose English.

15. Click **Next** on the following sections until you get to the **Finish** button. Click it to create the configuration file. Choose **Encrypt configuration** to encrypt the system user name and password in the *web.config* file. Click **Finish**.

16. SuperOffice product configuration for Reporter is opened. Click **Next** on the welcome screen.

17. A 32-bit ODBC system data source must be available on the server where SuperOffice NetServer is running. Add the name of the ODBC, and include the database prefix, typically CRM7.

18. Click **Finish** to finalize the installation.

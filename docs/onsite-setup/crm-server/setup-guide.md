---
title: crm_server_setup_guide
description: CRM Server setup guide
author: {github-id}
keywords:
so.topic: guide  
so.envir: onsite
# so.client:
---

# CRM Server setup guide

> [!NOTE]
> You need a running SuperOffice CRM Server before you install the other clients.  

## Prepare CRM server

### Prepare the program files folder

This is where the server software will be installed. By default, we put this in *c:\\program files\\SuperOffice\\SuperOffice Server*. Here you will find the tools for database maintenance (*Dbsetup.exe*) and create and edit the install files (*SoCreateMST.exe*).

In *SuperOffice Server* we also create a subfolder called *Client*, which must be available for all users who want to install the Win client. We recommend you share the Client folder and not the SuperOffice Server folder.

### Prepare the document archive folder

This folder is the central document archive, and all users must have access to this location via the application.

For Win app users, this folder must be shared, the user must be able to create and edit folders and files.

### Prepare IIS web server

* [How to configure IIS][3]

### Prepare the database

The central database may be running on either Microsoft SQL Server or Oracle before you start the server installer. Please refer to the manufacturers' webpages for more information.

* [List of supported databases][4]
* [Create Oracle database][5]
* [Create Microsoft SQL Server database][6]

> [!NOTE]
> The ODBC data source must be set up as a 32-bit system DSN.

When we describe how to set up the SQL database on your server, we will focus on how to prepare the database for a SuperOffice installation.

* Any advice we give is based on that this SQL server application is installed on a Windows 2012 or higher that is dedicated as a database application server.

* Any advice is also based on that the SuperOffice database is the only database served by this computer. If your environment is different from these preconditions, our advice may need to be reconsidered.

The more powerful the SQL Server computer is, the faster SuperOffice CRM will perform. This of course will depend on the amount of users this SQL server is going to serve.

#### Choosing Between Unicode and ANSI database

For new customers, we recommend using Unicode. This removes all ambiguity of future planning and ensures compatibility.

### Which Services end point to use?

[!include[Services end points table](../includes/services-end-points.md)]

### Prepare Win client computer

* [Guide][7]

## Prepare for Service

* [Guide][8]

## Install CRM Server

### Prerequisites

Prerequisites are available in the installation package.

After you start the SuperOffice CRM Server installer you will find the **Install prerequisites**. Here you can click the Advanced button to see what will be installed and select or unselect if you want to do it another way.

To install the .Net Framework an internet connection is required. If the server where the installation is done doesn't have an internet connection, the [correct][2] .Net framework must be installed from another source.

A warning will be given when installing prerequisites if the installation of the .Net framework fails, and ServerSetup will not start if .Net is not installed on the server.

The reason is the prerequisites installation program on the installation package contains only the bootstrapper for the .Net installation and not the entire setup program (approx 2.5 MB vs 250MB).

### Automatic update of clients (for SuperOffice Windows client only)

In the last screen of ServerSetup, **Installation is complete**, you can select to use an automated update for client installations.

The client setup file will be run from the location selected in ServerSetup, so this location must be available for the user and sufficient rights must have been granted.

If Active Directory is to be used for updates, the automatic update should not be selected in ServerSetup.

The automatic client update feature replaces the use of SoLoader in earlier versions.

Automated updates for client installations will ask the user if she wants to update SuperOffice CRM client if the client setup files have been updated by ServerSetup. The check is done by comparing the version of SuperOffice CRM client with the highest version of ServerSetup installation on this database.

The user can select to not update, the question will then be asked again next time she starts SuperOffice CRM client.

If the user selects to update, the SuperOffice CRM client will exit and the client setup file will be run. When the installation is finished, SuperOffice CRM client must be started again.

### Install with several languages

You can choose to install SuperOffice CRM  in one or more languages.

In a new installation, only the main language is used for most of the translated texts that are installed in the database. This will remain the same even if you install with several languages, and later select to run SuperOffice CRM in another language than the main language. This will cause some of the text in the application to be in the main language and most in the selected language. (Seen in dropdown lists for example.)

If you are upgrading from an earlier version of SuperOffice, make sure to select the same main language as in the last installation, or you risk getting a mix of languages in the database/program.

<!-- Referenced links -->
[2]: requirements.md
[3]: iis-web-server/prepare.md
[4]: ../compatibility/database.md
[5]: create-oracle-db.md
[6]: create-ms-sql-server-db.md
[7]: ../win-client/prepare-server.md
[8]: ../service/set-up-guide.md
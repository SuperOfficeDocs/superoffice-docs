---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: crm_server_setup_guide # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: CRM Server setup guide # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# CRM Server setup guide

## Prepare CRM server

### Prepare the program files folder

This is where the server software will be installed. By default, we put this in *c:\\program files\\SuperOffice\\SuperOffice Server*. Here you will find the tools for database maintenance (*Dbsetup.exe*) and create and edit the install files (*SoCreateMST.exe*).

In *SuperOffice Server* we also create a subfolder called *Client*, which must be available for all users who want to install the Win client. We recommend you share the Client folder, and not the SuperOffice Server folder.

### Prepare the document archive folder

This folder is the central document archive, and all users must have access to this location via the application.

For Win app users, this folder must be shared, the user must be able to create and edit folders and files.

### Prepare IIS web server

* [How to configure ISS](iis-web-server/prepare.md)

### Prepare the database

The central database may be running on either Microsoft SQL Server or Oracle before you start the server installer. Please refer to the manufacturers' webpages for more information.

* [list of supported databases](../compatibility/database.md)
* [create Oracle database](create-oracle-db.md)
* [create Microsoft SQL Server database](create-ms-sql-server-db.md)

> [!NOTE]
> The ODBC data source must be set up as a 32-bit system DSN.

### Which Services end point to use?

[!include[Services end points table](../includes/services-end-points.md)]

### Prepare Win client computer

* [Guide](../win-client/prepare-server.md)

## Prepare for Service

* [Guide](prepare-for-service-md)
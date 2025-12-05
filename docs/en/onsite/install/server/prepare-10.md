---
uid: prepare-crm-server-10
title: Prepare CRM Server 8-10
description: Prepare CRM Server computer
keywords: prepare CRM server
author: SuperOffice Product and Engineering
date: 12.01.2025
version: 10
content_type: howto
deployment: onsite
---

# Prepare CRM Server computer for SuperOffice 8-10

1. Prepare the program files folder:

    *Program Files* is where the server software will be installed. By default, we put this in *C:\Program Files\SuperOffice\SuperOffice Server*. Here you will find the tools for database maintenance (*Dbsetup.exe*) and create and edit the install files (*SoCreateMST.exe*).

    In *SuperOffice Server*, we also create a subfolder called *Client*, which must be available for all users who want to install the Win client. We recommend you share the *Client* folder and not the *SuperOffice Server* folder.

2. Prepare the document archive folder:

    This folder is the central document archive, and all users must have access to this location via the application. For Win client users, this folder must be shared, the user must be able to create and edit folders and files.

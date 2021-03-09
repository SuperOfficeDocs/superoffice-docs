---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: technical_overview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Hans Oluf Waaler             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide
so.date: 13 Oct 2016
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Technical overview over SuperOffice Web Tools

## Introduction

This is a technical blog post to describe the inner workings of SuperOffice Web Tools. The intended audience is technicians, developers and other special interested.

By understanding how SuperOffice Web Tools works, it is easier to troubleshoot issues and to have a common ground when reporting and discussing wishes and issues.

SuperOffice Web Tools have basically four features:

* Download, edit and upload documents
* Alarm notifications
* Quick-login to SuperOffice by menu or double-clicking on the icon in the notification area
* Bridge between user-initiated actions in SuperOffice CRM Web and SuperOffice Mail Link

### Prerequisites

Web Tools is currently using .NET framework 4.5, which will be installed by the installer if it is not already installed on the system.

## Installation

### Per user

When you download Web Tools from a SuperOffice installation, you might have noticed that the downloaded file has a name in form of *SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffice&un=souser-­-.exe*.  The contents after `--` is the configuration directive.

The Web Tools installer executes the command: `SuperOffice.TrayApp.Client.exe /autoconfig:[installer_name]` (without brackets). This example configures the Web Tool installation to connect to `https://superoffice/superoffice/`.  The full command given to SuperOffice.TrayApp.Client.exe in this example is:

`SuperOffice.TrayApp.Client.exe /autoconfig:"SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffic­e&un=souser--.exe"`

### Configuration after installation

If Web Tools are already installed, or if you for other reasons wish to configure it, it is possible to use SoConfig files for the initial setup. A SoConfig variant is given below. When deploying through GPO or other alternatives, executing the *SoConfig* file during the logon process will setup Web Tools for the user.  The site will not be added again if it has already been added.

![Example of a SoConfig file][img1]

## Upgrading

When the user logs in to an updated Web installation, Web Tools will detect there is an updated version available and prompt the user for an upgrade. Versioning in SuperOffice is defined as "MAJOR.MINOR.BUILD.REVISION". The user will be "forced" to upgrade if the MAJOR component is higher than the current major version of web tools. Other changes are optional upgrades.

The prompt to upgrade can be disabled in scenarios where you don’t want to push a new version of Web Tools. The configuration setting SuperOffice\\Downloads\\WebToolVersion in the *web.config* file can be set to a previous version. The user will still be able to upgrade to the latest version by pressing Download in the web client.

![Logging in to Sales and Marketing (upgrade)][img2]

## Configuration

Configuration in SuperOffice Web Tools can be segmented into configuration stored per site in the SiteInfo files and configuration stored in the Windows Registry.

The SiteInfo files, which are encrypted, contain all connectivity information such as the endpoint URL and the credentials used for authentication. Additionally, the settings from the Preferences-dialog in Web Tools are included here.

Versions before 8.0 stored SiteInfo files in the IsolatedFileStorage provided by .NET in local application data. Versions from 8.x store the SiteInfo files in *%AppData%\\SuperOffice\\TrayApp* (Roaming Profiles).

There are no command-line utilities for creating/modifying/viewing the SiteInfo files directly. All manipulation must be performed through the user interface in SuperOffice Web Tools.

Settings that are not site-specific are usually found in the registry. "Normal" installations should not require any tweaking in the registry. [View registry entries][1].

Set the credential type when authenticating towards a proxy. Valid values: Windows, Ntlm, Digest, and Basic. `ProxyUsesDefaultCredentials` must be set to 1 for this setting to have effect.

## Interactions between SuperOffice Web Tools and SuperOffice Sales and Marketing

Web Tools consists of three components: the installed component on the user’s computer, TrayApp2.svc (WCF) and the SignalR endpoint. The two latter are installed server-side along with SuperOffice Sales and Marketing, and access the SuperOffice database through NetServer APIs. (Yes, the same APIs which are available to partners).

## Starting up Web Tools

![Starting up Web Tools][img3]

After Web Tools have finished starting up, it will resume incomplete tasks. The tasks files are stored in *%localappdata%\\SuperOffice\\SuperOffice 7 Web Extensions\\Tasks*. One task consists of a task file and a directory with the same name. This directory will contain the document during editing/reading.

## Document editing

![Opening up a document in Sales and Marketing][img4]

## Authentication

Web Tools supports authenticating to two different layers to SuperOffice. The first layer is authenticating towards the Web Server (IIS) using Negotiate (Windows Authentication), NTLM, Digest, or Basic. The second layer is authenticating towards the SuperOffice installation. Authenticating towards the SuperOffice installation can be handled by SuperOffice, Active Directory, or delegated to a third-party such as Google or Office 365 (only available in Online). Single sign-on is achieved when both authentication layers are compatible – for instance, Windows Authentication in IIS and Active Directory on the SuperOffice installation.

SSO requires [configuration changes in IIS][2] and *web.config* file. Users must be configured to use Active Directory for authentication.

<!-- Referenced links -->
[1]: doclink/registry-entries.md
[2]: ../onsite/crm-server/iis-web-server/prepare.md

<!-- Referenced images -->
[img1]: media/11033-21660.jpg
[img2]: media/11035-21656.jpg
[img3]: media/11036-21654.jpg
[img4]: media/cdraw.png
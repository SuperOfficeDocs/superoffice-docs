---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: webtools_system_requirements # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for WebTools # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# System requirements for WebTools

## Requisites

* [Microsoft .Net Framework 4.5.1][1] (as a web download)
* VSTO 2010 runtime (32bit or 64bit) for Ribbons
* Visual C++ 2017 runtime for x86 (version 14.14.26429.4)

## Folders on Citrix/Terminal server

### MailLink

MailLink stores its configuration in *%appdata% folder under SuperOffice\\MailLink*. This folder is part of a roaming profile so the MailLink configuration is not forgotten when the user signs out and back in again.

### Web Extensions

It is necessary to make sure Web Extensions is set to automatically start when a user signs in.

To store Web Extensions configuration, we use folder *%localappdata%\\SuperOffice\\SuperOffice Web Extensions*.

> [!NOTE]
> The installation of the WebTools does not require administrative privileges, but the prerequisites do. For more information, see the [Web Tools installation documentation][2].

<!-- Referenced links -->
[1]: https://www.microsoft.com/en-US/download/details.aspx?id=40779
[2]: https://community.superoffice.com/en/technical/documentation/install-upgrade/superoffice-web-tools/superoffice-webtools-deployment/
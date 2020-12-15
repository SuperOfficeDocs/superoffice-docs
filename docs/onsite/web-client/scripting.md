---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scripting_web_client # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Scripting in Web client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: article # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite # cloud or onsite
so.client: web # online, web, win, pocket, or mobile
---

# Scripting in Web client

## Functionality overview

* high level scripting
* text files or DLLs
* Quick edit/refresh/retry cycle – i.e. able to re-load script easily – without restarting

## We support

VB.net and C# in the first release – either as source files or as compiled DLLs

## We do not support

* VBScript / Javascript through the old COM script control that we use in the windows client.
* The old .net VSA scripting system (JScript.net)
* VSTA – Visual Studio Tools for Applications – the .net replacement for the old VBA system
* Boo or other custom languages

The first version of the scripting support will not support user interaction and will only cater for database-independent data triggers for modifications performed through the service layer.

## Setting up scripting

When installing .web a scripting section is added to the SuperOffice Product Configuration application. If upgrading from a previous version, make sure you run the configuration.

![x][img1]

**Configuration options:**

* Enabling scripting overall.
* The path to the folder where the scripts are stored.
* The timeout limit is the allowed time on sync scripts. Asynchronous scripts are not affected by the limit.
* The Script violation limit is the number of times a script can violate the time limit before being disabled.

This will add a new section in web.config

## Script error logging, tracing

Script compilation errors are logged using the normal logging features.

Runtime errors are logged using the normal logging features.

## Register scripts

To enable your script simply drop the script files (or assemblies) in the script folder. Remember to flush in order to get .web aware of the new scripts.dll

For more information regarding scripting with .web, visit [DevNet][1]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/webclient/Scripting-in-the-NetServer-World/

<!-- Referenced images -->
[img1]: media/ns-web-scripting.jpg
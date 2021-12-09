---
title: Web.config
uid: web_config
description: Web.config
author: {github-id}
keywords:
so.topic: reference
so.envir: onsite
# so.client:
---

# Web.config

Used by web, remote web services, service.

The *web.config* file is an XML file that can be changed as needed, but we recommend running the SuperOffice Web Configurator, which is installed by the [web client][1]. Administrators can use configuration files to set policies that affect how applications run on their computers.

There are some SuperOffice specific sections, defined under the SuperOffice sectionGroup.

* Documents
* Globalization
* Services
* Scripting
* BatchService
* Client
* WebServices
* Diagnostics
* WebAPI
* Security
* Mail
* Data

## Factory

The Factory is part of a NetServer extension mechanism to support plug-ins. To utilize the methods you must develop your own method and configure it in a specific way in the configuration file to identify that you are enhancing a provided method.

<!-- Referenced links -->
[1]: ../install/web-client/index.md

<!-- Referenced images -->

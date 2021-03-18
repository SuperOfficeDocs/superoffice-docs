---
title: system_config_files
description: SuperOffice PageBuilder system configuration files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# System configuration files

System configuration files declare every application dependency, including web controls, currents, menu items, and pages. These files essentially describe the skeleton of the entire web application.

* [SoApplicationConfiguration.config][1]: contains all of the page and dialog declarations, essentially cataloging all of the files that represent UI components.

* **SoObjectMapping.config** maps all element types used in page configurations to user controls and web controls defined in assemblies.

Both of these system files contain more than what's described here, but this explanation is useful in that it describes how the contents of system files are different than dedicated page configuration files.

**Other files considered to be system files include:**

* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config
* SoMenuConfiguration.config

<!-- Referenced links -->
[1]: soapplicationconfiguration.md

<!-- Referenced images -->
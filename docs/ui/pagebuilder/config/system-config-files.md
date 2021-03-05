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

* **SoApplicationConfiguration.config:** contains all of the page and dialog declarations, essentially cataloging all of the files that represent UI components.

* **SoObjectMapping.config** maps all element types used in page configurations to user and web controls defined in assemblies.

Both of these system files contain more than what's described here, but this explanation is useful in that it describes how the contents of system files are different than dedicated page configuration files.

**Other files considered to be system files include:**

* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config
* SoMenuConfiguration.config

---
title: usercontrols
description: UserControls
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# UserControls

UserControls, or GUI controls, are the building blocks of CRM.web webpage. Many of the UserControls are simple controls:

* SoButton
* SoCheckBox
* SoInputButton
* SoTextBox
* ...

There are more complex controls like the `ContactMainView` or the `PersonDialogHeader`, which contains multiple simple controls. The controls are identified by the relevant config file and the actual objects will be mapped using the config file called *SoObjectMapping.config*.

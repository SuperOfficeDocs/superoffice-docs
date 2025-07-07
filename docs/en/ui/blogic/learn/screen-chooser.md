---
uid: help-en-screen-chooser
title: ScreenChoosers
description: ScreenChoosers
author: SuperOffice RnD
date: 06.29.2022
keywords: UI, screen chooser
content_type: concept
language: en
---

# ScreenChoosers

[!include[Requirement](../../../includes/req-dev-tools.md)]

A ScreenChooser is a script that can perform a redirect to a different screen from the default one. The script can execute the CRMScript "setVariable("url", myUrl)" function to display a different URL from the default one. This applies for example to redirecting from the Show request screen to a custom screen and/or performing calculations in the script before displaying the screen. The ScreenChoosers are organized in a folder structure based on where in the system they are run from.

## ScreenChooser properties

Here you can add a script that will cause a redirect to another screen by running the CRMScript "setVariable("url", myUrl)" function.

---
uid: help-en-screen-chooser
title: ScreenChoosers
description: ScreenChoosers
keywords: UI, screen chooser
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: concept
tier: core
language: en
---

# ScreenChoosers

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

A ScreenChooser is a script that can perform a redirect to a different screen from the default one. The script can execute the CRMScript "setVariable("url", myUrl)" function to display a different URL from the default one. This applies for example to redirecting from the Show request screen to a custom screen and/or performing calculations in the script before displaying the screen. The ScreenChoosers are organized in a folder structure based on where in the system they are run from.

## ScreenChooser properties

Here you can add a script that will cause a redirect to another screen by running the CRMScript "setVariable("url", myUrl)" function.

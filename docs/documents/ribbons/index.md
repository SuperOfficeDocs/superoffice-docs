---
title: ribbons       
description: SuperOffice Ribbons
author: {github-id}             # Your GitHub alias.
keywords:
---

# SuperOffice Ribbons

SuperOffice Ribbons are addons to MS Outlook, Word, Excel, and PowerPoint which enable users to edit SuperOffice documents directly from MS Office programs.

## System requirements

See complete overview in the [System Requirements](system-requirements.md).

## Architecture and technology

The product is developed as four different COM add-ins, one for each office product (Outlook, Word, Excel and Power Point). We have used Visual Studio tools for Office to develop these add-ins. This means that the result is compiled managed code deployed on each client computer. There are no macros, document tags etc. involved that may risk the robustness of the solution. Ribbons use the same language as your Office installation, unlike the Outlook Mail Link who use the same language as SuperOffice.

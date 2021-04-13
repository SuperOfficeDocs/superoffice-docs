---
title: ribbons
description: SuperOffice Ribbons
author: {github-id}
keywords:
so.topic: concept
---

# SuperOffice Ribbons

SuperOffice Ribbons are addons to MS Outlook, Word, Excel, and PowerPoint which enable users to edit SuperOffice documents directly from MS Office programs.

## System requirements

See complete overview in the System Requirements.

## Architecture and technology

The product is developed as four different COM add-ins, one for each office product (Outlook, Word, Excel, and PowerPoint). We have used Visual Studio tools for Office to develop these add-ins. This means that the result is compiled managed code deployed on each client computer. There are no macros, document tags, and such. involved that may risk the robustness of the solution. Ribbons use the same language as your Office installation, unlike the Outlook Mail Link who uses the same language as SuperOffice.

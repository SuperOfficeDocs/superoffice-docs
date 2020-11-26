---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_client_os         # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested client OS   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                    # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested client operating systems

Currently tested client operating systems if running SuperOffice Onsite (for our Mac users this means only the web client).

Want to know if a newly released OS is compatible? Check your [compatibility reports](reports.md).

[!include[legend](./includes/win-unavailable.md)]

## Windows

| OS                      | 8.0 | 8.1 | 8.2 | 8.3 R01 - R03 | 8.3 R04 | 8.4 | 8.5 | 9.1 |
|-------------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Windows 10\*            | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Windows 8.1             | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Windows 8               | ![][1] | ![][1] | ![][1] | ![][1] | ![][2] | ![][2] | ![][2] | ![][2] |
| Windows 7 x64 (SP2)\*\* | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][2] |
| Windows 7 x86 (SP2)\*\* | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][2] |

\* Windows 10 is supported from Windows 10 Anniversary Update (version 1607).

\*\* Windows 7 SP1 and SP2 have reached end of support 14th January 2020.

## MAC

| OS                      | 8.0 SR1 - SR2 | 8.0 SR3 - SR6 | 8.1 | 8.2 | 8.3 | 8.4 | 8.5 | 9.1 |
|-------------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| MacOS Big Sur | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][1] |
| MacOS Catalina | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][1] | ![][1] |
| MacOS Mojave | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][1] | ![][1] | ![][1] |
| MacOS High Sierra | ![][3] | ![][3] | ![][3] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| MacOS Sierra  | ![][3] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][2] |
| MacOS X El Capitan | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][3] | ![][2] |
| MacOS X Yosemite | ![][1] | ![][1] | ![][1] | ![][3] | ![][3] | ![][3] | ![][3] | ![][2] |
| MacOS X Mavericks |![][1] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][2] |

> [!NOTE]
> For Mac users, the biggest source of incompatibility is our WebTools. So for the Mac OS versions not part of our tested configurations, this is the most likely part of the product that will not work.

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced icons-->
[1]: ../../media/icons/testedyes.png
[2]: ../../media/icons/testedno.png
[3]: ../../media/icons/testednotyet.png
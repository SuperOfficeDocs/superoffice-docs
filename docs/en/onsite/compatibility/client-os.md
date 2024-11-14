---
uid: tested_client_os
title: Tested client OS
description: Tested client OS
keywords: client operating system, Windows compatibility, MacOS compatibility, Sequoia, Sonoma, Windows 11
author: Martin Pavlas
date: 11.07.2024
topic: reference
envir: onsite
# client:
---

# Tested client operating systems

Currently tested client operating systems if running SuperOffice Onsite (for our Mac users this means only the Web client).

Want to know if a newly released OS is compatible? Check the [compatibility reports][1].

[!include[legend](./includes/win-unavailable.md)]

## Windows

| OS                  | 8.0 - 8.3 R03 | 8.3 R04 - 8.4 | 8.5 | 9 | 10 |
|---------------------|:--:|:--:|:--:|:--:|:--:|
| Windows 11          | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| Windows 10          | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Windows 8.1         | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| Windows 8           | ![i][img1] | ![i][img2] | ![i][img2] | ![i][img2] | ![i][img2] |
| Windows 7 SP2       | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img2] | ![i][img2] |

> [!NOTE]
> Windows 10 is supported from Windows 10 Anniversary Update (version 1607).
>
> Windows 8.1 reached the end of support on January 10, 2023.
>
> Windows 8 reached the end of support on 12th January 2016.
>
> Windows 7 SP1 and SP2 reached the end of support on 14th January 2020.

## Mac

| OS                 | 8.0, SR1, SR2 | 8.0 SR3 - 8.1 | 8.2 - 8.3 | 8.4 | 8.5 | 9 | 10 |
|--------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| MacOS Sequoia      | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| MacOS Sonoma       | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| MacOS Ventura      | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| MacOS Monterey     | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| MacOS Big Sur      | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img3] |
| MacOS Catalina     | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img3] |
| MacOS Mojave       | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| MacOS High Sierra  | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img2] |
| MacOS Sierra       | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img2] | ![i][img2] |
| MacOS X El Capitan | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img3] | ![i][img2] | ![i][img2] |

> [!NOTE]
> WebTools is the primary source of incompatibility for Mac users. For Mac OS versions that are not included in our tested configurations, WebTools is the component most likely to experience issues.

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced links-->
[1]: index.md

<!--Referenced icons-->
[img1]: ../../media/icons/testedyes.png
[img2]: ../../media/icons/testedno.png
[img3]: ../../media/icons/testednotyet.png

---
title: Enable debug
uid: enable_debug_for_ribbons
description: Enable debug for Ribbons
author: {github-id}
keywords:
topic: howto
envir: onsite
client: win
---

# Enable debug for Ribbons

As with Mail Link, Ribbons logs to *%AppData%\SuperOffice* folder. It logs to the *Ribbons.log* file by default.

You may also specify the location for the log file by setting the logpath in [SuperOffice.ini][1].

Please note that logging for Ribbons is only turned on if both these values are set in *SuperOffice.ini*:

```text
[Error]
EnableDebug = 1
EnableRibbonLog = 1
```

> [!CAUTION]
> Running Ribbon vsto file can cause issues and this should not be done. Read more info on the [Community forum][2].

<!-- Referenced links -->
[1]: ../../onsite/install/win-client/superoffice-ini.md
[2]: https://community.superoffice.com/en/technical/forums/product-forums/crm-windows-application/why-we-should-not-run-.vsto-installer-manually/

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_server_os         # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested server OS   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                    # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested server operating systems

Currently tested server operating systems if running SuperOffice Onsite.

Want to know if a newly released operating system is compatible? Check the [compatibility reports](index.md).

| Operating system | 8.0, SR1 - SR3 | 8.0 SR4 - SR6 | 8.1 | 8.2 | 8.3 R01 - R03 | 8.3 R04 | 8.4 | 8.5 | 9.1 | 9.2 |
|---------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Windows&nbsp;Server&nbsp;2019 | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Windows&nbsp;Server&nbsp;2016 | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Windows&nbsp;Server&nbsp;2012&nbsp;R2 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Windows&nbsp;Server&nbsp;2012 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Windows&nbsp;Server&nbsp;2008&nbsp;R2 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img3] | ![i][img3] |
| Windows&nbsp;Server&nbsp;2008 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img2] | ![i][img2] | ![i][img2] | ![i][img2] | ![i][img2] |

> [!NOTE]
> Windows Server 2019, 2016, 2012 and 2008 R2 are also tested as Terminal Server / Citrix Server.

Our experience tells us that other configurations also should work, but SuperOffice will not guarantee any other configurations than the ones listed.

[!include[legend](./includes/caution-odbc-drivers.md)]

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced icons-->
[img1]: ../../media/icons/testedyes.png
[img2]: ../../media/icons/testedno.png
[img3]: ../../media/icons/testednotyet.png

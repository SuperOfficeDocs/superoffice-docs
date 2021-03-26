---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_ms_office  # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested Microsoft Office versions # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested Microsoft Office versions

Tested Microsoft Office versions on both SuperOffice Win and Web applications.

Want to know if a newly released Office version is compatible? Check the [compatibility reports][3].

| Microsoft Office version    | 8.0, SR1 - SR2 | 8.0 SR3 - SR6| 8.1 - 8.3 | 8.4 - 8.5 | 8.5 R16 | 9.1 | 9.2 | 9.2 R04+|
|-----------------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Microsoft Office 2019       | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 365 for Business | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 2016 64bit | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 2016 32bit | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 2013 64bit | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 2013 32bit | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Microsoft Office 2010 32bit | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3]* | ![i][img1] | ![i][img1] | ![i][img3]* |

> [!NOTE]
> Support for Office 2010 ended October 13, 2020 and it is not part of the test matrix.

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced links-->
[3]: index.md

<!--Referenced icons-->
[img1]: ../../media/icons/testedyes.png
[img2]: ../../media/icons/testedno.png
[img3]: ../../media/icons/testednotyet.png
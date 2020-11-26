---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_browsers # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested browser versions # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested browser versions

Tested browsers to run both Win and Web applications.

Want to know if a newly released browser is compatible? Check your [compatibility reports](reports.md).

| Browsers             | 8.0 | 8.1 | 8.2 | 8.3 | 8.4 | 8.5 |9.1 |
|----------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Edge                 | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Internet Explorer 11 | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][2] |
| Internet Explorer 10 | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][2] |
| Chrome Win           | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| FireFox Win          | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Chrome Mac           | ![][3] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| FireFox Mac          | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Safari Mac           | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced icons-->
[1]: ../../media/icons/testedyes.png
[2]: ../../media/icons/testedno.png
[3]: ../../media/icons/testednotyet.png
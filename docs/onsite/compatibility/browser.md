---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_browsers # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested browser versions # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested browser versions

Tested browsers to run both Win and Web applications.

Want to know if a newly released browser is compatible? Check your [compatibility reports][1].

| Browsers             | 8.0 | 8.1 | 8.2 | 8.3 | 8.4 | 8.5 | 9.1 | 9.2 |
|----------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Edge                 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Internet Explorer 11 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img2] | ![i][img2] |
| Internet Explorer 10 | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img2] | ![i][img2] |
| Chrome Win           | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| FireFox Win          | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Chrome Mac           | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| FireFox Mac          | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |
| Safari Mac           | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] |

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced links-->
[1]: index.md

<!--Referenced icons-->
[img1]: ../../media/icons/testedyes.png
[img2]: ../../media/icons/testedno.png
[img3]: ../../media/icons/testednotyet.png

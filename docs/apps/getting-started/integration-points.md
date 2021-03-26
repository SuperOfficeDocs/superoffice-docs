---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: integration_points       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SuperOffice Online integration points # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# SuperOffice Online integration points

The extensibility points are platform-independent.

Anything a consultant can do inside the SuperOffice Admin application, any application can programmatically do during or after [provisioning][1]:

* custom lists and list items
* user-defined fields
* web panels
* custom buttons
* sales guide, project guide
* preferences
* re-skinned to customer's brand

![imagejcbmo.png][img1]

## High-level integration points

* [Webhooks][2]
* [SOAP][3]
* [REST][4]
* [CRMScript][5]

## Integration services

These services are either an independent application or augment an existing application.

* [Database Mirroring Service][6]
* [ERPSync Connector Service][7]
* [Quote Connector Service][8]

<!-- Referenced links -->
[1]: ../provisioning/index.md
[2]: ../../automation/webhook/index.md
[3]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/soap/reference/index.md
[4]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/web-api/rest/reference/index.md
[5]: ../../automation/crmscript.md
[6]: ../../mirroring/index.md
[7]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/erp-connectors/index.md
[8]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/quote-connectors/index.md

<!-- Referenced images -->
[img1]: media/imagejcbmo.png

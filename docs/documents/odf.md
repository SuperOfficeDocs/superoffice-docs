---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: odf       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ODF Support # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ODF Support

Support of Open Document Format in SuperOffice

The Open Document Format (ODF) is an XML-based open source file format for saving and exchanging text, spreadsheets, charts, and presentations. Files saved under ODF, termed "OpenDocuments," have easily recognizable extensions, similar to Microsoft's proprietary .doc or .xls. It is the default format for OpenOffice.org and LibreOffice.

The ODF support was introduced in 8.4 R01 but had a bugfix concerning empty tags fixed in 8.4 R03. As such we would recommend 8.4 R03 as a minimum.

NetServer supports ODF files natively without need for any extra configuration.

In SuperOffice Web, you should also get the real ODF icons in the document dialog when using ODF files and templates.

![imageghtzm.png][1]

Please note this support has not been highly advertised and is not as tested as our general Microsoft Office file format support. If you encounter errors or issues, please let us know.

<!-- Referenced links -->
[1]: media/imageghtzm.png

---
title: Variables from Document dialog or system
uid: variables_from_doc_dialog_or_system
description: Variables from the Document dialog or from the system
author: {github-id}
keywords:
so.topic: reference
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:
# so.client:
---

# Variables from the Document dialog or from the system

| Variable | Description |
|----------|-------------|
| apid | Appointment ID |
| atti | Title of the contact the document will be sent to |
| attn | Selected contact in the Document dialog or text that is specified in the Company field for a recipient of the document |
| dat1 | Date in semi long format, for example, 10. December 2004 (from 10.0.4) |
| date | Date in long format, for example, 10 December 2004 |
| desc | Description of the created document |
| df01-10 | User-defined field 1-10 of the decimal number type |
| dl01-60 | User-defined field 1-60 of the whole number type |
| doid | Document ID (hidden, unique ID) |
| dope | Document, end date for publishing |
| dops | Document, start date for publishing |
| ds01-49 | User-defined field 1-49 of the text type |
| dsug | Suggested document ID for the document ("SuggestedDocument Id"). Set to 0 when the document is not part of a sale/project guide |
| file | Name of the document, without the path (for example SUPER001.DOC) |
| head | The heading for the created document |
| lanc | The ISO language code: "nb-NO", "en", "de-DE", ... |
| lang | The language being used in SuperOffice CRM |
| lanx | The SuperOffice language code: "NO", "US", "GE", ... |
| ltim | Time in long format, for example, 12:10:05 |
| oref | Our reference |
| pltf | Platform: Windows or web |
| ptha | SOARC path (from SuperOffice.ini) |
| pthi | Path to the folder where SuperOffice.ini is located |
| pthp | Path to the folder where SuperOffice CRM is installed |
| salu | Salutation as entered, or created automatically from the contact (Mr/Ms and last name) |
| sdat | Date in short format, for example, 10.12.04 |
| ser# | SuperOffice CRM's serial number |
| snum | Ascending serial number (different for every template) |
| time | Time in short format, for example, 12:10 |
| ver# | SuperOffice CRM's version number |
| vern | NetServer full name "NetServer 7.1 (Debug) 7.1.200.300" |
| yref | Your reference |

> [!NOTE]
> The short and long date formats will be determined by your computer’s settings for the Windows client. You can edit the settings in Control Panel in Windows.
>
> For the web client, it's the web server's setting based on the Local settings that appear on the button beside Help where you choose Active Language, Number and Date format, and Email client.

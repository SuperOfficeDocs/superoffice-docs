---
title: POST List/DocumentTemplate/Items/{id}/Content/{languageCode}
id: v1DocumentTemplateList_CreateDefaultDocumentTemplateLanguage
---

# POST List/DocumentTemplate/Items/{id}/Content/{languageCode}

```http
POST /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
```

Create a new document template language based on an existing template






| Path Part | Type | Description |
|-----------|------|-------------|
| documentTemplateId | int32 | The id of the document template **Required** |
| languageCode | string | The language code ('en-US, 'nb-NO', etc) **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |
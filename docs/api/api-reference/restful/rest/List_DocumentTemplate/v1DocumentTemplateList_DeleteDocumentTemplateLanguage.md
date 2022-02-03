---
title: DEL List/DocumentTemplate/Items/{id}/Content/{languageCode}
id: v1DocumentTemplateList_DeleteDocumentTemplateLanguage
---

# DEL List/DocumentTemplate/Items/{id}/Content/{languageCode}

```http
DELETE /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
```

Deletes language variant of the document template






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
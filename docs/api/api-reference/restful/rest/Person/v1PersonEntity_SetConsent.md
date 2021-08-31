---
title: PUT Person/{id}/Consent/{purpose}
id: v1PersonEntity_SetConsent
---

# PUT Person/{id}/Consent/{purpose}

```http
PUT /api/v1/Person/{personId}/Consent/{purpose}
```

Set a specified type of consent on the person.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id **Required** |
| purpose | string | The Key of the purpose this affects. e.g. 'STORE' or 'EMARKETING'. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| source | string | **Required** The Key of the source of this consent. e.g. 'USER', 'WEBFORM' or 'API'. |
| legalBase | string | **Required** The Key of the legal base for this consent. e.g. '61A', '61B', '61F' |
| comment | string |  A comment regarding this consent. May be null or empty. |

```http
PUT /api/v1/Person/{personId}/Consent/{purpose}?source=illo
PUT /api/v1/Person/{personId}/Consent/{purpose}?legalBase=quisquam
PUT /api/v1/Person/{personId}/Consent/{purpose}?comment=labore
```


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
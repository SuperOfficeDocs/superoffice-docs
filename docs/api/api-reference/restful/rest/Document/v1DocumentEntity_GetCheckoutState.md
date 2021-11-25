---
title: GET Document/{id}/Lock
id: v1DocumentEntity_GetCheckoutState
---

# GET Document/{id}/Lock

```http
GET /api/v1/Document/{documentId}/Lock
```

Get the current checkout state for a document, relative to the user perforing the call.






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document ID **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| State | string |  |
| AssociateId | int32 |  |
| Name | string |  |

## Sample Request

```http!
GET /api/v1/Document/{documentId}/Lock
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "State": "CheckedOutOther",
  "AssociateId": 463,
  "Name": "McCullough Inc and Sons"
}
```
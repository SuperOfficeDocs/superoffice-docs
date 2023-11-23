---
title: PUT List/LegalBase/Items/{id}
uid: v1LegalBaseList_PutLegalBase
generated: true
---

# PUT List/LegalBase/Items/{id}

```http
PUT /api/v1/List/LegalBase/Items/{id}
```

Updates the existing LegalBase


Calls the List agent service SaveLegalBase.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of LegalBase to be saved. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The details of LegalBase to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LegalBaseId | Integer | Primary key |
| Name | String | Name of legal base |
| Tooltip | String | Tooltip for this consent source |
| Rank | Integer | Rank of this consent source |
| Key | String | The key used to uniquely identify this legal base |
| Deleted | Boolean | true if the LegalBase is deleted |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: LegalBase

| Property Name | Type |  Description |
|----------------|------|--------------|
| LegalBaseId | int32 | Primary key |
| Name | string | Name of legal base |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this legal base |
| Deleted | bool | true if the LegalBase is deleted |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/LegalBase/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "LegalBaseId": 991,
  "Name": "White-Mertz",
  "Tooltip": "eveniet",
  "Rank": 55,
  "Key": "magni",
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LegalBaseId": 20,
  "Name": "Zieme, Metz and Kihn",
  "Tooltip": "qui",
  "Rank": 873,
  "Key": "adipisci",
  "Deleted": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 351
    }
  }
}
```
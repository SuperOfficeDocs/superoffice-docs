---
title: POST Agents/List/GetLegalBase
id: v1ListAgent_GetLegalBase
---

# POST Agents/List/GetLegalBase

```http
POST /api/v1/Agents/List/GetLegalBase
```

Gets a LegalBase object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| legalBaseId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetLegalBase?legalBaseId=507
POST /api/v1/Agents/List/GetLegalBase?$select=name,department,category/id
```


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

Carrier object for LegalBase.
Services for the LegalBase Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| LegalBaseId | int32 | Primary key |
| Name | string | Name of legal base |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this legal base |
| Deleted | bool | true if the LegalBase is deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/GetLegalBase
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LegalBaseId": 7,
  "Name": "Wiza, Collier and Toy",
  "Tooltip": "quod",
  "Rank": 992,
  "Key": "quos",
  "Deleted": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 153
    }
  }
}
```
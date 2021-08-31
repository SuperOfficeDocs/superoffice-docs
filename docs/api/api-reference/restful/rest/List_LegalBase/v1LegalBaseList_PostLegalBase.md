---
title: POST List/LegalBase/Items
id: v1LegalBaseList_PostLegalBase
---

# POST List/LegalBase/Items

```http
POST /api/v1/List/LegalBase/Items
```

Create a new LegalBase list item

Calls the List agent service SaveLegalBase.






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

## Request Body: newEntity  

The LegalBase to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LegalBaseId | int32 | Primary key |
| Name | string | Name of legal base |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this legal base |
| Deleted | bool | true if the LegalBase is deleted |


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
POST /api/v1/List/LegalBase/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LegalBaseId": 61,
  "Name": "Howe-Mraz",
  "Tooltip": "aut",
  "Rank": 549,
  "Key": "quam",
  "Deleted": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LegalBaseId": 341,
  "Name": "Kutch, Hamill and Stroman",
  "Tooltip": "doloribus",
  "Rank": 838,
  "Key": "repellat",
  "Deleted": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "leverage holistic relationships"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 902
    }
  }
}
```
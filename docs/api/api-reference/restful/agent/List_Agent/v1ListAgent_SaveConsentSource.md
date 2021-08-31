---
title: SaveConsentSource
id: v1ListAgent_SaveConsentSource
---

# SaveConsentSource

```http
POST /api/v1/Agents/List/SaveConsentSource
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveConsentSource?$select=name,department,category/id
```


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

## Request Body: request  

ConsentSource 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentSource |  | Carrier object for ConsentSource. Services for the ConsentSource Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |


## Response: object

Carrier object for ConsentSource.
Services for the ConsentSource Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentSourceId | int32 | Primary key |
| Name | string | Name of consent source |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this consent source |
| MailTemplateId | int32 | The mail template to use when automatically sending emails to new persons created with this consent source. |
| Deleted | bool | true if the ConsentSource is deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/SaveConsentSource
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConsentSource": {
    "ConsentSourceId": 209,
    "Name": "Olson-Erdman",
    "Tooltip": "qui",
    "Rank": 115,
    "Key": "aut",
    "MailTemplateId": 704,
    "Deleted": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentSourceId": 760,
  "Name": "Connelly-Hagenes",
  "Tooltip": "explicabo",
  "Rank": 976,
  "Key": "maiores",
  "MailTemplateId": 560,
  "Deleted": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "generate holistic web services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 996
    }
  }
}
```
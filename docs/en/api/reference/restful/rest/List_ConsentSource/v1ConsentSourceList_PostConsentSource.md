---
title: POST List/ConsentSource/Items
uid: v1ConsentSourceList_PostConsentSource
generated: true
---

# POST List/ConsentSource/Items

```http
POST /api/v1/List/ConsentSource/Items
```

Create a new ConsentSource list item


Calls the List agent service SaveConsentSource.







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

The ConsentSource to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentSourceId | Integer | Primary key |
| Name | String | Name of consent source |
| Tooltip | String | Tooltip for this consent source |
| Rank | Integer | Rank of this consent source |
| Key | String | The key used to uniquely identify this consent source |
| MailTemplateId | Integer | The mail template to use when automatically sending emails to new persons created with this consent source. |
| Deleted | Boolean | true if the ConsentSource is deleted |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ConsentSource

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentSourceId | int32 | Primary key |
| Name | string | Name of consent source |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this consent source |
| MailTemplateId | int32 | The mail template to use when automatically sending emails to new persons created with this consent source. |
| Deleted | bool | true if the ConsentSource is deleted |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/List/ConsentSource/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConsentSourceId": 397,
  "Name": "Bernier-Pagac",
  "Tooltip": "cumque",
  "Rank": 410,
  "Key": "sed",
  "MailTemplateId": 545,
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentSourceId": 786,
  "Name": "Brakus-Weber",
  "Tooltip": "ea",
  "Rank": 164,
  "Key": "ea",
  "MailTemplateId": 991,
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 888
    }
  }
}
```
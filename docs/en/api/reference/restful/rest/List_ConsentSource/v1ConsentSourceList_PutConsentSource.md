---
title: PUT List/ConsentSource/Items/{id}
uid: v1ConsentSourceList_PutConsentSource
---

# PUT List/ConsentSource/Items/{id}

```http
PUT /api/v1/List/ConsentSource/Items/{id}
```

Updates the existing ConsentSource


Calls the List agent service SaveConsentSource.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of ConsentSource to be saved. **Required** |



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

The details of ConsentSource to be saved. 

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
| 400 | Bad request. Entity to save is not in request body. |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/ConsentSource/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConsentSourceId": 210,
  "Name": "Torphy-Monahan",
  "Tooltip": "possimus",
  "Rank": 649,
  "Key": "ex",
  "MailTemplateId": 228,
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentSourceId": 321,
  "Name": "Dooley-Lang",
  "Tooltip": "veniam",
  "Rank": 208,
  "Key": "ipsum",
  "MailTemplateId": 798,
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 793
    }
  }
}
```
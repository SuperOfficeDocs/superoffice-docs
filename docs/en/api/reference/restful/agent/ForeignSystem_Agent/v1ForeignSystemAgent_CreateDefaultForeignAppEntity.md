---
title: POST Agents/ForeignSystem/CreateDefaultForeignAppEntity
uid: v1ForeignSystemAgent_CreateDefaultForeignAppEntity
generated: true
content_type: reference
---

# POST Agents/ForeignSystem/CreateDefaultForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
```

Loading default values into a new ForeignAppEntity.








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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignAppEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 48,
  "Name": "Klocko-Smith",
  "CreatedDate": "2016-10-13T03:46:54.8320045+02:00",
  "UpdatedDate": "2006-08-24T03:46:54.8320045+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 263,
      "Name": "Quigley-O'Reilly",
      "CreatedDate": "1999-02-14T03:46:54.8320045+01:00",
      "UpdatedDate": "2010-07-08T03:46:54.8320045+02:00",
      "AssociateFullName": "Dr. Caroline Justice Bahringer Sr.",
      "CreatedBy": "non",
      "UpdatedBy": "eligendi",
      "DeviceIdentifier": "tenetur",
      "ForeignAppId": 384,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 623
    }
  }
}
```
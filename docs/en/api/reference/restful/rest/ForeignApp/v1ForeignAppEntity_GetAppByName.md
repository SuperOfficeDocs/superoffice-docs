---
title: GET ForeignApp/{applicationName}
uid: v1ForeignAppEntity_GetAppByName
generated: true
content_type: reference
---

# GET ForeignApp/{applicationName}

```http
GET /api/v1/ForeignApp/{applicationName}
```

Gets the ForeignApp with the given name.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |



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
GET /api/v1/ForeignApp/{applicationName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 14 Aug 2011 03:47:00 G8T

{
  "ForeignAppId": 235,
  "Name": "Robel, Spencer and Feeney",
  "CreatedDate": "2007-11-08T03:47:00.0193121+01:00",
  "UpdatedDate": "2011-08-14T03:47:00.0193121+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 208,
      "Name": "Toy-Becker",
      "CreatedDate": "2011-01-14T03:47:00.0349452+01:00",
      "UpdatedDate": "2022-05-10T03:47:00.0349452+02:00",
      "AssociateFullName": "Ms. Lilla Elinor Macejkovic",
      "CreatedBy": "quibusdam",
      "UpdatedBy": "autem",
      "DeviceIdentifier": "consequatur",
      "ForeignAppId": 80,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 457
    }
  }
}
```
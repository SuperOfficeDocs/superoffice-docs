---
title: PUT ForeignApp/{appName}
uid: v1ForeignAppEntity_PostForeignApp_PUT
generated: true
---

# PUT ForeignApp/{appName}

```http
PUT /api/v1/ForeignApp/{appName}
```

Creates a new ForeignApp


Calls the ForeignSystem agent service SaveForeignAppEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| appName | string | The ForeignApp to be saved. **Required** |



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
PUT /api/v1/ForeignApp/{appName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 452,
  "Name": "Kling, Nitzsche and Lesch",
  "CreatedDate": "1998-04-17T02:38:26.1048073+02:00",
  "UpdatedDate": "2022-09-29T02:38:26.1048073+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 106,
      "Name": "Halvorson-Cole",
      "CreatedDate": "2018-02-24T02:38:26.1048073+01:00",
      "UpdatedDate": "2001-06-19T02:38:26.1048073+02:00",
      "AssociateFullName": "Isaiah Bayer",
      "CreatedBy": "sed",
      "UpdatedBy": "explicabo",
      "DeviceIdentifier": "modi",
      "ForeignAppId": 557,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 293
    }
  }
}
```
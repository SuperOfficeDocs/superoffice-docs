---
title: PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
uid: v1ForeignAppEntity_SaveDeviceByIdentifier
generated: true
---

# PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}

```http
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
```

Updates a ForeignDevice with deviceName that belongs to the application with applicationName.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| deviceIdentifier | string | Unique id of device (Palm pilot device ID, version number, etc) **Required** |



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

## Request Body: foreignDevice 

Foreign device to save. Can be null if adding new device. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignDeviceId | Integer | Primary key |
| Name | String | Name of device |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| AssociateFullName | String | The person owning the Foreign Device |
| CreatedBy | String | The person that created the device. |
| UpdatedBy | String | The person that last updated this device. |
| DeviceIdentifier | String | Optional unique id of device (Palm pilot device ID, etc) |
| ForeignAppId | Integer | Reference to foregin application (device type) |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignDevice

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignDeviceId | int32 | Primary key |
| Name | string | Name of device |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| AssociateFullName | string | The person owning the Foreign Device |
| CreatedBy | string | The person that created the device. |
| UpdatedBy | string | The person that last updated this device. |
| DeviceIdentifier | string | Optional unique id of device (Palm pilot device ID, etc) |
| ForeignAppId | int32 | Reference to foregin application (device type) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 55,
  "Name": "Conn, Sanford and VonRueden",
  "CreatedDate": "2006-12-01T13:38:17.4368262+01:00",
  "UpdatedDate": "2006-06-26T13:38:17.4368262+02:00",
  "AssociateFullName": "Joanne Rempel",
  "CreatedBy": "est",
  "UpdatedBy": "et",
  "DeviceIdentifier": "ipsum",
  "ForeignAppId": 471
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 483,
  "Name": "Sauer, Quigley and Carter",
  "CreatedDate": "2008-10-27T13:38:17.4524494+01:00",
  "UpdatedDate": "2018-07-25T13:38:17.4524494+02:00",
  "AssociateFullName": "Ollie Ernser",
  "CreatedBy": "totam",
  "UpdatedBy": "neque",
  "DeviceIdentifier": "quia",
  "ForeignAppId": 187,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 296
    }
  }
}
```
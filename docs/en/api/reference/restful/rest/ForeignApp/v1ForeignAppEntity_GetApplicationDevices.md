---
title: GET ForeignApp/{applicationName}/Devices
uid: v1ForeignAppEntity_GetApplicationDevices
---

# GET ForeignApp/{applicationName}/Devices

```http
GET /api/v1/ForeignApp/{applicationName}/Devices
```

Gets all devices that belong to a foreign application.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The foreign application name **Required** |



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


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/ForeignApp/{applicationName}/Devices
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 06 Aug 2013 02:49:50 G8T

[
  {
    "ForeignDeviceId": 14,
    "Name": "Gusikowski LLC",
    "CreatedDate": "1997-03-05T02:49:50.9952888+01:00",
    "UpdatedDate": "2013-08-06T02:49:50.9952888+02:00",
    "AssociateFullName": "Janessa Rippin",
    "CreatedBy": "quibusdam",
    "UpdatedBy": "in",
    "DeviceIdentifier": "id",
    "ForeignAppId": 748,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 835
      }
    }
  }
]
```
---
title: POST Agents/ForeignSystem/SaveForeignDevice
id: v1ForeignSystemAgent_SaveForeignDevice
---

# POST Agents/ForeignSystem/SaveForeignDevice

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignDevice
```

Saves a foreign device for an foreign application







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignDevice?$select=name,department,category/id
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

ForeignDevice, ApplicationName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignDevice |  | Saves a foreign device belonging to the ForeignDevice and application name specified. <para /> Carrier object for ForeignDevice. Services for the ForeignDevice Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |
| ApplicationName | string |  |


## Response: object

Saves a foreign device belonging to the ForeignDevice and application name specified.



Carrier object for ForeignDevice.
Services for the ForeignDevice Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignDevice
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ForeignDevice": {
    "ForeignDeviceId": 560,
    "Name": "Nitzsche LLC",
    "CreatedDate": "2008-12-16T16:48:29.7179242+01:00",
    "UpdatedDate": "1996-05-26T16:48:29.7179242+02:00",
    "AssociateFullName": "Nicole O'Keefe DVM",
    "CreatedBy": "delectus",
    "UpdatedBy": "fuga",
    "DeviceIdentifier": "dolorem",
    "ForeignAppId": 995
  },
  "ApplicationName": "Williamson LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 166,
  "Name": "Buckridge-Swift",
  "CreatedDate": "2009-08-01T16:48:29.7179242+02:00",
  "UpdatedDate": "2006-06-20T16:48:29.7179242+02:00",
  "AssociateFullName": "Mrs. Magdalen Bosco",
  "CreatedBy": "fugit",
  "UpdatedBy": "ratione",
  "DeviceIdentifier": "et",
  "ForeignAppId": 946,
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
      "FieldLength": 613
    }
  }
}
```
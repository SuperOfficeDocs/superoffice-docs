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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignDevice": {
    "ForeignDeviceId": 22,
    "Name": "Heller-Murphy",
    "CreatedDate": "2006-11-22T18:28:49.2181179+01:00",
    "UpdatedDate": "2019-07-07T18:28:49.2181179+02:00",
    "AssociateFullName": "Derrick Reichert",
    "CreatedBy": "quibusdam",
    "UpdatedBy": "quos",
    "DeviceIdentifier": "eaque",
    "ForeignAppId": 486
  },
  "ApplicationName": "Donnelly, Mante and Jerde"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 360,
  "Name": "Labadie, Weissnat and Schumm",
  "CreatedDate": "1994-09-16T18:28:49.2191175+02:00",
  "UpdatedDate": "2012-06-21T18:28:49.2191175+02:00",
  "AssociateFullName": "Moshe Schroeder",
  "CreatedBy": "quae",
  "UpdatedBy": "optio",
  "DeviceIdentifier": "ut",
  "ForeignAppId": 965,
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
      "FieldType": "System.String",
      "FieldLength": 100
    }
  }
}
```
---
title: POST Agents/Pocket/GetRegisteredDevices
id: v1PocketAgent_GetRegisteredDevices
---

# POST Agents/Pocket/GetRegisteredDevices

```http
POST /api/v1/Agents/Pocket/GetRegisteredDevices
```

Retrieve all registered devices for an associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Pocket/GetRegisteredDevices?$select=name,department,category/id
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

AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DeviceName | string | A friendly display name for the device. Ex: 'Bobbys iPhone 5S' |
| DeviceIdentifier | string | A unique identifier of this device. This value should always be the same for the same device |
| PocketVersion | string | What version of Pocket CRM this device is running. Ex: '8.0.37' |
| Language | string | The language which this device will receive notifications translated in |
| PNSHandle | string | The identifier associated with the device that will be used when talking with vendors push services |
| Platform | string | What platform does this device belong to |
| OSVersion | string | The operating system version. Ex: 'iOS v10.2' |

## Sample Request

```http!
POST /api/v1/Agents/Pocket/GetRegisteredDevices
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 117
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DeviceName": "Schmeler Inc and Sons",
    "DeviceIdentifier": "ullam",
    "PocketVersion": "adipisci",
    "Language": "nostrum",
    "PNSHandle": "et",
    "Platform": "Apple",
    "OSVersion": "expedita"
  }
]
```
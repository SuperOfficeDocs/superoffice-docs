---
title: POST Agents/ForeignSystem/GetKeyValue
id: v1ForeignSystemAgent_GetKeyValue
---

# POST Agents/ForeignSystem/GetKeyValue

```http
POST /api/v1/Agents/ForeignSystem/GetKeyValue
```

Gets the string value of a ForeignKey, that belongs to the specified device and application.

The table name and record ID must also be specified.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetKeyValue?$select=name,department,category/id
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

ApplicationName, DeviceName, KeyName, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |
| DeviceName | string |  |
| KeyName | string |  |
| TableName | string |  |
| RecordId | int32 |  |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/GetKeyValue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Stamm Inc and Sons",
  "DeviceName": "Yundt, Marks and Olson",
  "KeyName": "Rippin Inc and Sons",
  "TableName": "Heaney-Schaden",
  "RecordId": 201
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"harum"
```
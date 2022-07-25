---
title: POST Agents/Configuration/GetFilterList
id: v1ConfigurationAgent_GetFilterList
---

# POST Agents/Configuration/GetFilterList

```http
POST /api/v1/Agents/Configuration/GetFilterList
```

Get the list of filters to be used for processing the configuration data for this application.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetFilterList?$select=name,department,category/id
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

Application, Instance

| Property Name | Type |  Description |
|----------------|------|--------------|
| Application | string |  |
| Instance | string |  |

## Response: string

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string

## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetFilterList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Application": "aut",
  "Instance": "voluptatibus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"velit"
```

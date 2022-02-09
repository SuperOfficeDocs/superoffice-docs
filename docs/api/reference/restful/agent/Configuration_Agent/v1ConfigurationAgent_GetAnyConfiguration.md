---
title: POST Agents/Configuration/GetAnyConfiguration
id: v1ConfigurationAgent_GetAnyConfiguration
---

# POST Agents/Configuration/GetAnyConfiguration

```http
POST /api/v1/Agents/Configuration/GetAnyConfiguration
```

Get one defined configuration fragment, with full reference resolution and parsing applied.

This is essentially the same service as the GetPageConfiguration, except that this service is not locked to objects of type Page.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetAnyConfiguration?$select=name,department,category/id
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

Application, Instance, Item, Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Application | string |  |
| Instance | string |  |
| Item | string |  |
| Type | string |  |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetAnyConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Application": "blanditiis",
  "Instance": "consequuntur",
  "Item": "et",
  "Type": "ea"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"omnis"
```
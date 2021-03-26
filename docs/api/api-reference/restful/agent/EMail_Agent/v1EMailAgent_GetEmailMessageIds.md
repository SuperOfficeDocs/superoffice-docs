---
title: POST Agents/EMail/GetEmailMessageIds
id: v1EMailAgent_GetEmailMessageIds
---

# POST Agents/EMail/GetEmailMessageIds

```http
POST /api/v1/Agents/EMail/GetEmailMessageIds
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEmailMessageIds?$select=name,department,category/id
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

ConnectionInfoExtended 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfoExtended |  | Carrier object for EMailConnectionInfoExtended. Services for the EMailConnectionInfoExtended Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array


## Sample Request

```http!
POST /api/v1/Agents/EMail/GetEmailMessageIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfoExtended": {
    "Port": 281,
    "ServerName": "Von-Jones",
    "Protocol": "nihil",
    "UserName": "Durgan-Frami",
    "Password": "ut",
    "UseSSL": false,
    "Folder": "dicta"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  "consequatur",
  "enim"
]
```
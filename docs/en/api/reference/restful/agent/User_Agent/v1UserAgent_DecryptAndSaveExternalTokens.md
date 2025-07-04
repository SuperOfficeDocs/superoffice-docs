---
title: POST Agents/User/DecryptAndSaveExternalTokens
uid: v1UserAgent_DecryptAndSaveExternalTokens
generated: true
---

# POST Agents/User/DecryptAndSaveExternalTokens

```http
POST /api/v1/Agents/User/DecryptAndSaveExternalTokens
```

First asks AccessGateway to decrypt the tokens, then saves the external tokens to the DB and returns a key that can be used to retrieve them


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/DecryptAndSaveExternalTokens?$select=name,department,category/id
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

TokenManagementInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TokenManagementInfo | TokenManagementInfo | Token information <para /> Carrier object for TokenManagementInfo. Services for the TokenManagementInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |

## Response:string

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: string


## Sample request

```http!
POST /api/v1/Agents/User/DecryptAndSaveExternalTokens
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TokenManagementInfo": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"pariatur"
```
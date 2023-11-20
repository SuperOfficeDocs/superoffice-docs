---
title: POST Agents/User/SetExternalUserInfo
uid: v1UserAgent_SetExternalUserInfo
generated: true
---

# POST Agents/User/SetExternalUserInfo

```http
POST /api/v1/Agents/User/SetExternalUserInfo
```

Modifies an external user.


Changes external users information according to the flags set in  externalUserInfoModification.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SetExternalUserInfo?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

AssociateId, UserName, Password, IsActive, RoleId, ExternalUserInfoModification 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |
| UserName | String |  |
| Password | String |  |
| IsActive | Boolean |  |
| RoleId | Integer |  |
| ExternalUserInfoModification | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/User/SetExternalUserInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 747,
  "UserName": "Watsica-Zboncak",
  "Password": "et",
  "IsActive": false,
  "RoleId": 968,
  "ExternalUserInfoModification": "Active"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
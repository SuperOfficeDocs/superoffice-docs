---
title: POST Agents/User/SaveUntrustedCredentialsForAssociate
uid: v1UserAgent_SaveUntrustedCredentialsForAssociate
generated: true
---

# POST Agents/User/SaveUntrustedCredentialsForAssociate

```http
POST /api/v1/Agents/User/SaveUntrustedCredentialsForAssociate
```

Save credentials for a specified user.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SaveUntrustedCredentialsForAssociate?$select=name,department,category/id
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

AssociateId, Type, Credentials 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |
| Type | String |  |
| Credentials | UntrustedCredentials | Credentials for external authentication. <para /> Carrier object for UntrustedCredentials. Services for the UntrustedCredentials Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/User/SaveUntrustedCredentialsForAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 347,
  "Type": "eaque",
  "Credentials": null
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
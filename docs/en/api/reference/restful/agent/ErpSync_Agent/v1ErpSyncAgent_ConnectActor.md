---
title: POST Agents/ErpSync/ConnectActor
uid: v1ErpSyncAgent_ConnectActor
generated: true
---

# POST Agents/ErpSync/ConnectActor

```http
POST /api/v1/Agents/ErpSync/ConnectActor
```

Create a link between Erp and Crm and set default values


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/ConnectActor?$select=name,department,category/id
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

ErpConnectionId, CrmRecordId, CrmActorType, ErpKey, ErpActorType, FieldValues 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | Integer |  |
| CrmRecordId | Integer |  |
| CrmActorType | String |  |
| ErpKey | String |  |
| ErpActorType | String |  |
| FieldValues | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/ErpSync/ConnectActor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 684,
  "CrmRecordId": 386,
  "CrmActorType": "Contact",
  "ErpKey": "necessitatibus",
  "ErpActorType": "Customer",
  "FieldValues": [
    {
      "DisplayName": "Hauck Group",
      "CrmFieldKey": "officia",
      "Value": "voluptas",
      "DisplayValue": "aut",
      "SyncToCrm": false,
      "SyncToErp": false
    },
    {
      "DisplayName": "Hauck Group",
      "CrmFieldKey": "officia",
      "Value": "voluptas",
      "DisplayValue": "aut",
      "SyncToCrm": false,
      "SyncToErp": false
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
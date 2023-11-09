---
title: POST Agents/CustomerService/SaveAllCustomerCenterConfigs
uid: v1CustomerServiceAgent_SaveAllCustomerCenterConfigs
generated: true
---

# POST Agents/CustomerService/SaveAllCustomerCenterConfigs

```http
POST /api/v1/Agents/CustomerService/SaveAllCustomerCenterConfigs
```

Save an array of CustomerCenterConfig entities to the database







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/SaveAllCustomerCenterConfigs?$select=name,department,category/id
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

CustConfigs 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CustConfigs | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/CustomerService/SaveAllCustomerCenterConfigs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CustConfigs": [
    {
      "CustConfigId": 98,
      "Type": "Options",
      "Config": "rerum",
      "CustLangId": 838,
      "Registered": "1996-06-29T11:06:34.2539546+02:00",
      "RegisteredAssociateId": 65,
      "Updated": "2016-09-18T11:06:34.2539546+02:00",
      "UpdatedAssociateId": 650
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
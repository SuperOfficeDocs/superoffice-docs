---
title: POST Agents/Sale/AddSaleStakeholders
uid: v1SaleAgent_AddSaleStakeholders
generated: true
---

# POST Agents/Sale/AddSaleStakeholders

```http
POST /api/v1/Agents/Sale/AddSaleStakeholders
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/AddSaleStakeholders?$select=name,department,category/id
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

SaleId, SaleStakeholders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | Integer |  |
| SaleStakeholders | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Sale/AddSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleId": 157,
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kautzer LLC",
      "Comment": "sit",
      "StakeholderRoleId": 394,
      "CountryId": 59,
      "PersonId": 248,
      "EmailDescription": "camille@kertzmann.info",
      "EmailId": 61,
      "EmailAddress": "jesse.kuhic@adams.biz",
      "PhoneId": 383,
      "ContactName": "Emmerich, Bechtelar and Kutch",
      "ContactId": 149,
      "SaleId": 599,
      "Mrmrs": "illo",
      "Firstname": "April",
      "MiddleName": "Lebsack Inc and Sons",
      "Lastname": "Connelly",
      "SaleStakeholderId": 320,
      "Rank": 220,
      "Phone": "1-850-902-3551 x253"
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
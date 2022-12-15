---
title: POST Agents/Sale/AddSaleStakeholders
uid: v1SaleAgent_AddSaleStakeholders
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
| SaleId | int32 |  |
| SaleStakeholders | array |  |


## Response: 

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body: 


## Sample request

```http!
POST /api/v1/Agents/Sale/AddSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 635,
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Huels Group",
      "Comment": "cumque",
      "StakeholderRoleId": 121,
      "CountryId": 586,
      "PersonId": 993,
      "EmailDescription": "laurine@rathoberbrunner.us",
      "EmailId": 646,
      "EmailAddress": "rico_gleichner@schmeler.info",
      "PhoneId": 925,
      "ContactName": "Gerhold, Ernser and Toy",
      "ContactId": 211,
      "SaleId": 642,
      "Mrmrs": "fugiat",
      "Firstname": "Kirk",
      "MiddleName": "Bogisich, Stamm and Fritsch",
      "Lastname": "Fay",
      "SaleStakeholderId": 108,
      "Rank": 883,
      "Phone": "1-249-687-1623 x566"
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
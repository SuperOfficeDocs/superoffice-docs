---
title: POST Agents/Favourite/AddTicketsToFavouritesByProvider
uid: v1FavouriteAgent_AddTicketsToFavouritesByProvider
---

# POST Agents/Favourite/AddTicketsToFavouritesByProvider

```http
POST /api/v1/Agents/Favourite/AddTicketsToFavouritesByProvider
```

Add a list of tickets as favourites that are given by the ticket provider.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Favourite/AddTicketsToFavouritesByProvider?$select=name,department,category/id
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

ProviderName, Restrictions, AssociateId, ExtraInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Restrictions | Array |  |
| AssociateId | Integer |  |
| ExtraInfo | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/Favourite/AddTicketsToFavouritesByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Stoltenberg-Weissnat",
  "Restrictions": [
    {
      "Name": "Ernser-Reilly",
      "Operator": "sunt",
      "Values": [
        "provident",
        "dolorum"
      ],
      "DisplayValues": [
        "ipsa",
        "natus"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 584,
      "InterOperator": "And",
      "UniqueHash": 475
    }
  ],
  "AssociateId": 18,
  "ExtraInfo": "sint"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
---
title: POST Agents/User/ValidateUser
id: v1UserAgent_ValidateUser
---

# POST Agents/User/ValidateUser

```http
POST /api/v1/Agents/User/ValidateUser
```

Check that entity is ready for saving, return error messages by field.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/ValidateUser?$select=name,department,category/id
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

User 

| Property Name | Type |  Description |
|----------------|------|--------------|
| User |  | SuperOffice User, with login credentials and an associated person. <para /> Carrier object for User. Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/User/ValidateUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 480,
    "Name": "Sipes, Doyle and Kutch",
    "Rank": 719,
    "Tooltip": "dolorem",
    "LicenseOwners": [
      {},
      {}
    ],
    "Role": {},
    "UserGroup": {},
    "OtherGroups": [
      {},
      {}
    ],
    "Person": {},
    "Deleted": true,
    "Lastlogin": "2020-07-30T18:28:50.4244121+02:00",
    "Lastlogout": "2021-01-14T18:28:50.4244121+01:00",
    "EjUserId": 969,
    "RequestSignature": "atque",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": true,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Smitham LLC",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Rutherford, Stoltenberg and Robel",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "rerum",
      "ExtraFields2": "porro"
    },
    "CustomFields": {
      "CustomFields1": "iste",
      "CustomFields2": "accusamus"
    },
    "PostSaveCommands": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quo",
  "2": "sed"
}
```
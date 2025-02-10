---
title: GET SaleStakeholder/{id}
uid: v1SaleStakeholder_GetSaleStakeholder
generated: true
---

# GET SaleStakeholder/{id}

```http
GET /api/v1/SaleStakeholder/{id}
```

Gets a SaleStakeholder object.


Calls the Sale agent service GetSaleStakeholder.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SaleStakeholder to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/SaleStakeholder/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

SaleStakeholder found.

| Response | Description |
|----------------|-------------|
| 200 | SaleStakeholder found. |
| 404 | Not Found. |

### Response body: SaleStakeholderWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/SaleStakeholder/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 SaleStakeholder found.
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Marquardt-Bashirian",
  "Comment": "quas",
  "StakeholderRoleId": 976,
  "CountryId": 536,
  "PersonId": 184,
  "EmailDescription": "leo.gleichner@wittingledner.biz",
  "EmailId": 784,
  "EmailAddress": "evalyn@gleason.us",
  "PhoneId": 516,
  "ContactName": "Adams Inc and Sons",
  "ContactId": 364,
  "SaleId": 560,
  "Mrmrs": "ducimus",
  "Firstname": "Rachel",
  "MiddleName": "Torp, Kemmer and Zboncak",
  "Lastname": "Zieme",
  "SaleStakeholderId": 269,
  "Rank": 737,
  "Phone": "817-808-6117",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 13
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
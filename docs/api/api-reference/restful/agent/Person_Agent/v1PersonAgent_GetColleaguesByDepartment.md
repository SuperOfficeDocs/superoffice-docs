---
title: GetColleaguesByDepartment
id: v1PersonAgent_GetColleaguesByDepartment
---

# GetColleaguesByDepartment

```http
POST /api/v1/Agents/Person/GetColleaguesByDepartment
```

Gets the persons working in a specific department in the same company as the logged on user.

Departments can be retrieved with the PhoneList.DepartmentList service.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetColleaguesByDepartment?$select=name,department,category/id
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

DepartmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DepartmentId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Position | string | The position. This is a predefined SuperOffice value, different from Title |
| PersonId | int32 | Primary key |
| Mrmrs | string | e.g. Mrs   sex_title |
| Firstname | string | First name |
| Lastname | string | Last name |
| MiddleName | string | Middle name or 'van' etc. |
| Title | string | Title |
| Description | string | Info text/description on person. |
| Email | string | First email on contact person. |
| FullName | string | Get the persons full name (internal name used in clients for employees). |
| DirectPhone | string | Returns the direct phone that belong to the contact person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| CountryId | int32 | Country |
| ContactId | int32 | Owning contact ID |
| ContactName | string | The persons company name |
| Retired | int32 | 1 = the user is retired and should have no rights, not appear in lists, etc. |
| Rank | int32 | Display sort sequence for default sort order |
| ActiveInterests | int32 | Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true |
| ContactDepartment | string | The persons contact department |
| ContactCountryId | int32 | The persons contact country id |
| ContactOrgNr | string | The persons contact organization number |
| FaxPhone | string | Returns the fax phone that belong to the contact person. |
| MobilePhone | string | Returns the mobile phone that belong to the contact person. |
| ContactPhone | string | Returns the direct phone that belong to the persons contact. |
| AssociateName | string | Name of the person's owner |
| AssociateId | int32 | Id of the item's owner (Associate id) |
| UsePersonAddress | bool | If 1, use person's address for mailing instead of company address |
| ContactFax | string | Actual phone number as eneterd by the user |
| Kanafname | string | Kana first name, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post3 | string | Postal address, used in Japanese versions only |
| EmailName | string | E-mail description |
| ContactFullName | string | Company full name + department |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| TicketPriorityId | int32 | Ticket priority ID |
| SupportLanguageId | int32 | Support priority ID |
| SupportAssociateId | int32 | Our support contact for this person |
| CategoryName | string | The category list item name |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetColleaguesByDepartment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DepartmentId": 64
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Position": "numquam",
    "PersonId": 880,
    "Mrmrs": "perspiciatis",
    "Firstname": "Max",
    "Lastname": "Runolfsdottir",
    "MiddleName": "Schulist-Bins",
    "Title": "dolore",
    "Description": "Optimized clear-thinking utilisation",
    "Email": "shaun_bruen@weissnat.info",
    "FullName": "Mariano Hessel II",
    "DirectPhone": "(783)378-1311 x263",
    "FormalName": "Kling LLC",
    "CountryId": 29,
    "ContactId": 497,
    "ContactName": "Stark-Schroeder",
    "Retired": 354,
    "Rank": 36,
    "ActiveInterests": 65,
    "ContactDepartment": "",
    "ContactCountryId": 364,
    "ContactOrgNr": "1393293",
    "FaxPhone": "661.325.7574",
    "MobilePhone": "055.643.6842 x117",
    "ContactPhone": "648-313-5184 x402",
    "AssociateName": "Hills LLC",
    "AssociateId": 908,
    "UsePersonAddress": true,
    "ContactFax": "maiores",
    "Kanafname": "velit",
    "Kanalname": "nisi",
    "Post1": "facere",
    "Post2": "atque",
    "Post3": "aspernatur",
    "EmailName": "kathryn.wilderman@danielswift.us",
    "ContactFullName": "Alyson Bahringer",
    "ActiveErpLinks": 898,
    "TicketPriorityId": 641,
    "SupportLanguageId": 122,
    "SupportAssociateId": 229,
    "CategoryName": "VIP Customer",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "deliver real-time applications"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 811
      }
    }
  }
]
```
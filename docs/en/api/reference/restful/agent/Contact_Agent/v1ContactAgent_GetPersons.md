---
title: POST Agents/Contact/GetPersons
uid: v1ContactAgent_GetPersons
generated: true
content_type: reference
---

# POST Agents/Contact/GetPersons

```http
POST /api/v1/Agents/Contact/GetPersons
```

Returns an array of all the contact persons for the company card.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| PersonNumber | string | Alphanumeric user field |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 617
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Position": "consequatur",
    "PersonId": 32,
    "Mrmrs": "eveniet",
    "Firstname": "Araceli",
    "Lastname": "Shanahan",
    "MiddleName": "Kub, Price and Greenfelder",
    "Title": "reprehenderit",
    "Description": "Phased local emulation",
    "Email": "cleo@brekke.uk",
    "FullName": "Abby Crona",
    "DirectPhone": "(298)466-3649 x924",
    "FormalName": "Strosin-Lebsack",
    "CountryId": 464,
    "ContactId": 882,
    "ContactName": "Dietrich Group",
    "Retired": 666,
    "Rank": 950,
    "ActiveInterests": 200,
    "ContactDepartment": "",
    "ContactCountryId": 771,
    "ContactOrgNr": "1702130",
    "FaxPhone": "678-773-7279 x0113",
    "MobilePhone": "(303)910-8042 x40073",
    "ContactPhone": "895-695-3901 x9502",
    "AssociateName": "Gleichner, Schmitt and Runte",
    "AssociateId": 906,
    "UsePersonAddress": true,
    "ContactFax": "voluptate",
    "Kanafname": "autem",
    "Kanalname": "ex",
    "Post1": "molestiae",
    "Post2": "debitis",
    "Post3": "sed",
    "EmailName": "jaylan.oreilly@collinswitting.com",
    "ContactFullName": "Aric Fisher",
    "ActiveErpLinks": 993,
    "TicketPriorityId": 102,
    "SupportLanguageId": 937,
    "SupportAssociateId": 911,
    "CategoryName": "VIP Customer",
    "PersonNumber": "740038",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 759
      }
    }
  }
]
```
---
title: GET Person/{id}/Simple
id: v1PersonEntity_Simple
---

# GET Person/{id}/Simple

```http
GET /api/v1/Person/{id}/Simple
```

A simple Person object.

This is a simpler, smaller variation of the full PersonEntity. Calls the Person agent service GetPerson.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Person to return. **Required** |



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


## Response: object

Carrier object for Person.
Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 404 | Not Found. |

Response body: object

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
GET /api/v1/Person/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8

{
  "Position": "dicta",
  "PersonId": 368,
  "Mrmrs": "quidem",
  "Firstname": "Cale",
  "Lastname": "Ortiz",
  "MiddleName": "Veum-Jacobson",
  "Title": "dolorem",
  "Description": "Assimilated logistical knowledge base",
  "Email": "horacio_deckow@macejkovic.us",
  "FullName": "Alfonzo Becker",
  "DirectPhone": "027.068.8162 x305",
  "FormalName": "Kreiger-Steuber",
  "CountryId": 226,
  "ContactId": 754,
  "ContactName": "Langworth-Sanford",
  "Retired": 468,
  "Rank": 9,
  "ActiveInterests": 147,
  "ContactDepartment": "",
  "ContactCountryId": 675,
  "ContactOrgNr": "408691",
  "FaxPhone": "075-003-6500 x15301",
  "MobilePhone": "111.530.5447",
  "ContactPhone": "257.056.3537 x840",
  "AssociateName": "Gerlach, Buckridge and Pfeffer",
  "AssociateId": 411,
  "UsePersonAddress": false,
  "ContactFax": "et",
  "Kanafname": "aut",
  "Kanalname": "excepturi",
  "Post1": "deserunt",
  "Post2": "eaque",
  "Post3": "explicabo",
  "EmailName": "dianna_keebler@greenholt.info",
  "ContactFullName": "Glen Schamberger",
  "ActiveErpLinks": 369,
  "TicketPriorityId": 223,
  "SupportLanguageId": 640,
  "SupportAssociateId": 125,
  "CategoryName": "VIP Customer",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "matrix visionary partnerships"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 415
    }
  }
}
```
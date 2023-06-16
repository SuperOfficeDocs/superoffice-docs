---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
---

# POST Contact/Validate

```http
POST /api/v1/Contact/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: contactEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 327,
  "Name": "Braun-Barrows",
  "Department": "",
  "OrgNr": "1091194",
  "Number1": "674874",
  "Number2": "737510",
  "UpdatedDate": "2000-02-01T16:00:47.8053524+01:00",
  "CreatedDate": "2023-02-07T16:00:47.8053524+01:00",
  "Emails": [
    {
      "Value": "adipisci",
      "StrippedValue": "delectus",
      "Description": "Multi-channelled local installation"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "delectus",
      "Description": "Multi-channelled local installation"
    }
  ],
  "Interests": [
    {
      "Id": 655,
      "Name": "Kihn, Wisoky and Rosenbaum",
      "ToolTip": "Et perspiciatis amet minus numquam autem repellendus labore.",
      "Deleted": false,
      "Rank": 537,
      "Type": "praesentium",
      "ColorBlock": 334,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2010-06-13T16:00:47.8053524+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "maxime",
      "Hidden": true,
      "FullName": "Amira Johnson"
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "aut",
      "Description": "Optimized reciprocal database"
    },
    {
      "Value": "rerum",
      "StrippedValue": "aut",
      "Description": "Optimized reciprocal database"
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "quia",
      "Description": "Face to face attitude-oriented pricing structure"
    },
    {
      "Value": "id",
      "StrippedValue": "quia",
      "Description": "Face to face attitude-oriented pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "et",
      "Description": "Persistent uniform framework"
    },
    {
      "Value": "quae",
      "StrippedValue": "et",
      "Description": "Persistent uniform framework"
    }
  ],
  "Description": "Team-oriented reciprocal artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "architecto",
      "PersonId": 875,
      "Mrmrs": "tempore",
      "Firstname": "Mikel",
      "Lastname": "Vandervort",
      "MiddleName": "Macejkovic, Pfannerstill and Murray",
      "Title": "eveniet",
      "Description": "Intuitive object-oriented orchestration",
      "Email": "erna@spinka.uk",
      "FullName": "Dr. Keagan King",
      "DirectPhone": "652-899-1239 x1798",
      "FormalName": "Marvin LLC",
      "CountryId": 752,
      "ContactId": 924,
      "ContactName": "Hodkiewicz Inc and Sons",
      "Retired": 627,
      "Rank": 16,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 348,
      "ContactOrgNr": "460141",
      "FaxPhone": "967.943.7656",
      "MobilePhone": "630-899-5524",
      "ContactPhone": "642-671-8742",
      "AssociateName": "Stark, Adams and Prohaska",
      "AssociateId": 257,
      "UsePersonAddress": false,
      "ContactFax": "sequi",
      "Kanafname": "dolorem",
      "Kanalname": "eaque",
      "Post1": "explicabo",
      "Post2": "voluptatem",
      "Post3": "alias",
      "EmailName": "enid_raynor@beatty.biz",
      "ContactFullName": "Edd Christiansen",
      "ActiveErpLinks": 92,
      "TicketPriorityId": 283,
      "SupportLanguageId": 938,
      "SupportAssociateId": 810,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 602,
  "GroupId": 342,
  "ActiveStatusMonitorId": 457,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 150,
  "DbiAgentId": 705,
  "DbiLastSyncronized": "2017-12-24T16:00:47.8053524+01:00",
  "DbiKey": "provident",
  "DbiLastModified": "2017-04-11T16:00:47.8053524+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 853,
  "ActiveErpLinks": 379,
  "BounceEmails": [
    "milford.bogisich@beer.us",
    "elwyn_mitchell@schroeder.us"
  ],
  "Domains": [
    "libero",
    "harum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "337975637"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "maiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "fugit"
}
```
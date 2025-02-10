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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 790,
  "Name": "Fisher, Schaden and Conn",
  "Department": "",
  "OrgNr": "744074",
  "Number1": "1217997",
  "Number2": "1253086",
  "UpdatedDate": "2011-02-25T12:01:32.8238054+01:00",
  "CreatedDate": "2011-02-18T12:01:32.8238054+01:00",
  "Emails": [
    {
      "Value": "itaque",
      "StrippedValue": "officiis",
      "Description": "Innovative systemic contingency"
    },
    {
      "Value": "itaque",
      "StrippedValue": "officiis",
      "Description": "Innovative systemic contingency"
    }
  ],
  "Interests": [
    {
      "Id": 950,
      "Name": "Terry-Welch",
      "ToolTip": "Porro in dolor qui perferendis.",
      "Deleted": true,
      "Rank": 977,
      "Type": "et",
      "ColorBlock": 15,
      "IconHint": "aspernatur",
      "Selected": true,
      "LastChanged": "2024-02-24T12:01:32.8238054+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "earum",
      "StyleHint": "repudiandae",
      "Hidden": false,
      "FullName": "Maryjane Jacobi DVM"
    }
  ],
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "quaerat",
      "Description": "Reverse-engineered demand-driven core"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "quaerat",
      "Description": "Reverse-engineered demand-driven core"
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "consequuntur",
      "Description": "Profit-focused global attitude"
    },
    {
      "Value": "vel",
      "StrippedValue": "consequuntur",
      "Description": "Profit-focused global attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "quis",
      "Description": "Right-sized regional structure"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quis",
      "Description": "Right-sized regional structure"
    }
  ],
  "Description": "Pre-emptive web-enabled initiative",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 363,
      "Mrmrs": "sapiente",
      "Firstname": "Tillman",
      "Lastname": "Conroy",
      "MiddleName": "Mraz, Goodwin and Kris",
      "Title": "vel",
      "Description": "Open-architected reciprocal concept",
      "Email": "esmeralda@abbott.ca",
      "FullName": "Destinee Wilhelm Prosacco PhD",
      "DirectPhone": "061-763-8847",
      "FormalName": "Swift, Hand and Rosenbaum",
      "CountryId": 792,
      "ContactId": 881,
      "ContactName": "Ebert Group",
      "Retired": 916,
      "Rank": 21,
      "ActiveInterests": 288,
      "ContactDepartment": "",
      "ContactCountryId": 949,
      "ContactOrgNr": "743477",
      "FaxPhone": "1-439-983-7236",
      "MobilePhone": "(947)686-7492 x4076",
      "ContactPhone": "1-088-102-2345 x37494",
      "AssociateName": "Toy, Emmerich and Hills",
      "AssociateId": 985,
      "UsePersonAddress": true,
      "ContactFax": "suscipit",
      "Kanafname": "accusantium",
      "Kanalname": "vitae",
      "Post1": "recusandae",
      "Post2": "quia",
      "Post3": "aut",
      "EmailName": "shanelle@barrowshowell.uk",
      "ContactFullName": "Logan Turner",
      "ActiveErpLinks": 371,
      "TicketPriorityId": 564,
      "SupportLanguageId": 794,
      "SupportAssociateId": 901,
      "CategoryName": "VIP Customer",
      "PersonNumber": "561917"
    }
  ],
  "NoMailing": false,
  "Kananame": "repellat",
  "Xstop": false,
  "ActiveInterests": 830,
  "GroupId": 818,
  "ActiveStatusMonitorId": 370,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 272,
  "DbiAgentId": 458,
  "DbiLastSyncronized": "1999-01-17T12:01:32.8238054+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2003-09-08T12:01:32.8238054+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 542,
  "ActiveErpLinks": 834,
  "BounceEmails": [
    "nicklaus@collinsbergstrom.name",
    "kaylah@medhurst.com"
  ],
  "Domains": [
    "reprehenderit",
    "molestias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Julia Yundt PhD",
    "SuperOffice:2": "Linnie Wyman"
  },
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "doloremque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "repudiandae",
  "2": "rerum"
}
```
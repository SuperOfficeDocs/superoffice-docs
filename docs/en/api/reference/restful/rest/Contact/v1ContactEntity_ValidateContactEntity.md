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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 671,
  "Name": "Kohler, Reilly and Ruecker",
  "Department": "mesh frictionless models",
  "OrgNr": "434873",
  "Number1": "1401413",
  "Number2": "534827",
  "UpdatedDate": "2008-05-28T14:13:48.569529+02:00",
  "CreatedDate": "2014-02-14T14:13:48.569529+01:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "aperiam",
      "Description": "Quality-focused even-keeled monitoring"
    },
    {
      "Value": "sit",
      "StrippedValue": "aperiam",
      "Description": "Quality-focused even-keeled monitoring"
    }
  ],
  "Interests": [
    {
      "Id": 278,
      "Name": "Sanford Group",
      "ToolTip": "Unde et qui blanditiis.",
      "Deleted": false,
      "Rank": 593,
      "Type": "ducimus",
      "ColorBlock": 69,
      "IconHint": "temporibus",
      "Selected": true,
      "LastChanged": "2009-01-30T14:13:48.569529+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Mrs. Rodrigo Borer I"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "eligendi",
      "Description": "Seamless multimedia function"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "eligendi",
      "Description": "Seamless multimedia function"
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "rerum",
      "Description": "Quality-focused assymetric Graphic Interface"
    },
    {
      "Value": "et",
      "StrippedValue": "rerum",
      "Description": "Quality-focused assymetric Graphic Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "sunt",
      "Description": "Inverse static Graphic Interface"
    },
    {
      "Value": "sed",
      "StrippedValue": "sunt",
      "Description": "Inverse static Graphic Interface"
    }
  ],
  "Description": "Future-proofed intermediate complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolor",
      "PersonId": 898,
      "Mrmrs": "et",
      "Firstname": "Milan",
      "Lastname": "Steuber",
      "MiddleName": "Borer, Dicki and Wolf",
      "Title": "veniam",
      "Description": "Organized holistic task-force",
      "Email": "russell@harvey.ca",
      "FullName": "Vern Volkman",
      "DirectPhone": "859.203.9962 x2083",
      "FormalName": "Hamill-Maggio",
      "CountryId": 908,
      "ContactId": 76,
      "ContactName": "Metz, Doyle and Price",
      "Retired": 626,
      "Rank": 437,
      "ActiveInterests": 71,
      "ContactDepartment": "",
      "ContactCountryId": 445,
      "ContactOrgNr": "963225",
      "FaxPhone": "1-720-644-8281 x817",
      "MobilePhone": "733-329-4197 x3468",
      "ContactPhone": "232-882-1995 x73893",
      "AssociateName": "Boyle Inc and Sons",
      "AssociateId": 508,
      "UsePersonAddress": false,
      "ContactFax": "excepturi",
      "Kanafname": "ea",
      "Kanalname": "illum",
      "Post1": "id",
      "Post2": "voluptates",
      "Post3": "facilis",
      "EmailName": "micaela@okeefe.info",
      "ContactFullName": "Laney Reichert",
      "ActiveErpLinks": 915,
      "TicketPriorityId": 739,
      "SupportLanguageId": 582,
      "SupportAssociateId": 269,
      "CategoryName": "VIP Customer",
      "PersonNumber": "677153"
    }
  ],
  "NoMailing": false,
  "Kananame": "totam",
  "Xstop": true,
  "ActiveInterests": 132,
  "GroupId": 779,
  "ActiveStatusMonitorId": 954,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 657,
  "DbiAgentId": 746,
  "DbiLastSyncronized": "2005-06-01T14:13:48.5851503+02:00",
  "DbiKey": "vitae",
  "DbiLastModified": "2017-06-07T14:13:48.5851503+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 32,
  "ActiveErpLinks": 514,
  "BounceEmails": [
    "bethany@jaskolski.info",
    "matteo.kulas@kris.com"
  ],
  "Domains": [
    "soluta",
    "reiciendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Orie Corwin",
    "SuperOffice:2": "775072112"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "nam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "illum",
  "2": "soluta"
}
```
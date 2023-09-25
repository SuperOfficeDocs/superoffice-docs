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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 409,
  "Name": "Greenholt Group",
  "Department": "",
  "OrgNr": "261487",
  "Number1": "947942",
  "Number2": "764838",
  "UpdatedDate": "2022-04-16T03:24:51.52124+02:00",
  "CreatedDate": "2015-05-08T03:24:51.52124+02:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "voluptas",
      "Description": "Diverse eco-centric synergy"
    },
    {
      "Value": "dolores",
      "StrippedValue": "voluptas",
      "Description": "Diverse eco-centric synergy"
    }
  ],
  "Interests": [
    {
      "Id": 511,
      "Name": "Runolfsson, Lindgren and Beer",
      "ToolTip": "Rerum iusto perferendis error optio numquam.",
      "Deleted": true,
      "Rank": 347,
      "Type": "minus",
      "ColorBlock": 800,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "2012-04-02T03:24:51.52124+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Candelario Price"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Virtual incremental open architecture"
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Virtual incremental open architecture"
    }
  ],
  "Phones": [
    {
      "Value": "a",
      "StrippedValue": "nihil",
      "Description": "Self-enabling multimedia analyzer"
    },
    {
      "Value": "a",
      "StrippedValue": "nihil",
      "Description": "Self-enabling multimedia analyzer"
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "libero",
      "Description": "Multi-layered intermediate neural-net"
    },
    {
      "Value": "labore",
      "StrippedValue": "libero",
      "Description": "Multi-layered intermediate neural-net"
    }
  ],
  "Description": "Managed motivating task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 668,
      "Mrmrs": "accusamus",
      "Firstname": "Omari",
      "Lastname": "Nolan",
      "MiddleName": "Boyle-Rogahn",
      "Title": "suscipit",
      "Description": "Multi-channelled background throughput",
      "Email": "burley@feeneyskiles.name",
      "FullName": "Ahmad Strosin",
      "DirectPhone": "1-861-867-8584 x24473",
      "FormalName": "Rippin Inc and Sons",
      "CountryId": 833,
      "ContactId": 849,
      "ContactName": "Legros, Stracke and Johnston",
      "Retired": 187,
      "Rank": 294,
      "ActiveInterests": 339,
      "ContactDepartment": "monetize out-of-the-box e-tailers",
      "ContactCountryId": 224,
      "ContactOrgNr": "1064095",
      "FaxPhone": "1-026-622-3811",
      "MobilePhone": "770.094.6222",
      "ContactPhone": "863.496.1280 x0573",
      "AssociateName": "Bogan-Watsica",
      "AssociateId": 312,
      "UsePersonAddress": false,
      "ContactFax": "assumenda",
      "Kanafname": "error",
      "Kanalname": "quae",
      "Post1": "delectus",
      "Post2": "rerum",
      "Post3": "numquam",
      "EmailName": "tianna@davisgleason.uk",
      "ContactFullName": "Leif Schimmel",
      "ActiveErpLinks": 843,
      "TicketPriorityId": 286,
      "SupportLanguageId": 624,
      "SupportAssociateId": 955,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "placeat",
  "Xstop": false,
  "ActiveInterests": 185,
  "GroupId": 940,
  "ActiveStatusMonitorId": 244,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 717,
  "DbiAgentId": 388,
  "DbiLastSyncronized": "2013-08-12T03:24:51.52124+02:00",
  "DbiKey": "maxime",
  "DbiLastModified": "2007-09-14T03:24:51.52124+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 246,
  "ActiveErpLinks": 164,
  "BounceEmails": [
    "genoveva@eichmann.biz",
    "felicity.funk@runolfsson.us"
  ],
  "Domains": [
    "qui",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Trevion Thompson",
    "SuperOffice:2": "Miss Derrick Sanford"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "veritatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "nostrum"
}
```
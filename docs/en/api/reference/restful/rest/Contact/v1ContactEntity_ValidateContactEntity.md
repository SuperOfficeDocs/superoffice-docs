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
  "ContactId": 131,
  "Name": "Prohaska, Boyer and Howell",
  "Department": "",
  "OrgNr": "1003346",
  "Number1": "580127",
  "Number2": "929945",
  "UpdatedDate": "2015-01-27T13:14:08.5866221+01:00",
  "CreatedDate": "2005-01-20T13:14:08.5866221+01:00",
  "Emails": [
    {
      "Value": "quidem",
      "StrippedValue": "libero",
      "Description": "Face to face zero defect project"
    },
    {
      "Value": "quidem",
      "StrippedValue": "libero",
      "Description": "Face to face zero defect project"
    }
  ],
  "Interests": [
    {
      "Id": 695,
      "Name": "White-Kuhlman",
      "ToolTip": "Similique ea animi nesciunt sequi modi dolorem.",
      "Deleted": false,
      "Rank": 653,
      "Type": "quidem",
      "ColorBlock": 936,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2025-03-13T13:14:08.5866221+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Ismael Wunsch"
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Function-based solution-oriented knowledge base"
    },
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Function-based solution-oriented knowledge base"
    }
  ],
  "Phones": [
    {
      "Value": "libero",
      "StrippedValue": "doloremque",
      "Description": "Up-sized logistical implementation"
    },
    {
      "Value": "libero",
      "StrippedValue": "doloremque",
      "Description": "Up-sized logistical implementation"
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "asperiores",
      "Description": "Profound explicit function"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "asperiores",
      "Description": "Profound explicit function"
    }
  ],
  "Description": "Balanced next generation functionalities",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "possimus",
      "PersonId": 857,
      "Mrmrs": "voluptas",
      "Firstname": "Lazaro",
      "Lastname": "Monahan",
      "MiddleName": "Heathcote, Bednar and Torphy",
      "Title": "dolorem",
      "Description": "Focused value-added infrastructure",
      "Email": "allie.beatty@feeney.biz",
      "FullName": "Hector Thompson",
      "DirectPhone": "423.026.8413",
      "FormalName": "Torphy-Braun",
      "CountryId": 867,
      "ContactId": 860,
      "ContactName": "Nicolas, Tillman and Mills",
      "Retired": 275,
      "Rank": 122,
      "ActiveInterests": 177,
      "ContactDepartment": "",
      "ContactCountryId": 10,
      "ContactOrgNr": "1594236",
      "FaxPhone": "724-422-3345 x7481",
      "MobilePhone": "809-080-4029",
      "ContactPhone": "(973)315-9418 x02949",
      "AssociateName": "Cole, Gorczany and Crona",
      "AssociateId": 284,
      "UsePersonAddress": false,
      "ContactFax": "quae",
      "Kanafname": "cum",
      "Kanalname": "ratione",
      "Post1": "consequatur",
      "Post2": "esse",
      "Post3": "reprehenderit",
      "EmailName": "woodrow.considine@hagenesmann.co.uk",
      "ContactFullName": "Irwin Stracke",
      "ActiveErpLinks": 922,
      "TicketPriorityId": 241,
      "SupportLanguageId": 489,
      "SupportAssociateId": 922,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1338999"
    }
  ],
  "NoMailing": false,
  "Kananame": "perferendis",
  "Xstop": false,
  "ActiveInterests": 825,
  "GroupId": 693,
  "ActiveStatusMonitorId": 927,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 533,
  "DbiAgentId": 50,
  "DbiLastSyncronized": "2014-10-01T13:14:08.6022481+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2021-08-01T13:14:08.6022481+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 378,
  "ActiveErpLinks": 713,
  "BounceEmails": [
    "amya@abernathy.biz",
    "haven_will@purdy.ca"
  ],
  "Domains": [
    "autem",
    "aperiam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Ulices Roberto Kohler Jr.",
    "SuperOffice:2": "Ulices Murazik"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "unde"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "dolor",
  "2": "saepe"
}
```
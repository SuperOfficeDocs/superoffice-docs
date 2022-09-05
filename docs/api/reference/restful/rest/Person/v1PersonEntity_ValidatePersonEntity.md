---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
---

# POST Person/Validate

```http
POST /api/v1/Person/Validate
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

## Request Body: personEntity  

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 635,
  "Firstname": "Carleton",
  "MiddleName": "Bashirian-Reynolds",
  "Lastname": "Douglas",
  "Mrmrs": "eligendi",
  "Title": "eligendi",
  "UpdatedDate": "1995-05-10T11:10:53.0321791+02:00",
  "CreatedDate": "2004-04-05T11:10:53.0321791+02:00",
  "BirthDate": "2021-08-13T11:10:53.0321791+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "placeat",
      "StrippedValue": "consequatur",
      "Description": "Multi-channelled even-keeled intranet"
    },
    {
      "Value": "placeat",
      "StrippedValue": "consequatur",
      "Description": "Multi-channelled even-keeled intranet"
    }
  ],
  "Description": "Distributed multimedia superstructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nemo",
      "StrippedValue": "corrupti",
      "Description": "Networked secondary leverage"
    },
    {
      "Value": "nemo",
      "StrippedValue": "corrupti",
      "Description": "Networked secondary leverage"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "perferendis",
      "Description": "Mandatory interactive superstructure"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "perferendis",
      "Description": "Mandatory interactive superstructure"
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Team-oriented hybrid contingency"
    },
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Team-oriented hybrid contingency"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quas",
      "StrippedValue": "qui",
      "Description": "Front-line systemic attitude"
    },
    {
      "Value": "quas",
      "StrippedValue": "qui",
      "Description": "Front-line systemic attitude"
    }
  ],
  "OtherPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "est",
      "Description": "Ameliorated national data-warehouse"
    },
    {
      "Value": "rerum",
      "StrippedValue": "est",
      "Description": "Ameliorated national data-warehouse"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 843,
      "Name": "Bartoletti-Purdy",
      "ToolTip": "Distinctio a ut optio debitis sit sit natus.",
      "Deleted": false,
      "Rank": 437,
      "Type": "asperiores",
      "ColorBlock": 729,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "2020-02-10T11:10:53.0351461+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dicta",
      "StyleHint": "aliquam",
      "Hidden": false,
      "FullName": "Gracie Funk"
    }
  ],
  "PersonNumber": "1192326",
  "FullName": "Vesta Satterfield",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Persevering methodical monitoring"
    },
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Persevering methodical monitoring"
    }
  ],
  "FormalName": "Schimmel, Weber and Weissnat",
  "Address": null,
  "Post3": "iusto",
  "Post2": "aliquam",
  "Post1": "voluptate",
  "Kanalname": "ea",
  "Kanafname": "sequi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quod",
  "ActiveInterests": 206,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 2,
  "DbiKey": "et",
  "DbiLastModified": "1997-06-20T11:10:53.0371455+02:00",
  "DbiLastSyncronized": "2021-10-22T11:10:53.0371455+02:00",
  "SentInfo": 483,
  "ShowContactTickets": 391,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "incidunt",
      "StrippedValue": "sint",
      "Description": "Right-sized user-facing encryption"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "sint",
      "Description": "Right-sized user-facing encryption"
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Inverse well-modulated time-frame"
    },
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Inverse well-modulated time-frame"
    }
  ],
  "Source": 627,
  "ActiveErpLinks": 703,
  "ShipmentTypes": [
    {
      "Id": 544,
      "Name": "Ritchie-Quitzon",
      "ToolTip": "Id ad voluptas rerum.",
      "Deleted": false,
      "Rank": 776,
      "Type": "vero",
      "ColorBlock": 778,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2020-06-26T11:10:53.0381732+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Prof. Erik Chaim Schulist Sr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 996,
      "Comment": "saepe",
      "Registered": "1999-02-09T11:10:53.0381732+01:00",
      "RegisteredAssociateId": 990,
      "Updated": "2000-06-21T11:10:53.0381732+02:00",
      "UpdatedAssociateId": 200,
      "LegalBaseId": 591,
      "LegalBaseKey": "illo",
      "LegalBaseName": "Nolan LLC",
      "ConsentPurposeId": 135,
      "ConsentPurposeKey": "molestiae",
      "ConsentPurposeName": "Haag, Ernser and Bogan",
      "ConsentSourceId": 934,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Mitchell-Stoltenberg"
    }
  ],
  "BounceEmails": [
    "nora@heathcote.uk",
    "eldridge.christiansen@schummlockman.name"
  ],
  "ActiveStatusMonitorId": 778,
  "UserDefinedFields": {
    "SuperOffice:1": "Coy Hyatt",
    "SuperOffice:2": "1632233200"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "sunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "qui",
  "2": "maiores"
}
```
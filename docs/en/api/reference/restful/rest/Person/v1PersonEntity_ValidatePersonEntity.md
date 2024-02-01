---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
generated: true
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
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 286,
  "Firstname": "Alfonzo",
  "MiddleName": "Altenwerth LLC",
  "Lastname": "Bailey",
  "Mrmrs": "quos",
  "Title": "officiis",
  "UpdatedDate": "2006-01-07T23:04:04.3605163+01:00",
  "CreatedDate": "1997-12-31T23:04:04.3605163+01:00",
  "BirthDate": "2001-09-15T23:04:04.3605163+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "veniam",
      "Description": "Automated optimizing local area network"
    },
    {
      "Value": "nam",
      "StrippedValue": "veniam",
      "Description": "Automated optimizing local area network"
    }
  ],
  "Description": "Networked uniform local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "saepe",
      "StrippedValue": "quaerat",
      "Description": "Persistent discrete help-desk"
    },
    {
      "Value": "saepe",
      "StrippedValue": "quaerat",
      "Description": "Persistent discrete help-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "provident",
      "Description": "Integrated real-time framework"
    },
    {
      "Value": "quo",
      "StrippedValue": "provident",
      "Description": "Integrated real-time framework"
    }
  ],
  "MobilePhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "sit",
      "Description": "User-friendly zero defect process improvement"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "sit",
      "Description": "User-friendly zero defect process improvement"
    }
  ],
  "OfficePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "impedit",
      "Description": "Reduced multi-state application"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "impedit",
      "Description": "Reduced multi-state application"
    }
  ],
  "OtherPhones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "earum",
      "Description": "Front-line multimedia toolset"
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "earum",
      "Description": "Front-line multimedia toolset"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 925,
      "Name": "Kessler, Goldner and Considine",
      "ToolTip": "Quo velit maxime commodi id nam.",
      "Deleted": false,
      "Rank": 764,
      "Type": "dolor",
      "ColorBlock": 877,
      "IconHint": "sequi",
      "Selected": false,
      "LastChanged": "2014-06-11T23:04:04.3640173+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Bernard McKenzie"
    }
  ],
  "PersonNumber": "594277",
  "FullName": "Christina Purdy",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Cross-group human-resource middleware"
    },
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Cross-group human-resource middleware"
    }
  ],
  "FormalName": "Grimes, Wilderman and Bednar",
  "Address": null,
  "Post3": "exercitationem",
  "Post2": "non",
  "Post1": "velit",
  "Kanalname": "autem",
  "Kanafname": "pariatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sunt",
  "ActiveInterests": 579,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 271,
  "DbiKey": "maiores",
  "DbiLastModified": "1997-06-24T23:04:04.3675143+02:00",
  "DbiLastSyncronized": "2007-11-29T23:04:04.3675143+01:00",
  "SentInfo": 452,
  "ShowContactTickets": 890,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Innovative stable task-force"
    },
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Innovative stable task-force"
    }
  ],
  "InternetPhones": [
    {
      "Value": "nemo",
      "StrippedValue": "velit",
      "Description": "Customer-focused directional complexity"
    },
    {
      "Value": "nemo",
      "StrippedValue": "velit",
      "Description": "Customer-focused directional complexity"
    }
  ],
  "Source": 778,
  "ActiveErpLinks": 591,
  "ShipmentTypes": [
    {
      "Id": 616,
      "Name": "Dickens LLC",
      "ToolTip": "Mollitia aut deleniti.",
      "Deleted": false,
      "Rank": 430,
      "Type": "voluptas",
      "ColorBlock": 795,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2019-03-15T23:04:04.3680144+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "porro",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Adelle Renner"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 275,
      "Comment": "odio",
      "Registered": "2019-12-18T23:04:04.3680144+01:00",
      "RegisteredAssociateId": 744,
      "Updated": "1999-09-10T23:04:04.3680144+02:00",
      "UpdatedAssociateId": 978,
      "LegalBaseId": 713,
      "LegalBaseKey": "at",
      "LegalBaseName": "Medhurst Group",
      "ConsentPurposeId": 452,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Dietrich, Deckow and Konopelski",
      "ConsentSourceId": 623,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Wuckert, Ratke and Davis"
    }
  ],
  "BounceEmails": [
    "michele@watsicalittle.name",
    "maeve_kiehn@morarlittel.biz"
  ],
  "ActiveStatusMonitorId": 850,
  "UserDefinedFields": {
    "SuperOffice:1": "1280713088",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "ducimus"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "veniam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "cumque",
  "2": "voluptas"
}
```
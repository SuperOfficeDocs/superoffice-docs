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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
  "PersonId": 816,
  "Firstname": "Henri",
  "MiddleName": "Kertzmann-Robel",
  "Lastname": "Stanton",
  "Mrmrs": "rerum",
  "Title": "atque",
  "UpdatedDate": "1999-07-02T02:38:26.1829353+02:00",
  "CreatedDate": "2016-04-20T02:38:26.1829353+02:00",
  "BirthDate": "2022-04-30T02:38:26.1829353+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "accusamus",
      "Description": "Versatile assymetric ability"
    },
    {
      "Value": "rem",
      "StrippedValue": "accusamus",
      "Description": "Versatile assymetric ability"
    }
  ],
  "Description": "Cross-platform even-keeled groupware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "in",
      "StrippedValue": "quisquam",
      "Description": "Stand-alone fault-tolerant firmware"
    },
    {
      "Value": "in",
      "StrippedValue": "quisquam",
      "Description": "Stand-alone fault-tolerant firmware"
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "explicabo",
      "Description": "Robust needs-based website"
    },
    {
      "Value": "porro",
      "StrippedValue": "explicabo",
      "Description": "Robust needs-based website"
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "quasi",
      "Description": "Re-engineered 4th generation budgetary management"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "quasi",
      "Description": "Re-engineered 4th generation budgetary management"
    }
  ],
  "OfficePhones": [
    {
      "Value": "illum",
      "StrippedValue": "et",
      "Description": "Horizontal methodical productivity"
    },
    {
      "Value": "illum",
      "StrippedValue": "et",
      "Description": "Horizontal methodical productivity"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ad",
      "StrippedValue": "sit",
      "Description": "Polarised context-sensitive capacity"
    },
    {
      "Value": "ad",
      "StrippedValue": "sit",
      "Description": "Polarised context-sensitive capacity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 114,
      "Name": "Konopelski-VonRueden",
      "ToolTip": "Et doloremque reprehenderit suscipit officiis asperiores.",
      "Deleted": false,
      "Rank": 326,
      "Type": "perferendis",
      "ColorBlock": 240,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2002-12-19T02:38:26.1829353+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Ms. Jefferey Sarah Hamill"
    }
  ],
  "PersonNumber": "1010293",
  "FullName": "Mrs. Arnulfo Christian Mann IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "officia",
      "StrippedValue": "fugiat",
      "Description": "Phased well-modulated model"
    },
    {
      "Value": "officia",
      "StrippedValue": "fugiat",
      "Description": "Phased well-modulated model"
    }
  ],
  "FormalName": "Brakus-Skiles",
  "Address": null,
  "Post3": "et",
  "Post2": "sit",
  "Post1": "quas",
  "Kanalname": "rerum",
  "Kanafname": "rerum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "repudiandae",
  "ActiveInterests": 559,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 948,
  "DbiKey": "accusantium",
  "DbiLastModified": "2004-06-14T02:38:26.1829353+02:00",
  "DbiLastSyncronized": "2007-01-25T02:38:26.1829353+01:00",
  "SentInfo": 52,
  "ShowContactTickets": 547,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "est",
      "Description": "Realigned next generation project"
    },
    {
      "Value": "sed",
      "StrippedValue": "est",
      "Description": "Realigned next generation project"
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "hic",
      "Description": "Business-focused background attitude"
    },
    {
      "Value": "omnis",
      "StrippedValue": "hic",
      "Description": "Business-focused background attitude"
    }
  ],
  "Source": 250,
  "ActiveErpLinks": 668,
  "ShipmentTypes": [
    {
      "Id": 344,
      "Name": "Conroy, Gleason and Wyman",
      "ToolTip": "Rem cupiditate sed sit ducimus enim ducimus eos.",
      "Deleted": false,
      "Rank": 889,
      "Type": "id",
      "ColorBlock": 658,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2008-09-02T02:38:26.1829353+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Paris Webster Bailey DDS"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 604,
      "Comment": "perspiciatis",
      "Registered": "2014-09-18T02:38:26.1829353+02:00",
      "RegisteredAssociateId": 721,
      "Updated": "2013-08-21T02:38:26.1829353+02:00",
      "UpdatedAssociateId": 126,
      "LegalBaseId": 820,
      "LegalBaseKey": "minima",
      "LegalBaseName": "Mayer-Gutkowski",
      "ConsentPurposeId": 755,
      "ConsentPurposeKey": "exercitationem",
      "ConsentPurposeName": "Robel Inc and Sons",
      "ConsentSourceId": 574,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Boyle, Schimmel and Heaney"
    }
  ],
  "BounceEmails": [
    "janis@hintzgrant.us",
    "abdullah.johnson@hansen.ca"
  ],
  "ActiveStatusMonitorId": 580,
  "CreatedByFormId": 571,
  "UserDefinedFields": {
    "SuperOffice:1": "Felton Garfield Rice II",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ullam",
  "2": "voluptas"
}
```
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
  "PersonId": 70,
  "Firstname": "Eliseo",
  "MiddleName": "Lakin Group",
  "Lastname": "Lebsack",
  "Mrmrs": "omnis",
  "Title": "suscipit",
  "UpdatedDate": "2011-06-18T03:45:28.4828085+02:00",
  "CreatedDate": "2006-08-07T03:45:28.4828085+02:00",
  "BirthDate": "2007-05-09T03:45:28.4828085+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "sit",
      "Description": "Triple-buffered systematic support"
    },
    {
      "Value": "fugiat",
      "StrippedValue": "sit",
      "Description": "Triple-buffered systematic support"
    }
  ],
  "Description": "Persevering client-server extranet",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "id",
      "StrippedValue": "corrupti",
      "Description": "Programmable motivating moderator"
    },
    {
      "Value": "id",
      "StrippedValue": "corrupti",
      "Description": "Programmable motivating moderator"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "veritatis",
      "Description": "Right-sized optimizing alliance"
    },
    {
      "Value": "non",
      "StrippedValue": "veritatis",
      "Description": "Right-sized optimizing alliance"
    }
  ],
  "MobilePhones": [
    {
      "Value": "alias",
      "StrippedValue": "error",
      "Description": "Grass-roots user-facing concept"
    },
    {
      "Value": "alias",
      "StrippedValue": "error",
      "Description": "Grass-roots user-facing concept"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "dolorem",
      "Description": "Cross-group exuding attitude"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "dolorem",
      "Description": "Cross-group exuding attitude"
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugit",
      "StrippedValue": "consectetur",
      "Description": "Front-line secondary parallelism"
    },
    {
      "Value": "fugit",
      "StrippedValue": "consectetur",
      "Description": "Front-line secondary parallelism"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 345,
      "Name": "Champlin Group",
      "ToolTip": "Molestias minima ut doloribus aut possimus est.",
      "Deleted": false,
      "Rank": 896,
      "Type": "quidem",
      "ColorBlock": 461,
      "IconHint": "eaque",
      "Selected": false,
      "LastChanged": "2011-01-13T03:45:28.4828085+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "tenetur",
      "Hidden": false,
      "FullName": "Daniela Cassin PhD"
    }
  ],
  "PersonNumber": "1169342",
  "FullName": "Dr. Melba Sylvan Goodwin",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "magni",
      "StrippedValue": "odio",
      "Description": "Digitized client-driven groupware"
    },
    {
      "Value": "magni",
      "StrippedValue": "odio",
      "Description": "Digitized client-driven groupware"
    }
  ],
  "FormalName": "Botsford, Baumbach and Toy",
  "Address": null,
  "Post3": "atque",
  "Post2": "itaque",
  "Post1": "nihil",
  "Kanalname": "voluptate",
  "Kanafname": "nobis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "itaque",
  "ActiveInterests": 78,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 811,
  "DbiKey": "aut",
  "DbiLastModified": "2014-03-02T03:45:28.4828085+01:00",
  "DbiLastSyncronized": "2002-10-26T03:45:28.4828085+02:00",
  "SentInfo": 271,
  "ShowContactTickets": 252,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolore",
      "StrippedValue": "exercitationem",
      "Description": "Secured directional Graphical User Interface"
    },
    {
      "Value": "dolore",
      "StrippedValue": "exercitationem",
      "Description": "Secured directional Graphical User Interface"
    }
  ],
  "InternetPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "ea",
      "Description": "Self-enabling user-facing archive"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "ea",
      "Description": "Self-enabling user-facing archive"
    }
  ],
  "Source": 928,
  "ActiveErpLinks": 515,
  "ShipmentTypes": [
    {
      "Id": 624,
      "Name": "Grady LLC",
      "ToolTip": "Nostrum nostrum aliquam.",
      "Deleted": true,
      "Rank": 501,
      "Type": "odit",
      "ColorBlock": 348,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2000-09-04T03:45:28.4828085+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Candelario Durgan"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 557,
      "Comment": "qui",
      "Registered": "2018-05-13T03:45:28.4828085+02:00",
      "RegisteredAssociateId": 232,
      "Updated": "2008-08-01T03:45:28.4828085+02:00",
      "UpdatedAssociateId": 971,
      "LegalBaseId": 424,
      "LegalBaseKey": "facilis",
      "LegalBaseName": "Price LLC",
      "ConsentPurposeId": 58,
      "ConsentPurposeKey": "blanditiis",
      "ConsentPurposeName": "Pouros Inc and Sons",
      "ConsentSourceId": 948,
      "ConsentSourceKey": "nostrum",
      "ConsentSourceName": "Williamson-Bahringer"
    }
  ],
  "BounceEmails": [
    "eusebio_muller@rolfsonwisozk.us",
    "brody.morar@heathcoteroob.us"
  ],
  "ActiveStatusMonitorId": 195,
  "CreatedByFormId": 536,
  "UserDefinedFields": {
    "SuperOffice:1": "231386554",
    "SuperOffice:2": "Prof. Francis Sauer"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "nobis",
  "2": "illum"
}
```
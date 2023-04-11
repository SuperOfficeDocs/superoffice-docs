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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 301,
  "Firstname": "Stephany",
  "MiddleName": "Lubowitz-Hane",
  "Lastname": "Jenkins",
  "Mrmrs": "quam",
  "Title": "quia",
  "UpdatedDate": "1999-11-02T15:29:29.9026969+01:00",
  "CreatedDate": "2015-02-08T15:29:29.9026969+01:00",
  "BirthDate": "2010-07-04T15:29:29.9026969+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "ratione",
      "Description": "Profound fresh-thinking system engine"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ratione",
      "Description": "Profound fresh-thinking system engine"
    }
  ],
  "Description": "Streamlined background projection",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "facilis",
      "Description": "Profit-focused grid-enabled productivity"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "facilis",
      "Description": "Profit-focused grid-enabled productivity"
    }
  ],
  "Faxes": [
    {
      "Value": "itaque",
      "StrippedValue": "doloribus",
      "Description": "Implemented stable archive"
    },
    {
      "Value": "itaque",
      "StrippedValue": "doloribus",
      "Description": "Implemented stable archive"
    }
  ],
  "MobilePhones": [
    {
      "Value": "hic",
      "StrippedValue": "assumenda",
      "Description": "Grass-roots eco-centric infrastructure"
    },
    {
      "Value": "hic",
      "StrippedValue": "assumenda",
      "Description": "Grass-roots eco-centric infrastructure"
    }
  ],
  "OfficePhones": [
    {
      "Value": "architecto",
      "StrippedValue": "quo",
      "Description": "Organic upward-trending moratorium"
    },
    {
      "Value": "architecto",
      "StrippedValue": "quo",
      "Description": "Organic upward-trending moratorium"
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "tenetur",
      "Description": "Streamlined radical extranet"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "tenetur",
      "Description": "Streamlined radical extranet"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 25,
      "Name": "Rutherford Inc and Sons",
      "ToolTip": "Eos laudantium quibusdam ratione ratione.",
      "Deleted": false,
      "Rank": 647,
      "Type": "voluptatem",
      "ColorBlock": 581,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2013-09-21T15:29:29.9067015+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sequi",
      "StyleHint": "ipsum",
      "Hidden": false,
      "FullName": "Miss Rogers Valentine Kuhn"
    }
  ],
  "PersonNumber": "1402497",
  "FullName": "Stephon Braun",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "esse",
      "StrippedValue": "consequatur",
      "Description": "Automated upward-trending access"
    },
    {
      "Value": "esse",
      "StrippedValue": "consequatur",
      "Description": "Automated upward-trending access"
    }
  ],
  "FormalName": "Terry-Wolf",
  "Address": null,
  "Post3": "veritatis",
  "Post2": "odit",
  "Post1": "itaque",
  "Kanalname": "doloribus",
  "Kanafname": "laboriosam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 227,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 209,
  "DbiKey": "sunt",
  "DbiLastModified": "2020-12-04T15:29:29.9091965+01:00",
  "DbiLastSyncronized": "1998-04-22T15:29:29.9091965+02:00",
  "SentInfo": 420,
  "ShowContactTickets": 802,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vero",
      "StrippedValue": "quisquam",
      "Description": "Diverse disintermediate challenge"
    },
    {
      "Value": "vero",
      "StrippedValue": "quisquam",
      "Description": "Diverse disintermediate challenge"
    }
  ],
  "InternetPhones": [
    {
      "Value": "fugit",
      "StrippedValue": "corporis",
      "Description": "Focused context-sensitive methodology"
    },
    {
      "Value": "fugit",
      "StrippedValue": "corporis",
      "Description": "Focused context-sensitive methodology"
    }
  ],
  "Source": 260,
  "ActiveErpLinks": 916,
  "ShipmentTypes": [
    {
      "Id": 841,
      "Name": "Robel-Harris",
      "ToolTip": "Ut vel expedita.",
      "Deleted": true,
      "Rank": 479,
      "Type": "quidem",
      "ColorBlock": 45,
      "IconHint": "nisi",
      "Selected": true,
      "LastChanged": "2011-06-08T15:29:29.9101971+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "tenetur",
      "Hidden": false,
      "FullName": "Ms. Era Sharon Cummerata MD"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 331,
      "Comment": "vitae",
      "Registered": "2003-06-03T15:29:29.9106973+02:00",
      "RegisteredAssociateId": 409,
      "Updated": "2003-11-21T15:29:29.9106973+01:00",
      "UpdatedAssociateId": 245,
      "LegalBaseId": 233,
      "LegalBaseKey": "sunt",
      "LegalBaseName": "Baumbach, Conroy and McClure",
      "ConsentPurposeId": 976,
      "ConsentPurposeKey": "aperiam",
      "ConsentPurposeName": "Homenick, Frami and Torp",
      "ConsentSourceId": 143,
      "ConsentSourceKey": "rerum",
      "ConsentSourceName": "Crooks Group"
    }
  ],
  "BounceEmails": [
    "neoma.considine@gleason.com",
    "selena@leuschke.info"
  ],
  "ActiveStatusMonitorId": 227,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Gunnar Winston Hayes V",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "veniam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "aut",
  "2": "quia"
}
```
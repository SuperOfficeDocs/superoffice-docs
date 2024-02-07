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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 915,
  "Firstname": "Corbin",
  "MiddleName": "Frami-McDermott",
  "Lastname": "Hermiston",
  "Mrmrs": "ipsam",
  "Title": "quod",
  "UpdatedDate": "2019-03-23T16:55:29.8975191+01:00",
  "CreatedDate": "2003-12-25T16:55:29.8975191+01:00",
  "BirthDate": "1997-02-09T16:55:29.8975191+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "magnam",
      "Description": "Synchronised next generation support"
    },
    {
      "Value": "sit",
      "StrippedValue": "magnam",
      "Description": "Synchronised next generation support"
    }
  ],
  "Description": "Persevering exuding website",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "dolores",
      "Description": "Synchronised zero administration product"
    },
    {
      "Value": "non",
      "StrippedValue": "dolores",
      "Description": "Synchronised zero administration product"
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "ipsam",
      "Description": "Multi-channelled global success"
    },
    {
      "Value": "ad",
      "StrippedValue": "ipsam",
      "Description": "Multi-channelled global success"
    }
  ],
  "MobilePhones": [
    {
      "Value": "veritatis",
      "StrippedValue": "et",
      "Description": "Team-oriented full-range forecast"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "et",
      "Description": "Team-oriented full-range forecast"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quos",
      "StrippedValue": "mollitia",
      "Description": "Multi-layered fresh-thinking superstructure"
    },
    {
      "Value": "quos",
      "StrippedValue": "mollitia",
      "Description": "Multi-layered fresh-thinking superstructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "non",
      "Description": "Down-sized asynchronous focus group"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "non",
      "Description": "Down-sized asynchronous focus group"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 899,
      "Name": "Spencer Group",
      "ToolTip": "Necessitatibus qui sint et quis possimus distinctio.",
      "Deleted": false,
      "Rank": 402,
      "Type": "molestiae",
      "ColorBlock": 944,
      "IconHint": "corrupti",
      "Selected": false,
      "LastChanged": "2017-04-05T16:55:29.8995202+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Waldo Sporer"
    }
  ],
  "PersonNumber": "209133",
  "FullName": "Garnett Hoppe",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "doloribus",
      "StrippedValue": "fuga",
      "Description": "User-centric motivating Graphical User Interface"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "fuga",
      "Description": "User-centric motivating Graphical User Interface"
    }
  ],
  "FormalName": "Grady LLC",
  "Address": null,
  "Post3": "possimus",
  "Post2": "maiores",
  "Post1": "porro",
  "Kanalname": "officia",
  "Kanafname": "eum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "expedita",
  "ActiveInterests": 840,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 959,
  "DbiKey": "id",
  "DbiLastModified": "2020-11-14T16:55:29.9015197+01:00",
  "DbiLastSyncronized": "2001-08-03T16:55:29.9015197+02:00",
  "SentInfo": 368,
  "ShowContactTickets": 185,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sequi",
      "StrippedValue": "velit",
      "Description": "Versatile bi-directional productivity"
    },
    {
      "Value": "sequi",
      "StrippedValue": "velit",
      "Description": "Versatile bi-directional productivity"
    }
  ],
  "InternetPhones": [
    {
      "Value": "atque",
      "StrippedValue": "est",
      "Description": "Implemented cohesive capacity"
    },
    {
      "Value": "atque",
      "StrippedValue": "est",
      "Description": "Implemented cohesive capacity"
    }
  ],
  "Source": 868,
  "ActiveErpLinks": 88,
  "ShipmentTypes": [
    {
      "Id": 892,
      "Name": "Cummings-Tillman",
      "ToolTip": "Atque consequatur.",
      "Deleted": false,
      "Rank": 523,
      "Type": "ipsa",
      "ColorBlock": 797,
      "IconHint": "amet",
      "Selected": false,
      "LastChanged": "2024-01-03T16:55:29.9015197+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Mrs. Claire Oberbrunner Sr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 688,
      "Comment": "corrupti",
      "Registered": "2012-02-20T16:55:29.9025174+01:00",
      "RegisteredAssociateId": 688,
      "Updated": "2013-04-03T16:55:29.9025174+02:00",
      "UpdatedAssociateId": 8,
      "LegalBaseId": 837,
      "LegalBaseKey": "esse",
      "LegalBaseName": "Glover LLC",
      "ConsentPurposeId": 879,
      "ConsentPurposeKey": "aliquam",
      "ConsentPurposeName": "Muller Group",
      "ConsentSourceId": 936,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Kertzmann LLC"
    }
  ],
  "BounceEmails": [
    "maeve@kuhic.com",
    "alysha_baumbach@dachhoppe.uk"
  ],
  "ActiveStatusMonitorId": 210,
  "UserDefinedFields": {
    "SuperOffice:1": "1816218936",
    "SuperOffice:2": "1911173355"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "ab"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quod",
  "2": "qui"
}
```
---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

## Request Body: entity 

The PersonEntity to be saved. 

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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 415,
  "Firstname": "Russ",
  "MiddleName": "Torphy, Koch and Hickle",
  "Lastname": "Keebler",
  "Mrmrs": "nesciunt",
  "Title": "voluptatem",
  "UpdatedDate": "2018-07-05T16:32:39.3832102+02:00",
  "CreatedDate": "2015-03-26T16:32:39.3832102+01:00",
  "BirthDate": "2025-01-08T16:32:39.3832102+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "soluta",
      "StrippedValue": "est",
      "Description": "User-friendly zero defect database"
    },
    {
      "Value": "soluta",
      "StrippedValue": "est",
      "Description": "User-friendly zero defect database"
    }
  ],
  "Description": "Virtual real-time matrices",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "voluptas",
      "Description": "Multi-channelled analyzing focus group"
    },
    {
      "Value": "cumque",
      "StrippedValue": "voluptas",
      "Description": "Multi-channelled analyzing focus group"
    }
  ],
  "Faxes": [
    {
      "Value": "laboriosam",
      "StrippedValue": "sit",
      "Description": "Optional multi-state portal"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "sit",
      "Description": "Optional multi-state portal"
    }
  ],
  "MobilePhones": [
    {
      "Value": "vitae",
      "StrippedValue": "architecto",
      "Description": "Focused multimedia project"
    },
    {
      "Value": "vitae",
      "StrippedValue": "architecto",
      "Description": "Focused multimedia project"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "voluptatem",
      "Description": "Optional multimedia protocol"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "voluptatem",
      "Description": "Optional multimedia protocol"
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "ratione",
      "Description": "Cross-platform asynchronous system engine"
    },
    {
      "Value": "aut",
      "StrippedValue": "ratione",
      "Description": "Cross-platform asynchronous system engine"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 562,
      "Name": "Wiegand-Daniel",
      "ToolTip": "Vitae itaque dicta exercitationem est.",
      "Deleted": true,
      "Rank": 589,
      "Type": "sit",
      "ColorBlock": 759,
      "IconHint": "consectetur",
      "Selected": false,
      "LastChanged": "2001-09-08T16:32:39.3832102+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "sapiente",
      "Hidden": true,
      "FullName": "Hilma Lockman"
    }
  ],
  "PersonNumber": "460666",
  "FullName": "Schuyler Armstrong",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "repudiandae",
      "Description": "Innovative asynchronous matrix"
    },
    {
      "Value": "aut",
      "StrippedValue": "repudiandae",
      "Description": "Innovative asynchronous matrix"
    }
  ],
  "FormalName": "Hamill Group",
  "Address": null,
  "Post3": "quis",
  "Post2": "a",
  "Post1": "et",
  "Kanalname": "exercitationem",
  "Kanafname": "nemo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsum",
  "ActiveInterests": 405,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 337,
  "DbiKey": "consequatur",
  "DbiLastModified": "2024-06-03T16:32:39.398832+02:00",
  "DbiLastSyncronized": "2020-09-27T16:32:39.398832+02:00",
  "SentInfo": 826,
  "ShowContactTickets": 277,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ipsa",
      "StrippedValue": "ad",
      "Description": "Synergized encompassing time-frame"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "ad",
      "Description": "Synergized encompassing time-frame"
    }
  ],
  "InternetPhones": [
    {
      "Value": "itaque",
      "StrippedValue": "facere",
      "Description": "Versatile impactful software"
    },
    {
      "Value": "itaque",
      "StrippedValue": "facere",
      "Description": "Versatile impactful software"
    }
  ],
  "Source": 879,
  "ActiveErpLinks": 378,
  "ShipmentTypes": [
    {
      "Id": 914,
      "Name": "Stoltenberg LLC",
      "ToolTip": "Nulla beatae laborum iusto.",
      "Deleted": false,
      "Rank": 211,
      "Type": "blanditiis",
      "ColorBlock": 624,
      "IconHint": "tenetur",
      "Selected": false,
      "LastChanged": "2013-03-22T16:32:39.398832+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "molestias",
      "Hidden": false,
      "FullName": "Audra Hagenes"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 789,
      "Comment": "velit",
      "Registered": "2007-08-24T16:32:39.398832+02:00",
      "RegisteredAssociateId": 464,
      "Updated": "2008-06-29T16:32:39.398832+02:00",
      "UpdatedAssociateId": 151,
      "LegalBaseId": 166,
      "LegalBaseKey": "ipsum",
      "LegalBaseName": "Kreiger LLC",
      "ConsentPurposeId": 27,
      "ConsentPurposeKey": "eos",
      "ConsentPurposeName": "Bergstrom LLC",
      "ConsentSourceId": 487,
      "ConsentSourceKey": "occaecati",
      "ConsentSourceName": "Bernier LLC"
    }
  ],
  "BounceEmails": [
    "mariana@schoen.us",
    "nolan@murphy.us"
  ],
  "ActiveStatusMonitorId": 45,
  "CreatedByFormId": 625,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "tempora"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 698,
  "Firstname": "Beau",
  "MiddleName": "Lockman, McKenzie and Johnson",
  "Lastname": "Lindgren",
  "Mrmrs": "iste",
  "Title": "adipisci",
  "UpdatedDate": "2013-09-18T16:32:39.398832+02:00",
  "CreatedDate": "2003-12-06T16:32:39.398832+01:00",
  "BirthDate": "2016-01-31T16:32:39.398832+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "rem",
      "Description": "Organic bi-directional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "rem",
      "Description": "Organic bi-directional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    }
  ],
  "Description": "Innovative secondary budgetary management",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "occaecati",
      "StrippedValue": "voluptas",
      "Description": "Secured secondary implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "voluptas",
      "Description": "Secured secondary implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "suscipit",
      "Description": "Upgradable full-range success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "suscipit",
      "Description": "Upgradable full-range success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "dolor",
      "Description": "Enterprise-wide high-level architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "dolor",
      "Description": "Enterprise-wide high-level architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Robust next generation process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Robust next generation process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "nobis",
      "Description": "Devolved coherent parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "nobis",
      "Description": "Devolved coherent parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 531,
      "Name": "Crooks-Dickens",
      "ToolTip": "Ipsa consequatur perferendis.",
      "Deleted": false,
      "Rank": 431,
      "Type": "animi",
      "ColorBlock": 443,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2013-06-12T16:32:39.398832+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Mr. Monty Schoen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "PersonNumber": "1508297",
  "FullName": "Kaia Lindgren",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "modi",
      "Description": "Persistent high-level portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "modi",
      "Description": "Persistent high-level portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "FormalName": "Gutmann-Harris",
  "Address": null,
  "Post3": "qui",
  "Post2": "exercitationem",
  "Post1": "rem",
  "Kanalname": "quia",
  "Kanafname": "quod",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "illo",
  "ActiveInterests": 948,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 525,
  "DbiKey": "cumque",
  "DbiLastModified": "2011-10-25T16:32:39.4147246+02:00",
  "DbiLastSyncronized": "2025-01-15T16:32:39.4147246+01:00",
  "SentInfo": 485,
  "ShowContactTickets": 839,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cum",
      "StrippedValue": "numquam",
      "Description": "Function-based tertiary parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "numquam",
      "Description": "Function-based tertiary parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "sapiente",
      "Description": "Expanded homogeneous Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "sapiente",
      "Description": "Expanded homogeneous Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    }
  ],
  "Source": 401,
  "ActiveErpLinks": 112,
  "ShipmentTypes": [
    {
      "Id": 946,
      "Name": "Denesik, Klocko and Nitzsche",
      "ToolTip": "Eligendi quasi aut minima quia.",
      "Deleted": false,
      "Rank": 545,
      "Type": "nulla",
      "ColorBlock": 462,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2007-12-05T16:32:39.4147246+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "veritatis",
      "Hidden": true,
      "FullName": "Donna Daugherty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 40,
      "Comment": "omnis",
      "Registered": "2019-04-25T16:32:39.4147246+02:00",
      "RegisteredAssociateId": 575,
      "Updated": "2010-01-12T16:32:39.4147246+01:00",
      "UpdatedAssociateId": 797,
      "LegalBaseId": 694,
      "LegalBaseKey": "deleniti",
      "LegalBaseName": "Leannon-Ankunding",
      "ConsentPurposeId": 814,
      "ConsentPurposeKey": "tempora",
      "ConsentPurposeName": "Gerhold, Stroman and Streich",
      "ConsentSourceId": 397,
      "ConsentSourceKey": "consequuntur",
      "ConsentSourceName": "Moore Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "BounceEmails": [
    "estelle@bayersatterfield.ca",
    "gus.heathcote@powlowskimante.co.uk"
  ],
  "ActiveStatusMonitorId": 864,
  "CreatedByFormId": 846,
  "UserDefinedFields": {
    "SuperOffice:1": "Fritz Windler",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "deserunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 131
    }
  }
}
```
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 614,
  "Firstname": "Vincent",
  "MiddleName": "Heaney-Schroeder",
  "Lastname": "Ankunding",
  "Mrmrs": "occaecati",
  "Title": "atque",
  "UpdatedDate": "2023-09-13T11:44:33.9783821+02:00",
  "CreatedDate": "1998-05-16T11:44:33.9783821+02:00",
  "BirthDate": "2006-09-27T11:44:33.9783821+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "cupiditate",
      "Description": "Adaptive static collaboration"
    },
    {
      "Value": "eius",
      "StrippedValue": "cupiditate",
      "Description": "Adaptive static collaboration"
    }
  ],
  "Description": "Visionary executive productivity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "et",
      "Description": "Re-contextualized encompassing policy"
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "et",
      "Description": "Re-contextualized encompassing policy"
    }
  ],
  "Faxes": [
    {
      "Value": "alias",
      "StrippedValue": "at",
      "Description": "Open-architected well-modulated encoding"
    },
    {
      "Value": "alias",
      "StrippedValue": "at",
      "Description": "Open-architected well-modulated encoding"
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "porro",
      "Description": "Devolved coherent throughput"
    },
    {
      "Value": "est",
      "StrippedValue": "porro",
      "Description": "Devolved coherent throughput"
    }
  ],
  "OfficePhones": [
    {
      "Value": "laudantium",
      "StrippedValue": "itaque",
      "Description": "Re-engineered value-added portal"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "itaque",
      "Description": "Re-engineered value-added portal"
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "ut",
      "Description": "Cross-platform 24/7 data-warehouse"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "ut",
      "Description": "Cross-platform 24/7 data-warehouse"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 112,
      "Name": "Leffler Group",
      "ToolTip": "Ex non hic perferendis.",
      "Deleted": false,
      "Rank": 554,
      "Type": "quaerat",
      "ColorBlock": 161,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2009-04-01T11:44:33.9783821+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Carlee Fadel"
    }
  ],
  "PersonNumber": "1115084",
  "FullName": "German Gusikowski",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Persevering content-based methodology"
    },
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Persevering content-based methodology"
    }
  ],
  "FormalName": "Kunze-Mueller",
  "Address": null,
  "Post3": "sunt",
  "Post2": "voluptatibus",
  "Post1": "doloribus",
  "Kanalname": "vitae",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 155,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 113,
  "DbiKey": "possimus",
  "DbiLastModified": "2011-05-13T11:44:33.9783821+02:00",
  "DbiLastSyncronized": "2012-02-06T11:44:33.9783821+01:00",
  "SentInfo": 416,
  "ShowContactTickets": 514,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "maxime",
      "StrippedValue": "sit",
      "Description": "Universal bi-directional service-desk"
    },
    {
      "Value": "maxime",
      "StrippedValue": "sit",
      "Description": "Universal bi-directional service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "in",
      "StrippedValue": "sint",
      "Description": "Public-key bottom-line product"
    },
    {
      "Value": "in",
      "StrippedValue": "sint",
      "Description": "Public-key bottom-line product"
    }
  ],
  "Source": 578,
  "ActiveErpLinks": 479,
  "ShipmentTypes": [
    {
      "Id": 183,
      "Name": "Zieme Group",
      "ToolTip": "Amet voluptate.",
      "Deleted": false,
      "Rank": 413,
      "Type": "sint",
      "ColorBlock": 858,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "2008-12-26T11:44:33.9783821+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nostrum",
      "StyleHint": "recusandae",
      "Hidden": false,
      "FullName": "Miss Alverta Sven Pagac"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 934,
      "Comment": "libero",
      "Registered": "1998-02-01T11:44:33.9783821+01:00",
      "RegisteredAssociateId": 853,
      "Updated": "2009-10-01T11:44:33.9783821+02:00",
      "UpdatedAssociateId": 337,
      "LegalBaseId": 170,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Cremin, Emard and Huel",
      "ConsentPurposeId": 336,
      "ConsentPurposeKey": "neque",
      "ConsentPurposeName": "Fisher-Hansen",
      "ConsentSourceId": 951,
      "ConsentSourceKey": "consectetur",
      "ConsentSourceName": "Hane Inc and Sons"
    }
  ],
  "BounceEmails": [
    "enrico_deckow@hilpertnikolaus.co.uk",
    "myrl.haley@runolfsdottirbashirian.biz"
  ],
  "ActiveStatusMonitorId": 328,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Dejuan Koepp Sr.",
    "SuperOffice:2": "Ms. Ara Cary Buckridge III"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "eveniet"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 660,
  "Firstname": "Alexanne",
  "MiddleName": "Dach-Heaney",
  "Lastname": "Johnston",
  "Mrmrs": "quis",
  "Title": "quam",
  "UpdatedDate": "2001-02-08T11:44:33.9940049+01:00",
  "CreatedDate": "2017-09-22T11:44:33.9940049+02:00",
  "BirthDate": "2020-06-22T11:44:33.9940049+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "illo",
      "StrippedValue": "aut",
      "Description": "Horizontal 3rd generation moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "aut",
      "Description": "Horizontal 3rd generation moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    }
  ],
  "Description": "Balanced tertiary toolset",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "harum",
      "Description": "Open-source optimal focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "harum",
      "Description": "Open-source optimal focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "impedit",
      "StrippedValue": "inventore",
      "Description": "Monitored well-modulated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "inventore",
      "Description": "Monitored well-modulated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "iste",
      "StrippedValue": "odit",
      "Description": "Optional zero tolerance orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "odit",
      "Description": "Optional zero tolerance orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "dignissimos",
      "Description": "Public-key zero tolerance concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "dignissimos",
      "Description": "Public-key zero tolerance concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Assimilated executive architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Assimilated executive architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
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
      "Id": 391,
      "Name": "Kertzmann Inc and Sons",
      "ToolTip": "Laborum porro facilis tempora odit omnis.",
      "Deleted": false,
      "Rank": 413,
      "Type": "id",
      "ColorBlock": 85,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2014-07-21T11:44:33.9940049+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Dr. Daphne Davis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    }
  ],
  "PersonNumber": "1011975",
  "FullName": "Patsy Kirlin",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "quisquam",
      "Description": "Synchronised empowering emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 550
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "quisquam",
      "Description": "Synchronised empowering emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 550
        }
      }
    }
  ],
  "FormalName": "McKenzie-Langosh",
  "Address": null,
  "Post3": "consectetur",
  "Post2": "debitis",
  "Post1": "iusto",
  "Kanalname": "laudantium",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eaque",
  "ActiveInterests": 319,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 197,
  "DbiKey": "repellat",
  "DbiLastModified": "2011-08-30T11:44:33.9940049+02:00",
  "DbiLastSyncronized": "2022-02-24T11:44:33.9940049+01:00",
  "SentInfo": 353,
  "ShowContactTickets": 1002,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nostrum",
      "StrippedValue": "sit",
      "Description": "Integrated foreground circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "sit",
      "Description": "Integrated foreground circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Up-sized system-worthy alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Up-sized system-worthy alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "Source": 630,
  "ActiveErpLinks": 682,
  "ShipmentTypes": [
    {
      "Id": 565,
      "Name": "Tremblay Inc and Sons",
      "ToolTip": "Ullam dignissimos.",
      "Deleted": false,
      "Rank": 43,
      "Type": "repudiandae",
      "ColorBlock": 671,
      "IconHint": "hic",
      "Selected": false,
      "LastChanged": "1998-09-26T11:44:33.9940049+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Ms. Adam Scottie Monahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 960
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 792,
      "Comment": "ipsa",
      "Registered": "2023-02-14T11:44:33.9940049+01:00",
      "RegisteredAssociateId": 123,
      "Updated": "2015-09-30T11:44:33.9940049+02:00",
      "UpdatedAssociateId": 856,
      "LegalBaseId": 219,
      "LegalBaseKey": "rerum",
      "LegalBaseName": "Okuneva-Hintz",
      "ConsentPurposeId": 42,
      "ConsentPurposeKey": "expedita",
      "ConsentPurposeName": "Gislason LLC",
      "ConsentSourceId": 387,
      "ConsentSourceKey": "maxime",
      "ConsentSourceName": "Parker-Mohr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "BounceEmails": [
    "liliana_senger@lednerjerde.biz",
    "zack.lesch@hicklekovacek.biz"
  ],
  "ActiveStatusMonitorId": 299,
  "UserDefinedFields": {
    "SuperOffice:1": "Zander Armstrong DDS",
    "SuperOffice:2": "1651160551"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "libero"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 878
    }
  }
}
```
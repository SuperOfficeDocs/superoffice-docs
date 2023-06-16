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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 505,
  "Firstname": "Gussie",
  "MiddleName": "Grant, Zieme and Konopelski",
  "Lastname": "Gerlach",
  "Mrmrs": "explicabo",
  "Title": "accusantium",
  "UpdatedDate": "2010-05-08T16:00:41.3049427+02:00",
  "CreatedDate": "2019-07-24T16:00:41.3049427+02:00",
  "BirthDate": "2020-09-21T16:00:41.3049427+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "dicta",
      "Description": "Virtual maximized attitude"
    },
    {
      "Value": "cum",
      "StrippedValue": "dicta",
      "Description": "Virtual maximized attitude"
    }
  ],
  "Description": "Multi-lateral intermediate projection",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "laboriosam",
      "StrippedValue": "est",
      "Description": "Enhanced static attitude"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "est",
      "Description": "Enhanced static attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "possimus",
      "Description": "Horizontal zero administration core"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "possimus",
      "Description": "Horizontal zero administration core"
    }
  ],
  "MobilePhones": [
    {
      "Value": "nam",
      "StrippedValue": "nemo",
      "Description": "Horizontal eco-centric model"
    },
    {
      "Value": "nam",
      "StrippedValue": "nemo",
      "Description": "Horizontal eco-centric model"
    }
  ],
  "OfficePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "ut",
      "Description": "Organic systemic access"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "ut",
      "Description": "Organic systemic access"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "ullam",
      "Description": "Devolved holistic artificial intelligence"
    },
    {
      "Value": "et",
      "StrippedValue": "ullam",
      "Description": "Devolved holistic artificial intelligence"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 510,
      "Name": "Kessler, Luettgen and Kshlerin",
      "ToolTip": "Earum modi dolore eligendi corporis corrupti rerum veritatis.",
      "Deleted": false,
      "Rank": 624,
      "Type": "sint",
      "ColorBlock": 578,
      "IconHint": "aspernatur",
      "Selected": true,
      "LastChanged": "2019-04-25T16:00:41.3049427+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quae",
      "Hidden": false,
      "FullName": "Friedrich Trudie Cormier I"
    }
  ],
  "PersonNumber": "1293856",
  "FullName": "Dr. Johnpaul Leannon III",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "id",
      "Description": "Reverse-engineered responsive complexity"
    },
    {
      "Value": "ad",
      "StrippedValue": "id",
      "Description": "Reverse-engineered responsive complexity"
    }
  ],
  "FormalName": "Raynor, Steuber and Heidenreich",
  "Address": null,
  "Post3": "inventore",
  "Post2": "quam",
  "Post1": "ea",
  "Kanalname": "nemo",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "saepe",
  "ActiveInterests": 105,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 805,
  "DbiKey": "deleniti",
  "DbiLastModified": "2000-03-22T16:00:41.3049427+01:00",
  "DbiLastSyncronized": "2017-10-11T16:00:41.3049427+02:00",
  "SentInfo": 967,
  "ShowContactTickets": 644,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "incidunt",
      "StrippedValue": "non",
      "Description": "Adaptive needs-based structure"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "non",
      "Description": "Adaptive needs-based structure"
    }
  ],
  "InternetPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "omnis",
      "Description": "Cross-group fault-tolerant info-mediaries"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "omnis",
      "Description": "Cross-group fault-tolerant info-mediaries"
    }
  ],
  "Source": 738,
  "ActiveErpLinks": 870,
  "ShipmentTypes": [
    {
      "Id": 759,
      "Name": "Huel, Paucek and Bergstrom",
      "ToolTip": "Aut tempore molestiae qui harum ducimus dolorem quibusdam.",
      "Deleted": false,
      "Rank": 218,
      "Type": "molestias",
      "ColorBlock": 969,
      "IconHint": "tempore",
      "Selected": true,
      "LastChanged": "1999-09-01T16:00:41.3049427+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sequi",
      "StyleHint": "dolorum",
      "Hidden": false,
      "FullName": "Brant Fahey"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 455,
      "Comment": "distinctio",
      "Registered": "2015-02-19T16:00:41.3049427+01:00",
      "RegisteredAssociateId": 714,
      "Updated": "2013-02-11T16:00:41.3049427+01:00",
      "UpdatedAssociateId": 416,
      "LegalBaseId": 342,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Crona LLC",
      "ConsentPurposeId": 900,
      "ConsentPurposeKey": "autem",
      "ConsentPurposeName": "Wolf LLC",
      "ConsentSourceId": 579,
      "ConsentSourceKey": "nam",
      "ConsentSourceName": "Kovacek-McKenzie"
    }
  ],
  "BounceEmails": [
    "dejah@welchglover.us",
    "rowan.considine@schuppe.uk"
  ],
  "ActiveStatusMonitorId": 325,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Alexandria Romaguera DDS",
    "SuperOffice:2": "Roscoe Lynch"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "repellendus"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "id"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 281,
  "Firstname": "Madge",
  "MiddleName": "Kuhn, Wiegand and Lockman",
  "Lastname": "Mueller",
  "Mrmrs": "deserunt",
  "Title": "et",
  "UpdatedDate": "2013-09-11T16:00:41.3206757+02:00",
  "CreatedDate": "2018-10-12T16:00:41.3206757+02:00",
  "BirthDate": "2018-07-10T16:00:41.3206757+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "error",
      "Description": "Automated contextually-based help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "error",
      "Description": "Automated contextually-based help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Description": "Operative zero tolerance secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "hic",
      "StrippedValue": "eos",
      "Description": "Multi-channelled tangible throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "eos",
      "Description": "Multi-channelled tangible throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "voluptatem",
      "Description": "Expanded solution-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "voluptatem",
      "Description": "Expanded solution-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "fugiat",
      "Description": "Reduced 24/7 matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "fugiat",
      "Description": "Reduced 24/7 matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "doloremque",
      "Description": "Reactive client-server functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "doloremque",
      "Description": "Reactive client-server functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "ipsam",
      "Description": "Versatile object-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "ipsam",
      "Description": "Versatile object-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
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
      "Id": 378,
      "Name": "Barton Group",
      "ToolTip": "Sed voluptas.",
      "Deleted": false,
      "Rank": 165,
      "Type": "cupiditate",
      "ColorBlock": 996,
      "IconHint": "quos",
      "Selected": false,
      "LastChanged": "2004-07-23T16:00:41.3206757+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Eryn Bashirian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "PersonNumber": "928890",
  "FullName": "Dr. Hassan Cartwright V",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "beatae",
      "Description": "Expanded intangible contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 409
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "beatae",
      "Description": "Expanded intangible contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 409
        }
      }
    }
  ],
  "FormalName": "Zemlak LLC",
  "Address": null,
  "Post3": "doloremque",
  "Post2": "ea",
  "Post1": "voluptatem",
  "Kanalname": "quaerat",
  "Kanafname": "voluptatibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "alias",
  "ActiveInterests": 717,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 880,
  "DbiKey": "est",
  "DbiLastModified": "2022-06-02T16:00:41.3206757+02:00",
  "DbiLastSyncronized": "2011-07-04T16:00:41.3206757+02:00",
  "SentInfo": 595,
  "ShowContactTickets": 752,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "omnis",
      "StrippedValue": "odit",
      "Description": "Synergistic incremental model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "odit",
      "Description": "Synergistic incremental model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "minus",
      "StrippedValue": "alias",
      "Description": "Organized bandwidth-monitored encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "alias",
      "Description": "Organized bandwidth-monitored encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
  "Source": 77,
  "ActiveErpLinks": 506,
  "ShipmentTypes": [
    {
      "Id": 333,
      "Name": "Weber-Boehm",
      "ToolTip": "Eum asperiores sint delectus est.",
      "Deleted": true,
      "Rank": 3,
      "Type": "unde",
      "ColorBlock": 46,
      "IconHint": "alias",
      "Selected": false,
      "LastChanged": "2002-09-03T16:00:41.3206757+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "praesentium",
      "Hidden": false,
      "FullName": "Arvilla Zemlak",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 128,
      "Comment": "consequatur",
      "Registered": "1998-11-25T16:00:41.3206757+01:00",
      "RegisteredAssociateId": 737,
      "Updated": "2023-03-28T16:00:41.3206757+02:00",
      "UpdatedAssociateId": 644,
      "LegalBaseId": 565,
      "LegalBaseKey": "autem",
      "LegalBaseName": "Hodkiewicz-Reinger",
      "ConsentPurposeId": 263,
      "ConsentPurposeKey": "culpa",
      "ConsentPurposeName": "Schaefer, Langworth and Russel",
      "ConsentSourceId": 479,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Labadie, Gulgowski and VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    }
  ],
  "BounceEmails": [
    "viva_boehm@satterfield.us",
    "art@okon.ca"
  ],
  "ActiveStatusMonitorId": 562,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Antoinette Langosh IV",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 16
    }
  }
}
```
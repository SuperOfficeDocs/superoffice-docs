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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 269,
  "Firstname": "Megane",
  "MiddleName": "Kemmer, Moore and Friesen",
  "Lastname": "Gottlieb",
  "Mrmrs": "qui",
  "Title": "esse",
  "UpdatedDate": "2020-03-27T13:14:06.1476714+01:00",
  "CreatedDate": "2012-08-28T13:14:06.1476714+02:00",
  "BirthDate": "2022-12-24T13:14:06.1476714+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "consectetur",
      "Description": "Fundamental local info-mediaries"
    },
    {
      "Value": "sunt",
      "StrippedValue": "consectetur",
      "Description": "Fundamental local info-mediaries"
    }
  ],
  "Description": "Sharable modular structure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Diverse multimedia circuit"
    },
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Diverse multimedia circuit"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "aperiam",
      "Description": "Exclusive scalable process improvement"
    },
    {
      "Value": "non",
      "StrippedValue": "aperiam",
      "Description": "Exclusive scalable process improvement"
    }
  ],
  "MobilePhones": [
    {
      "Value": "in",
      "StrippedValue": "quae",
      "Description": "Enhanced 6th generation paradigm"
    },
    {
      "Value": "in",
      "StrippedValue": "quae",
      "Description": "Enhanced 6th generation paradigm"
    }
  ],
  "OfficePhones": [
    {
      "Value": "animi",
      "StrippedValue": "deserunt",
      "Description": "Persevering full-range interface"
    },
    {
      "Value": "animi",
      "StrippedValue": "deserunt",
      "Description": "Persevering full-range interface"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sit",
      "StrippedValue": "a",
      "Description": "Cloned multi-state encryption"
    },
    {
      "Value": "sit",
      "StrippedValue": "a",
      "Description": "Cloned multi-state encryption"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 476,
      "Name": "Fay-Botsford",
      "ToolTip": "Nesciunt voluptatem magnam.",
      "Deleted": false,
      "Rank": 603,
      "Type": "sit",
      "ColorBlock": 108,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2019-01-04T13:14:06.1476714+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Dr. Lon Hickle Sr."
    }
  ],
  "PersonNumber": "1106533",
  "FullName": "Mr. Deontae Margaret Kovacek V",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "ex",
      "Description": "Customer-focused background methodology"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ex",
      "Description": "Customer-focused background methodology"
    }
  ],
  "FormalName": "Langosh Group",
  "Address": null,
  "Post3": "sit",
  "Post2": "minus",
  "Post1": "excepturi",
  "Kanalname": "quia",
  "Kanafname": "ipsa",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "reprehenderit",
  "ActiveInterests": 233,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 303,
  "DbiKey": "nobis",
  "DbiLastModified": "2023-01-28T13:14:06.1632974+01:00",
  "DbiLastSyncronized": "2007-04-12T13:14:06.1632974+02:00",
  "SentInfo": 783,
  "ShowContactTickets": 25,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nihil",
      "StrippedValue": "fugit",
      "Description": "Operative secondary interface"
    },
    {
      "Value": "nihil",
      "StrippedValue": "fugit",
      "Description": "Operative secondary interface"
    }
  ],
  "InternetPhones": [
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Switchable non-volatile array"
    },
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Switchable non-volatile array"
    }
  ],
  "Source": 712,
  "ActiveErpLinks": 197,
  "ShipmentTypes": [
    {
      "Id": 970,
      "Name": "Parisian-Schmeler",
      "ToolTip": "Tempora ut.",
      "Deleted": true,
      "Rank": 831,
      "Type": "excepturi",
      "ColorBlock": 595,
      "IconHint": "distinctio",
      "Selected": true,
      "LastChanged": "2021-10-31T13:14:06.1632974+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "quisquam",
      "Hidden": false,
      "FullName": "Terrence Dewayne Satterfield Sr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 271,
      "Comment": "possimus",
      "Registered": "2001-10-14T13:14:06.1632974+02:00",
      "RegisteredAssociateId": 276,
      "Updated": "2004-08-30T13:14:06.1632974+02:00",
      "UpdatedAssociateId": 60,
      "LegalBaseId": 1000,
      "LegalBaseKey": "eius",
      "LegalBaseName": "Schinner, Runolfsdottir and Cartwright",
      "ConsentPurposeId": 819,
      "ConsentPurposeKey": "nostrum",
      "ConsentPurposeName": "Rippin LLC",
      "ConsentSourceId": 696,
      "ConsentSourceKey": "modi",
      "ConsentSourceName": "Windler Inc and Sons"
    }
  ],
  "BounceEmails": [
    "tyreek@bayer.com",
    "deangelo@shields.com"
  ],
  "ActiveStatusMonitorId": 44,
  "CreatedByFormId": 787,
  "UserDefinedFields": {
    "SuperOffice:1": "Maiya Zemlak",
    "SuperOffice:2": "Trace Legros"
  },
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "suscipit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 610,
  "Firstname": "Markus",
  "MiddleName": "Kemmer, Brekke and Borer",
  "Lastname": "Wiza",
  "Mrmrs": "sed",
  "Title": "nisi",
  "UpdatedDate": "2007-01-28T13:14:06.1632974+01:00",
  "CreatedDate": "2018-02-26T13:14:06.1632974+01:00",
  "BirthDate": "1998-12-28T13:14:06.1632974+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ducimus",
      "StrippedValue": "minima",
      "Description": "Compatible methodical parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "minima",
      "Description": "Compatible methodical parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "Description": "Advanced secondary initiative",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "necessitatibus",
      "Description": "Fundamental analyzing info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "necessitatibus",
      "Description": "Fundamental analyzing info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "ratione",
      "Description": "Re-engineered 24/7 data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "ratione",
      "Description": "Re-engineered 24/7 data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sint",
      "StrippedValue": "repellat",
      "Description": "Centralized high-level toolset",
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
      "Value": "sint",
      "StrippedValue": "repellat",
      "Description": "Centralized high-level toolset",
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
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "nam",
      "Description": "Down-sized uniform toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "nam",
      "Description": "Down-sized uniform toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "sit",
      "Description": "Upgradable demand-driven encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "sit",
      "Description": "Upgradable demand-driven encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
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
      "Id": 422,
      "Name": "Kassulke-Ledner",
      "ToolTip": "Libero optio qui tempora sunt aut.",
      "Deleted": false,
      "Rank": 17,
      "Type": "adipisci",
      "ColorBlock": 691,
      "IconHint": "nemo",
      "Selected": false,
      "LastChanged": "2021-09-04T13:14:06.1632974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Emmie Corkery",
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
  "PersonNumber": "839730",
  "FullName": "Ariane Bauch DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "illum",
      "Description": "Assimilated cohesive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "illum",
      "Description": "Assimilated cohesive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    }
  ],
  "FormalName": "Buckridge-Monahan",
  "Address": null,
  "Post3": "nemo",
  "Post2": "dolores",
  "Post1": "sunt",
  "Kanalname": "corporis",
  "Kanafname": "sequi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "in",
  "ActiveInterests": 390,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 747,
  "DbiKey": "alias",
  "DbiLastModified": "2016-10-22T13:14:06.1632974+02:00",
  "DbiLastSyncronized": "2014-07-22T13:14:06.1632974+02:00",
  "SentInfo": 166,
  "ShowContactTickets": 857,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "non",
      "StrippedValue": "facilis",
      "Description": "Focused methodical system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "facilis",
      "Description": "Focused methodical system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Versatile assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Versatile assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "Source": 654,
  "ActiveErpLinks": 226,
  "ShipmentTypes": [
    {
      "Id": 156,
      "Name": "Batz Inc and Sons",
      "ToolTip": "Autem similique repellendus repellat sapiente dolorem nulla.",
      "Deleted": false,
      "Rank": 859,
      "Type": "quia",
      "ColorBlock": 559,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "2021-08-17T13:14:06.1632974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Ms. Phyllis Rosenbaum DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 22,
      "Comment": "dolores",
      "Registered": "2021-02-09T13:14:06.1632974+01:00",
      "RegisteredAssociateId": 413,
      "Updated": "2004-10-06T13:14:06.1632974+02:00",
      "UpdatedAssociateId": 346,
      "LegalBaseId": 374,
      "LegalBaseKey": "aut",
      "LegalBaseName": "McKenzie, Willms and Gottlieb",
      "ConsentPurposeId": 736,
      "ConsentPurposeKey": "esse",
      "ConsentPurposeName": "Cormier, Heidenreich and Kreiger",
      "ConsentSourceId": 119,
      "ConsentSourceKey": "ab",
      "ConsentSourceName": "Kiehn-Turner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "BounceEmails": [
    "cheyenne@koss.ca",
    "malcolm@hodkiewicz.co.uk"
  ],
  "ActiveStatusMonitorId": 843,
  "CreatedByFormId": 819,
  "UserDefinedFields": {
    "SuperOffice:1": "1077206154",
    "SuperOffice:2": "1138051016"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 692
    }
  }
}
```
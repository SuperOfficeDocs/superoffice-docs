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
  "PersonId": 994,
  "Firstname": "Cortez",
  "MiddleName": "Dare-Dare",
  "Lastname": "Langosh",
  "Mrmrs": "enim",
  "Title": "omnis",
  "UpdatedDate": "2022-12-20T14:28:22.1335134+01:00",
  "CreatedDate": "2016-02-06T14:28:22.1335134+01:00",
  "BirthDate": "2023-09-03T14:28:22.1335134+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Multi-channelled incremental migration"
    },
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Multi-channelled incremental migration"
    }
  ],
  "Description": "Persevering explicit leverage",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "suscipit",
      "Description": "Team-oriented neutral capacity"
    },
    {
      "Value": "velit",
      "StrippedValue": "suscipit",
      "Description": "Team-oriented neutral capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "temporibus",
      "Description": "Up-sized intermediate projection"
    },
    {
      "Value": "dolor",
      "StrippedValue": "temporibus",
      "Description": "Up-sized intermediate projection"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Monitored intermediate strategy"
    },
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Monitored intermediate strategy"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sint",
      "StrippedValue": "id",
      "Description": "Operative holistic array"
    },
    {
      "Value": "sint",
      "StrippedValue": "id",
      "Description": "Operative holistic array"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quas",
      "StrippedValue": "sed",
      "Description": "Persistent asynchronous model"
    },
    {
      "Value": "quas",
      "StrippedValue": "sed",
      "Description": "Persistent asynchronous model"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 481,
      "Name": "Nitzsche-Harvey",
      "ToolTip": "Error reprehenderit eaque molestiae quia nihil.",
      "Deleted": true,
      "Rank": 909,
      "Type": "ducimus",
      "ColorBlock": 1002,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2019-01-26T14:28:22.1335134+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "debitis",
      "Hidden": false,
      "FullName": "Ernesto Dickens"
    }
  ],
  "PersonNumber": "1233379",
  "FullName": "Duane Towne",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Switchable analyzing architecture"
    },
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Switchable analyzing architecture"
    }
  ],
  "FormalName": "Koch Inc and Sons",
  "Address": null,
  "Post3": "est",
  "Post2": "voluptates",
  "Post1": "sapiente",
  "Kanalname": "voluptas",
  "Kanafname": "delectus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 587,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 311,
  "DbiKey": "nisi",
  "DbiLastModified": "2000-01-30T14:28:22.1335134+01:00",
  "DbiLastSyncronized": "2006-12-18T14:28:22.1335134+01:00",
  "SentInfo": 904,
  "ShowContactTickets": 859,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perferendis",
      "StrippedValue": "veritatis",
      "Description": "Automated intermediate contingency"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "veritatis",
      "Description": "Automated intermediate contingency"
    }
  ],
  "InternetPhones": [
    {
      "Value": "maxime",
      "StrippedValue": "dolor",
      "Description": "Focused context-sensitive product"
    },
    {
      "Value": "maxime",
      "StrippedValue": "dolor",
      "Description": "Focused context-sensitive product"
    }
  ],
  "Source": 787,
  "ActiveErpLinks": 116,
  "ShipmentTypes": [
    {
      "Id": 811,
      "Name": "Bartell LLC",
      "ToolTip": "Ipsam voluptatem quia soluta repellendus quae.",
      "Deleted": false,
      "Rank": 435,
      "Type": "velit",
      "ColorBlock": 934,
      "IconHint": "dolores",
      "Selected": true,
      "LastChanged": "1998-08-24T14:28:22.1335134+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "quisquam",
      "Hidden": false,
      "FullName": "Prof. Angelica Veum"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 225,
      "Comment": "pariatur",
      "Registered": "2022-01-18T14:28:22.1335134+01:00",
      "RegisteredAssociateId": 656,
      "Updated": "2003-05-10T14:28:22.1335134+02:00",
      "UpdatedAssociateId": 449,
      "LegalBaseId": 356,
      "LegalBaseKey": "quod",
      "LegalBaseName": "Waelchi-Grant",
      "ConsentPurposeId": 246,
      "ConsentPurposeKey": "odit",
      "ConsentPurposeName": "Pfannerstill Group",
      "ConsentSourceId": 228,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Barrows, Hirthe and Skiles"
    }
  ],
  "BounceEmails": [
    "aditya@connkuhic.name",
    "buford_ferry@huels.ca"
  ],
  "ActiveStatusMonitorId": 829,
  "CreatedByFormId": 803,
  "UserDefinedFields": {
    "SuperOffice:1": "Cade Boyer",
    "SuperOffice:2": "1415430544"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 214,
  "Firstname": "Dorothea",
  "MiddleName": "Friesen LLC",
  "Lastname": "Kessler",
  "Mrmrs": "est",
  "Title": "consequatur",
  "UpdatedDate": "2023-12-01T14:28:22.1335134+01:00",
  "CreatedDate": "2008-01-31T14:28:22.1335134+01:00",
  "BirthDate": "2011-10-10T14:28:22.1335134+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "ex",
      "Description": "Proactive object-oriented solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ex",
      "Description": "Proactive object-oriented solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    }
  ],
  "Description": "Virtual dedicated parallelism",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "non",
      "Description": "Organized transitional model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "non",
      "Description": "Organized transitional model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "magni",
      "Description": "Customizable actuating standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "magni",
      "Description": "Customizable actuating standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "autem",
      "Description": "Multi-layered fault-tolerant monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "autem",
      "Description": "Multi-layered fault-tolerant monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Adaptive responsive software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Adaptive responsive software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 744
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "enim",
      "StrippedValue": "ex",
      "Description": "Virtual bandwidth-monitored access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 758
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "ex",
      "Description": "Virtual bandwidth-monitored access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 758
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
      "Id": 750,
      "Name": "Luettgen-Collins",
      "ToolTip": "Vitae consequatur ea iste et ipsam.",
      "Deleted": true,
      "Rank": 248,
      "Type": "minus",
      "ColorBlock": 5,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2022-11-18T14:28:22.1335134+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Mr. Mariana Halle Feil",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    }
  ],
  "PersonNumber": "615180",
  "FullName": "Colleen Cameron Orn IV",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "sit",
      "Description": "Upgradable needs-based toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "sit",
      "Description": "Upgradable needs-based toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    }
  ],
  "FormalName": "Kuhn Group",
  "Address": null,
  "Post3": "optio",
  "Post2": "cum",
  "Post1": "eaque",
  "Kanalname": "veritatis",
  "Kanafname": "sequi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 514,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 884,
  "DbiKey": "laudantium",
  "DbiLastModified": "2020-07-30T14:28:22.1335134+02:00",
  "DbiLastSyncronized": "2000-02-15T14:28:22.1335134+01:00",
  "SentInfo": 883,
  "ShowContactTickets": 250,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "provident",
      "StrippedValue": "qui",
      "Description": "Synergized context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "qui",
      "Description": "Synergized context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "illo",
      "StrippedValue": "delectus",
      "Description": "Multi-lateral well-modulated structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "delectus",
      "Description": "Multi-lateral well-modulated structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "Source": 258,
  "ActiveErpLinks": 401,
  "ShipmentTypes": [
    {
      "Id": 653,
      "Name": "Kemmer, Leannon and Armstrong",
      "ToolTip": "Sunt quasi voluptas est ducimus suscipit et itaque.",
      "Deleted": true,
      "Rank": 962,
      "Type": "officiis",
      "ColorBlock": 826,
      "IconHint": "a",
      "Selected": false,
      "LastChanged": "2001-12-25T14:28:22.1335134+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "assumenda",
      "Hidden": false,
      "FullName": "Isabel Howe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 246
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 799,
      "Comment": "occaecati",
      "Registered": "2007-01-04T14:28:22.1335134+01:00",
      "RegisteredAssociateId": 460,
      "Updated": "2007-07-21T14:28:22.1335134+02:00",
      "UpdatedAssociateId": 612,
      "LegalBaseId": 431,
      "LegalBaseKey": "tempora",
      "LegalBaseName": "Welch, Mohr and Grady",
      "ConsentPurposeId": 945,
      "ConsentPurposeKey": "tenetur",
      "ConsentPurposeName": "Prohaska, Feil and Luettgen",
      "ConsentSourceId": 190,
      "ConsentSourceKey": "similique",
      "ConsentSourceName": "Cronin Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 68
        }
      }
    }
  ],
  "BounceEmails": [
    "orlo.daugherty@damore.com",
    "rahsaan@handjewess.name"
  ],
  "ActiveStatusMonitorId": 415,
  "CreatedByFormId": 102,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Mittie Zelma Jast",
    "SuperOffice:2": "1486731320"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "iure"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 875
    }
  }
}
```
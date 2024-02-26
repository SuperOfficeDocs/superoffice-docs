---
title: POST Agents/Person/CreateDefaultByContactId
uid: v1PersonAgent_CreateDefaultByContactId
generated: true
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
```


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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 298
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 735,
  "Firstname": "Caroline",
  "MiddleName": "McCullough Inc and Sons",
  "Lastname": "Adams",
  "Mrmrs": "nemo",
  "Title": "dolor",
  "UpdatedDate": "2001-12-08T10:30:24.2287678+01:00",
  "CreatedDate": "2016-12-01T10:30:24.2287678+01:00",
  "BirthDate": "2019-10-19T10:30:24.2287678+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "explicabo",
      "StrippedValue": "in",
      "Description": "Networked tertiary monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "in",
      "Description": "Networked tertiary monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    }
  ],
  "Description": "Upgradable contextually-based artificial intelligence",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "magnam",
      "StrippedValue": "adipisci",
      "Description": "Extended optimizing toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "adipisci",
      "Description": "Extended optimizing toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "consequatur",
      "Description": "Public-key fresh-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "consequatur",
      "Description": "Public-key fresh-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "libero",
      "StrippedValue": "suscipit",
      "Description": "Quality-focused multi-state leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "suscipit",
      "Description": "Quality-focused multi-state leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ratione",
      "StrippedValue": "ducimus",
      "Description": "Managed grid-enabled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "ducimus",
      "Description": "Managed grid-enabled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "eos",
      "Description": "Optional full-range product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "eos",
      "Description": "Optional full-range product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
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
      "Id": 288,
      "Name": "Deckow-Bergnaum",
      "ToolTip": "Numquam quasi ea nam eius.",
      "Deleted": true,
      "Rank": 146,
      "Type": "ut",
      "ColorBlock": 700,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2009-11-13T10:30:24.2287678+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "illum",
      "Hidden": true,
      "FullName": "Antoinette Elliott Tromp DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    }
  ],
  "PersonNumber": "948435",
  "FullName": "Prof. Clement Lang IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "omnis",
      "Description": "Fundamental encompassing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "omnis",
      "Description": "Fundamental encompassing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "FormalName": "Kuhic-Rowe",
  "Address": null,
  "Post3": "totam",
  "Post2": "qui",
  "Post1": "numquam",
  "Kanalname": "culpa",
  "Kanafname": "dolorem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laudantium",
  "ActiveInterests": 777,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 960,
  "DbiKey": "ut",
  "DbiLastModified": "2018-07-19T10:30:24.2287678+02:00",
  "DbiLastSyncronized": "2020-06-27T10:30:24.2287678+02:00",
  "SentInfo": 373,
  "ShowContactTickets": 663,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ut",
      "StrippedValue": "delectus",
      "Description": "Integrated heuristic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "delectus",
      "Description": "Integrated heuristic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "a",
      "Description": "Open-source stable initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "a",
      "Description": "Open-source stable initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    }
  ],
  "Source": 238,
  "ActiveErpLinks": 63,
  "ShipmentTypes": [
    {
      "Id": 55,
      "Name": "Lang, Sipes and Upton",
      "ToolTip": "Qui reprehenderit eius quia ratione.",
      "Deleted": false,
      "Rank": 904,
      "Type": "cupiditate",
      "ColorBlock": 720,
      "IconHint": "dolorum",
      "Selected": false,
      "LastChanged": "2014-09-23T10:30:24.2287678+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "ipsam",
      "Hidden": false,
      "FullName": "Mrs. Madisyn Bashirian V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 411,
      "Comment": "consequatur",
      "Registered": "2003-08-25T10:30:24.2287678+02:00",
      "RegisteredAssociateId": 588,
      "Updated": "2005-06-19T10:30:24.2287678+02:00",
      "UpdatedAssociateId": 890,
      "LegalBaseId": 16,
      "LegalBaseKey": "illum",
      "LegalBaseName": "Yost, McKenzie and Wunsch",
      "ConsentPurposeId": 310,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Boyle-Wiza",
      "ConsentSourceId": 727,
      "ConsentSourceKey": "soluta",
      "ConsentSourceName": "Collins, Keeling and Ullrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 386
        }
      }
    }
  ],
  "BounceEmails": [
    "john.cruickshank@dietrichwhite.com",
    "winona@klein.com"
  ],
  "ActiveStatusMonitorId": 431,
  "UserDefinedFields": {
    "SuperOffice:1": "Lorenza Casper",
    "SuperOffice:2": "Paige Braun"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 802
    }
  }
}
```
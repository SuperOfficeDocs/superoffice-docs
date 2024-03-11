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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 409
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 324,
  "Firstname": "Larissa",
  "MiddleName": "Jerde, Bauch and Rempel",
  "Lastname": "Murray",
  "Mrmrs": "voluptatem",
  "Title": "dolorem",
  "UpdatedDate": "2023-04-18T14:23:47.0348994+02:00",
  "CreatedDate": "2020-06-26T14:23:47.0348994+02:00",
  "BirthDate": "2016-12-09T14:23:47.0348994+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "magnam",
      "Description": "Upgradable human-resource artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "magnam",
      "Description": "Upgradable human-resource artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Description": "Business-focused impactful secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "laboriosam",
      "StrippedValue": "rem",
      "Description": "Multi-channelled leading edge throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "rem",
      "Description": "Multi-channelled leading edge throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "cumque",
      "Description": "Up-sized modular hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "cumque",
      "Description": "Up-sized modular hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "fugiat",
      "Description": "Horizontal static ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "fugiat",
      "Description": "Horizontal static ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "maxime",
      "StrippedValue": "cum",
      "Description": "Implemented disintermediate monitoring",
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
      "Value": "maxime",
      "StrippedValue": "cum",
      "Description": "Implemented disintermediate monitoring",
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
      "Value": "qui",
      "StrippedValue": "eius",
      "Description": "Up-sized dedicated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "eius",
      "Description": "Up-sized dedicated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
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
      "Id": 583,
      "Name": "Haag-Boyer",
      "ToolTip": "Quos iusto suscipit ad sint officia consequatur.",
      "Deleted": false,
      "Rank": 157,
      "Type": "eius",
      "ColorBlock": 180,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2007-12-10T14:23:47.0348994+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "maiores",
      "Hidden": true,
      "FullName": "Annabelle Bartell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "PersonNumber": "427872",
  "FullName": "Prof. Althea Tillman I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "autem",
      "Description": "Re-contextualized executive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "autem",
      "Description": "Re-contextualized executive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "FormalName": "Bailey, Kiehn and Ebert",
  "Address": null,
  "Post3": "reprehenderit",
  "Post2": "possimus",
  "Post1": "tempora",
  "Kanalname": "unde",
  "Kanafname": "sit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "debitis",
  "ActiveInterests": 727,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 914,
  "DbiKey": "asperiores",
  "DbiLastModified": "1996-10-21T14:23:47.0505119+02:00",
  "DbiLastSyncronized": "2018-03-03T14:23:47.0505119+01:00",
  "SentInfo": 441,
  "ShowContactTickets": 417,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ut",
      "StrippedValue": "voluptas",
      "Description": "Synergistic global orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptas",
      "Description": "Synergistic global orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "inventore",
      "StrippedValue": "quod",
      "Description": "Programmable dynamic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "quod",
      "Description": "Programmable dynamic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Source": 888,
  "ActiveErpLinks": 930,
  "ShipmentTypes": [
    {
      "Id": 471,
      "Name": "Blick Inc and Sons",
      "ToolTip": "Culpa quidem minima.",
      "Deleted": false,
      "Rank": 663,
      "Type": "voluptatem",
      "ColorBlock": 568,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2017-09-04T14:23:47.0505119+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "dicta",
      "Hidden": true,
      "FullName": "Janae Dickens",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 925,
      "Comment": "ex",
      "Registered": "2020-02-07T14:23:47.0505119+01:00",
      "RegisteredAssociateId": 630,
      "Updated": "2010-04-01T14:23:47.0505119+02:00",
      "UpdatedAssociateId": 720,
      "LegalBaseId": 352,
      "LegalBaseKey": "delectus",
      "LegalBaseName": "Rogahn, Lowe and Bins",
      "ConsentPurposeId": 802,
      "ConsentPurposeKey": "rerum",
      "ConsentPurposeName": "Ziemann, Daugherty and Mills",
      "ConsentSourceId": 10,
      "ConsentSourceKey": "inventore",
      "ConsentSourceName": "Dooley, Parker and Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 410
        }
      }
    }
  ],
  "BounceEmails": [
    "nathaniel@funk.us",
    "sincere_kassulke@reilly.com"
  ],
  "ActiveStatusMonitorId": 844,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Kelton Goldner"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 463
    }
  }
}
```
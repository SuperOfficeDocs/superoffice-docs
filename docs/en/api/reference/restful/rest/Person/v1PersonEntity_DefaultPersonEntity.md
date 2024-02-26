---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 20 Dec 2013 10:30:32 G12T

{
  "PersonId": 670,
  "Firstname": "Percival",
  "MiddleName": "Aufderhar-Marks",
  "Lastname": "Bradtke",
  "Mrmrs": "esse",
  "Title": "hic",
  "UpdatedDate": "2013-12-20T10:30:32.0886795+01:00",
  "CreatedDate": "2003-01-09T10:30:32.0886795+01:00",
  "BirthDate": "2005-11-25T10:30:32.0886795+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "cumque",
      "StrippedValue": "ex",
      "Description": "Decentralized human-resource ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 669
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "ex",
      "Description": "Decentralized human-resource ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 669
        }
      }
    }
  ],
  "Description": "Business-focused reciprocal throughput",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "molestias",
      "Description": "Seamless context-sensitive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "molestias",
      "Description": "Seamless context-sensitive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "optio",
      "StrippedValue": "blanditiis",
      "Description": "Sharable dynamic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "blanditiis",
      "Description": "Sharable dynamic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "aspernatur",
      "Description": "Focused 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 48
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "aspernatur",
      "Description": "Focused 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 48
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "autem",
      "Description": "Team-oriented homogeneous algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "autem",
      "Description": "Team-oriented homogeneous algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "corrupti",
      "Description": "Triple-buffered zero tolerance standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "corrupti",
      "Description": "Triple-buffered zero tolerance standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 467
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
      "Id": 400,
      "Name": "Turcotte, Ritchie and Howell",
      "ToolTip": "Pariatur laboriosam optio aut nihil.",
      "Deleted": true,
      "Rank": 673,
      "Type": "vitae",
      "ColorBlock": 444,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "2000-01-19T10:30:32.1044912+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ex",
      "StyleHint": "deleniti",
      "Hidden": false,
      "FullName": "Dr. Brad Drake Kovacek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "PersonNumber": "645680",
  "FullName": "Eleazar Marcel Ebert DVM",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "similique",
      "StrippedValue": "illum",
      "Description": "Persevering high-level secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "illum",
      "Description": "Persevering high-level secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "FormalName": "Wuckert-Abernathy",
  "Address": null,
  "Post3": "id",
  "Post2": "ut",
  "Post1": "doloribus",
  "Kanalname": "consectetur",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "necessitatibus",
  "ActiveInterests": 366,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 870,
  "DbiKey": "suscipit",
  "DbiLastModified": "2001-05-19T10:30:32.1044912+02:00",
  "DbiLastSyncronized": "2021-09-01T10:30:32.1044912+02:00",
  "SentInfo": 420,
  "ShowContactTickets": 958,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "consectetur",
      "StrippedValue": "eligendi",
      "Description": "Synergized high-level initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "eligendi",
      "Description": "Synergized high-level initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Universal multi-state throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Universal multi-state throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    }
  ],
  "Source": 316,
  "ActiveErpLinks": 49,
  "ShipmentTypes": [
    {
      "Id": 445,
      "Name": "Herzog Group",
      "ToolTip": "Voluptates enim fuga.",
      "Deleted": false,
      "Rank": 429,
      "Type": "ipsa",
      "ColorBlock": 90,
      "IconHint": "animi",
      "Selected": false,
      "LastChanged": "2011-02-12T10:30:32.1044912+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Korbin Lueilwitz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 383,
      "Comment": "placeat",
      "Registered": "2008-02-15T10:30:32.1044912+01:00",
      "RegisteredAssociateId": 920,
      "Updated": "2017-12-30T10:30:32.1044912+01:00",
      "UpdatedAssociateId": 342,
      "LegalBaseId": 14,
      "LegalBaseKey": "aperiam",
      "LegalBaseName": "Haag, Bernhard and Dach",
      "ConsentPurposeId": 379,
      "ConsentPurposeKey": "suscipit",
      "ConsentPurposeName": "Hackett, Boehm and Nolan",
      "ConsentSourceId": 84,
      "ConsentSourceKey": "ea",
      "ConsentSourceName": "Lakin-Orn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    }
  ],
  "BounceEmails": [
    "madisyn.kertzmann@kilback.biz",
    "theresa@riceboyle.com"
  ],
  "ActiveStatusMonitorId": 737,
  "UserDefinedFields": {
    "SuperOffice:1": "Xavier Considine",
    "SuperOffice:2": "1522562389"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 896
    }
  }
}
```
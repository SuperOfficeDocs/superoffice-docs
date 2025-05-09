---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=491
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
```


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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 381,
  "Firstname": "Dejon",
  "MiddleName": "Gleason, Gerhold and Barton",
  "Lastname": "Kovacek",
  "Mrmrs": "labore",
  "Title": "distinctio",
  "UpdatedDate": "2010-07-11T16:32:39.4302855+02:00",
  "CreatedDate": "2009-02-16T16:32:39.4302855+01:00",
  "BirthDate": "2021-11-01T16:32:39.4302855+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "labore",
      "Description": "Customer-focused explicit data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "labore",
      "Description": "Customer-focused explicit data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    }
  ],
  "Description": "Stand-alone analyzing product",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "neque",
      "Description": "Assimilated real-time project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "neque",
      "Description": "Assimilated real-time project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "eum",
      "Description": "Upgradable background system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "eum",
      "Description": "Upgradable background system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "voluptatibus",
      "Description": "Stand-alone radical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 139
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "voluptatibus",
      "Description": "Stand-alone radical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 139
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "repellendus",
      "Description": "Optimized attitude-oriented success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "repellendus",
      "Description": "Optimized attitude-oriented success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Down-sized uniform process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 684
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Down-sized uniform process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 684
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
      "Id": 386,
      "Name": "Olson, Heaney and Shanahan",
      "ToolTip": "A non molestiae occaecati dolorum tempore.",
      "Deleted": false,
      "Rank": 147,
      "Type": "ut",
      "ColorBlock": 545,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2023-06-21T16:32:39.4302855+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "distinctio",
      "StyleHint": "asperiores",
      "Hidden": true,
      "FullName": "Miss Burley Marquise Lehner DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 97
        }
      }
    }
  ],
  "PersonNumber": "1360312",
  "FullName": "Marquis Prosacco",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "odit",
      "Description": "Extended 6th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "odit",
      "Description": "Extended 6th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "FormalName": "Johnston-Kilback",
  "Address": null,
  "Post3": "occaecati",
  "Post2": "molestias",
  "Post1": "est",
  "Kanalname": "in",
  "Kanafname": "vero",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "repudiandae",
  "ActiveInterests": 807,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 153,
  "DbiKey": "ex",
  "DbiLastModified": "2023-08-21T16:32:39.4302855+02:00",
  "DbiLastSyncronized": "2003-10-06T16:32:39.4302855+02:00",
  "SentInfo": 29,
  "ShowContactTickets": 80,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "corporis",
      "StrippedValue": "ratione",
      "Description": "Cloned non-volatile framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 739
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "ratione",
      "Description": "Cloned non-volatile framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 739
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "inventore",
      "StrippedValue": "voluptatem",
      "Description": "Implemented transitional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 412
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "voluptatem",
      "Description": "Implemented transitional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 412
        }
      }
    }
  ],
  "Source": 838,
  "ActiveErpLinks": 235,
  "ShipmentTypes": [
    {
      "Id": 96,
      "Name": "Jenkins Group",
      "ToolTip": "Dolore doloribus sed sunt quisquam ut.",
      "Deleted": false,
      "Rank": 359,
      "Type": "nihil",
      "ColorBlock": 474,
      "IconHint": "ipsa",
      "Selected": false,
      "LastChanged": "2004-12-25T16:32:39.4302855+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Elsa Hartmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 383,
      "Comment": "voluptatum",
      "Registered": "2009-06-21T16:32:39.4302855+02:00",
      "RegisteredAssociateId": 117,
      "Updated": "2005-11-22T16:32:39.4302855+01:00",
      "UpdatedAssociateId": 864,
      "LegalBaseId": 481,
      "LegalBaseKey": "facilis",
      "LegalBaseName": "Frami, Zboncak and Hermiston",
      "ConsentPurposeId": 26,
      "ConsentPurposeKey": "accusamus",
      "ConsentPurposeName": "Leannon-Feest",
      "ConsentSourceId": 321,
      "ConsentSourceKey": "sit",
      "ConsentSourceName": "Abernathy Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "BounceEmails": [
    "jovani_lebsack@larson.biz",
    "esmeralda@cormier.biz"
  ],
  "ActiveStatusMonitorId": 579,
  "CreatedByFormId": 946,
  "UserDefinedFields": {
    "SuperOffice:1": "Pauline Muller",
    "SuperOffice:2": "Justyn Dibbert"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "officiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 727
    }
  }
}
```
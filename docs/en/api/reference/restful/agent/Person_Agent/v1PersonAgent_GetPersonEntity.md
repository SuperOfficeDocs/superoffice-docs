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
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=244
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 81,
  "Firstname": "Paolo",
  "MiddleName": "Stark-Nikolaus",
  "Lastname": "Reichel",
  "Mrmrs": "quia",
  "Title": "numquam",
  "UpdatedDate": "2018-10-06T10:17:55.800926+02:00",
  "CreatedDate": "2003-08-03T10:17:55.800926+02:00",
  "BirthDate": "2008-02-13T10:17:55.800926+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Assimilated grid-enabled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Assimilated grid-enabled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    }
  ],
  "Description": "Multi-layered impactful paradigm",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "libero",
      "Description": "Profit-focused analyzing adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "libero",
      "Description": "Profit-focused analyzing adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "deleniti",
      "Description": "Managed zero defect emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "deleniti",
      "Description": "Managed zero defect emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "similique",
      "StrippedValue": "animi",
      "Description": "Versatile uniform Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "animi",
      "Description": "Versatile uniform Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Adaptive maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Adaptive maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Public-key responsive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Public-key responsive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
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
      "Id": 727,
      "Name": "O'Reilly, Feest and Jacobson",
      "ToolTip": "Quis neque et excepturi.",
      "Deleted": true,
      "Rank": 613,
      "Type": "maxime",
      "ColorBlock": 485,
      "IconHint": "laborum",
      "Selected": true,
      "LastChanged": "2018-01-06T10:17:55.800926+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Leone Koepp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 839
        }
      }
    }
  ],
  "PersonNumber": "1048945",
  "FullName": "Ms. Laurel Lorine Schneider",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "sint",
      "Description": "Compatible methodical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "sint",
      "Description": "Compatible methodical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "FormalName": "Pfeffer-Hermann",
  "Address": null,
  "Post3": "totam",
  "Post2": "aliquid",
  "Post1": "veniam",
  "Kanalname": "distinctio",
  "Kanafname": "quisquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nihil",
  "ActiveInterests": 202,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 999,
  "DbiKey": "qui",
  "DbiLastModified": "1999-12-20T10:17:55.800926+01:00",
  "DbiLastSyncronized": "2000-11-23T10:17:55.800926+01:00",
  "SentInfo": 517,
  "ShowContactTickets": 496,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Self-enabling mission-critical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Self-enabling mission-critical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "possimus",
      "StrippedValue": "similique",
      "Description": "Re-engineered object-oriented instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "similique",
      "Description": "Re-engineered object-oriented instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    }
  ],
  "Source": 803,
  "ActiveErpLinks": 207,
  "ShipmentTypes": [
    {
      "Id": 745,
      "Name": "Weissnat LLC",
      "ToolTip": "Minima ut rerum odio temporibus delectus fuga.",
      "Deleted": true,
      "Rank": 294,
      "Type": "expedita",
      "ColorBlock": 393,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2002-06-09T10:17:55.800926+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "libero",
      "Hidden": false,
      "FullName": "Mr. Jodie Lee Keeling PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 443,
      "Comment": "modi",
      "Registered": "2011-10-16T10:17:55.800926+02:00",
      "RegisteredAssociateId": 106,
      "Updated": "2007-04-18T10:17:55.800926+02:00",
      "UpdatedAssociateId": 106,
      "LegalBaseId": 163,
      "LegalBaseKey": "commodi",
      "LegalBaseName": "Jakubowski, Ernser and Wisozk",
      "ConsentPurposeId": 919,
      "ConsentPurposeKey": "unde",
      "ConsentPurposeName": "Runolfsdottir-Hettinger",
      "ConsentSourceId": 423,
      "ConsentSourceKey": "quaerat",
      "ConsentSourceName": "Gusikowski, Jacobi and Goyette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "BounceEmails": [
    "jose@mckenziedenesik.biz",
    "terence.lubowitz@leuschkekuphal.com"
  ],
  "ActiveStatusMonitorId": 426,
  "CreatedByFormId": 830,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Lula Pacocha Jr.",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "impedit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 995
    }
  }
}
```
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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 259
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 501,
  "Firstname": "Randi",
  "MiddleName": "Bayer, Kovacek and Beer",
  "Lastname": "King",
  "Mrmrs": "atque",
  "Title": "id",
  "UpdatedDate": "2016-04-15T17:54:03.3983189+02:00",
  "CreatedDate": "1998-04-26T17:54:03.3983189+02:00",
  "BirthDate": "2021-12-16T17:54:03.3983189+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "nam",
      "Description": "Customizable optimizing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "nam",
      "Description": "Customizable optimizing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "Description": "Re-contextualized bandwidth-monitored ability",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quam",
      "StrippedValue": "tempora",
      "Description": "Configurable regional portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "tempora",
      "Description": "Configurable regional portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestias",
      "StrippedValue": "vitae",
      "Description": "Enhanced local leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "vitae",
      "Description": "Enhanced local leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "laudantium",
      "Description": "Re-contextualized user-facing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "laudantium",
      "Description": "Re-contextualized user-facing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "qui",
      "Description": "Up-sized system-worthy benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "qui",
      "Description": "Up-sized system-worthy benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "soluta",
      "StrippedValue": "atque",
      "Description": "Total logistical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "atque",
      "Description": "Total logistical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
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
      "Id": 576,
      "Name": "Boyer, Renner and Raynor",
      "ToolTip": "Ab quo et repudiandae suscipit.",
      "Deleted": true,
      "Rank": 705,
      "Type": "dolores",
      "ColorBlock": 228,
      "IconHint": "eaque",
      "Selected": false,
      "LastChanged": "2010-07-18T17:54:03.3983189+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Carolyne Bruen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 838
        }
      }
    }
  ],
  "PersonNumber": "1470705",
  "FullName": "Mrs. Wyatt Hand",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "unde",
      "Description": "Networked asynchronous forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 194
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "unde",
      "Description": "Networked asynchronous forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 194
        }
      }
    }
  ],
  "FormalName": "Fay-Kozey",
  "Address": null,
  "Post3": "officia",
  "Post2": "autem",
  "Post1": "nobis",
  "Kanalname": "molestiae",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 864,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 115,
  "DbiKey": "quis",
  "DbiLastModified": "2023-08-15T17:54:03.3983189+02:00",
  "DbiLastSyncronized": "2022-04-13T17:54:03.3983189+02:00",
  "SentInfo": 367,
  "ShowContactTickets": 309,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "harum",
      "StrippedValue": "natus",
      "Description": "Virtual discrete functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "natus",
      "Description": "Virtual discrete functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Digitized scalable focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Digitized scalable focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Source": 38,
  "ActiveErpLinks": 257,
  "ShipmentTypes": [
    {
      "Id": 261,
      "Name": "Littel LLC",
      "ToolTip": "Quas eveniet eius ut qui.",
      "Deleted": true,
      "Rank": 996,
      "Type": "ut",
      "ColorBlock": 447,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "2003-07-06T17:54:03.3983189+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Adriel Camille Bartoletti DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 834,
      "Comment": "facere",
      "Registered": "1998-05-04T17:54:03.3983189+02:00",
      "RegisteredAssociateId": 160,
      "Updated": "2002-04-05T17:54:03.3983189+02:00",
      "UpdatedAssociateId": 490,
      "LegalBaseId": 690,
      "LegalBaseKey": "tempora",
      "LegalBaseName": "Ortiz, Borer and Crist",
      "ConsentPurposeId": 543,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Ernser, Bechtelar and Jast",
      "ConsentSourceId": 187,
      "ConsentSourceKey": "quaerat",
      "ConsentSourceName": "Nitzsche Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    }
  ],
  "BounceEmails": [
    "cristal.cruickshank@braun.us",
    "muhammad@wisozkhuel.com"
  ],
  "ActiveStatusMonitorId": 499,
  "CreatedByFormId": 103,
  "UserDefinedFields": {
    "SuperOffice:1": "2027006000",
    "SuperOffice:2": "Lucious Dach"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "pariatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 72
    }
  }
}
```
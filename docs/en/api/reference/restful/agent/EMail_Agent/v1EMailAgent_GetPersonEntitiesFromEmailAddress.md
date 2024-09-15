---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
generated: true
---

# POST Agents/EMail/GetPersonEntitiesFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
```

Get all persons and contacts with the given email address


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress?$select=name,department,category/id
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

EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "ona@wisozkkunde.info"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 195,
    "Firstname": "Cathy",
    "MiddleName": "Tromp-Jacobi",
    "Lastname": "Moen",
    "Mrmrs": "ut",
    "Title": "dolores",
    "UpdatedDate": "2006-06-20T04:02:01.706124+02:00",
    "CreatedDate": "2005-10-26T04:02:01.706124+02:00",
    "BirthDate": "2010-10-18T04:02:01.706124+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "incidunt",
        "StrippedValue": "nulla",
        "Description": "Monitored background customer loyalty",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 748
          }
        }
      },
      {
        "Value": "incidunt",
        "StrippedValue": "nulla",
        "Description": "Monitored background customer loyalty",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 748
          }
        }
      }
    ],
    "Description": "Inverse local info-mediaries",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "sit",
        "StrippedValue": "laudantium",
        "Description": "Exclusive local product",
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
        "Value": "sit",
        "StrippedValue": "laudantium",
        "Description": "Exclusive local product",
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
    "Faxes": [
      {
        "Value": "ducimus",
        "StrippedValue": "enim",
        "Description": "Cloned contextually-based internet solution",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 235
          }
        }
      },
      {
        "Value": "ducimus",
        "StrippedValue": "enim",
        "Description": "Cloned contextually-based internet solution",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 235
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "nisi",
        "StrippedValue": "dolorem",
        "Description": "Public-key stable customer loyalty",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 190
          }
        }
      },
      {
        "Value": "nisi",
        "StrippedValue": "dolorem",
        "Description": "Public-key stable customer loyalty",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 190
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "culpa",
        "StrippedValue": "voluptatem",
        "Description": "Digitized analyzing core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 921
          }
        }
      },
      {
        "Value": "culpa",
        "StrippedValue": "voluptatem",
        "Description": "Digitized analyzing core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 921
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "numquam",
        "StrippedValue": "voluptatem",
        "Description": "Multi-channelled 3rd generation capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 918
          }
        }
      },
      {
        "Value": "numquam",
        "StrippedValue": "voluptatem",
        "Description": "Multi-channelled 3rd generation capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 918
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
        "Name": "Wilderman Inc and Sons",
        "ToolTip": "Autem cumque voluptas tempora.",
        "Deleted": true,
        "Rank": 758,
        "Type": "culpa",
        "ColorBlock": 379,
        "IconHint": "voluptas",
        "Selected": false,
        "LastChanged": "2010-10-26T04:02:01.706124+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "cumque",
        "StyleHint": "corrupti",
        "Hidden": true,
        "FullName": "Nona Ritchie",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 477
          }
        }
      }
    ],
    "PersonNumber": "698087",
    "FullName": "Ms. Sydnie Murphy PhD",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "est",
        "StrippedValue": "necessitatibus",
        "Description": "Persistent maximized ability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 445
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "necessitatibus",
        "Description": "Persistent maximized ability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 445
          }
        }
      }
    ],
    "FormalName": "Ritchie-Botsford",
    "Address": null,
    "Post3": "nostrum",
    "Post2": "vitae",
    "Post1": "nobis",
    "Kanalname": "corporis",
    "Kanafname": "impedit",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "facere",
    "ActiveInterests": 825,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 661,
    "DbiKey": "explicabo",
    "DbiLastModified": "2021-05-05T04:02:01.706124+02:00",
    "DbiLastSyncronized": "2002-06-02T04:02:01.706124+02:00",
    "SentInfo": 34,
    "ShowContactTickets": 326,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "sed",
        "StrippedValue": "qui",
        "Description": "Multi-layered analyzing capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 414
          }
        }
      },
      {
        "Value": "sed",
        "StrippedValue": "qui",
        "Description": "Multi-layered analyzing capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 414
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "tempora",
        "StrippedValue": "dolores",
        "Description": "Self-enabling dedicated strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 434
          }
        }
      },
      {
        "Value": "tempora",
        "StrippedValue": "dolores",
        "Description": "Self-enabling dedicated strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 434
          }
        }
      }
    ],
    "Source": 258,
    "ActiveErpLinks": 868,
    "ShipmentTypes": [
      {
        "Id": 751,
        "Name": "Weissnat LLC",
        "ToolTip": "Eum nulla laudantium.",
        "Deleted": false,
        "Rank": 684,
        "Type": "placeat",
        "ColorBlock": 805,
        "IconHint": "velit",
        "Selected": true,
        "LastChanged": "2002-02-23T04:02:01.706124+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "explicabo",
        "StyleHint": "unde",
        "Hidden": false,
        "FullName": "Devyn Rice",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 922
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 716,
        "Comment": "quia",
        "Registered": "2016-03-01T04:02:01.706124+01:00",
        "RegisteredAssociateId": 948,
        "Updated": "2002-01-12T04:02:01.706124+01:00",
        "UpdatedAssociateId": 627,
        "LegalBaseId": 52,
        "LegalBaseKey": "adipisci",
        "LegalBaseName": "Kerluke, Greenfelder and O'Hara",
        "ConsentPurposeId": 363,
        "ConsentPurposeKey": "suscipit",
        "ConsentPurposeName": "Huels-Schowalter",
        "ConsentSourceId": 849,
        "ConsentSourceKey": "magnam",
        "ConsentSourceName": "Schmeler, Kilback and Weber",
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
    "BounceEmails": [
      "myrna@willharvey.ca",
      "linda_ward@glover.name"
    ],
    "ActiveStatusMonitorId": 741,
    "CreatedByFormId": 105,
    "UserDefinedFields": {
      "SuperOffice:1": "Rocio Murray",
      "SuperOffice:2": "1604384185"
    },
    "ExtraFields": {
      "ExtraFields1": "consequatur",
      "ExtraFields2": "dolor"
    },
    "CustomFields": {
      "CustomFields1": "natus",
      "CustomFields2": "expedita"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 744
      }
    }
  }
]
```
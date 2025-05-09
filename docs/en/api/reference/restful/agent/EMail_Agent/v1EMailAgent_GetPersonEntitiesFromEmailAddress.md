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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "hayley.hyatt@schummheathcote.biz"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 369,
    "Firstname": "Vivien",
    "MiddleName": "Haley-Sipes",
    "Lastname": "Blick",
    "Mrmrs": "ipsum",
    "Title": "aperiam",
    "UpdatedDate": "1999-06-04T16:32:39.0082952+02:00",
    "CreatedDate": "2002-11-05T16:32:39.0082952+01:00",
    "BirthDate": "2018-12-09T16:32:39.0082952+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "ducimus",
        "StrippedValue": "saepe",
        "Description": "Realigned systemic attitude",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 82
          }
        }
      },
      {
        "Value": "ducimus",
        "StrippedValue": "saepe",
        "Description": "Realigned systemic attitude",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 82
          }
        }
      }
    ],
    "Description": "Open-source web-enabled knowledge base",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "et",
        "StrippedValue": "cum",
        "Description": "Mandatory responsive core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 598
          }
        }
      },
      {
        "Value": "et",
        "StrippedValue": "cum",
        "Description": "Mandatory responsive core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 598
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "distinctio",
        "StrippedValue": "voluptatem",
        "Description": "Universal system-worthy capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 12
          }
        }
      },
      {
        "Value": "distinctio",
        "StrippedValue": "voluptatem",
        "Description": "Universal system-worthy capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 12
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "molestias",
        "StrippedValue": "nam",
        "Description": "Ameliorated multi-state success",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 193
          }
        }
      },
      {
        "Value": "molestias",
        "StrippedValue": "nam",
        "Description": "Ameliorated multi-state success",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 193
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "illo",
        "StrippedValue": "a",
        "Description": "Multi-tiered methodical flexibility",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 810
          }
        }
      },
      {
        "Value": "illo",
        "StrippedValue": "a",
        "Description": "Multi-tiered methodical flexibility",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 810
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "enim",
        "StrippedValue": "inventore",
        "Description": "Secured bifurcated middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 162
          }
        }
      },
      {
        "Value": "enim",
        "StrippedValue": "inventore",
        "Description": "Secured bifurcated middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 162
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
        "Id": 681,
        "Name": "Donnelly, Torp and Crona",
        "ToolTip": "Quibusdam maiores ut enim illo perferendis.",
        "Deleted": false,
        "Rank": 59,
        "Type": "ut",
        "ColorBlock": 166,
        "IconHint": "vel",
        "Selected": false,
        "LastChanged": "2009-11-26T16:32:39.0239176+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "pariatur",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Wyatt Swaniawski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 865
          }
        }
      }
    ],
    "PersonNumber": "647997",
    "FullName": "Miss Finn Donnelly",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "minus",
        "StrippedValue": "porro",
        "Description": "Robust regional policy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 344
          }
        }
      },
      {
        "Value": "minus",
        "StrippedValue": "porro",
        "Description": "Robust regional policy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 344
          }
        }
      }
    ],
    "FormalName": "Sanford LLC",
    "Address": null,
    "Post3": "harum",
    "Post2": "deleniti",
    "Post1": "fugit",
    "Kanalname": "beatae",
    "Kanafname": "non",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "aspernatur",
    "ActiveInterests": 622,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 828,
    "DbiKey": "dolor",
    "DbiLastModified": "2002-01-16T16:32:39.0239176+01:00",
    "DbiLastSyncronized": "2019-03-09T16:32:39.0239176+01:00",
    "SentInfo": 502,
    "ShowContactTickets": 490,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "est",
        "StrippedValue": "beatae",
        "Description": "Automated value-added framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 133
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "beatae",
        "Description": "Automated value-added framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 133
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "quos",
        "StrippedValue": "rerum",
        "Description": "Progressive radical approach",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 34
          }
        }
      },
      {
        "Value": "quos",
        "StrippedValue": "rerum",
        "Description": "Progressive radical approach",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 34
          }
        }
      }
    ],
    "Source": 654,
    "ActiveErpLinks": 93,
    "ShipmentTypes": [
      {
        "Id": 545,
        "Name": "Hilpert, Fahey and D'Amore",
        "ToolTip": "Quas voluptate ipsum voluptas.",
        "Deleted": true,
        "Rank": 158,
        "Type": "dolorem",
        "ColorBlock": 390,
        "IconHint": "nostrum",
        "Selected": false,
        "LastChanged": "1999-05-30T16:32:39.0239176+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "nihil",
        "Hidden": false,
        "FullName": "Prof. Marlin Wallace Tromp",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 54
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 574,
        "Comment": "aut",
        "Registered": "2003-04-14T16:32:39.0239176+02:00",
        "RegisteredAssociateId": 111,
        "Updated": "2004-02-05T16:32:39.0239176+01:00",
        "UpdatedAssociateId": 982,
        "LegalBaseId": 619,
        "LegalBaseKey": "et",
        "LegalBaseName": "Mueller, Jerde and Schneider",
        "ConsentPurposeId": 470,
        "ConsentPurposeKey": "architecto",
        "ConsentPurposeName": "Effertz, Leannon and Collins",
        "ConsentSourceId": 878,
        "ConsentSourceKey": "quo",
        "ConsentSourceName": "Spinka LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 326
          }
        }
      }
    ],
    "BounceEmails": [
      "cletus@kirlindoyle.uk",
      "erick@morar.us"
    ],
    "ActiveStatusMonitorId": 9,
    "CreatedByFormId": 883,
    "UserDefinedFields": {
      "SuperOffice:1": "Sheila Stracke",
      "SuperOffice:2": "Mrs. Winston Jairo Rohan"
    },
    "ExtraFields": {
      "ExtraFields1": "nihil",
      "ExtraFields2": "sint"
    },
    "CustomFields": {
      "CustomFields1": "sit",
      "CustomFields2": "voluptate"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 215
      }
    }
  }
]
```
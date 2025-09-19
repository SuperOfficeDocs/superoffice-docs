---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "ross@rutherfordlindgren.name"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 146,
    "Firstname": "Hailie",
    "MiddleName": "Nikolaus, Homenick and Lesch",
    "Lastname": "Wisozk",
    "Mrmrs": "ad",
    "Title": "architecto",
    "UpdatedDate": "2007-08-09T03:41:53.5119835+02:00",
    "CreatedDate": "2006-04-06T03:41:53.5119835+02:00",
    "BirthDate": "2003-09-25T03:41:53.5119835+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "in",
        "StrippedValue": "magnam",
        "Description": "Face to face coherent interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 789
          }
        }
      },
      {
        "Value": "in",
        "StrippedValue": "magnam",
        "Description": "Face to face coherent interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 789
          }
        }
      }
    ],
    "Description": "Enhanced disintermediate workforce",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "nihil",
        "StrippedValue": "aut",
        "Description": "Multi-channelled eco-centric Graphic Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 343
          }
        }
      },
      {
        "Value": "nihil",
        "StrippedValue": "aut",
        "Description": "Multi-channelled eco-centric Graphic Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 343
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "necessitatibus",
        "StrippedValue": "voluptatem",
        "Description": "Ameliorated incremental extranet",
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
        "Value": "necessitatibus",
        "StrippedValue": "voluptatem",
        "Description": "Ameliorated incremental extranet",
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
    "MobilePhones": [
      {
        "Value": "quo",
        "StrippedValue": "sapiente",
        "Description": "Fundamental client-driven projection",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 158
          }
        }
      },
      {
        "Value": "quo",
        "StrippedValue": "sapiente",
        "Description": "Fundamental client-driven projection",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 158
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "non",
        "StrippedValue": "illo",
        "Description": "Reduced foreground artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 290
          }
        }
      },
      {
        "Value": "non",
        "StrippedValue": "illo",
        "Description": "Reduced foreground artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 290
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "quis",
        "StrippedValue": "quisquam",
        "Description": "Persevering well-modulated architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 8
          }
        }
      },
      {
        "Value": "quis",
        "StrippedValue": "quisquam",
        "Description": "Persevering well-modulated architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 8
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
        "Id": 631,
        "Name": "Schumm, O'Hara and Schiller",
        "ToolTip": "Corporis eligendi expedita autem consequuntur id sint.",
        "Deleted": false,
        "Rank": 921,
        "Type": "sapiente",
        "ColorBlock": 691,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2009-12-29T03:41:53.5119835+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "porro",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Ms. Whitney Gregory Bergstrom",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 887
          }
        }
      }
    ],
    "PersonNumber": "387796",
    "FullName": "Marge Hoeger II",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "esse",
        "StrippedValue": "velit",
        "Description": "Phased intangible orchestration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 732
          }
        }
      },
      {
        "Value": "esse",
        "StrippedValue": "velit",
        "Description": "Phased intangible orchestration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 732
          }
        }
      }
    ],
    "FormalName": "Lowe Inc and Sons",
    "Address": null,
    "Post3": "ducimus",
    "Post2": "est",
    "Post1": "voluptates",
    "Kanalname": "in",
    "Kanafname": "culpa",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "ut",
    "ActiveInterests": 626,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 638,
    "DbiKey": "fugit",
    "DbiLastModified": "2020-06-22T03:41:53.5119835+02:00",
    "DbiLastSyncronized": "2023-06-15T03:41:53.5119835+02:00",
    "SentInfo": 393,
    "ShowContactTickets": 33,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "veniam",
        "StrippedValue": "pariatur",
        "Description": "Organized directional conglomeration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 940
          }
        }
      },
      {
        "Value": "veniam",
        "StrippedValue": "pariatur",
        "Description": "Organized directional conglomeration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 940
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "animi",
        "StrippedValue": "odio",
        "Description": "Intuitive analyzing budgetary management",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 135
          }
        }
      },
      {
        "Value": "animi",
        "StrippedValue": "odio",
        "Description": "Intuitive analyzing budgetary management",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 135
          }
        }
      }
    ],
    "Source": 319,
    "ActiveErpLinks": 653,
    "ShipmentTypes": [
      {
        "Id": 653,
        "Name": "Miller, Fadel and Towne",
        "ToolTip": "Recusandae eos optio.",
        "Deleted": false,
        "Rank": 693,
        "Type": "eos",
        "ColorBlock": 89,
        "IconHint": "commodi",
        "Selected": true,
        "LastChanged": "2004-04-17T03:41:53.5119835+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "exercitationem",
        "Hidden": false,
        "FullName": "Mrs. Adolphus Block",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 377
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 298,
        "Comment": "omnis",
        "Registered": "2006-01-04T03:41:53.5119835+01:00",
        "RegisteredAssociateId": 927,
        "Updated": "2009-02-12T03:41:53.5119835+01:00",
        "UpdatedAssociateId": 749,
        "LegalBaseId": 577,
        "LegalBaseKey": "eos",
        "LegalBaseName": "Conroy Group",
        "ConsentPurposeId": 362,
        "ConsentPurposeKey": "iusto",
        "ConsentPurposeName": "Cronin, Koch and Balistreri",
        "ConsentSourceId": 664,
        "ConsentSourceKey": "adipisci",
        "ConsentSourceName": "Kunze, Terry and Bartoletti",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 643
          }
        }
      }
    ],
    "BounceEmails": [
      "antwon@lehnerwelch.com",
      "mathias@abshire.info"
    ],
    "ActiveStatusMonitorId": 963,
    "CreatedByFormId": 655,
    "UtmParameters": null,
    "LeadstatusId": 552,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "assumenda",
      "ExtraFields2": "esse"
    },
    "CustomFields": {
      "CustomFields1": "ut",
      "CustomFields2": "eum"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  }
]
```
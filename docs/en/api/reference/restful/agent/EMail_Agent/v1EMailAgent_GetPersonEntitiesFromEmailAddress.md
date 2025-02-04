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
  "EmailAddress": "napoleon_runolfsdottir@haley.info"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 437,
    "Firstname": "Viviane",
    "MiddleName": "Frami-Haag",
    "Lastname": "Lebsack",
    "Mrmrs": "nihil",
    "Title": "culpa",
    "UpdatedDate": "2011-01-11T13:13:23.0239812+01:00",
    "CreatedDate": "2010-06-14T13:13:23.0239812+02:00",
    "BirthDate": "2022-02-01T13:13:23.0239812+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "eum",
        "StrippedValue": "voluptatem",
        "Description": "Total even-keeled synergy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 537
          }
        }
      },
      {
        "Value": "eum",
        "StrippedValue": "voluptatem",
        "Description": "Total even-keeled synergy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 537
          }
        }
      }
    ],
    "Description": "Compatible needs-based architecture",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "nemo",
        "StrippedValue": "autem",
        "Description": "Assimilated hybrid hardware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 881
          }
        }
      },
      {
        "Value": "nemo",
        "StrippedValue": "autem",
        "Description": "Assimilated hybrid hardware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 881
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "ipsa",
        "StrippedValue": "quos",
        "Description": "Reduced methodical strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 927
          }
        }
      },
      {
        "Value": "ipsa",
        "StrippedValue": "quos",
        "Description": "Reduced methodical strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 927
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "fugit",
        "StrippedValue": "iste",
        "Description": "Public-key object-oriented throughput",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 321
          }
        }
      },
      {
        "Value": "fugit",
        "StrippedValue": "iste",
        "Description": "Public-key object-oriented throughput",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 321
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "error",
        "StrippedValue": "deserunt",
        "Description": "Realigned well-modulated firmware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 911
          }
        }
      },
      {
        "Value": "error",
        "StrippedValue": "deserunt",
        "Description": "Realigned well-modulated firmware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 911
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "corporis",
        "StrippedValue": "voluptatem",
        "Description": "Customer-focused asynchronous toolset",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 841
          }
        }
      },
      {
        "Value": "corporis",
        "StrippedValue": "voluptatem",
        "Description": "Customer-focused asynchronous toolset",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 841
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
        "Id": 984,
        "Name": "White, McKenzie and Beier",
        "ToolTip": "Dicta et commodi et qui qui deleniti.",
        "Deleted": false,
        "Rank": 508,
        "Type": "modi",
        "ColorBlock": 920,
        "IconHint": "quod",
        "Selected": false,
        "LastChanged": "2022-11-09T13:13:23.0239812+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "repellat",
        "StyleHint": "autem",
        "Hidden": true,
        "FullName": "Ms. Milford Vincenzo Lebsack",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 333
          }
        }
      }
    ],
    "PersonNumber": "773924",
    "FullName": "Magnolia Alberta Boehm DDS",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "in",
        "StrippedValue": "veritatis",
        "Description": "Optional bi-directional adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 541
          }
        }
      },
      {
        "Value": "in",
        "StrippedValue": "veritatis",
        "Description": "Optional bi-directional adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 541
          }
        }
      }
    ],
    "FormalName": "Walker, Parisian and Cronin",
    "Address": null,
    "Post3": "ad",
    "Post2": "incidunt",
    "Post1": "neque",
    "Kanalname": "expedita",
    "Kanafname": "exercitationem",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "animi",
    "ActiveInterests": 788,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 732,
    "DbiKey": "maxime",
    "DbiLastModified": "2023-01-30T13:13:23.0239812+01:00",
    "DbiLastSyncronized": "2004-07-13T13:13:23.0239812+02:00",
    "SentInfo": 823,
    "ShowContactTickets": 240,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "sit",
        "StrippedValue": "temporibus",
        "Description": "Sharable high-level groupware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 424
          }
        }
      },
      {
        "Value": "sit",
        "StrippedValue": "temporibus",
        "Description": "Sharable high-level groupware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 424
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "nobis",
        "StrippedValue": "voluptas",
        "Description": "Multi-lateral assymetric migration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 972
          }
        }
      },
      {
        "Value": "nobis",
        "StrippedValue": "voluptas",
        "Description": "Multi-lateral assymetric migration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 972
          }
        }
      }
    ],
    "Source": 269,
    "ActiveErpLinks": 313,
    "ShipmentTypes": [
      {
        "Id": 497,
        "Name": "Schinner, Carroll and Parker",
        "ToolTip": "Ducimus totam consequatur vero praesentium eaque qui.",
        "Deleted": false,
        "Rank": 657,
        "Type": "mollitia",
        "ColorBlock": 14,
        "IconHint": "ipsa",
        "Selected": false,
        "LastChanged": "2018-07-31T13:13:23.0239812+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officiis",
        "StyleHint": "saepe",
        "Hidden": true,
        "FullName": "Tavares Bashirian",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 322
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 288,
        "Comment": "minima",
        "Registered": "2020-12-27T13:13:23.0239812+01:00",
        "RegisteredAssociateId": 535,
        "Updated": "2022-09-05T13:13:23.0239812+02:00",
        "UpdatedAssociateId": 487,
        "LegalBaseId": 294,
        "LegalBaseKey": "in",
        "LegalBaseName": "Farrell-Howell",
        "ConsentPurposeId": 414,
        "ConsentPurposeKey": "quasi",
        "ConsentPurposeName": "Witting Inc and Sons",
        "ConsentSourceId": 995,
        "ConsentSourceKey": "illum",
        "ConsentSourceName": "Bogan, Stamm and Schulist",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 469
          }
        }
      }
    ],
    "BounceEmails": [
      "bailee@pollich.ca",
      "kenna.parker@collier.com"
    ],
    "ActiveStatusMonitorId": 234,
    "CreatedByFormId": 963,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "Orville Stanton"
    },
    "ExtraFields": {
      "ExtraFields1": "sed",
      "ExtraFields2": "omnis"
    },
    "CustomFields": {
      "CustomFields1": "est",
      "CustomFields2": "illum"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 363
      }
    }
  }
]
```
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "athena@toybednar.co.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 802,
    "Firstname": "Eldon",
    "MiddleName": "Stanton LLC",
    "Lastname": "Stark",
    "Mrmrs": "consequatur",
    "Title": "iure",
    "UpdatedDate": "2015-06-09T14:28:21.9460219+02:00",
    "CreatedDate": "2013-07-04T14:28:21.9460219+02:00",
    "BirthDate": "2025-02-04T14:28:21.9460219+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "doloremque",
        "StrippedValue": "et",
        "Description": "Focused cohesive framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 749
          }
        }
      },
      {
        "Value": "doloremque",
        "StrippedValue": "et",
        "Description": "Focused cohesive framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 749
          }
        }
      }
    ],
    "Description": "Assimilated even-keeled benchmark",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "occaecati",
        "StrippedValue": "sequi",
        "Description": "Self-enabling disintermediate adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 744
          }
        }
      },
      {
        "Value": "occaecati",
        "StrippedValue": "sequi",
        "Description": "Self-enabling disintermediate adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 744
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "iste",
        "StrippedValue": "minima",
        "Description": "Phased non-volatile support",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 320
          }
        }
      },
      {
        "Value": "iste",
        "StrippedValue": "minima",
        "Description": "Phased non-volatile support",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 320
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "eveniet",
        "StrippedValue": "neque",
        "Description": "Cross-platform leading edge archive",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 762
          }
        }
      },
      {
        "Value": "eveniet",
        "StrippedValue": "neque",
        "Description": "Cross-platform leading edge archive",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 762
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "nam",
        "StrippedValue": "eveniet",
        "Description": "Universal zero defect frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 167
          }
        }
      },
      {
        "Value": "nam",
        "StrippedValue": "eveniet",
        "Description": "Universal zero defect frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 167
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "adipisci",
        "StrippedValue": "aut",
        "Description": "Polarised systematic encryption",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 10
          }
        }
      },
      {
        "Value": "adipisci",
        "StrippedValue": "aut",
        "Description": "Polarised systematic encryption",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 10
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
        "Id": 811,
        "Name": "Gulgowski-Rosenbaum",
        "ToolTip": "Est et eaque et quo aspernatur nisi ab.",
        "Deleted": true,
        "Rank": 251,
        "Type": "rerum",
        "ColorBlock": 803,
        "IconHint": "dolorum",
        "Selected": false,
        "LastChanged": "2017-01-11T14:28:21.9460219+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "numquam",
        "Hidden": true,
        "FullName": "Prof. Alfredo Lesch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 711
          }
        }
      }
    ],
    "PersonNumber": "775773",
    "FullName": "Noah Hansen",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {
        "Value": "ut",
        "StrippedValue": "libero",
        "Description": "Total bottom-line superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 819
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "libero",
        "Description": "Total bottom-line superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 819
          }
        }
      }
    ],
    "FormalName": "Bernier, Abshire and Corwin",
    "Address": null,
    "Post3": "similique",
    "Post2": "fugit",
    "Post1": "sed",
    "Kanalname": "maxime",
    "Kanafname": "soluta",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "repellendus",
    "ActiveInterests": 814,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 112,
    "DbiKey": "aliquam",
    "DbiLastModified": "1999-09-21T14:28:21.9460219+02:00",
    "DbiLastSyncronized": "1999-01-27T14:28:21.9460219+01:00",
    "SentInfo": 685,
    "ShowContactTickets": 865,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "iure",
        "StrippedValue": "voluptate",
        "Description": "Fully-configurable full-range service-desk",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 635
          }
        }
      },
      {
        "Value": "iure",
        "StrippedValue": "voluptate",
        "Description": "Fully-configurable full-range service-desk",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 635
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "commodi",
        "StrippedValue": "quia",
        "Description": "Optional exuding extranet",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 895
          }
        }
      },
      {
        "Value": "commodi",
        "StrippedValue": "quia",
        "Description": "Optional exuding extranet",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 895
          }
        }
      }
    ],
    "Source": 432,
    "ActiveErpLinks": 822,
    "ShipmentTypes": [
      {
        "Id": 602,
        "Name": "Willms LLC",
        "ToolTip": "Nihil dolorem incidunt.",
        "Deleted": true,
        "Rank": 394,
        "Type": "earum",
        "ColorBlock": 986,
        "IconHint": "enim",
        "Selected": false,
        "LastChanged": "2019-07-12T14:28:21.9460219+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "temporibus",
        "StyleHint": "architecto",
        "Hidden": false,
        "FullName": "Jayda Molly Hills II",
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
    "Consents": [
      {
        "ConsentPersonId": 240,
        "Comment": "id",
        "Registered": "2019-04-28T14:28:21.9460219+02:00",
        "RegisteredAssociateId": 331,
        "Updated": "2002-10-07T14:28:21.9460219+02:00",
        "UpdatedAssociateId": 194,
        "LegalBaseId": 443,
        "LegalBaseKey": "unde",
        "LegalBaseName": "Pouros, Kuhlman and Lynch",
        "ConsentPurposeId": 992,
        "ConsentPurposeKey": "expedita",
        "ConsentPurposeName": "Raynor, Johns and Kilback",
        "ConsentSourceId": 535,
        "ConsentSourceKey": "dignissimos",
        "ConsentSourceName": "Reichert Group",
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
    "BounceEmails": [
      "joey.miller@kihn.ca",
      "dixie@marquardt.com"
    ],
    "ActiveStatusMonitorId": 739,
    "CreatedByFormId": 395,
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "Chanelle Flatley"
    },
    "ExtraFields": {
      "ExtraFields1": "quia",
      "ExtraFields2": "dolorem"
    },
    "CustomFields": {
      "CustomFields1": "velit",
      "CustomFields2": "et"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 334
      }
    }
  }
]
```
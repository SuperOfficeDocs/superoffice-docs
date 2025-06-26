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
  "EmailAddress": "avis@heathcote.info"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 42,
    "Firstname": "Ron",
    "MiddleName": "Rodriguez, Prosacco and Kerluke",
    "Lastname": "Altenwerth",
    "Mrmrs": "labore",
    "Title": "et",
    "UpdatedDate": "2018-04-12T03:45:23.4204561+02:00",
    "CreatedDate": "2016-10-05T03:45:23.4204561+02:00",
    "BirthDate": "2018-10-05T03:45:23.4204561+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "quas",
        "StrippedValue": "et",
        "Description": "Self-enabling global productivity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 93
          }
        }
      },
      {
        "Value": "quas",
        "StrippedValue": "et",
        "Description": "Self-enabling global productivity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 93
          }
        }
      }
    ],
    "Description": "Cloned well-modulated challenge",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "enim",
        "StrippedValue": "ea",
        "Description": "Organic responsive utilisation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 565
          }
        }
      },
      {
        "Value": "enim",
        "StrippedValue": "ea",
        "Description": "Organic responsive utilisation",
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
    "Faxes": [
      {
        "Value": "architecto",
        "StrippedValue": "cum",
        "Description": "Networked stable methodology",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 89
          }
        }
      },
      {
        "Value": "architecto",
        "StrippedValue": "cum",
        "Description": "Networked stable methodology",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 89
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "consequatur",
        "StrippedValue": "ut",
        "Description": "Intuitive bandwidth-monitored data-warehouse",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 627
          }
        }
      },
      {
        "Value": "consequatur",
        "StrippedValue": "ut",
        "Description": "Intuitive bandwidth-monitored data-warehouse",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 627
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "est",
        "StrippedValue": "id",
        "Description": "Managed homogeneous matrices",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 90
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "id",
        "Description": "Managed homogeneous matrices",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 90
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "nisi",
        "StrippedValue": "et",
        "Description": "Horizontal well-modulated array",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 25
          }
        }
      },
      {
        "Value": "nisi",
        "StrippedValue": "et",
        "Description": "Horizontal well-modulated array",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 25
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
        "Id": 920,
        "Name": "Langosh, Gleichner and Torp",
        "ToolTip": "Quaerat voluptas ex doloremque aut aperiam.",
        "Deleted": true,
        "Rank": 14,
        "Type": "aut",
        "ColorBlock": 815,
        "IconHint": "possimus",
        "Selected": true,
        "LastChanged": "2001-03-22T03:45:23.4204561+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "nostrum",
        "Hidden": true,
        "FullName": "Oswald Fahey",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 771
          }
        }
      }
    ],
    "PersonNumber": "177728",
    "FullName": "Alfonzo Langosh",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "suscipit",
        "StrippedValue": "fuga",
        "Description": "Stand-alone 4th generation strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 471
          }
        }
      },
      {
        "Value": "suscipit",
        "StrippedValue": "fuga",
        "Description": "Stand-alone 4th generation strategy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 471
          }
        }
      }
    ],
    "FormalName": "Feeney Group",
    "Address": null,
    "Post3": "sapiente",
    "Post2": "cumque",
    "Post1": "atque",
    "Kanalname": "soluta",
    "Kanafname": "ea",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "et",
    "ActiveInterests": 464,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 754,
    "DbiKey": "aut",
    "DbiLastModified": "1998-10-06T03:45:23.4204561+02:00",
    "DbiLastSyncronized": "2004-11-16T03:45:23.4204561+01:00",
    "SentInfo": 28,
    "ShowContactTickets": 565,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "hic",
        "StrippedValue": "et",
        "Description": "Multi-lateral real-time parallelism",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 53
          }
        }
      },
      {
        "Value": "hic",
        "StrippedValue": "et",
        "Description": "Multi-lateral real-time parallelism",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 53
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "qui",
        "StrippedValue": "recusandae",
        "Description": "Exclusive mobile architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 816
          }
        }
      },
      {
        "Value": "qui",
        "StrippedValue": "recusandae",
        "Description": "Exclusive mobile architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 816
          }
        }
      }
    ],
    "Source": 777,
    "ActiveErpLinks": 819,
    "ShipmentTypes": [
      {
        "Id": 763,
        "Name": "Adams, Ziemann and Keebler",
        "ToolTip": "Voluptas aspernatur quo numquam nesciunt autem in.",
        "Deleted": true,
        "Rank": 803,
        "Type": "ut",
        "ColorBlock": 375,
        "IconHint": "quia",
        "Selected": false,
        "LastChanged": "2015-06-30T03:45:23.4204561+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "eos",
        "Hidden": false,
        "FullName": "Rosamond Nicklaus Konopelski II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 692
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 428,
        "Comment": "numquam",
        "Registered": "2024-04-01T03:45:23.4204561+02:00",
        "RegisteredAssociateId": 551,
        "Updated": "2018-01-20T03:45:23.4204561+01:00",
        "UpdatedAssociateId": 981,
        "LegalBaseId": 45,
        "LegalBaseKey": "doloribus",
        "LegalBaseName": "Legros-Wolff",
        "ConsentPurposeId": 357,
        "ConsentPurposeKey": "dignissimos",
        "ConsentPurposeName": "Feeney-White",
        "ConsentSourceId": 155,
        "ConsentSourceKey": "et",
        "ConsentSourceName": "Kulas Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 624
          }
        }
      }
    ],
    "BounceEmails": [
      "serenity_gulgowski@kuhic.name",
      "jeffry_klein@cormier.biz"
    ],
    "ActiveStatusMonitorId": 355,
    "CreatedByFormId": 830,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "Elnora Amir Beatty MD"
    },
    "ExtraFields": {
      "ExtraFields1": "iste",
      "ExtraFields2": "dolorem"
    },
    "CustomFields": {
      "CustomFields1": "hic",
      "CustomFields2": "expedita"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 559
      }
    }
  }
]
```
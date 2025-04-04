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
  "EmailAddress": "pierre@corwin.co.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 685,
    "Firstname": "Marlon",
    "MiddleName": "Hackett-Mills",
    "Lastname": "Purdy",
    "Mrmrs": "tempora",
    "Title": "magni",
    "UpdatedDate": "2024-08-19T13:14:00.3449758+02:00",
    "CreatedDate": "2023-05-17T13:14:00.3449758+02:00",
    "BirthDate": "2018-04-20T13:14:00.3449758+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "sapiente",
        "StrippedValue": "dolores",
        "Description": "Integrated impactful info-mediaries",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 809
          }
        }
      },
      {
        "Value": "sapiente",
        "StrippedValue": "dolores",
        "Description": "Integrated impactful info-mediaries",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 809
          }
        }
      }
    ],
    "Description": "Inverse systemic middleware",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "eaque",
        "StrippedValue": "vitae",
        "Description": "Visionary foreground Graphical User Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 279
          }
        }
      },
      {
        "Value": "eaque",
        "StrippedValue": "vitae",
        "Description": "Visionary foreground Graphical User Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 279
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "qui",
        "StrippedValue": "sed",
        "Description": "Persevering cohesive groupware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 842
          }
        }
      },
      {
        "Value": "qui",
        "StrippedValue": "sed",
        "Description": "Persevering cohesive groupware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 842
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "quis",
        "StrippedValue": "ducimus",
        "Description": "Proactive scalable Graphical User Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 369
          }
        }
      },
      {
        "Value": "quis",
        "StrippedValue": "ducimus",
        "Description": "Proactive scalable Graphical User Interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 369
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "quo",
        "StrippedValue": "mollitia",
        "Description": "Managed solution-oriented complexity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 821
          }
        }
      },
      {
        "Value": "quo",
        "StrippedValue": "mollitia",
        "Description": "Managed solution-oriented complexity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 821
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "soluta",
        "StrippedValue": "et",
        "Description": "Self-enabling 24/7 open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 898
          }
        }
      },
      {
        "Value": "soluta",
        "StrippedValue": "et",
        "Description": "Self-enabling 24/7 open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 898
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
        "Id": 208,
        "Name": "Jakubowski-Kuvalis",
        "ToolTip": "Voluptatem omnis labore minus aliquid expedita vero.",
        "Deleted": false,
        "Rank": 936,
        "Type": "ab",
        "ColorBlock": 633,
        "IconHint": "maxime",
        "Selected": true,
        "LastChanged": "2003-03-05T13:14:00.3449758+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aspernatur",
        "StyleHint": "sequi",
        "Hidden": false,
        "FullName": "Alexane Cruickshank",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 532
          }
        }
      }
    ],
    "PersonNumber": "1070744",
    "FullName": "Eloise Brakus",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "ipsam",
        "StrippedValue": "adipisci",
        "Description": "Digitized optimizing interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 83
          }
        }
      },
      {
        "Value": "ipsam",
        "StrippedValue": "adipisci",
        "Description": "Digitized optimizing interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 83
          }
        }
      }
    ],
    "FormalName": "Ledner, Fritsch and Larson",
    "Address": null,
    "Post3": "voluptatem",
    "Post2": "et",
    "Post1": "blanditiis",
    "Kanalname": "ut",
    "Kanafname": "eligendi",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "eius",
    "ActiveInterests": 779,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 419,
    "DbiKey": "beatae",
    "DbiLastModified": "2013-04-25T13:14:00.3449758+02:00",
    "DbiLastSyncronized": "2020-08-27T13:14:00.3449758+02:00",
    "SentInfo": 544,
    "ShowContactTickets": 909,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "molestiae",
        "StrippedValue": "dicta",
        "Description": "Digitized reciprocal architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 33
          }
        }
      },
      {
        "Value": "molestiae",
        "StrippedValue": "dicta",
        "Description": "Digitized reciprocal architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 33
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "sequi",
        "StrippedValue": "fuga",
        "Description": "Self-enabling client-server installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 649
          }
        }
      },
      {
        "Value": "sequi",
        "StrippedValue": "fuga",
        "Description": "Self-enabling client-server installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 649
          }
        }
      }
    ],
    "Source": 39,
    "ActiveErpLinks": 700,
    "ShipmentTypes": [
      {
        "Id": 982,
        "Name": "Weimann-Lueilwitz",
        "ToolTip": "Quibusdam necessitatibus.",
        "Deleted": false,
        "Rank": 295,
        "Type": "ullam",
        "ColorBlock": 308,
        "IconHint": "magnam",
        "Selected": false,
        "LastChanged": "2020-08-24T13:14:00.3449758+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "ducimus",
        "Hidden": true,
        "FullName": "Patrick Weber V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 115
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 116,
        "Comment": "alias",
        "Registered": "2006-02-12T13:14:00.3449758+01:00",
        "RegisteredAssociateId": 352,
        "Updated": "2000-11-27T13:14:00.3449758+01:00",
        "UpdatedAssociateId": 908,
        "LegalBaseId": 96,
        "LegalBaseKey": "id",
        "LegalBaseName": "Schuppe LLC",
        "ConsentPurposeId": 23,
        "ConsentPurposeKey": "voluptate",
        "ConsentPurposeName": "Muller-Ritchie",
        "ConsentSourceId": 367,
        "ConsentSourceKey": "nam",
        "ConsentSourceName": "Metz, Deckow and Balistreri",
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
      "darby_bosco@strosin.uk",
      "nicolette.champlin@wolf.ca"
    ],
    "ActiveStatusMonitorId": 101,
    "CreatedByFormId": 186,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "Jammie Marvin Dibbert IV"
    },
    "ExtraFields": {
      "ExtraFields1": "quasi",
      "ExtraFields2": "aliquam"
    },
    "CustomFields": {
      "CustomFields1": "dolor",
      "CustomFields2": "mollitia"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 729
      }
    }
  }
]
```
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "ebony.keeling@stamm.com"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 411,
    "Firstname": "Zachariah",
    "MiddleName": "Dickens Inc and Sons",
    "Lastname": "Prohaska",
    "Mrmrs": "architecto",
    "Title": "accusantium",
    "UpdatedDate": "2003-03-15T11:24:48.0626591+01:00",
    "CreatedDate": "1999-05-12T11:24:48.0626591+02:00",
    "BirthDate": "1998-05-13T11:24:48.0626591+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "ex",
        "StrippedValue": "repellat",
        "Description": "Ergonomic 5th generation process improvement",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 6
          }
        }
      },
      {
        "Value": "ex",
        "StrippedValue": "repellat",
        "Description": "Ergonomic 5th generation process improvement",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 6
          }
        }
      }
    ],
    "Description": "Organic dynamic methodology",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "vel",
        "StrippedValue": "ut",
        "Description": "Digitized optimal definition",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 775
          }
        }
      },
      {
        "Value": "vel",
        "StrippedValue": "ut",
        "Description": "Digitized optimal definition",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 775
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "animi",
        "StrippedValue": "et",
        "Description": "Universal bi-directional emulation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 492
          }
        }
      },
      {
        "Value": "animi",
        "StrippedValue": "et",
        "Description": "Universal bi-directional emulation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 492
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "iusto",
        "StrippedValue": "saepe",
        "Description": "Mandatory analyzing superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 798
          }
        }
      },
      {
        "Value": "iusto",
        "StrippedValue": "saepe",
        "Description": "Mandatory analyzing superstructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 798
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "et",
        "StrippedValue": "corrupti",
        "Description": "Down-sized foreground help-desk",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 786
          }
        }
      },
      {
        "Value": "et",
        "StrippedValue": "corrupti",
        "Description": "Down-sized foreground help-desk",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 786
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "quibusdam",
        "StrippedValue": "maiores",
        "Description": "Switchable logistical portal",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 589
          }
        }
      },
      {
        "Value": "quibusdam",
        "StrippedValue": "maiores",
        "Description": "Switchable logistical portal",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 589
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
        "Id": 394,
        "Name": "Davis, Morissette and Goldner",
        "ToolTip": "Corrupti est animi sit repellat in aliquam eum.",
        "Deleted": false,
        "Rank": 99,
        "Type": "officia",
        "ColorBlock": 625,
        "IconHint": "exercitationem",
        "Selected": false,
        "LastChanged": "2003-06-12T11:24:48.078283+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptates",
        "StyleHint": "doloribus",
        "Hidden": false,
        "FullName": "Mrs. Bria Dewitt Homenick I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 15
          }
        }
      }
    ],
    "PersonNumber": "661483",
    "FullName": "William Franecki",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "perspiciatis",
        "StrippedValue": "vel",
        "Description": "Sharable bottom-line open architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 174
          }
        }
      },
      {
        "Value": "perspiciatis",
        "StrippedValue": "vel",
        "Description": "Sharable bottom-line open architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 174
          }
        }
      }
    ],
    "FormalName": "Labadie-Miller",
    "Address": null,
    "Post3": "sunt",
    "Post2": "est",
    "Post1": "et",
    "Kanalname": "et",
    "Kanafname": "et",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "ipsam",
    "ActiveInterests": 723,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 271,
    "DbiKey": "debitis",
    "DbiLastModified": "2013-03-27T11:24:48.078283+01:00",
    "DbiLastSyncronized": "2024-08-08T11:24:48.078283+02:00",
    "SentInfo": 590,
    "ShowContactTickets": 18,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "quam",
        "StrippedValue": "porro",
        "Description": "Networked even-keeled infrastructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 356
          }
        }
      },
      {
        "Value": "quam",
        "StrippedValue": "porro",
        "Description": "Networked even-keeled infrastructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 356
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "veniam",
        "StrippedValue": "commodi",
        "Description": "Versatile radical knowledge user",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 267
          }
        }
      },
      {
        "Value": "veniam",
        "StrippedValue": "commodi",
        "Description": "Versatile radical knowledge user",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 267
          }
        }
      }
    ],
    "Source": 774,
    "ActiveErpLinks": 950,
    "ShipmentTypes": [
      {
        "Id": 207,
        "Name": "Marquardt-Kautzer",
        "ToolTip": "Harum ipsam alias omnis occaecati deserunt.",
        "Deleted": false,
        "Rank": 828,
        "Type": "id",
        "ColorBlock": 936,
        "IconHint": "nihil",
        "Selected": true,
        "LastChanged": "2015-01-10T11:24:48.078283+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "amet",
        "StyleHint": "ratione",
        "Hidden": false,
        "FullName": "Mrs. Casimir Bert Hoeger DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 419
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 209,
        "Comment": "repellendus",
        "Registered": "2014-07-20T11:24:48.078283+02:00",
        "RegisteredAssociateId": 146,
        "Updated": "2022-03-17T11:24:48.078283+01:00",
        "UpdatedAssociateId": 299,
        "LegalBaseId": 436,
        "LegalBaseKey": "voluptatem",
        "LegalBaseName": "Gutmann-Crona",
        "ConsentPurposeId": 641,
        "ConsentPurposeKey": "tempore",
        "ConsentPurposeName": "Kutch Inc and Sons",
        "ConsentSourceId": 249,
        "ConsentSourceKey": "dignissimos",
        "ConsentSourceName": "Haley, Nitzsche and Lubowitz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 390
          }
        }
      }
    ],
    "BounceEmails": [
      "kailee@goldner.uk",
      "magali.walter@grimes.co.uk"
    ],
    "ActiveStatusMonitorId": 154,
    "CreatedByFormId": 747,
    "UtmParameters": null,
    "LeadstatusId": 629,
    "UserDefinedFields": {
      "SuperOffice:1": "1614067982",
      "SuperOffice:2": "1200062915"
    },
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "rerum"
    },
    "CustomFields": {
      "CustomFields1": "non",
      "CustomFields2": "dolor"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 220
      }
    }
  }
]
```
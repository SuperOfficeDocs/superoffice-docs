---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
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
| EmailAddress | string |  |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "lupe.moore@ziemann.co.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 852,
    "Firstname": "Winnifred",
    "MiddleName": "Feeney Inc and Sons",
    "Lastname": "Pouros",
    "Mrmrs": "et",
    "Title": "nobis",
    "UpdatedDate": "2005-05-14T11:10:26.9114255+02:00",
    "CreatedDate": "1995-09-24T11:10:26.9114255+02:00",
    "BirthDate": "2004-12-09T11:10:26.9114255+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "dolorem",
        "StrippedValue": "officia",
        "Description": "Triple-buffered responsive utilisation",
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
        "Value": "dolorem",
        "StrippedValue": "officia",
        "Description": "Triple-buffered responsive utilisation",
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
    "Description": "Customizable 5th generation capacity",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "ut",
        "StrippedValue": "ut",
        "Description": "Implemented secondary time-frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 548
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "ut",
        "Description": "Implemented secondary time-frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 548
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "laborum",
        "StrippedValue": "quo",
        "Description": "Upgradable demand-driven complexity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 237
          }
        }
      },
      {
        "Value": "laborum",
        "StrippedValue": "quo",
        "Description": "Upgradable demand-driven complexity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 237
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "repudiandae",
        "StrippedValue": "delectus",
        "Description": "Organized hybrid analyzer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 67
          }
        }
      },
      {
        "Value": "repudiandae",
        "StrippedValue": "delectus",
        "Description": "Organized hybrid analyzer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 67
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "aut",
        "StrippedValue": "eligendi",
        "Description": "Focused fresh-thinking conglomeration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 911
          }
        }
      },
      {
        "Value": "aut",
        "StrippedValue": "eligendi",
        "Description": "Focused fresh-thinking conglomeration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 911
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "est",
        "StrippedValue": "eum",
        "Description": "Robust methodical infrastructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 924
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "eum",
        "Description": "Robust methodical infrastructure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 924
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
        "Id": 229,
        "Name": "Feil LLC",
        "ToolTip": "Rerum minus non omnis.",
        "Deleted": true,
        "Rank": 619,
        "Type": "suscipit",
        "ColorBlock": 18,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2020-08-25T11:10:26.9134249+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dignissimos",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Alexandra Koch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 952
          }
        }
      }
    ],
    "PersonNumber": "704998",
    "FullName": "Jena Murphy",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "iusto",
        "StrippedValue": "blanditiis",
        "Description": "Fully-configurable local collaboration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 308
          }
        }
      },
      {
        "Value": "iusto",
        "StrippedValue": "blanditiis",
        "Description": "Fully-configurable local collaboration",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 308
          }
        }
      }
    ],
    "FormalName": "Crist-Donnelly",
    "Address": null,
    "Post3": "nesciunt",
    "Post2": "doloremque",
    "Post1": "minus",
    "Kanalname": "exercitationem",
    "Kanafname": "culpa",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "a",
    "ActiveInterests": 544,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 667,
    "DbiKey": "cum",
    "DbiLastModified": "2020-07-29T11:10:26.9164247+02:00",
    "DbiLastSyncronized": "2007-03-11T11:10:26.9164247+01:00",
    "SentInfo": 406,
    "ShowContactTickets": 658,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "sequi",
        "StrippedValue": "numquam",
        "Description": "Compatible solution-oriented analyzer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 143
          }
        }
      },
      {
        "Value": "sequi",
        "StrippedValue": "numquam",
        "Description": "Compatible solution-oriented analyzer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 143
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "omnis",
        "StrippedValue": "consequatur",
        "Description": "Organized non-volatile hub",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 221
          }
        }
      },
      {
        "Value": "omnis",
        "StrippedValue": "consequatur",
        "Description": "Organized non-volatile hub",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 221
          }
        }
      }
    ],
    "Source": 407,
    "ActiveErpLinks": 642,
    "ShipmentTypes": [
      {
        "Id": 645,
        "Name": "Wuckert, Mueller and Purdy",
        "ToolTip": "Voluptatem suscipit quibusdam magnam hic.",
        "Deleted": false,
        "Rank": 971,
        "Type": "et",
        "ColorBlock": 586,
        "IconHint": "voluptatem",
        "Selected": true,
        "LastChanged": "2008-01-25T11:10:26.9174249+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "porro",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Mr. Morgan Garland Littel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 962
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 928,
        "Comment": "consectetur",
        "Registered": "2005-09-24T11:10:26.9174249+02:00",
        "RegisteredAssociateId": 634,
        "Updated": "2009-12-19T11:10:26.9174249+01:00",
        "UpdatedAssociateId": 32,
        "LegalBaseId": 253,
        "LegalBaseKey": "incidunt",
        "LegalBaseName": "Beatty Group",
        "ConsentPurposeId": 190,
        "ConsentPurposeKey": "dolorem",
        "ConsentPurposeName": "Schaefer-Turcotte",
        "ConsentSourceId": 401,
        "ConsentSourceKey": "modi",
        "ConsentSourceName": "Brekke Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 77
          }
        }
      }
    ],
    "BounceEmails": [
      "jessika@willmskuhic.co.uk",
      "brenden@maggio.ca"
    ],
    "ActiveStatusMonitorId": 314,
    "UserDefinedFields": {
      "SuperOffice:1": "Darian Wilderman",
      "SuperOffice:2": "1053298690"
    },
    "ExtraFields": {
      "ExtraFields1": "ut",
      "ExtraFields2": "autem"
    },
    "CustomFields": {
      "CustomFields1": "voluptas",
      "CustomFields2": "quod"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 415
      }
    }
  }
]
```
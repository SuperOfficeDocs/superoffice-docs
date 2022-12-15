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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "novella.weber@kautzergreen.co.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 481,
    "Firstname": "Breana",
    "MiddleName": "Farrell Group",
    "Lastname": "Robel",
    "Mrmrs": "harum",
    "Title": "quaerat",
    "UpdatedDate": "2010-08-17T02:49:44.4191642+02:00",
    "CreatedDate": "2013-10-26T02:49:44.4191642+02:00",
    "BirthDate": "2016-05-29T02:49:44.4191642+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "est",
        "StrippedValue": "magnam",
        "Description": "Balanced local emulation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 258
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "magnam",
        "Description": "Balanced local emulation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 258
          }
        }
      }
    ],
    "Description": "Ameliorated 24 hour frame",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "eligendi",
        "StrippedValue": "ea",
        "Description": "Streamlined 3rd generation ability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 665
          }
        }
      },
      {
        "Value": "eligendi",
        "StrippedValue": "ea",
        "Description": "Streamlined 3rd generation ability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 665
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "ut",
        "StrippedValue": "minima",
        "Description": "Sharable holistic instruction set",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 603
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "minima",
        "Description": "Sharable holistic instruction set",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 603
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "sunt",
        "StrippedValue": "dignissimos",
        "Description": "Phased encompassing knowledge base",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 908
          }
        }
      },
      {
        "Value": "sunt",
        "StrippedValue": "dignissimos",
        "Description": "Phased encompassing knowledge base",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 908
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "pariatur",
        "StrippedValue": "autem",
        "Description": "Self-enabling high-level contingency",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 723
          }
        }
      },
      {
        "Value": "pariatur",
        "StrippedValue": "autem",
        "Description": "Self-enabling high-level contingency",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 723
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "repellendus",
        "StrippedValue": "quis",
        "Description": "Stand-alone composite adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 316
          }
        }
      },
      {
        "Value": "repellendus",
        "StrippedValue": "quis",
        "Description": "Stand-alone composite adapter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 316
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
        "Id": 630,
        "Name": "Harvey-McGlynn",
        "ToolTip": "Omnis occaecati voluptatum delectus minima quis commodi esse.",
        "Deleted": false,
        "Rank": 198,
        "Type": "et",
        "ColorBlock": 502,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2003-07-04T02:49:44.4191642+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "incidunt",
        "StyleHint": "tempore",
        "Hidden": false,
        "FullName": "Pinkie Wisoky",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 488
          }
        }
      }
    ],
    "PersonNumber": "282206",
    "FullName": "Prof. Fannie Mueller DDS",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "quas",
        "StrippedValue": "atque",
        "Description": "Sharable multimedia extranet",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 283
          }
        }
      },
      {
        "Value": "quas",
        "StrippedValue": "atque",
        "Description": "Sharable multimedia extranet",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 283
          }
        }
      }
    ],
    "FormalName": "Nader-Botsford",
    "Address": null,
    "Post3": "quibusdam",
    "Post2": "autem",
    "Post1": "voluptatibus",
    "Kanalname": "ut",
    "Kanafname": "et",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "officia",
    "ActiveInterests": 920,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 994,
    "DbiKey": "inventore",
    "DbiLastModified": "2021-06-09T02:49:44.4191642+02:00",
    "DbiLastSyncronized": "2003-01-22T02:49:44.4191642+01:00",
    "SentInfo": 178,
    "ShowContactTickets": 435,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "nisi",
        "StrippedValue": "quidem",
        "Description": "User-centric assymetric implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 37
          }
        }
      },
      {
        "Value": "nisi",
        "StrippedValue": "quidem",
        "Description": "User-centric assymetric implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 37
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "veritatis",
        "StrippedValue": "consequatur",
        "Description": "Phased heuristic success",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 106
          }
        }
      },
      {
        "Value": "veritatis",
        "StrippedValue": "consequatur",
        "Description": "Phased heuristic success",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 106
          }
        }
      }
    ],
    "Source": 246,
    "ActiveErpLinks": 390,
    "ShipmentTypes": [
      {
        "Id": 886,
        "Name": "Wilkinson LLC",
        "ToolTip": "Praesentium reiciendis magni ea.",
        "Deleted": false,
        "Rank": 120,
        "Type": "inventore",
        "ColorBlock": 164,
        "IconHint": "reiciendis",
        "Selected": false,
        "LastChanged": "2004-12-01T02:49:44.4191642+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Yvonne Bahringer I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 427
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 78,
        "Comment": "rerum",
        "Registered": "2018-09-11T02:49:44.4191642+02:00",
        "RegisteredAssociateId": 757,
        "Updated": "2018-05-27T02:49:44.4191642+02:00",
        "UpdatedAssociateId": 296,
        "LegalBaseId": 100,
        "LegalBaseKey": "natus",
        "LegalBaseName": "Marks-Collier",
        "ConsentPurposeId": 608,
        "ConsentPurposeKey": "sed",
        "ConsentPurposeName": "Schuppe Inc and Sons",
        "ConsentSourceId": 779,
        "ConsentSourceKey": "blanditiis",
        "ConsentSourceName": "Hane Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 235
          }
        }
      }
    ],
    "BounceEmails": [
      "simeon.batz@smithambraun.info",
      "krystel.hessel@botsfordgulgowski.name"
    ],
    "ActiveStatusMonitorId": 669,
    "UserDefinedFields": {
      "SuperOffice:1": "Marianna Cronin",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "eum"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "possimus"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 733
      }
    }
  }
]
```
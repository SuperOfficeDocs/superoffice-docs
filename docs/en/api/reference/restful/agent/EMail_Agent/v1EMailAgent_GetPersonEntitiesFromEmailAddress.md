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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "ivah.schulist@casperlockman.us"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 522,
    "Firstname": "Keenan",
    "MiddleName": "Bauch Group",
    "Lastname": "Eichmann",
    "Mrmrs": "maiores",
    "Title": "nemo",
    "UpdatedDate": "2005-06-02T11:22:38.242853+02:00",
    "CreatedDate": "2005-07-10T11:22:38.242853+02:00",
    "BirthDate": "2013-05-18T11:22:38.242853+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "fuga",
        "StrippedValue": "soluta",
        "Description": "Organized uniform protocol",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 867
          }
        }
      },
      {
        "Value": "fuga",
        "StrippedValue": "soluta",
        "Description": "Organized uniform protocol",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 867
          }
        }
      }
    ],
    "Description": "Assimilated web-enabled attitude",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "necessitatibus",
        "StrippedValue": "ut",
        "Description": "Automated local time-frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 53
          }
        }
      },
      {
        "Value": "necessitatibus",
        "StrippedValue": "ut",
        "Description": "Automated local time-frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 53
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "minus",
        "StrippedValue": "amet",
        "Description": "Operative modular productivity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 887
          }
        }
      },
      {
        "Value": "minus",
        "StrippedValue": "amet",
        "Description": "Operative modular productivity",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 887
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "et",
        "StrippedValue": "officiis",
        "Description": "Intuitive non-volatile software",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 570
          }
        }
      },
      {
        "Value": "et",
        "StrippedValue": "officiis",
        "Description": "Intuitive non-volatile software",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 570
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "in",
        "StrippedValue": "voluptas",
        "Description": "Public-key stable forecast",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 438
          }
        }
      },
      {
        "Value": "in",
        "StrippedValue": "voluptas",
        "Description": "Public-key stable forecast",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 438
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "quas",
        "StrippedValue": "blanditiis",
        "Description": "Fully-configurable intangible open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 572
          }
        }
      },
      {
        "Value": "quas",
        "StrippedValue": "blanditiis",
        "Description": "Fully-configurable intangible open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 572
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
        "Id": 955,
        "Name": "Sawayn-Schmeler",
        "ToolTip": "Impedit ea tenetur occaecati.",
        "Deleted": false,
        "Rank": 786,
        "Type": "veniam",
        "ColorBlock": 555,
        "IconHint": "dolore",
        "Selected": true,
        "LastChanged": "1999-08-02T11:22:38.242853+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "quis",
        "Hidden": false,
        "FullName": "Macy Ward Raynor Jr.",
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
    "PersonNumber": "420300",
    "FullName": "Erin Lemke",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "exercitationem",
        "StrippedValue": "et",
        "Description": "Realigned human-resource task-force",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 856
          }
        }
      },
      {
        "Value": "exercitationem",
        "StrippedValue": "et",
        "Description": "Realigned human-resource task-force",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 856
          }
        }
      }
    ],
    "FormalName": "Dibbert LLC",
    "Address": null,
    "Post3": "culpa",
    "Post2": "sunt",
    "Post1": "et",
    "Kanalname": "voluptas",
    "Kanafname": "aut",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "qui",
    "ActiveInterests": 120,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 670,
    "DbiKey": "culpa",
    "DbiLastModified": "2005-12-27T11:22:38.242853+01:00",
    "DbiLastSyncronized": "2014-06-22T11:22:38.242853+02:00",
    "SentInfo": 59,
    "ShowContactTickets": 216,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "excepturi",
        "StrippedValue": "officiis",
        "Description": "Down-sized bandwidth-monitored functionalities",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 958
          }
        }
      },
      {
        "Value": "excepturi",
        "StrippedValue": "officiis",
        "Description": "Down-sized bandwidth-monitored functionalities",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 958
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "possimus",
        "StrippedValue": "voluptas",
        "Description": "Operative transitional implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 69
          }
        }
      },
      {
        "Value": "possimus",
        "StrippedValue": "voluptas",
        "Description": "Operative transitional implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 69
          }
        }
      }
    ],
    "Source": 188,
    "ActiveErpLinks": 694,
    "ShipmentTypes": [
      {
        "Id": 989,
        "Name": "Purdy-Wehner",
        "ToolTip": "Et veritatis rerum deserunt qui quo qui.",
        "Deleted": false,
        "Rank": 334,
        "Type": "voluptas",
        "ColorBlock": 581,
        "IconHint": "modi",
        "Selected": false,
        "LastChanged": "2017-09-13T11:22:38.242853+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "blanditiis",
        "StyleHint": "libero",
        "Hidden": false,
        "FullName": "Percy Ed Stark MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 629
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 426,
        "Comment": "culpa",
        "Registered": "2012-07-12T11:22:38.242853+02:00",
        "RegisteredAssociateId": 217,
        "Updated": "2000-09-25T11:22:38.242853+02:00",
        "UpdatedAssociateId": 839,
        "LegalBaseId": 742,
        "LegalBaseKey": "sunt",
        "LegalBaseName": "Pfannerstill, Blanda and Connelly",
        "ConsentPurposeId": 338,
        "ConsentPurposeKey": "nobis",
        "ConsentPurposeName": "Jones Inc and Sons",
        "ConsentSourceId": 13,
        "ConsentSourceKey": "aut",
        "ConsentSourceName": "Cronin Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 550
          }
        }
      }
    ],
    "BounceEmails": [
      "solon_klocko@gottlieb.co.uk",
      "richmond@schoen.us"
    ],
    "ActiveStatusMonitorId": 845,
    "UserDefinedFields": {
      "SuperOffice:1": "Ms. Lavern Alexandro Boyer Sr.",
      "SuperOffice:2": "Sabryna Hermann"
    },
    "ExtraFields": {
      "ExtraFields1": "tempora",
      "ExtraFields2": "aliquid"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "labore"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 580
      }
    }
  }
]
```
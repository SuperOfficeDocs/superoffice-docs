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
  "EmailAddress": "julien.metz@dibbert.uk"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 378,
    "Firstname": "Louie",
    "MiddleName": "Gottlieb-O'Connell",
    "Lastname": "Connelly",
    "Mrmrs": "ducimus",
    "Title": "omnis",
    "UpdatedDate": "2016-09-15T03:31:26.4644863+02:00",
    "CreatedDate": "2022-09-07T03:31:26.4644863+02:00",
    "BirthDate": "2016-09-23T03:31:26.4644863+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "omnis",
        "StrippedValue": "quia",
        "Description": "Cross-platform logistical core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 13
          }
        }
      },
      {
        "Value": "omnis",
        "StrippedValue": "quia",
        "Description": "Cross-platform logistical core",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 13
          }
        }
      }
    ],
    "Description": "Stand-alone real-time challenge",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "quas",
        "StrippedValue": "fugiat",
        "Description": "Business-focused demand-driven challenge",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 177
          }
        }
      },
      {
        "Value": "quas",
        "StrippedValue": "fugiat",
        "Description": "Business-focused demand-driven challenge",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 177
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "ab",
        "StrippedValue": "quia",
        "Description": "Multi-lateral bifurcated artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 745
          }
        }
      },
      {
        "Value": "ab",
        "StrippedValue": "quia",
        "Description": "Multi-lateral bifurcated artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 745
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "aspernatur",
        "StrippedValue": "officia",
        "Description": "Devolved fresh-thinking implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 318
          }
        }
      },
      {
        "Value": "aspernatur",
        "StrippedValue": "officia",
        "Description": "Devolved fresh-thinking implementation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 318
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "voluptas",
        "StrippedValue": "voluptas",
        "Description": "Advanced human-resource archive",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 61
          }
        }
      },
      {
        "Value": "voluptas",
        "StrippedValue": "voluptas",
        "Description": "Advanced human-resource archive",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 61
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "aut",
        "StrippedValue": "consequuntur",
        "Description": "User-friendly multimedia leverage",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 746
          }
        }
      },
      {
        "Value": "aut",
        "StrippedValue": "consequuntur",
        "Description": "User-friendly multimedia leverage",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 746
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
        "Id": 294,
        "Name": "VonRueden-Lynch",
        "ToolTip": "Accusantium rerum tenetur cumque.",
        "Deleted": true,
        "Rank": 597,
        "Type": "est",
        "ColorBlock": 600,
        "IconHint": "distinctio",
        "Selected": false,
        "LastChanged": "1997-08-21T03:31:26.4644863+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "cupiditate",
        "StyleHint": "officia",
        "Hidden": false,
        "FullName": "Loren Renner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 233
          }
        }
      }
    ],
    "PersonNumber": "1339994",
    "FullName": "Mrs. Viviane Nikolaus",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "odit",
        "StrippedValue": "cumque",
        "Description": "Persevering bandwidth-monitored projection",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      },
      {
        "Value": "odit",
        "StrippedValue": "cumque",
        "Description": "Persevering bandwidth-monitored projection",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      }
    ],
    "FormalName": "Dickens, Stanton and Treutel",
    "Address": null,
    "Post3": "nulla",
    "Post2": "qui",
    "Post1": "suscipit",
    "Kanalname": "provident",
    "Kanafname": "expedita",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "provident",
    "ActiveInterests": 346,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 402,
    "DbiKey": "fugiat",
    "DbiLastModified": "2006-05-10T03:31:26.4644863+02:00",
    "DbiLastSyncronized": "2014-03-23T03:31:26.4644863+01:00",
    "SentInfo": 364,
    "ShowContactTickets": 582,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "blanditiis",
        "StrippedValue": "doloremque",
        "Description": "Open-architected context-sensitive hardware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 561
          }
        }
      },
      {
        "Value": "blanditiis",
        "StrippedValue": "doloremque",
        "Description": "Open-architected context-sensitive hardware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 561
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "sunt",
        "StrippedValue": "et",
        "Description": "Monitored systematic website",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 728
          }
        }
      },
      {
        "Value": "sunt",
        "StrippedValue": "et",
        "Description": "Monitored systematic website",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 728
          }
        }
      }
    ],
    "Source": 101,
    "ActiveErpLinks": 458,
    "ShipmentTypes": [
      {
        "Id": 774,
        "Name": "Watsica, Denesik and Bosco",
        "ToolTip": "Enim consequatur.",
        "Deleted": true,
        "Rank": 571,
        "Type": "sed",
        "ColorBlock": 81,
        "IconHint": "ipsum",
        "Selected": false,
        "LastChanged": "2019-09-23T03:31:26.4644863+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laborum",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Lacey Bins",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 796
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 825,
        "Comment": "consectetur",
        "Registered": "1997-08-17T03:31:26.4644863+02:00",
        "RegisteredAssociateId": 55,
        "Updated": "2021-08-11T03:31:26.4644863+02:00",
        "UpdatedAssociateId": 652,
        "LegalBaseId": 241,
        "LegalBaseKey": "temporibus",
        "LegalBaseName": "Luettgen-Gulgowski",
        "ConsentPurposeId": 222,
        "ConsentPurposeKey": "voluptate",
        "ConsentPurposeName": "Bosco-Ziemann",
        "ConsentSourceId": 71,
        "ConsentSourceKey": "dicta",
        "ConsentSourceName": "Bayer Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 991
          }
        }
      }
    ],
    "BounceEmails": [
      "allison@howe.co.uk",
      "gilberto_hodkiewicz@kovacekkiehn.name"
    ],
    "ActiveStatusMonitorId": 221,
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "Mr. Evangeline Fay IV"
    },
    "ExtraFields": {
      "ExtraFields1": "qui",
      "ExtraFields2": "quod"
    },
    "CustomFields": {
      "CustomFields1": "maiores",
      "CustomFields2": "ea"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 27
      }
    }
  }
]
```
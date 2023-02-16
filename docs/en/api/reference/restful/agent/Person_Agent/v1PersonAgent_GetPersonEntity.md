---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=352
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 311,
  "Firstname": "Candido",
  "MiddleName": "Mertz Group",
  "Lastname": "Hickle",
  "Mrmrs": "illo",
  "Title": "dolores",
  "UpdatedDate": "2010-10-10T14:19:03.7801249+02:00",
  "CreatedDate": "2015-10-22T14:19:03.7801249+02:00",
  "BirthDate": "2011-02-07T14:19:03.7801249+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "explicabo",
      "Description": "Pre-emptive systemic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "explicabo",
      "Description": "Pre-emptive systemic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "Description": "Profit-focused systemic data-warehouse",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "consequatur",
      "Description": "Up-sized cohesive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "consequatur",
      "Description": "Up-sized cohesive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "commodi",
      "Description": "Profound tangible database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "commodi",
      "Description": "Profound tangible database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "odio",
      "Description": "Persevering 24 hour time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "odio",
      "Description": "Persevering 24 hour time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "veniam",
      "StrippedValue": "enim",
      "Description": "Ergonomic didactic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "enim",
      "Description": "Ergonomic didactic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ratione",
      "StrippedValue": "mollitia",
      "Description": "Re-contextualized multi-state methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "mollitia",
      "Description": "Re-contextualized multi-state methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
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
      "Id": 219,
      "Name": "Dooley, Bogan and Willms",
      "ToolTip": "Minima aspernatur voluptatem aspernatur quisquam commodi quos velit.",
      "Deleted": true,
      "Rank": 963,
      "Type": "vel",
      "ColorBlock": 174,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2017-11-17T14:19:03.7801249+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "incidunt",
      "Hidden": true,
      "FullName": "Dock Kessler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 100
        }
      }
    }
  ],
  "PersonNumber": "1735423",
  "FullName": "Delores Hauck",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "numquam",
      "Description": "Managed bandwidth-monitored support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "numquam",
      "Description": "Managed bandwidth-monitored support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    }
  ],
  "FormalName": "O'Kon, Zboncak and Stanton",
  "Address": null,
  "Post3": "quia",
  "Post2": "similique",
  "Post1": "consequatur",
  "Kanalname": "quia",
  "Kanafname": "impedit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 511,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 289,
  "DbiKey": "minus",
  "DbiLastModified": "2014-10-16T14:19:03.7801249+02:00",
  "DbiLastSyncronized": "1997-04-19T14:19:03.7801249+02:00",
  "SentInfo": 731,
  "ShowContactTickets": 711,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "error",
      "StrippedValue": "eos",
      "Description": "Re-contextualized responsive moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "eos",
      "Description": "Re-contextualized responsive moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "ut",
      "Description": "Integrated coherent model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "ut",
      "Description": "Integrated coherent model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "Source": 822,
  "ActiveErpLinks": 160,
  "ShipmentTypes": [
    {
      "Id": 527,
      "Name": "Lindgren-Klein",
      "ToolTip": "Et sapiente dolor.",
      "Deleted": false,
      "Rank": 885,
      "Type": "quod",
      "ColorBlock": 830,
      "IconHint": "aliquam",
      "Selected": false,
      "LastChanged": "2001-05-20T14:19:03.7801249+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "accusamus",
      "Hidden": false,
      "FullName": "Marina Becker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 258
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 915,
      "Comment": "quidem",
      "Registered": "2011-02-14T14:19:03.7801249+01:00",
      "RegisteredAssociateId": 222,
      "Updated": "2009-09-11T14:19:03.7801249+02:00",
      "UpdatedAssociateId": 781,
      "LegalBaseId": 382,
      "LegalBaseKey": "occaecati",
      "LegalBaseName": "Fay, Mayer and Hamill",
      "ConsentPurposeId": 92,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Davis Inc and Sons",
      "ConsentSourceId": 888,
      "ConsentSourceKey": "itaque",
      "ConsentSourceName": "Mills Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "BounceEmails": [
    "jeff.erdman@konopelskifisher.ca",
    "stephen.bradtke@okuneva.co.uk"
  ],
  "ActiveStatusMonitorId": 730,
  "UserDefinedFields": {
    "SuperOffice:1": "695409114",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "odit",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "asperiores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 329
    }
  }
}
```
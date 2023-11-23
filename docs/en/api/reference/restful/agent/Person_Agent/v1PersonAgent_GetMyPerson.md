---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 410,
  "Firstname": "Amiya",
  "MiddleName": "Ryan-Mayert",
  "Lastname": "Klein",
  "Mrmrs": "sunt",
  "Title": "rerum",
  "UpdatedDate": "2019-01-20T13:38:13.7803629+01:00",
  "CreatedDate": "2007-10-02T13:38:13.7803629+02:00",
  "BirthDate": "1999-04-19T13:38:13.7803629+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "corporis",
      "StrippedValue": "quia",
      "Description": "Organized heuristic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "quia",
      "Description": "Organized heuristic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    }
  ],
  "Description": "Managed homogeneous matrix",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "at",
      "StrippedValue": "ut",
      "Description": "Function-based neutral implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "ut",
      "Description": "Function-based neutral implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quis",
      "StrippedValue": "est",
      "Description": "Digitized zero defect neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "est",
      "Description": "Digitized zero defect neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "sint",
      "Description": "Stand-alone next generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "sint",
      "Description": "Stand-alone next generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "neque",
      "StrippedValue": "earum",
      "Description": "Automated responsive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "earum",
      "Description": "Automated responsive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "sed",
      "Description": "Focused radical support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "sed",
      "Description": "Focused radical support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
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
      "Id": 760,
      "Name": "Gottlieb Inc and Sons",
      "ToolTip": "Similique eum ex ut similique accusamus.",
      "Deleted": false,
      "Rank": 502,
      "Type": "perspiciatis",
      "ColorBlock": 394,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "1998-08-20T13:38:13.7803629+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Monique Botsford MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 547
        }
      }
    }
  ],
  "PersonNumber": "1143465",
  "FullName": "Valentina Kirlin III",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "quia",
      "Description": "Polarised directional parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "quia",
      "Description": "Polarised directional parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "FormalName": "Bartoletti Inc and Sons",
  "Address": null,
  "Post3": "numquam",
  "Post2": "non",
  "Post1": "ipsam",
  "Kanalname": "in",
  "Kanafname": "dolorem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "id",
  "ActiveInterests": 810,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 807,
  "DbiKey": "et",
  "DbiLastModified": "2021-06-22T13:38:13.7803629+02:00",
  "DbiLastSyncronized": "2023-01-05T13:38:13.7803629+01:00",
  "SentInfo": 34,
  "ShowContactTickets": 155,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "consequatur",
      "StrippedValue": "minus",
      "Description": "Programmable eco-centric portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "minus",
      "Description": "Programmable eco-centric portal",
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
  "InternetPhones": [
    {
      "Value": "harum",
      "StrippedValue": "quia",
      "Description": "De-engineered user-facing help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "quia",
      "Description": "De-engineered user-facing help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 576
        }
      }
    }
  ],
  "Source": 623,
  "ActiveErpLinks": 236,
  "ShipmentTypes": [
    {
      "Id": 525,
      "Name": "Jerde, O'Hara and Friesen",
      "ToolTip": "Eius nostrum ipsam dolorem sed.",
      "Deleted": false,
      "Rank": 317,
      "Type": "ipsum",
      "ColorBlock": 273,
      "IconHint": "officia",
      "Selected": false,
      "LastChanged": "2006-09-04T13:38:13.7803629+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Lou Gleichner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 141,
      "Comment": "doloremque",
      "Registered": "2013-01-04T13:38:13.7803629+01:00",
      "RegisteredAssociateId": 10,
      "Updated": "2007-09-05T13:38:13.7803629+02:00",
      "UpdatedAssociateId": 323,
      "LegalBaseId": 213,
      "LegalBaseKey": "repudiandae",
      "LegalBaseName": "Green LLC",
      "ConsentPurposeId": 445,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Purdy, Stark and Kohler",
      "ConsentSourceId": 141,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Gusikowski-Windler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 675
        }
      }
    }
  ],
  "BounceEmails": [
    "jovany@lesch.info",
    "luella@schultzharvey.com"
  ],
  "ActiveStatusMonitorId": 568,
  "UserDefinedFields": {
    "SuperOffice:1": "Macy Simonis",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 174
    }
  }
}
```
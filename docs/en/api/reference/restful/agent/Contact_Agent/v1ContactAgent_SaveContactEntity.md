---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 229,
  "Name": "Rice-Jacobs",
  "Department": "",
  "OrgNr": "1308478",
  "Number1": "1109178",
  "Number2": "1022175",
  "UpdatedDate": "2021-01-27T12:57:33.4774764+01:00",
  "CreatedDate": "1999-01-02T12:57:33.4774764+01:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "exercitationem",
      "Description": "Balanced bottom-line circuit"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "exercitationem",
      "Description": "Balanced bottom-line circuit"
    }
  ],
  "Interests": [
    {
      "Id": 841,
      "Name": "Brown Inc and Sons",
      "ToolTip": "Aperiam doloremque eligendi.",
      "Deleted": true,
      "Rank": 201,
      "Type": "dolores",
      "ColorBlock": 320,
      "IconHint": "inventore",
      "Selected": true,
      "LastChanged": "2013-02-02T12:57:33.4774764+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ex",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Orie Pfeffer"
    }
  ],
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "sint",
      "Description": "Inverse 6th generation migration"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "sint",
      "Description": "Inverse 6th generation migration"
    }
  ],
  "Phones": [
    {
      "Value": "sapiente",
      "StrippedValue": "sed",
      "Description": "Integrated multi-tasking flexibility"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "sed",
      "Description": "Integrated multi-tasking flexibility"
    }
  ],
  "Faxes": [
    {
      "Value": "delectus",
      "StrippedValue": "nam",
      "Description": "Total contextually-based software"
    },
    {
      "Value": "delectus",
      "StrippedValue": "nam",
      "Description": "Total contextually-based software"
    }
  ],
  "Description": "Organic mobile strategy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "amet",
      "PersonId": 444,
      "Mrmrs": "illum",
      "Firstname": "Constance",
      "Lastname": "Considine",
      "MiddleName": "Zulauf, Hansen and Rempel",
      "Title": "et",
      "Description": "User-friendly eco-centric leverage",
      "Email": "isabelle@kossrussel.info",
      "FullName": "Dr. Ardella Cassie Krajcik MD",
      "DirectPhone": "(530)663-0815",
      "FormalName": "Schulist-Kuphal",
      "CountryId": 692,
      "ContactId": 986,
      "ContactName": "Rempel Inc and Sons",
      "Retired": 855,
      "Rank": 399,
      "ActiveInterests": 498,
      "ContactDepartment": "",
      "ContactCountryId": 472,
      "ContactOrgNr": "677751",
      "FaxPhone": "098.953.8230",
      "MobilePhone": "599.976.0485 x823",
      "ContactPhone": "649-062-9305",
      "AssociateName": "Upton, Smitham and Greenholt",
      "AssociateId": 889,
      "UsePersonAddress": true,
      "ContactFax": "impedit",
      "Kanafname": "nihil",
      "Kanalname": "sint",
      "Post1": "labore",
      "Post2": "fuga",
      "Post3": "nam",
      "EmailName": "brant_hodkiewicz@wiza.us",
      "ContactFullName": "Robbie Altenwerth",
      "ActiveErpLinks": 789,
      "TicketPriorityId": 370,
      "SupportLanguageId": 325,
      "SupportAssociateId": 461,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "nisi",
  "Xstop": false,
  "ActiveInterests": 394,
  "GroupId": 756,
  "ActiveStatusMonitorId": 916,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 147,
  "DbiAgentId": 200,
  "DbiLastSyncronized": "2000-01-15T12:57:33.4774764+01:00",
  "DbiKey": "error",
  "DbiLastModified": "2016-09-02T12:57:33.4774764+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 171,
  "ActiveErpLinks": 259,
  "BounceEmails": [
    "quinn.larkin@boylebreitenberg.com",
    "ora.steuber@bahringerdaugherty.biz"
  ],
  "Domains": [
    "nisi",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Lamont Kiehn V"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "pariatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 347,
  "Name": "Watsica Group",
  "Department": "",
  "OrgNr": "931432",
  "Number1": "463151",
  "Number2": "1618143",
  "UpdatedDate": "2012-11-23T12:57:33.4774764+01:00",
  "CreatedDate": "2006-11-06T12:57:33.4774764+01:00",
  "Emails": [
    {
      "Value": "facere",
      "StrippedValue": "est",
      "Description": "Re-engineered client-server encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "est",
      "Description": "Re-engineered client-server encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 851,
      "Name": "Koepp Group",
      "ToolTip": "Aliquam sit.",
      "Deleted": false,
      "Rank": 974,
      "Type": "aspernatur",
      "ColorBlock": 883,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2019-01-28T12:57:33.4774764+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "nostrum",
      "Hidden": false,
      "FullName": "Sterling Rosenbaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "eos",
      "Description": "Phased encompassing alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "eos",
      "Description": "Phased encompassing alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "corrupti",
      "StrippedValue": "ex",
      "Description": "Polarised tertiary model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "ex",
      "Description": "Polarised tertiary model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "dicta",
      "Description": "Re-contextualized 24/7 frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 645
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "dicta",
      "Description": "Re-contextualized 24/7 frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 645
        }
      }
    }
  ],
  "Description": "Diverse full-range alliance",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 437,
      "Mrmrs": "non",
      "Firstname": "Bethany",
      "Lastname": "Keeling",
      "MiddleName": "Block-Feest",
      "Title": "culpa",
      "Description": "Digitized multi-state monitoring",
      "Email": "norris@dicki.us",
      "FullName": "Ms. Geoffrey Miguel Wiza",
      "DirectPhone": "(608)983-5673",
      "FormalName": "Labadie Inc and Sons",
      "CountryId": 80,
      "ContactId": 30,
      "ContactName": "Ritchie-Rohan",
      "Retired": 856,
      "Rank": 922,
      "ActiveInterests": 966,
      "ContactDepartment": "",
      "ContactCountryId": 241,
      "ContactOrgNr": "1324772",
      "FaxPhone": "380.591.2706",
      "MobilePhone": "088.934.6014",
      "ContactPhone": "990.798.9418",
      "AssociateName": "Ruecker, Gutkowski and Predovic",
      "AssociateId": 203,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "eos",
      "Kanalname": "doloribus",
      "Post1": "commodi",
      "Post2": "eligendi",
      "Post3": "provident",
      "EmailName": "reese@torphy.com",
      "ContactFullName": "Felicity Theron Kozey I",
      "ActiveErpLinks": 418,
      "TicketPriorityId": 254,
      "SupportLanguageId": 903,
      "SupportAssociateId": 923,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 280
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ad",
  "Xstop": false,
  "ActiveInterests": 25,
  "GroupId": 869,
  "ActiveStatusMonitorId": 267,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 943,
  "DbiAgentId": 488,
  "DbiLastSyncronized": "2002-02-16T12:57:33.4930977+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2001-11-09T12:57:33.4930977+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 915,
  "ActiveErpLinks": 625,
  "BounceEmails": [
    "dangelo@kesslerpfeffer.info",
    "darrell@olsongreenholt.info"
  ],
  "Domains": [
    "enim",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mack Keebler",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "doloremque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 998
    }
  }
}
```
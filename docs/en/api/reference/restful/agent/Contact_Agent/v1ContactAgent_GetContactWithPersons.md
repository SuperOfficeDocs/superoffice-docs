---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 137
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 230,
  "Name": "Cremin-Franecki",
  "Department": "",
  "OrgNr": "1057065",
  "Number1": "952261",
  "Number2": "751446",
  "UpdatedDate": "1999-05-31T04:02:01.4561411+02:00",
  "CreatedDate": "2011-10-11T04:02:01.4561411+02:00",
  "Emails": [
    {
      "Value": "facere",
      "StrippedValue": "est",
      "Description": "Multi-lateral maximized time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "est",
      "Description": "Multi-lateral maximized time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 538,
      "Name": "McClure, Dooley and Towne",
      "ToolTip": "Rerum quae porro sed officiis.",
      "Deleted": false,
      "Rank": 168,
      "Type": "illum",
      "ColorBlock": 933,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2014-07-17T04:02:01.4561411+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "labore",
      "Hidden": false,
      "FullName": "Allene Krajcik MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "debitis",
      "StrippedValue": "iure",
      "Description": "Synergistic 5th generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "iure",
      "Description": "Synergistic 5th generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "occaecati",
      "StrippedValue": "velit",
      "Description": "Focused clear-thinking Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "velit",
      "Description": "Focused clear-thinking Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quas",
      "StrippedValue": "et",
      "Description": "Advanced heuristic secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "et",
      "Description": "Advanced heuristic secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "Description": "Multi-tiered homogeneous open system",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 557,
      "Mrmrs": "quia",
      "Firstname": "Emmanuelle",
      "Lastname": "Hamill",
      "MiddleName": "Ondricka-Parker",
      "Title": "autem",
      "Description": "Assimilated real-time functionalities",
      "Email": "delores@fritsch.com",
      "FullName": "Prof. Juliet Albin D'Amore",
      "DirectPhone": "1-497-875-7185",
      "FormalName": "Schneider Group",
      "CountryId": 625,
      "ContactId": 989,
      "ContactName": "Hamill-Ritchie",
      "Retired": 492,
      "Rank": 249,
      "ActiveInterests": 405,
      "ContactDepartment": "",
      "ContactCountryId": 56,
      "ContactOrgNr": "1267986",
      "FaxPhone": "847-201-3477",
      "MobilePhone": "268.550.0042 x053",
      "ContactPhone": "(481)899-0201 x509",
      "AssociateName": "Cole-Hackett",
      "AssociateId": 567,
      "UsePersonAddress": false,
      "ContactFax": "adipisci",
      "Kanafname": "et",
      "Kanalname": "beatae",
      "Post1": "minima",
      "Post2": "sint",
      "Post3": "expedita",
      "EmailName": "sheldon@kautzerrowe.uk",
      "ContactFullName": "Elvis Greenholt",
      "ActiveErpLinks": 658,
      "TicketPriorityId": 689,
      "SupportLanguageId": 535,
      "SupportAssociateId": 552,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "magnam",
  "Xstop": true,
  "ActiveInterests": 608,
  "GroupId": 684,
  "ActiveStatusMonitorId": 413,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 914,
  "DbiAgentId": 611,
  "DbiLastSyncronized": "2008-06-25T04:02:01.4717645+02:00",
  "DbiKey": "corporis",
  "DbiLastModified": "2024-01-16T04:02:01.4717645+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 335,
  "ActiveErpLinks": 515,
  "BounceEmails": [
    "eulah.price@funk.ca",
    "sabryna@gutmann.info"
  ],
  "Domains": [
    "et",
    "nisi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "883819173"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "optio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 436
    }
  }
}
```
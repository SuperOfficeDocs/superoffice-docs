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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 63
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 993,
  "Name": "Sanford-O'Reilly",
  "Department": "",
  "OrgNr": "158513",
  "Number1": "1081755",
  "Number2": "1625188",
  "UpdatedDate": "2010-04-17T14:13:39.8129867+02:00",
  "CreatedDate": "2017-06-12T14:13:39.8129867+02:00",
  "Emails": [
    {
      "Value": "incidunt",
      "StrippedValue": "qui",
      "Description": "Synergistic bifurcated forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "qui",
      "Description": "Synergistic bifurcated forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 390,
      "Name": "Mante-Lemke",
      "ToolTip": "Corporis illum illum id eum voluptatem deleniti.",
      "Deleted": false,
      "Rank": 465,
      "Type": "cumque",
      "ColorBlock": 24,
      "IconHint": "veritatis",
      "Selected": true,
      "LastChanged": "2014-11-23T14:13:39.8129867+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "accusantium",
      "Hidden": true,
      "FullName": "Leonie Nader",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "optio",
      "Description": "Face to face 6th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "optio",
      "Description": "Face to face 6th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eos",
      "StrippedValue": "ipsum",
      "Description": "Enhanced multi-tasking definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "ipsum",
      "Description": "Enhanced multi-tasking definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "esse",
      "StrippedValue": "recusandae",
      "Description": "Operative 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "recusandae",
      "Description": "Operative 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "Description": "Expanded tertiary parallelism",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 879,
      "Mrmrs": "eum",
      "Firstname": "Gaetano",
      "Lastname": "Blanda",
      "MiddleName": "Daniel-Doyle",
      "Title": "dolorem",
      "Description": "Total optimizing core",
      "Email": "abdul.torphy@mcglynn.us",
      "FullName": "Mittie Emard",
      "DirectPhone": "1-995-261-7936",
      "FormalName": "Murazik LLC",
      "CountryId": 828,
      "ContactId": 958,
      "ContactName": "Wolff, Wintheiser and Koch",
      "Retired": 638,
      "Rank": 896,
      "ActiveInterests": 26,
      "ContactDepartment": "",
      "ContactCountryId": 192,
      "ContactOrgNr": "361954",
      "FaxPhone": "1-975-339-2441 x0520",
      "MobilePhone": "054-928-7924 x92765",
      "ContactPhone": "883.341.4909",
      "AssociateName": "Jenkins, Reynolds and Bode",
      "AssociateId": 560,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "natus",
      "Kanalname": "ut",
      "Post1": "et",
      "Post2": "aspernatur",
      "Post3": "fugit",
      "EmailName": "vella.smith@hahn.name",
      "ContactFullName": "Bertrand Legros",
      "ActiveErpLinks": 41,
      "TicketPriorityId": 131,
      "SupportLanguageId": 709,
      "SupportAssociateId": 923,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1339009",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptatem",
  "Xstop": false,
  "ActiveInterests": 312,
  "GroupId": 438,
  "ActiveStatusMonitorId": 102,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 266,
  "DbiAgentId": 52,
  "DbiLastSyncronized": "2022-10-05T14:13:39.8129867+02:00",
  "DbiKey": "quos",
  "DbiLastModified": "2012-02-21T14:13:39.8129867+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 552,
  "ActiveErpLinks": 728,
  "BounceEmails": [
    "vidal.stoltenberg@trantowbashirian.ca",
    "roosevelt@toy.ca"
  ],
  "Domains": [
    "odit",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Anderson Abshire",
    "SuperOffice:2": "Ms. Dave Hamill DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 1002
    }
  }
}
```
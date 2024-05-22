---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 539,
  "Name": "Gleason-Wunsch",
  "Department": "",
  "OrgNr": "1590241",
  "Number1": "699666",
  "Number2": "353027",
  "UpdatedDate": "2006-10-09T12:57:33.5399622+02:00",
  "CreatedDate": "2007-01-23T12:57:33.5399622+01:00",
  "Emails": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "rerum",
      "Description": "Object-based multi-tasking intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "rerum",
      "Description": "Object-based multi-tasking intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 269,
      "Name": "Mertz, Ebert and Dietrich",
      "ToolTip": "Sit eius cum voluptas porro.",
      "Deleted": false,
      "Rank": 927,
      "Type": "ipsa",
      "ColorBlock": 91,
      "IconHint": "earum",
      "Selected": true,
      "LastChanged": "2014-01-08T12:57:33.5399622+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Abbie Heller DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory leading edge project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory leading edge project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iusto",
      "StrippedValue": "et",
      "Description": "Adaptive mission-critical groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "et",
      "Description": "Adaptive mission-critical groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Phased maximized archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Phased maximized archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 166
        }
      }
    }
  ],
  "Description": "Exclusive client-server flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 31,
      "Mrmrs": "soluta",
      "Firstname": "Vergie",
      "Lastname": "Hartmann",
      "MiddleName": "Ebert-Ortiz",
      "Title": "exercitationem",
      "Description": "Vision-oriented dynamic hierarchy",
      "Email": "shania_brekke@bartellkuphal.co.uk",
      "FullName": "Mrs. Josefina Cronin",
      "DirectPhone": "350.142.4300 x73095",
      "FormalName": "Reilly, McLaughlin and Beahan",
      "CountryId": 272,
      "ContactId": 472,
      "ContactName": "Breitenberg Group",
      "Retired": 569,
      "Rank": 960,
      "ActiveInterests": 954,
      "ContactDepartment": "",
      "ContactCountryId": 182,
      "ContactOrgNr": "1001343",
      "FaxPhone": "1-532-816-2161 x29015",
      "MobilePhone": "350.994.8978 x96359",
      "ContactPhone": "1-896-683-3338",
      "AssociateName": "Braun-Zulauf",
      "AssociateId": 848,
      "UsePersonAddress": true,
      "ContactFax": "optio",
      "Kanafname": "dolorem",
      "Kanalname": "laboriosam",
      "Post1": "eum",
      "Post2": "optio",
      "Post3": "nemo",
      "EmailName": "malinda@cartwrightthiel.com",
      "ContactFullName": "Dr. Dorian Klocko",
      "ActiveErpLinks": 62,
      "TicketPriorityId": 596,
      "SupportLanguageId": 127,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ducimus",
  "Xstop": false,
  "ActiveInterests": 319,
  "GroupId": 261,
  "ActiveStatusMonitorId": 327,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 545,
  "DbiAgentId": 21,
  "DbiLastSyncronized": "2024-04-04T12:57:33.5555835+02:00",
  "DbiKey": "fuga",
  "DbiLastModified": "2017-12-21T12:57:33.5555835+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 953,
  "ActiveErpLinks": 93,
  "BounceEmails": [
    "oda_zboncak@towne.info",
    "jamar@ward.name"
  ],
  "Domains": [
    "mollitia",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Trey Candelario Hyatt",
    "SuperOffice:2": "Prof. Claire Nicholas Langworth II"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "odio"
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
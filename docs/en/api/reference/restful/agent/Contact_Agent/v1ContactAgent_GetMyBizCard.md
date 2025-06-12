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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 783,
  "Name": "Dietrich-Sanford",
  "Department": "",
  "OrgNr": "365412",
  "Number1": "1574372",
  "Number2": "1175540",
  "UpdatedDate": "2001-07-27T17:54:02.8670938+02:00",
  "CreatedDate": "2024-06-19T17:54:02.8670938+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Cloned tertiary interface",
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
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Cloned tertiary interface",
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
  "Interests": [
    {
      "Id": 961,
      "Name": "Stiedemann-Balistreri",
      "ToolTip": "Reiciendis voluptate nihil ullam.",
      "Deleted": false,
      "Rank": 443,
      "Type": "distinctio",
      "ColorBlock": 389,
      "IconHint": "animi",
      "Selected": true,
      "LastChanged": "2019-06-28T17:54:02.8670938+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "laudantium",
      "Hidden": false,
      "FullName": "Israel Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "omnis",
      "Description": "Proactive transitional emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "omnis",
      "Description": "Proactive transitional emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quia",
      "Description": "Function-based multi-tasking product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quia",
      "Description": "Function-based multi-tasking product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "nam",
      "Description": "Multi-tiered mission-critical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "nam",
      "Description": "Multi-tiered mission-critical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "Description": "Triple-buffered incremental algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequatur",
      "PersonId": 82,
      "Mrmrs": "voluptates",
      "Firstname": "Anjali",
      "Lastname": "Feest",
      "MiddleName": "Durgan Group",
      "Title": "atque",
      "Description": "Integrated zero administration moderator",
      "Email": "kaela.marvin@frami.co.uk",
      "FullName": "Mandy Grady",
      "DirectPhone": "(980)713-2348 x5282",
      "FormalName": "Grady-Ebert",
      "CountryId": 890,
      "ContactId": 650,
      "ContactName": "Williamson-O'Connell",
      "Retired": 928,
      "Rank": 924,
      "ActiveInterests": 954,
      "ContactDepartment": "",
      "ContactCountryId": 711,
      "ContactOrgNr": "1679342",
      "FaxPhone": "374.344.4685 x49845",
      "MobilePhone": "290.015.3991 x30456",
      "ContactPhone": "019.307.6220",
      "AssociateName": "Hessel, Haag and Johnson",
      "AssociateId": 473,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "tempora",
      "Kanalname": "asperiores",
      "Post1": "aut",
      "Post2": "nostrum",
      "Post3": "et",
      "EmailName": "alverta@thiel.biz",
      "ContactFullName": "Mrs. Louie Jamal Kovacek",
      "ActiveErpLinks": 873,
      "TicketPriorityId": 337,
      "SupportLanguageId": 395,
      "SupportAssociateId": 14,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1449799",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "illo",
  "Xstop": true,
  "ActiveInterests": 65,
  "GroupId": 900,
  "ActiveStatusMonitorId": 642,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 623,
  "DbiAgentId": 606,
  "DbiLastSyncronized": "2022-05-19T17:54:02.8827182+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2018-01-18T17:54:02.8827182+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 408,
  "ActiveErpLinks": 92,
  "BounceEmails": [
    "vivien.schoen@blick.ca",
    "brittany@wunschbrown.info"
  ],
  "Domains": [
    "non",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Ross Spencer",
    "SuperOffice:2": "Jayson Cronin"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "soluta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 926
    }
  }
}
```
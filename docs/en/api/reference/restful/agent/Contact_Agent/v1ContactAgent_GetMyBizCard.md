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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 275,
  "Name": "Yundt LLC",
  "Department": "seize virtual bandwidth",
  "OrgNr": "914918",
  "Number1": "1390866",
  "Number2": "1957543",
  "UpdatedDate": "2008-05-07T13:38:13.3271428+02:00",
  "CreatedDate": "2020-12-14T13:38:13.3271428+01:00",
  "Emails": [
    {
      "Value": "tenetur",
      "StrippedValue": "qui",
      "Description": "Diverse motivating capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "qui",
      "Description": "Diverse motivating capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 268,
      "Name": "Wyman LLC",
      "ToolTip": "Odio ad quia quos expedita velit delectus.",
      "Deleted": false,
      "Rank": 494,
      "Type": "nobis",
      "ColorBlock": 107,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "1999-10-18T13:38:13.3271428+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nulla",
      "StyleHint": "debitis",
      "Hidden": true,
      "FullName": "Woodrow Haley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Reduced needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Reduced needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "temporibus",
      "StrippedValue": "nisi",
      "Description": "Front-line dedicated algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "nisi",
      "Description": "Front-line dedicated algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magnam",
      "StrippedValue": "ad",
      "Description": "Re-engineered background knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 827
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "ad",
      "Description": "Re-engineered background knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 827
        }
      }
    }
  ],
  "Description": "Horizontal systematic matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quaerat",
      "PersonId": 349,
      "Mrmrs": "illo",
      "Firstname": "Pink",
      "Lastname": "Friesen",
      "MiddleName": "DuBuque LLC",
      "Title": "voluptas",
      "Description": "Innovative radical conglomeration",
      "Email": "robb.mckenzie@west.com",
      "FullName": "Bertha Veum",
      "DirectPhone": "1-973-778-9603 x83320",
      "FormalName": "Jenkins Group",
      "CountryId": 255,
      "ContactId": 275,
      "ContactName": "Littel, Kohler and Lind",
      "Retired": 958,
      "Rank": 771,
      "ActiveInterests": 826,
      "ContactDepartment": "",
      "ContactCountryId": 435,
      "ContactOrgNr": "1245519",
      "FaxPhone": "872-125-1999",
      "MobilePhone": "1-124-363-1047",
      "ContactPhone": "831-145-7482 x95716",
      "AssociateName": "Wunsch, Purdy and Hyatt",
      "AssociateId": 207,
      "UsePersonAddress": true,
      "ContactFax": "voluptates",
      "Kanafname": "sint",
      "Kanalname": "sit",
      "Post1": "id",
      "Post2": "quasi",
      "Post3": "necessitatibus",
      "EmailName": "laurel@bartell.name",
      "ContactFullName": "Mr. Soledad Rohan Jr.",
      "ActiveErpLinks": 321,
      "TicketPriorityId": 684,
      "SupportLanguageId": 494,
      "SupportAssociateId": 503,
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
  "Kananame": "distinctio",
  "Xstop": false,
  "ActiveInterests": 257,
  "GroupId": 10,
  "ActiveStatusMonitorId": 871,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 831,
  "DbiAgentId": 304,
  "DbiLastSyncronized": "2009-10-27T13:38:13.3427643+01:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2014-06-17T13:38:13.3427643+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 495,
  "ActiveErpLinks": 796,
  "BounceEmails": [
    "pink@friesen.us",
    "nicklaus@kihncarroll.uk"
  ],
  "Domains": [
    "debitis",
    "nesciunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Zita Schuppe",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 700
    }
  }
}
```
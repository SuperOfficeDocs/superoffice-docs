```http!
POST /api/v1/Agents/Import/SaveImport
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "quis",
        "et"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "aut"
    },
    {
      "Values": [
        "quis",
        "et"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "aut"
    }
  ],
  "ColumnDefinition": [
    "in",
    "quibusdam"
  ],
  "CreateSelection": false,
  "Culture": "ea",
  "Context": "voluptatem"
}
```
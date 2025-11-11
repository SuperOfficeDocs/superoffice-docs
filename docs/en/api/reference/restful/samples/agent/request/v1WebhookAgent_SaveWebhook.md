```http!
POST /api/v1/Agents/Webhook/SaveWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 541,
  "Name": "Ondricka Group",
  "Events": [
    "ad",
    "vero"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "beatae",
  "State": "Active",
  "Type": "et",
  "Headers": {
    "Headers1": "ut",
    "Headers2": "vel"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2004-03-28T10:11:01.8786829+02:00",
  "RegisteredAssociate": null,
  "Updated": "2024-10-14T10:11:01.8786829+02:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "adolph.olson@maggioconroy.us"
}
```
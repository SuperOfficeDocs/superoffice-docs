```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2024-11-24T14:35:10.234567+01:00",
  "UserPrompt": "Summarize contact information and interaction history",
  "UserDisplayText": "Create a summary of this contact",
  "BotResponse": "I'll create a comprehensive summary including contact details, recent interactions, sales opportunities, and support tickets.",
  "BotActions": {
    "includeInteractions": "true",
    "includeSales": "true",
    "includeTickets": "true"
  },
  "Attachments": [
    "contact-template.json"
  ]
}
```

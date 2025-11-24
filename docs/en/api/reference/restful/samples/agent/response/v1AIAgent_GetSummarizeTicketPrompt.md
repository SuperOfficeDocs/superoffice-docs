```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2024-11-24T14:38:20.678901+01:00",
  "UserPrompt": "Summarize support ticket with priority and resolution status",
  "UserDisplayText": "Create a ticket summary",
  "BotResponse": "I'll provide a concise summary including ticket category, priority level, customer issue description, actions taken, and current status.",
  "BotActions": {
    "includeMessages": "true",
    "includeAttachments": "true",
    "includeTimeline": "true"
  },
  "Attachments": [
    "ticket-summary-template.json"
  ]
}
```

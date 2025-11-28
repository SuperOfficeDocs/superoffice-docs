```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2024-11-24T14:36:45.567890+01:00",
  "UserPrompt": "Summarize sale opportunity with key milestones and risks",
  "UserDisplayText": "Create a sale summary",
  "BotResponse": "I'll generate a summary covering sale value, stage, probability, key stakeholders, recent activities, and potential risks or opportunities.",
  "BotActions": {
    "includeTimeline": "true",
    "includeStakeholders": "true",
    "includeRisks": "true"
  },
  "Attachments": [
    "sale-summary-template.json"
  ]
}
```

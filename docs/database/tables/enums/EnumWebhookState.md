<properties generated="1" SortOrder="990" />

# WebhookState Enum

Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors

* Unknown = 0
* Active = 1
* Stopped = 2
* TooManyErrors = 3

## Usage
* [Webhook](Webhook.md).state - Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.


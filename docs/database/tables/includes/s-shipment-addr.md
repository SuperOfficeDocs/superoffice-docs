<!-- markdownlint-disable-file MD041 -->
| Status | ID | Comment |
|---|---|---|
| Unknown | 0 | Default value for empty rows |
| Ready | 1 | Ready for shipment |
| Duplicate | 2 | Blocked because it duplicates another shipment addr in the same batch |
| Blocked | 3 | Blocked because of nomailing flag |
| Sent | 4 | Sent |
| Bounced | 5 | Bounce received from transport channel |
| Opened | 6 | Recipient has opened the message, we know because of tracking |
| Clicked | 7 | Recipient has actively clicked a link in the message |
| SoftBounced | 8 |  Vacation notice, etc |
| NoSubscription | 9 | Recipient does not have subscription for shipmentType |
| Complained | 10 | Recipient sent a complaint |
| TooManyBounces | 11 | Recipient address has bounced too many times |

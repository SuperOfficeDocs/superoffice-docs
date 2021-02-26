---
title: quote_connector_enum_quotestatus
description: ERP Quote Connector Interface data carrier - Enum QuoteStatus
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# Enum QuoteStatus

QuoteStatus shall be used to give indications in the user interface that there is more info or problems available.

| Ok | OK, all is good |
| OkWithInfo | All is good, but there is some additional information that the user should be made aware of. |
| Warning | There is a problem that the user must be made aware of. |
| Error | There is a problem that the system will not be able to get around. The user needs to do something. **SuperOffice will deny the user to send the quote or place the order.** If the error is not so bad that it has to stop the user? Then it is not an error, it is a warning. |

Example: The user has registered a quoteline that is discontinued and the amount the user has registered is not in stock.

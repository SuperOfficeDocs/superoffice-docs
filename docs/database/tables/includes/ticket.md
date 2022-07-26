<!-- markdownlint-disable-file MD041 -->
### Communication channel leading to ticket being created

| Origin | Comment |
|---|---|
| 0 | We just have no idea. Maybe it was too long ago |
| 1 | Email |
| 2 | SMS |
| 3 | Telefacsimile |
| 4 | Phone call to human operator |
| 5 | Facebook wall |
| 6 | Tweet tweet |
| 7 | Internal, by human operator |
| 8 | Direct by customer through Customer Centre web pages |
| 9 | Auto-generated from e-marketing link |
| 10 | Automatic processes in Service |

### Status of a ticket / request

This is the internal value. The user-defined ticket status is saved to `ticket.ticket_status`

| Status | Comment |
|---|---|
| 0 | Unknown / uninitialized |
| 1 | Request is currently active |
| 2 | Request has been closed |
| 3 | Request has been postponed |
| 4 | Deleted |
| 5 | Request has been merged with another request. See `connect_id` |

<!-- markdownlint-disable-file MD041 -->
### Field type in table associate

This enumeration consists of flag values that can be combined.

| Type | Comment |
 |---|---|
 | 0 | User / Employee |
 | 1 | Associates with this bit is not associated with any person. Disregard the PersonId for associates with this bit set. |
 | 2 | Associates of this type is not authenticated for SuperOffice |
 | 4 | Associates with this bit do not have a calendar |
 | 8 | Associates with this bit has full access rights, and the Sentry mechanism is bypassed |

A resource like meeting room or projector would typically be type = 1

An external associate who may log in via Audience or any Collaborative CRM would be type = 4

Unknown party accessing the system (e.g. prospecting, eCRM) = 7 (no person (1) + not authenticated (2) + no diary(4))

Application with full access rights (EAI) (system user) = 13 (no person (1) + no diary(4) + full access/bypass sentry (8))

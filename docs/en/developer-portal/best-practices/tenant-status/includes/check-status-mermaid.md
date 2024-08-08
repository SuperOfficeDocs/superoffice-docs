```mermaid
sequenceDiagram
    participant Client
    participant SuperOffice

    Client->>SuperOffice: GET ../api/state/CONTEXTID
    SuperOffice-->>Client: HTTP Response (200 OK, JSON)
    Client-->>Client: Check state
    Client->>SuperOffice: Business Logic
```
<!-- markdownlint-disable-file MD041 -->
```mermaid
sequenceDiagram
    participant SuperOffice
    participant Client

    SuperOffice->>Client: POST (JSON)
    Client-->>Client: Check state (Pause/Stop?)
```

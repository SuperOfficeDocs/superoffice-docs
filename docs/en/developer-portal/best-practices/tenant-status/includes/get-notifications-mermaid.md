sequenceDiagram
    participant Client
    participant SuperOffice

    SuperOffice->>Client: POST (JSON)
    Client-->>Client: Check state (Pause/Stop?)
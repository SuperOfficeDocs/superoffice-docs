---
title: POST Agents/Ticket/ClearNotify
uid: v1TicketAgent_ClearNotify
---

# POST Agents/Ticket/ClearNotify

```http
POST /api/v1/Agents/Ticket/ClearNotify
```

Rensa meddelandestatus för en eller flera tickets.

## Parametrar för frågesträng

| Parameterns namn | Typ |  Beskrivning |
|----------------|------|--------------|
| Välj | sträng |  Valfri kommaavgränsad lista över egenskaper som inkluderas i resultaten. Andra fält nollställs för att minska belastningen: "Namn,avdelning,kategori". Standard = visa alla fält. |

```http
POST /api/v1/Agents/Ticket/ClearNotify?$select=name,department,category/id
```

## Ärendehuvud

| Parameterns namn | Beskrivning |
|----------------|-------------|
| Auktorisering  | Stöd för Basic-, SoTicket- och Bearer-scheman beroende på installationstyp. |
| X-XSRF-TOKEN   | Om du inte använder en auktoriseringsrubrik måste du ange ett XSRF-värde från cookiefältet eller det dolda inmatningsfältet |
| Typ av innehåll | Typ av innehåll i ärendets brödtext: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Godkännande         | Typ av innehåll som du vill ha svaret i:  |
| SO-AppToken | Det applikationstoken som identifierar partnerappen. Används när Online WebAPI anropas från en server. |

## Ärendets brödtext: ärende

Id

| Egenskapens namn | Typ |  Beskrivning |
|----------------|------|--------------|
| Id | Samling |  |

## Svar

Inget innehåll

| Svar | Beskrivning |
|----------------|-------------|
| 204 | Inget innehåll |

### Svarets brödtext: TableRight

## Exempelärende

```http!
POST /api/v1/Agents/Ticket/ClearNotify
Auktorisering: Basic dGplMDpUamUw
Acceptera: application/json; charset=utf-8
Godkänt språk: sv
Typ av innehåll: application/json; charset=utf-8

{
  "Ids": [
    82,
    995
  ]
}
```

## Exempelsvar

```http_
HTTP/1.1 204 Inget innehåll
Typ av innehåll: application/json; charset=utf-8

tomt
```

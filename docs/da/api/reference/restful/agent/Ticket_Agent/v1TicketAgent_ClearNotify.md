---
title: POST Agents/Ticket/ClearNotify
uid: v1TicketAgent_ClearNotify
---

# POST Agents/Ticket/ClearNotify

```http
POST /api/v1/Agents/Ticket/ClearNotify
```

Ryd notifikationsstatus for en eller flere tickets.

## Parametre for forespørgselsstreng

| Parameternavn | Type |  Beskrivelse |
|----------------|------|--------------|
| $vælg | streng |  Valgfri kommasepareret liste over egenskaber, der skal medtages i resultatet. Andre felter annulleres derefter for at reducere nyttelaststørrelsen: "Navn,afdeling,kategori". Standard = vis alle felter. |

```http
POST /api/v1/Agents/Ticket/ClearNotify?$select=name,department,category/id
```

## Sagsoverskrifter

| Parameternavn | Beskrivelse |
|----------------|-------------|
| Godkendelse  | Understøtter ordninger med 'Basic', 'SoTicket' og 'Bearer' afhængig af installationstype. |
| X-XSRF-TOKEN   | Hvis du ikke bruger autorisationsheader, skal du angive XSRF-værdi fra cookie eller skjult indtastningsfelt |
| Indholdstype | Anmodningens indholdstype: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accepter         | Indholdstype(r), du gerne vil have svar på:  |
| SO-AppToken | Det programtoken, der identificerer partnerappen. Bruges, når du kalder Online WebAPI fra en server. |

## Anmodningstekst: anmodning

Id'er

| Ejendomsnavn | Type |  Beskrivelse |
|----------------|------|--------------|
| Id'er | Array |  |

## Svar

Intet indhold

| Respons | Beskrivelse |
|----------------|-------------|
| 204 | Intet indhold |

### Responstekst: TableRight

## Anmodning om eksempel

```http!
POST /api/v1/Agents/Ticket/ClearNotify
Godkendelse: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Ids": [
    82,
    995
  ]
}
```

## Eksempel på svar

```http_
HTTP / 1.1 204 Intet indhold
Content-Type: application/json; charset=utf-8

null
```

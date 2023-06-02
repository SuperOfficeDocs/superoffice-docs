---
title: POST Agents/Ticket/ClearNotify
uid: v1TicketAgent_ClearNotify
---

# POST Agents/Ticket/ClearNotify

```http
POST /api/v1/Agents/Ticket/ClearNotify
```

Nullstill varslingsstatus for en eller flere saker.







## Parametere for spørrestreng

| Navn på parameter | Type |  Beskrivelse |
|----------------|------|--------------|
| $select | streng |  Valgfri kommadelt liste over egenskaper som skal inkluderes i resultatet. Andre felt nulles deretter ut for å redusere nyttelaststørrelsen: "Navn, avdeling, kategori". Standard = vis alle felt. |

```http
POST /api/v1/Agents/Ticket/ClearNotify?$select=name,department,category/id
```


## Meldingshoder for sak

| Navn på parameter | Beskrivelse |
|----------------|-------------|
| Godkjenning  | Støtter 'Basic'-, 'SoTicket'- og 'Bearer'-planer, avhengig av installasjonstype. |
| X-XSRF-TOKEN   | Hvis du ikke bruker Authorization-toppteksten, må du oppgi XSRF-verdi fra informasjonskapsel eller skjult inntastingsfelt |
| Innholdstype | Innholdstype for sakskropp: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Godta         | Innholdstype(r) du ønsker svaret som:  |
| SO-AppToken | Applikasjontokenet som identifiserer partnerappen. Brukes når du kaller Online WebAPI fra en server. |

## Sakstekst: sak 

Ids 

| Egenskapsnavn | Type |  Beskrivelse |
|----------------|------|--------------|
| Ids | Matrise |  |

## Svar:

Ikke noe innhold

| Respons | Beskrivelse |
|----------------|-------------|
| 204 | Ikke noe innhold |

### Responstekst: TableRight


## Eksempel på sak

```http!
POST /api/v1/Agents/Ticket/ClearNotify
Authorization: Basic dGplMDpUamUw
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
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
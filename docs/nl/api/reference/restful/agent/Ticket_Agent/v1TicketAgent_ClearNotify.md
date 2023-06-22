---
title: POST Agents/Ticket/ClearNotify
uid: v1TicketAgent_ClearNotify
---

# POST Agents/Ticket/ClearNotify

```http
POST /api/v1/Agents/Ticket/ClearNotify
```

Meldingsstatus voor een of meer tickets wissen.

## Parameters voor queryreeksen

| Parameternaam | Type |  Beschrijving |
|----------------|------|--------------|
| $select | tekenreeks |  Optionele door komma's gescheiden lijst met eigenschappen die in het resultaat moeten worden opgenomen. Andere velden worden vervolgens tenietgedaan om de grootte van de lading te verkleinen: "Naam,afdeling,categorie". Standaard = alle velden weergeven. |

```http
POST /api/v1/Agents/Ticket/ClearNotify?$select=name,department,category/id
```

## Kopteksten van verzoek

| Parameternaam | Beschrijving |
|----------------|-------------|
| Autorisatie  | Ondersteunt 'Basic', 'SoTicket' en 'Bearer' schema's, afhankelijk van het installatietype. |
| X-XSRF-TOKEN   | Als u de autorisatiekoptekst niet gebruikt, moet u de XSRF-waarde opgeven uit de cookie of het verborgen invoerveld |
| Inhoud-Type | Inhoudstype van de hoofdtekst van het verzoek: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accepteren         | Inhoud-type(n) waarin u het antwoord wilt hebben:  |
| SO-AppToken | Het toepassingstoken dat de partner-app identificeert. Wordt gebruikt bij het aanroepen van Online WebAPI vanaf een server. |

## Verzoek hoofdtekst: verzoek

Ids

| Naam eigenschap | Type |  Beschrijving |
|----------------|------|--------------|
| Ids | Array |  |

## Respons

Geen inhoud

| Respons | Beschrijving |
|----------------|-------------|
| 204 | Geen inhoud |

### Hoofdtekst respons: TableRight

## Sampleverzoek

```http!
POST /api/v1/Agents/Ticket/ClearNotify
Autorisatie: Basic dGplMDpUamUw
Accepteren: application/json; charset=utf-8
Accept-Language: sv
Inhoud-Type: application/json; charset=utf-8

{
  "Ids": [
    82,
    995
  ]
}
```

## Samplerespons

```http_
HTTP/1.1 204 Geen inhoud
Inhoud-Type: application/json; charset=utf-8

nul
```

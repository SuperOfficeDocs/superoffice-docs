---
title: POST Agents/Ticket/ClearNotify
uid: v1TicketAgent_ClearNotify
---

# POST Agents/Ticket/ClearNotify

```http
POST /api/v1/Agents/Ticket/ClearNotify
```

Löschen Sie den Benachrichtigungsstatus für ein oder mehrere Tickets.

## Parameter für Abfragezeichenfolgen

| Parameter Name | Typ |  Beschreibung |
|----------------|------|--------------|
| $select | Zeichenfolge |  Optionale, durch Kommas getrennte Liste von Eigenschaften, die in das Ergebnis einbezogen werden sollen. Andere Felder werden dann auf Null gesetzt, um die Nutzdatengröße zu reduzieren: "Name,Abteilung,Kategorie". Standard = Alle Felder anzeigen. |

```http
POST /api/v1/Agents/Ticket/ClearNotify?$select=name,department,category/id
```

## Anfrage-Kopfzeilen

| Parameter Name | Beschreibung |
|----------------|-------------|
| Genehmigung  | Unterstützt je nach dem Installationstyp die Schemata 'Basic', 'SoTicket' und 'Bearer'. |
| X-XSRF-TOKEN   | Wenn Sie die Kopfzeile Genehmigung nicht verwenden, müssen Sie den XSRF-Wert vom Cookie oder ausgeblendeten Eingabefeld angeben |
| Inhaltstyp | Inhaltstyp des Anfragetextes: `Anwendung/json`, `Text/json`, `Anwendung/xml`, `Text/xml`, `Anwendung/x-www-formular-urlcodiert`, `Anwendung/json-Patch+json`, `Anwendung/zusammenführen-Patch+json` |
| Mündliche Zusage         | Inhaltstyp(en), auf die Sie die Antwort möchten:  |
| SO-AppToken | Das Anwendungstoken, das die Partner-App identifiziert. Wird verwendet, wenn Sie die Online-WebAPI von einem Server aufrufen. |

## Anfragetext: Anfrage

IDs

| Name der Eigenschaft | Typ |  Beschreibung |
|----------------|------|--------------|
| IDs | Datenfeld |  |

## Antwort

Kein Inhalt

| Antwort | Beschreibung |
|----------------|-------------|
| 204 | Kein Inhalt |

### Antwort-Text: TableRight

## Muster-Anfrage

```http!
POST /api/v1/Agents/Ticket/ClearNotify
Genehmigung: Basic dGplMDpUamUw
Annahmen: Anwendung/json; Zeichensatz=UTF-8
Annehmen-Sprache: sv
Inhaltstyp: Anwendung/json; Zeichensatz=UTF-8

{
  "Ids": [
    82,
    995
  ]
}
```

## Antwortbeispiel

```http_
HTTP/1.1 204 Kein Inhalt
Inhaltstyp: Anwendung/json; Zeichensatz=UTF-8

null
```

---
uid: help-de-section-tab-requests
title: Bereichsregisterkarte Anfragen
description: Erfahren Sie, wie Sie Serviceanfragen in SuperOffice CRM anzeigen, hinzufügen und verwalten können, um Kundeninteraktionen effizient über Firmen und Personen hinweg zu verfolgen.
keywords: requests tab, section tab, request archive, ticket archive
author: Bergfrid Skaara Dias
date: 03.11.2025
version: 10.5.3
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Bereichsregisterkarte Anfragen

Die **Bereichsregisterkarte Anfragen** in SuperOffice CRM ermöglicht es Benutzern, [Service-Anfragen][1] anzuzeigen und zu verwalten, die mit bestimmten Entitäten wie Firmen und Personen verknüpft sind. Dieser Leitfaden bietet einen umfassenden Überblick darüber, wie Sie auf Anfragen zugreifen und mit diesen interagieren können, um Kundeninteraktionen effizient zu bearbeiten.

![Bereichsregisterkarte Anfragen in Firmaansicht -screenshot][img1]

## Verfügbarkeit der Bereichsregisterkarte Anfragen

Die **Bereichsregisterkarte Anfragen** ist verfügbar für:

| Entität | Beschreibung der Bereichsregisterkarte |
|---|---|
| [Firma][9] | Zeigt alle Anfragen an, die mit der Firma verknüpft sind, mit Optionen zum Anzeigen und Verwalten der Details. |
| [Person][10] | Zeigt Anfragen an, die mit der Person verknüpft sind, um eine personalisierte Unterstützung zu ermöglichen. |

## <a id="columns"></a>Übersicht der Spalten in der Bereichsregisterkarte Anfragen

Die **Bereichsregisterkarte Anfragen** enthält die folgenden Spalten, um wichtige Informationen zu jeder Anfrage bereitzustellen:

| Spalte | Beschreibung |
|---|---|
| Anfragen-ID | Eindeutige Kennung für die Anfrage. |
| Titel | Der Titel oder Betreff der Anfrage. |
| Erstellt | Das Datum, an dem die Anfrage ursprünglich erfasst wurde. |
| Letzte Änderung | Das Datum, an dem die Anfrage zuletzt aktualisiert wurde. |
| Geschlossen am | Das Datum, an dem die Anfrage geschlossen wurde. |
| Besitzer | Die Person, die für die Bearbeitung der Anfrage verantwortlich ist. |
| Kategorie | Die Kategorie der Anfrage. |
| Vollständiger Name | Der vollständige Name der Person, die mit der Anfrage verknüpft ist. |
| Firma | Die Firma, die mit der Anfrage verknüpft ist. |
| Status | Der aktuelle Status der Anfrage (wie z. B. Offen, Geschlossen, Ausstehend). |
| Tags | Tags, die zur Kategorisierung oder zum Hinzufügen von Metadaten zu der Anfrage verwendet werden. |

[!include[Spalten konfigurieren](../includes/tip-configure-columns.md)]

## Anfragen in der Bereichsregisterkarte Anfragen anzeigen

1. Gehen Sie zur entsprechenden Ansicht, wie z. B. Firma oder Person.

1. Klicken Sie auf die Registerkarte **Anfragen**, um alle Anfragen anzuzeigen, die mit der Entität verknüpft sind.

1. Doppelklicken Sie auf eine Anfrage in der Liste, um sie in einem separaten Fenster zu öffnen und vollständige Details einzusehen.

### Geschlossene Anfragen einschließen

Um geschlossene Anfragen in der Liste einzuschließen, aktivieren Sie das Kontrollkästchen **Geschlossen** am unteren Rand der Bereichsregisterkarte. Dies bietet eine vollständige Übersicht über sowohl offene als auch geschlossene Anfragen, die mit der Entität verknüpft sind.

## Erstellen einer Anfrage

1. Klicken Sie in der Registerkarte **Anfrage** auf **Hinzufügen**, um eine neue Anfrage für den Person zu erstellen.

1. Füllen Sie die Anfragedetails nach Bedarf aus. Das Feld **Person** wird basierend auf der angezeigten Person vorausgefüllt.

1. Klicken Sie auf **Speichern**, um die Anfrage zu registrieren.

## Eine Anfrage bearbeiten

Um eine Anfrage direkt aus der Bereichsregisterkarte **Anfragen** zu bearbeiten:

1. Suchen Sie die Anfrage, die Sie bearbeiten möchten, und doppelklicken Sie darauf.

1. Klicken Sie im sich öffnenden Fenster auf **Bearbeiten** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), um die Anfrage zu aktualisieren.

## Zusätzliche Tipps

* **Anfragen verfolgen:** Verfolgen Sie offene Probleme und stellen Sie sicher, dass rechtzeitig reagiert wird.

## Verwandte Inhalte

* [Wie man eine Anfrage erstellt][2]
* [Kundenanfragen in SuperOffice CRM verwalten][3]
* [Spalten gruppieren und Summen berechnen][5]

<!-- Referenced links -->
[1]: ../../request/learn/index.md
[2]: ../../request/learn/create.md
[3]: ../../request/learn/reply.md
[5]: configure-columns.md#calculate
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/requests-detail.png

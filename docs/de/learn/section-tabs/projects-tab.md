---
uid: help-de-section-tab-projects
title: Projects tab
description: Erfahren Sie, wie Sie Projekte mit der Bereichsregisterkarte "Projekte" in SuperOffice CRM anzeigen, hinzufügen und verwalten. Vereinfachen Sie die Projektverfolgung über Firmen, Personen und mehr.
keywords: Bereichsregisterkarte Projekte, Projekte-Bereichsregisterkarte, Bereichsregisterkarte, Projektarkif
author: Bergfrid Skaara Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Bereichsregisterkarte Projekte

Die Bereichsregisterkarte **Projekte** in SuperOffice CRM ermöglicht es den Benutzern, [Projektinformationen][1] zu spezifischen Entitäten wie Firmen und Personen anzuzeigen und zu verwalten. Dieser Leitfaden bietet einen umfassenden Überblick darüber, wie man auf Projektdatensätze zugreift und diese bearbeitet, um die Verfolgung und Verwaltung von Projektaktivitäten effektiv zu gestalten.

![Bereichsregisterkarte Projekte in Firma -screenshot][img1]

## Verfügbarkeit der Bereichsregisterkarte Projekte

Die Bereichsregisterkarte **Projekte** ist verfügbar für:

| Entität | Beschreibung der Bereichsregisterkarte |
|---|---|
| [Firma][9] | Zeigt alle Projekte an, die mit der Firma verknüpft sind. Mindestens ein Mitarbeiter muss als Projektmitglied registriert sein, um hier ein Projekt anzeigen. |
| [Person][10] | Zeigt Projekte an, bei denen die Person ein Projektmitglied ist. |

## <a id="columns"></a>Übersicht der Spalten in der Bereichsregisterkarte Projekte

Die Bereichsregisterkarte **Projekte** enthält die folgenden Spalten, um wichtige Informationen zu jedem Projekt anzuzeigen:

| Spalte | Beschreibung |
|---|---|
| Abgeschlossen | Kontrollkästchen, das anzeigt, ob das Projekt abgeschlossen ist. Ein angekreuztes Kontrollkästchen (<i class="ph ph-check" aria-hidden="true"></i>) bedeutet abgeschlossen, während ein leeres Kästchen bedeutet, dass es noch läuft. |
| Projektname | Der Name des Projekts. |
| Projekttyp | Gibt den Typ des Projekts an, z. B. intern oder kundenorientiert. |
| Status | Der aktuelle Status des Projekts. |
| Projektnummer | Die dem Projekt zugewiesene eindeutige Kennung. |
| Beschreibung | Zeigt eine Beschreibung des Projekts an. Fahren Sie mit der Maus über das Büroklammer-Symbol, um den vollständigen Text zu sehen. |
| Weblink | Eine mit dem Projekt verknüpfte URL, falls zutreffend. |
| Benutzer-ID | Der Benutzer, der das Projekt erstellt hat. |

[!include[Spalten konfigurieren](../includes/tip-configure-columns.md)]

## Projekte in der Projekte-Bereichsregisterkarte anzeigen

1. Gehen Sie zur entsprechenden Ansicht, wie z. B. Firma oder Person.

1. Klicken Sie auf die Bereichsregisterkarte **Projekte**, um alle mit der Entität verknüpften Projekte anzuzeigen.

1. Doppelklicken Sie auf ein Projekt in der Liste, um die Projektansicht zu öffnen und detaillierte Informationen anzuzeigen.

### Projekte filtern

Sie können [die Liste der Projekte][8] nach Datum, Benutzer oder Gruppe filtern, indem Sie auf die Schaltfläche **Filter** klicken. Dies hilft dabei, sich auf bestimmte Projektaktivitäten zu konzentrieren, die Aufmerksamkeit erfordern.

## Projektmitglieder hinzufügen

Um [Projektmitglieder hinzuzufügen][4] direkt aus der Bereichsregisterkarte **Projekte**:

1. Wählen Sie **Zum Projekt hinzufügen** aus, um den Dialog **Projektmitglieder hinzufügen/bearbeiten** zu öffnen.

1. Füllen Sie die erforderlichen Felder aus und klicken Sie auf **Speichern**.

## Zusätzliche Tipps

* **Schnelle Navigation:** Verwenden Sie den [Navigator][7], um schnell zwischen verschiedenen Entitäten und deren entsprechenden Projektbereichen zu wechseln.

## Verwandte Inhalte

* [Wie man ein Projekt hinzufügt][2]
* [Projekte filtern][8]
* [Spalten gruppieren und Summen berechnen][5]

<!-- Referenced links -->
[1]: ../../project/learn/index.md
[2]: ../../project/learn/create.md
[4]: ../../project/learn/project-members/add.md
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/projects-detail.png

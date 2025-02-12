---
uid: help-de-section-tab-sales
title: Registerkarte Verkäufe
description: Erfahren Sie, wie Sie Verkaufsinformationen im Bereichsregisterkarte "Verkäufe" in SuperOffice CRM verwalten und anzeigen, einschließlich des Hinzufügens von Verkäufen, Filtern und Nachverfolgen von Verkaufsaktivitäten für Firmen, Personen und Projekte.
keywords: Registerkarte Verkäufe, Verkäufe-Reiter, Bereichsregisterkarte Verkäufe, Bereichsregisterkarte
author: Bergfrid Skaara Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Registerkarte Verkäufe

Der Bereichsregisterkarte **Verkäufe** in SuperOffice CRM ermöglicht es Benutzern, [Verkaufsinformationen][1] zu bestimmten Entitäten wie Firmen, Personen, Projekte und Tagebücher zu sehen und zu verwalten. Es zeigt eine Liste aller Verkäufe an, die mit einer Entität verbunden sind, und erleichtert es so, Aktivitäten im Kontext nachzuverfolgen und tiefere Einblicke in Verkaufsleistungen und anstehende Aktionen zu gewinnen.

![Bereichsregisterkarte Verkäufe -screenshot][img1]

## Verfügbarkeit der Bereichsregisterkarte Verkäufe

Die Bereichsregisterkarte **Verkäufe** ist verfügbar für:

| Entität | Beschreibung der Bereichsregisterkarte |
|---|---|
| [Firma][9] | Zeigt alle Verkäufe, die mit der Firma verbunden sind. |
| [Person][10] | Zeigt Verkäufe, die mit der Person verbunden sind, einschließlich Details wie Status, Betrag und nächste Schritte. |
| [Tagebuch][11] | Gibt eine Übersicht über Verkäufe, mit Schwerpunkt auf geplanten Aktivitäten und Verkaufsfortschritt. |
| [Projekt][13] | Listet Verkäufe, die mit dem Projekt verknüpft sind, und hebt verwandte Aktivitäten sowie bevorstehende Folgeaufgaben hervor. |

## <a id="columns"></a>Spaltenübersicht der Bereichsregisterkarte Verkäufe

Die Bereichsregisterkarte **Verkäufe** enthält folgende Spalten zur Anzeige wichtiger Informationen zu jedem Verkauf:

| Spalte | Beschreibung |
|---|---|
| Abgeschlossen | Kontrollkästchen, das angibt, ob der Verkauf abgeschlossen ist. Ein markiertes Kästchen (<i class="ph ph-check" aria-hidden="true"></i>) bedeutet abgeschlossen, während ein leeres Kästchen bedeutet, dass es noch läuft. |
| Statussymbol | Zeigt den aktuellen [Verkaufsstatus][4] an, z. B. verkauft, verloren oder aufgeschoben. |
| Verkaufsdatum | Das mit dem Verkauf verbundene Datum, das voraussichtlich, verkauft oder verloren sein kann. |
| Betrag | Der finanzielle Wert des Verkaufs. |
| Stufe | Der aktuelle Stand des Verkaufsprozesses. |
| Nächste Aktivität | Datum der nächste geplante Folgeaufgabe oder Verkaufsaktivität. Das angezeigte Datum repräsentiert die älteste noch nicht abgeschlossene Folgeaufgabe. Um weitere Details zu sehen oder zu identifizieren, was die nächste Folgeaufgabe ist, doppelklicken Sie auf den Verkauf, um den **Verkaufs**-Bildschirm zu öffnen. Die Folgeaufgabe kann in der Bereichsregisterkarte **Aktivitäten** des Verkaufs eingesehen werden. |
| Name | Name des Verkaufs. |
| Person | Der mit dem Verkauf verbundene Person. |
| Firma | Das mit dem Verkauf verknüpfte Firma. |
| Benutzer-ID | Der Benutzer, der den Verkauf erfasst hat. |
| ERP-Rabatt | Zeigt Rabattinformationen an, wenn SuperOffice CRM mit einem ERP-System verbunden ist. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Verkäufe in der Bereichsregisterkarte Verkäufe anzeigen

1. Gehen Sie zum relevanten Bildschirm, z. B. Firma, Person, Projekt oder Tagebuch.

1. Klicken Sie auf die Bereichsregisterkarte **Verkäufe**, um alle mit der Entität verbundenen Verkäufe zu sehen.

1. Doppelklicken Sie auf einen Verkauf in der Liste, um die Verkauf zu öffnen und detaillierte Informationen zu sehen.

### Verkäufe filtern

Sie können die Liste der Verkäufe nach Datum, Benutzer oder Gruppe [filtern][8], indem Sie auf die **Filter**-Schaltfläche (<i class="ph ph-funnel" aria-hidden="true"></i>) klicken. Dies hilft Ihnen, sich auf bestimmte Verkaufsaktivitäten zu konzentrieren, die Aufmerksamkeit benötigen.

### Beteiligte einbeziehen

Um Verkäufe einzuschließen, an denen das aktuelle Unternehmen oder die Person als [Beteiligte][3] beteiligt ist, aktivieren Sie das Kontrollkästchen **Beteiligte einschließen** am unteren Rand der Bereichsregisterkarte. Dies bietet eine umfassendere Übersicht über alle mit der Entität verbundenen Verkaufsaktivitäten.

## Verkaufsaufgabenassistent

Die Bereichsregisterkarte **Verkäufe** fungiert als **Verkaufsaufgabenassistent**, der Ihnen hilft, einen Überblick über laufende Verkaufsaktivitäten zu behalten. Er fungiert als verkaufsorientierte Aufgabenliste und bietet eine Zusammenfassung von:

* **Unvollständige Verkäufe:** Alle laufenden Verkäufe, bei denen das Verkaufsdatum innerhalb des definierten Anzeigebereichs liegt.

* **Geplante Verkaufsaktivitäten:** Alle Verkäufe mit geplanten Aktivitäten für eine bestimmte Anzahl von Tagen im Voraus.

    > [!NOTE]
    > Die Anzahl der Tage im Voraus ist benutzerdefiniert. Um diese Einstellung zu ändern, gehen Sie zu **Persönliche Einstellungen** > **Präferenzen** > **Funktionen** > **Tage im Voraus anzeigen**.

* **Überfällige Aktivitäten:** Alle Verkäufe, deren Aktivitäten überfällig sind (Enddatum vor heute). Diese Verkäufe werden rot hervorgehoben, um eine einfache Identifizierung zu ermöglichen.

* **Pausierte Verkäufe:** Wenn ein Verkauf als [aufgeschoben][4] markiert ist und ein Wiedereröffnungsdatum hat, überschreibt dieses Datum das Datum im Feld **Nächste Aktivität** und wird in der Spalte **Nächste Aktivität** angezeigt.

Diese Ansicht hilft Benutzern, den Überblick über anstehende Aktionen zu behalten und sicherzustellen, dass nichts übersehen wird, was letztendlich das Verkaufsmanagement verbessert.

## Verkauf hinzufügen

Um einen neuen Verkauf direkt aus der Bereichsregisterkarte **Verkäufe** hinzuzufügen:

1. Wählen Sie **Hinzufügen**, um den Verkaufsdialog zu öffnen.

1. Geben Sie die Verkaufsdetails ein: Füllen Sie die erforderlichen Felder aus und klicken Sie auf **Speichern**.

## Zusätzliche Tipps

* **Schnelle Navigation:** Verwenden Sie den [Navigator][7], um schnell zwischen verschiedenen Entitäten und ihren entsprechenden **Verkäufe**-Registerkarten zu wechseln.

## Verwandte Inhalte

* [Wie fügt man einen Verkauf hinzu][2]
* [Interessenten im Verkauf verwalten][3]
* [Aktivitäten und Verkäufe filtern][8]
* [Spalten gruppieren und Beträge zusammenfassen][5]

<!-- Referenced links -->
[1]: ../../sale/learn/index.md
[2]: ../../sale/learn/create.md
[3]: ../../sale/learn/stakeholders/index.md
[4]: ../../sale/learn/update.md#stalled
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/sale-detail.png

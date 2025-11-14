---
uid: help-de-saint-admin
title: SAINT in Einstellungen und Verwaltung
description: Lernen Sie die Schlüsselkonzepte von SuperOffice SAINT kennen, einschließlich Kriterien, Bilder, Zähler und Standard-Folgeaufgaben.
keywords: SAINT, Aktivitätsüberwachung, Statusüberwachung
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
index: true
redirect_from: /de/sale/saint/learn/admin/index
---

# SAINT in Einstellungen und Verwaltung

SAINT (Sales Intelligence) hilft Ihnen dabei, Firmen, Personen und Projekte zu überwachen, damit Sie zum richtigen Zeitpunkt nachfassen können. Eine **Aktivitätsüberwachung** (auch als Statusüberwachung bekannt) kombiniert Kriterien, Zähler und optionale Eigenschaften, um Datensätze hervorzuheben, die Aufmerksamkeit benötigen.

Bevor Sie SAINT implementieren, ist es wichtig zu wissen, was Sie verbessern möchten und wie Sie es analysieren werden. Überlegen Sie dann, welche proaktiven Maßnahmen Ihr Unternehmen ergreifen kann, um die aktuelle Situation zu verbessern. Zum Beispiel:

* Eine Gruppenkampagne senden
* Alle Kunden in der SAINT-Auswahl anrufen
* Alle Anfragen nachverfolgen

[!include[Requirement](../includes/note-saint-req.md)]

Mit der Registerkarte **Statuskontrollen/SAINT** können Sie Statusangaben für Firmen, Personen und Projekte erstellen. Statuskontrollen stellen die Funktionalität hinter dem SAINT-Konzept (Sales Intelligence) dar. Dies erleichtert die Folgeaufgaben für Firmen, Personen und Projekte und das Bereitstellen von sinnvolleren Suchoptionen in SuperOffice CRM.

![SAINT-Bildschirm mit Statusliste, Beschreibung, Bild und Kriterien -screenshot][img1]

## Statusliste

Die Statusliste auf den Registerkarten **Firma**, **Person** und **Projekt** zeigt aktive Statusmonitore für dieses Datensatz und – wenn **Gelöschte anzeigen** ausgewählt ist – auch gelöschte.

| Element | Beschreibung |
|---|---|
| **Darstellen-Symbol** <i class="ph ph-eye" aria-label="eye"></i> | Zeigt an, ob ein Statusbild auf Firmen-, Personen- oder Projektkarten angezeigt wird. Das Symbol wird nur angezeigt, wenn das Kontrollkästchen **Darstellen** aktiviert ist. |
| **Rotes X** | Wird neben Statusangaben angezeigt, die [regeneriert][8] werden müssen. Diese Statusangaben werden nicht aktualisiert und geben keine aktuellen Daten zurück. |
| **Namensspalte** | Zeigt die Namen der Statusangaben an. Gelöschte Statusangaben werden rot angezeigt, wenn **Gelöschte anzeigen** unter der Liste aktiviert ist. |
| **Prioritätsspalte** | Legt fest, welches Statusbild auf der Karte angezeigt wird, wenn ein Firmen, Person oder Projekt die Kriterien für mehrere Status erfüllt. Die Statusangabe mit der höchsten Priorität wird angezeigt, während andere aktive Statusangaben als Links im Statusdialog verfügbar sind. |

## Eigenschaften

Eine Statusüberwachung kombiniert mehrere Eigenschaften, die definieren, wie sie funktioniert:

* **Kriterien:** Jeder Status muss ein oder mehrere Kriterien enthalten. Diese Bedingungen bestimmen, für welche Firmen, Personen oder Projekte der Status gilt. Sie können beispielsweise einen Status für Kunden definieren, die in den letzten 90 Tagen keine Verkäufe hatten.

* **Statusbilder:** Ein optionales Bild kann auf Firmen-, Personen- oder Projektkarten angezeigt werden, die den Kriterien entsprechen. Ein Spinnennetz kann beispielsweise Inaktivität anzeigen. Bilder erscheinen als helle Wasserzeichen und können für weitere Details angeklickt werden.

* **Standard-Folgeaufgabe:** Wenn ein Benutzer auf den Status klickt, kann er eine Folgeaufgabe erstellen. Der Typ und die Beschreibung können vordefiniert werden, sodass die Folgeaufgabe klar angibt, welche Aktion erforderlich ist.

## Zähler und Zeiträume

Zähler [verfolgen Aktivitäten über die Zeit][5], wie Verkäufe, Anfragen oder abgeschlossene Folgeaufgaben.
Sie können Zähler in Suchen und Selektionen verwenden, um Datensätze zu identifizieren, die bestimmte Schwellenwerte erfüllen oder verfehlen.

Sie können bis zu drei verschiedene Zeiträume definieren (zum Beispiel 30, 60 und 90 Tage).
Dies ermöglicht es Ihnen, denselben Zähler, wie "Anzahl der Verkäufe", auf verschiedene Zeitspannen anzuwenden.

## <a id="database"></a>Wie SAINT Zähler und Status speichert

SAINT-Zähler werden in der [countervalue][13]-Tabelle gespeichert und automatisch aktualisiert, wenn Sie Aktionen durchführen:

* Wenn SAINT aktiviert ist, wird bei der Erstellung einer Person oder eines Projekts eine Reihe von Zählerzeilen erstellt.

* Wann immer eine Folgeaufgabe, ein Dokument oder ein Verkauf erstellt wird, werden die entsprechenden Zählerzeilen aktualisiert.

SAINT-Werte sind einfache binäre Werte (ein oder aus), die das Erscheinungsbild der Firmen- und Projektkarten bestimmen. Diese Werte werden in der [statusvalue][14]-Tabelle gespeichert.

## Verwandte Inhalte

* [Neue Statusüberwachung einrichten][1]
* [Status mit Bildern visualisieren][2]
* [Zähler und Zählereinstellungen][5]
* [Statusüberwachungen aktualisieren, löschen und wiederherstellen][7]
* [Statusüberwachungen und Zähler regenerieren][8]

<!-- Referenzierte Links -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: https://docs.superoffice.com/en/database/tables/countervalue.html
[14]: https://docs.superoffice.com/en/database/tables/statusvalue.html

<!-- Referenzierte Bilder -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png

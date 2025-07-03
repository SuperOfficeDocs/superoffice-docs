---
uid: help-de-sales-guide
title: Verkaufsleitfaden
description: Einführung in Verkaufsleitfäden in SuperOffice CRM.
keywords: Verkaufsleitfaden, Leitfaden, Workflow, Bereichsregisterkarte Verkaufsleitfaden, Verkaufsprozess, Vertriebsprozess, Stufe, automatische Fortschreibung, Verkauf
author: Bergfrid Dias
date: 11.02.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/sale/learn/sales-guide/index
  - /de/sale/learn/sales-guide/sales-guide-tab
  - /de/sale/learn/sales-guide/working-with-sales-guide
  - /de/sale/learn/screen/sales-guide-admin
  - /de/sale/learn/screen/sales-guide-tab
---

# Verkaufsleitfaden

Verkaufsleitfäden in SuperOffice CRM sind leistungsstarke Tools, die den Vertriebsprozess vereinfachen und standardisieren, indem sie Verkaufstypen mit vordefinierten Stufen verknüpfen. Jede Stufe enthält vorgeschlagene Folgeaufgaben und Dokumente, die den Vertrieb durch eine strukturierte Verkaufspipeline führen. So wird sichergestellt, dass keine Verkaufschancen übersehen werden und ein konsistenter Prozess im gesamten Team eingehalten wird.

> [!NOTE]
> Diese Funktion erfordert eine Sales Premium-Lizenz.

## Was ist ein Verkaufsleitfaden?

Ein Verkaufsleitfaden besteht aus:

* **Stufen:** Vordefinierte Phasen im Vertriebsprozess, wie Erstgespräch, Angebot oder Abschluss. Jede Stufe hat einen Namen, eine Wahrscheinlichkeitsangabe in Prozent und eine Beschreibung.
* **Folgeaufgaben:** Aktionen wie Anrufe oder Meetings, die mit jeder Stufe verknüpft sind.
* **Dokumente:** Vorlagen für Angebote, Verträge oder E-Mails, die für den Vertriebsprozess relevant sind.

Wenn Sie einen Verkauf erstellen oder seinen Typ auf einen mit einem Verkaufsleitfaden verknüpften Typ ändern, wird der Leitfaden automatisch in der Bereichsregisterkarte **Verkaufsleitfaden** aktiviert. Diese Registerkarte bietet eine Übersicht über Stufen, Folgeaufgaben und Dokumente für den Verkauf.

**Beispiel:**

Ein Verkaufstyp für Neukundenakquise könnte folgende Struktur haben:

* Erstgespräch: Meeting-Folgeaufgabe und Einführungs-E-Mail.
* Angebotsphase: Angebotserstellung und Versand.
* Abschluss: Vertragsunterzeichnung und geplante Folgeaufgaben.

Verkaufsleitfäden werden in **Einstellungen und Verwaltung** eingerichtet und können an die spezifischen Abläufe Ihrer Firma angepasst werden.

## So funktioniert ein Verkaufsleitfaden

Sehen Sie sich dieses Video an, um zu lernen, wie einfach die Nutzung des Verkaufsleitfadens ist:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

(Videolänge - 1:24)

### Schritte

1. **Mit einer Stufe beginnen:** Wenn Sie einen Verkauf mit einem verknüpften Verkaufsleitfaden erstellen oder aktualisieren, wird die erste Stufe automatisch gesetzt. Die Bereichsregisterkarte **Verkaufsleitfaden** zeigt die zugehörigen Folgeaufgaben und Dokumente an.

1. **Aktivitäten erstellen:** Folgeaufgaben und Dokumente können direkt aus der Bereichsregisterkarte **Verkaufsleitfaden** erstellt werden:
    * Klicken Sie auf **Erstellen** neben der Folgeaufgabe oder dem Dokument.
    * Vervollständigen Sie die vorausgefüllten Felder im Dialogfeld und speichern Sie die Eingaben.

    > [!TIP]
    > Weisen Sie Folgeaufgaben bestimmten Teammitgliedern zu, um die Zusammenarbeit zu verbessern.

1. **Aufgabe als abgeschlossen markieren:** Nachdem eine Aktivität abgeschlossen wurde, aktivieren Sie das Kontrollkästchen neben ihrem Namen in der Bereichsregisterkarte **Verkaufsleitfaden**. Dokumente werden automatisch als abgeschlossen markiert, sobald sie erstellt wurden.

    Abgeschlossene Elemente erscheinen ebenfalls in der Bereichsregisterkarte **Aktivitäten**.

1. **Zur nächsten Stufe wechseln:** Sobald alle Aktivitäten für eine Stufe abgeschlossen sind oder wenn nötig:
    * Wechseln Sie den Verkauf manuell zur nächsten Stufe oder lassen Sie ihn automatisch fortschreiten (falls konfiguriert).
    * Der Leitfaden aktualisiert sich und zeigt die vorgeschlagenen Folgeaufgaben und Dokumente für die neue Stufe an.

1. **Wiederholen, bis der Verkauf abgeschlossen ist:** Arbeiten Sie alle Stufen durch, bis der Verkauf als **Verkauft** oder **Verloren** markiert wird.

> [!NOTE]
> Sie können zur nächsten Stufe wechseln, ohne alle Folgeaufgaben der aktuellen Stufe abzuschließen.

## <a id="sales-guide-tab"></a>Bereichsregisterkarte Verkaufsleitfaden

Die Bereichsregisterkarte **Verkaufsleitfaden** bietet eine visuelle und funktionale Übersicht über den Verkaufsprozess, sodass Vertriebsmitarbeiter Fortschritte nachverfolgen und Aufgaben effizient verwalten können.

![Bereichsregisterkarte Verkaufsleitfaden mit der Stufe Erstgespräch -screenshot][img1]

### Wichtige Komponenten

* **Stufen-Schaltflächen:** Oben in der Registerkarte werden vordefinierte Stufen wie Erstgespräch, Angebot und Abschluss angezeigt.

    ![Verkaufsleitfaden-Stufen -screenshot][img2]

  * **Aktuelle Stufe:** Markiert mit einem gefüllten Kreis (<i class="ph ph-fill ph-circle" aria-hidden="true"></i>).
  * **Zukünftige Stufen:** Gekennzeichnet mit einem offenen Kreis (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Abgeschlossene Stufen:** Mit einem Häkchen (<i class="ph ph-check" aria-hidden="true"></i>) markiert.

* **Aktivitäten:** Die Registerkarte ist in zwei Spalten unterteilt: **Folgeaufgaben** und **Dokumente**. Jede Zeile enthält einen **Erstellen**-Link, mit dem Benutzer die erforderliche Folgeaufgabe oder das Dokument direkt aus der Bereichsregisterkarte heraus erstellen können.

    > [!TIP]
    > Verwenden Sie die Option **Alle Stufen anzeigen**, um alle Aktivitäten und Dokumente über sämtliche Stufen hinweg anzuzeigen.

## Folgeaufgabe oder Dokument erstellen

Um eine Folgeaufgabe oder ein Dokument im Verkaufsleitfaden zu erstellen:

1. Wechseln Sie zur Bereichsregisterkarte **Verkaufsleitfaden**.
1. Suchen Sie die gewünschte Folgeaufgabe oder das Dokument in der aktuellen Stufe.
1. Klicken Sie auf **Erstellen** neben dem jeweiligen Element.

    * Für Folgeaufgaben öffnet sich das [Dialogfeld Folgeaufgabe][6], das basierend auf den Einstellungen des Verkaufsleitfadens vorausgefüllt ist. Bearbeiten Sie die Angaben nach Bedarf und klicken Sie auf **Speichern**.

    * Für Dokumente öffnet sich das [Dialogfeld Dokument][7] mit einer vorab ausgewählten Vorlage. Vervollständigen Sie die erforderlichen Felder und klicken Sie auf **Speichern**.

> [!TIP]
> Sie können mehrere Folgeaufgaben oder Dokumente desselben Typs erstellen, indem Sie mit der rechten Maustaste auf ein Element klicken und **Weiteres erstellen** auswählen.

## Eine Folgeaufgabe als abgeschlossen markieren

1. Gehen Sie zur Bereichsregisterkarte **Verkaufsleitfaden** und suchen Sie die abzuschließende Folgeaufgabe.
1. Aktivieren Sie das Kontrollkästchen neben dem Namen der Folgeaufgabe. Die Aufgabe wird als abgeschlossen markiert und erscheint als erledigt in der Bereichsregisterkarte **Aktivitäten**.

Dokumente werden automatisch als abgeschlossen markiert, sobald sie erstellt wurden.

### Warum öffnet sich das Dialogfeld Verkaufsleitfaden, wenn eine Folgeaufgabe abgeschlossen wird?

In Einstellungen und Verwaltung kann festgelegt werden, dass eine Folgeaufgabe automatisch vorgeschlagen wird, wenn die vorherige abgeschlossen wurde. In diesem Fall öffnet sich das Dialogfeld **Verkaufsleitfaden**, sobald die vorherige Aufgabe abgeschlossen wird.

Im Dialogfeld **Verkaufsleitfaden** haben Sie drei Optionen:

* Klicken Sie auf **Erstellen**, um die nächste Folgeaufgabe im Verkaufsleitfaden zu erstellen. Dadurch wird das Dialogfeld für Folgeaufgaben geöffnet.

* Klicken Sie auf **Abbrechen**, wenn Sie die Folgeaufgabe noch nicht erstellen möchten. Das Dialogfeld **Verkaufsleitfaden** wird geschlossen, und Sie können die Folgeaufgabe später erstellen.

* Aktivieren Sie **Immer Folgeaufgabe erstellen? Diesen Dialog nicht mehr anzeigen**, wenn Sie die vorgeschlagene Folgeaufgabe zukünftig immer erstellen möchten. Das Dialogfeld für Folgeaufgaben wird dann automatisch geöffnet.

> [!TIP]
> Um diese Option zurückzusetzen, damit das Dialogfeld **Verkaufsleitfaden** wieder erscheint, gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen** > **Verkauf** und wählen Sie **Ja** für die Option **Erstellung der vorgeschlagenen Folgeaufgabe bestätigen**.

## <a id="change-stage"></a>Zur nächsten Stufe wechseln

Verkaufsleitfäden unterstützen sowohl die **manuelle** als auch die **automatische** Fortschreibung durch die Stufen.

### Automatische Stufenfortschreibung

Falls aktiviert, wird die nächste Stufe vorgeschlagen, sobald alle erforderlichen Folgeaufgaben und Dokumente der aktuellen Stufe als abgeschlossen markiert wurden. Sie können entscheiden, ob Sie zur nächsten Stufe wechseln oder in der aktuellen Stufe bleiben möchten.

![Automatischer Dialog zur Stufenfortschreibung -screenshot][img3]

1. Schließen Sie alle erforderlichen Folgeaufgaben und Dokumente der aktuellen Stufe ab.
1. Wenn der Dialog erscheint, klicken Sie auf **Ja**, um zur nächsten Stufe zu wechseln, oder **Nein**, um in der aktuellen Stufe zu bleiben.

> [!NOTE]
> Die automatische Fortschreibung muss in Einstellungen und Verwaltung aktiviert sein, damit diese Funktion verfügbar ist.

### Manuelle Stufenfortschreibung

Sie können den Verkauf manuell zur nächsten Stufe verschieben, auch wenn nicht alle Folgeaufgaben und Dokumente der aktuellen Phase abgeschlossen sind.

1. Klicken Sie mit der rechten Maustaste auf die gewünschte Stufenschaltfläche in der Bereichsregisterkarte **Verkaufsleitfaden**.
1. Wählen Sie **Zu dieser Stufe wechseln** aus dem Menü.

Oder:

1. Klicken Sie auf **Bearbeiten** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) auf der Verkaufskarte.
1. Wählen Sie die nächste Stufe im Menü **Stufe** aus.
1. Klicken Sie auf **Speichern**.

> [!TIP]
> Sie können auch zur vorherigen Stufe zurückkehren, indem Sie dieselben Schritte ausführen.

## Vorteile der Verwendung von Verkaufsleitfäden

* **Konsistenz:** Standardisiert die Vertriebsprozesse in Ihrem Unternehmen.
* **Effizienz:** Bietet klare Schritte, Vorlagen und Aufgaben für jede Stufe.
* **Transparenz:** Hält das Vertriebsteam auf dem Laufenden über den aktuellen Fortschritt und die nächsten Schritte.

## Verwandte Inhalte

* [Einführung in Verkäufe][1]
* [Verkauf erstellen][2]
* [Verkaufsleitfaden-Tutorial][3]
* [Neuen Verkaufsleitfaden erstellen][4]
* [Verkaufsleitfaden bearbeiten oder deaktivieren][5]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: tutorial.md
[4]: ../admin/create-sales-guide.md
[5]: ../admin/edit-sales-guide.md
[6]: ../../diary/learn/create-follow-up.md
[7]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/sales-guide-tab.png
[img2]: ../../../media/loc/en/sale/guide-stages.png
[img3]: ../../../media/loc/en/sale/goto-next-stage.png

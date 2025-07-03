---
uid: help-de-project-guide
title: Projektleitfäden
description: Einführung in Projektleitfäden in SuperOffice.
keywords: Projektleitfaden, Leitfaden, Workflow, Prozessmanagement, Bereichsregisterkarte Projektleitfaden, Status wechseln, Projekt
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: concept
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/project/learn/project-guide/index
  - /de/project/learn/project-guide/project-guide-tab
  - /de/project/learn/project-guide/view-followups-and-documents
---

# Projektleitfäden

Ein Projektleitfaden in SuperOffice CRM ist ein Prozessmanagement-Tool, das die Projektdurchführung vereinfacht und standardisiert, indem Projekttypen mit vordefinierten Statuswerten verknüpft werden. Jeder Status enthält spezifische Folgeaufgaben, Dokumente und Meilensteine, die Sie durch den gesamten Projektlebenszyklus führen. Dieser strukturierte Ansatz sorgt für Konsistenz zwischen Projekten und hilft Projektmanagern, Aufgaben und wichtige Meilensteine im Blick zu behalten.

Standardmäßig sind in SuperOffice CRM mehrere Projektleitfäden verfügbar. Sie können diese unverändert nutzen oder in Einstellungen und Verwaltung an die Arbeitsweise Ihrer Firma anpassen.

## Was ist ein Projektleitfaden?

Ein Projektleitfaden besteht aus:

* **Statuswerten:** Verschiedene Phasen eines Projekts, z. B. Geplant, In Bearbeitung und Wird beendet.
* **Folgeaufgaben:** Aktionen wie Aufgaben und Besprechungen, die jedem Status zugeordnet sind.
* **Dokumente:** Relevante Dateien wie Berichte oder Memos, die mit dem Projekt verknüpft sind.
* **Meilensteine:** Wichtige Folgeaufgaben, die einen signifikanten Fortschritt im Projekt markieren.

Wenn Sie ein Projekt erstellen oder seinen Typ auf einen Projekttyp mit verknüpftem Leitfaden aktualisieren, wird der Leitfaden automatisch in der Bereichsregisterkarte **Projektleitfaden** aktiviert. Diese Registerkarte zeigt die Statuswerte, zugehörigen Aktivitäten und nächsten Schritte für das Projekt an.

**Beispiel:**

Für den Projekttyp "Konferenz" könnte der Projektleitfaden Folgendes enthalten:

* **Geplant:** Eine Folgeaufgabe "Recherche" und ein Dokument "Konferenzprogramm".
* **In Bearbeitung:** Aufgaben zur Erstellung einer Teilnehmerliste und zum Versenden von Einladungen.
* **Wird beendet:** Ein Auswertungsmeeting und ein Abschlussbericht.

Projektleitfäden werden in **Einstellungen und Verwaltung** definiert und können an die spezifischen Abläufe Ihrer Firma angepasst werden.

## So funktioniert ein Projektleitfaden

1. **Mit einem Status beginnen:** Wenn Sie ein Projekt mit einem verknüpften Projektleitfaden erstellen oder aktualisieren, wird automatisch der erste Status gesetzt. Die Bereichsregisterkarte **Projektleitfaden** zeigt die Folgeaufgaben und Dokumente für diesen Status an.

1. **Aktivitäten erstellen:** Jede Folgeaufgabe oder jedes Dokument im Leitfaden kann direkt aus der Registerkarte erstellt werden:
    * Klicken Sie auf **Erstellen** neben dem Namen der Folgeaufgabe oder des Dokuments.
    * Vervollständigen Sie die vorab ausgefüllten Felder im Dialogfeld und speichern Sie.

    > [!TIP]
    > Weisen Sie Folgeaufgaben Teammitgliedern zu, um eine effiziente Zusammenarbeit zu ermöglichen. Für bestimmte Folgeaufgaben wird das Dialogfeld **Aufgabe zu Projektmitglied zuweisen** angezeigt.

1. **Aufgaben als erledigt markieren:** Nach Abschluss einer Aktivität setzen Sie das Häkchen neben ihrem Namen in der Bereichsregisterkarte **Projektleitfaden**. Dokumente werden automatisch als erledigt markiert, sobald sie erstellt wurden.

    Abgeschlossene Elemente erscheinen auch in der Bereichsregisterkarte **Aktivitäten**.

1. **Zum nächsten Status wechseln:** Sobald alle Aktivitäten für einen Status abgeschlossen sind oder wenn nötig:
   * Wechseln Sie den Status manuell oder automatisch (falls in Einstellungen und Verwaltung definiert).
   * Der Leitfaden wird aktualisiert und zeigt die Folgeaufgaben und Dokumente für den neuen Status an.

1. **Den gesamten Prozess durchlaufen:** Arbeiten Sie sich durch die Statuswerte und erledigen Sie die vorgeschlagenen Aktivitäten, bis das Projekt als abgeschlossen markiert ist.

> [!NOTE]
> Sie können zum nächsten Status wechseln, ohne alle Folgeaufgaben des aktuellen Status zu erledigen.

## <a id="project-guide-tab"></a>Bereichsregisterkarte Projektleitfaden

![Bereichsregisterkarte Projektleitfaden mit Status Geplant -screenshot][img1]

Die Bereichsregisterkarte **Projektleitfaden** bietet eine strukturierte Übersicht über die vordefinierten Statuswerte, Folgeaufgaben und Dokumente eines Projekts. Über diese Registerkarte können Benutzer Aufgaben einfach nachverfolgen und ausführen, um sicherzustellen, dass Projekte wie geplant voranschreiten.

### Wichtige Komponenten

* **Status-Schaltflächen:** Diese repräsentieren die vordefinierten Status, wie Geplant, In Bearbeitung, Wird beendet und Abgeschlossen.

    ![Projektleitfaden-Status -screenshot][img2]

  * **Aktueller Status:** Markiert mit einem ausgefüllten Kreis (<i class="ph ph-circle-fill" aria-hidden="true"></i>).
  * **Zukünftige Status:** Markiert mit einem offenen Kreis (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Abgeschlossene Status:** Markiert mit einem Häkchen (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktivitäten:** Die Registerkarte ist in zwei Spalten unterteilt: **Folgeaufgaben** und **Dokumente**. Jede Zeile enthält einen **Erstellen**-Link, mit dem Benutzer direkt aus der Registerkarte heraus die benötigte Folgeaufgabe oder das Dokument erstellen können.

    **Meilenstein**-Aktivitäten sind mit einem Diamantsymbol (<i class="ph ph-diamond" aria-hidden="true"></i>) gekennzeichnet. Das Feld **Nächster Meilenstein** auf der Hauptkarte des Projekts zeigt automatisch das Datum des nächsten Meilensteins an.

* **Filter:** Unten befinden sich Kontrollkästchen zur Anpassung der Anzeige:

  * **Nur erstellt:** Zeigt nur abgeschlossene oder laufende Folgeaufgaben und Dokumente.
  * **Nur Meilensteine:** Zeigt nur Meilenstein-Folgeaufgaben.
  * **Alle Stati anzeigen:** Zeigt alle Status und deren zugehörige Folgeaufgaben und Dokumente.

### Tipps zur Nutzung

* **Schnelle Navigation:** Nutzen Sie die Status-Schaltflächen, um sich auf bestimmte Projektphasen zu konzentrieren.
* **Effiziente Nachverfolgung:** Markieren Sie Aktivitäten als abgeschlossen oder erstellen Sie Aufgaben direkt aus dieser Registerkarte.
* **Individuelle Anpassung:** Passen Sie die Filter an, um sich auf Meilensteine oder erstellte Aktivitäten zu konzentrieren.

## Ein Folgeaufgabe oder Dokument erstellen

Um eine Folgeaufgabe oder ein Dokument zu erstellen, das mit einem Projektleitfaden verknüpft ist:

1. Wechseln Sie zur Bereichsregisterkarte **Projektleitfaden**.
1. Suchen Sie die gewünschte Folgeaufgabe oder das Dokument im aktuellen Status.
1. Klicken Sie auf **Erstellen** neben dem jeweiligen Element.

    * Für Folgeaufgaben öffnet sich das [Dialogfeld Folgeaufgabe][7] mit vorab ausgefüllten Feldern basierend auf den Einstellungen des Projektleitfadens. Ändern Sie die Angaben bei Bedarf und klicken Sie auf **Speichern**.
    * Für Dokumente öffnet sich das [Dialogfeld Dokument][8] mit einer vorausgewählten Vorlage. Vervollständigen Sie die erforderlichen Felder und klicken Sie auf **Speichern**.

> [!TIP]
> Sie können mehrere Folgeaufgaben oder Dokumente desselben Typs erstellen, indem Sie mit der rechten Maustaste auf das Element klicken und **Weitere erstellen** auswählen.

## Eine Folgeaufgabe als abgeschlossen markieren

1. Wechseln Sie zur Bereichsregisterkarte **Projektleitfaden** und suchen Sie die Folgeaufgabe.
1. Aktivieren Sie das Kontrollkästchen neben dem Namen der Folgeaufgabe.
    Die Aufgabe wird als abgeschlossen markiert und in der Bereichsregisterkarte **Aktivitäten** als erledigt angezeigt.

Dokumente werden automatisch als abgeschlossen markiert, sobald sie erstellt wurden.

## <a id="change-status"></a>Zum nächsten Status wechseln

Projektstatus können entweder automatisch oder manuell gewechselt werden, je nach den Anforderungen Ihres Workflows.

### Automatische Statusänderung

Falls der Projektleitfaden so konfiguriert ist, dass er den nächsten Status vorschlägt, erscheint das Dialogfeld **Projektleitfaden – Projekt in den nächsten Status verschieben**, sobald alle erforderlichen Folgeaufgaben und Dokumente als abgeschlossen markiert wurden.

1. Vervollständigen Sie alle erforderlichen Folgeaufgaben und Dokumente des aktuellen Status.
1. Wenn das Dialogfeld erscheint, klicken Sie auf **Ja**, um zum nächsten Status zu wechseln, oder auf **Nein**, um im aktuellen Status zu bleiben.

> [!NOTE]
> Automatische Statusänderung muss in Einstellungen und Verwaltung aktiviert sein.

### Manueller Statuswechsel

Falls erforderlich, können Sie das Projekt manuell zum nächsten Status verschieben, ohne alle Folgeaufgaben abzuschließen.

#### Über die Bereichsregisterkarte Projektleitfaden

1. Klicken Sie mit der rechten Maustaste auf den gewünschten Status.
1. Wählen Sie **Zu diesem Status wechseln**.

#### Über die Projektkarte

1. Klicken Sie auf **Bearbeiten** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) in der Projekt-Ansicht.
1. Klicken Sie auf den Pfeil neben dem Feld **Status**, um die Liste zu öffnen.
1. Wählen Sie den gewünschten Status aus.
1. Klicken Sie auf **Speichern**, um die Änderungen zu bestätigen.

> [!TIP]
> Sie können auch zu einem vorherigen Status zurückkehren, indem Sie dieselben Schritte ausführen.

## Vorteile der Nutzung von Projektleitfäden

* **Konsistenz:** Stellt sicher, dass Ihr Team Projekte einheitlich und standardisiert verwaltet.
* **Transparenz:** Hält das gesamte Team über den aktuellen Status, die nächsten Schritte und wichtige Meilensteine auf dem Laufenden.
* **Flexibilität:** Passen Sie Projektleitfäden an die individuellen Arbeitsabläufe Ihrer Firma an.

## Verwandte Inhalte

* [Einführung in Projekte][2]
* [Projekt erstellen][4]
* [Projektleitfaden bearbeiten oder deaktivieren][5]

<!-- Referenced links -->
[2]: index.md
[4]: create.md
[5]: edit.md
[7]: ../../diary/learn/create-follow-up.md
[8]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/project-guide-tab.png
[img2]: ../../../media/loc/en/project/guide-statuses.png

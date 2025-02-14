---
uid: help-de-flow-update
title: Flow aktualisieren
description: Flow aktualisieren
keywords: Marketing, Flow, aktualisieren
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: de
audience: person
audience_tooltip: SuperOffice Marketing
---

# Flow aktualisieren

Es ist nützlich, mit einem einfachen Flow zu beginnen und ihn nach Überwachung der Leistung zu erweitern. Möglicherweise möchten Sie auch einen Flow während seiner Gestaltung aktualisieren.

Um Änderungen vorzunehmen:

1. [Pausieren Sie den Flow][1].
1. Klicken Sie auf **Bearbeiten**.
1. Nehmen Sie die erforderlichen Änderungen vor.
1. Klicken Sie auf **Speichern**.
1. Starten Sie den Flow neu.

> [!NOTE]
> Die von Ihnen vorgenommenen Änderungen an einem Schritt betreffen nur neue Teilnehmer und aktive Teilnehmer, die diesen Schritt noch nicht erreicht haben.

## Einstellungen des Flow, Erfolgskriterien und/oder Trigger aktualisieren

Gleich wie bei [der Erstellung eines Flow][2].

## Schritt hinzufügen

Gleich wie bei [der Erstellung eines Flow][3].

## Schritteinstellungen aktualisieren

1. Klicken Sie auf einen Schritt im Diagramm, um die Schritteinstellungen zu öffnen.
1. Je nach Typ des Schritts können Sie Folgendes tun:

    * Eigenschaften neuer Aktivitäten aktualisieren.
    * E-Mail-Inhalt und/oder Anhänge hinzufügen.
    * Wartezeit verlängern oder verkürzen.
    * Aktionen hinzufügen oder entfernen.
    * Eine statische Selektion, ein Projekt oder einen Flow auswählen, um den Teilnehmer zu übertragen.
    * Die Reihenfolge der Zweige ändern, Zweige umbenennen, einen Zweig hinzufügen.
    * Bedingungen in einer Aufteilung aktualisieren.

1. Klicken Sie auf **Speichern**.

Sie finden diese Ressourcen nützlich:

* [Liste der verfügbaren Einstellungen für jeden Schritt][6].
* [Flow aufteilen][5]
* [Wartezeit und Auf Aktion warten][4]
* [Inhalt hinzufügen][7]
* [Aktivität erstellen][9]
* [Person aktualisieren][8]
* [Selection erstellen][11]
* [Formular erstellen][10]

## Schritt verschieben, duplizieren oder entfernen

* **Verschieben:** Klicken Sie auf einen Schritt und ziehen Sie ihn an eine neue Position.
* **Duplizieren:** Zeigen Sie auf einen Schritt und klicken Sie auf das **Duplikat**-Symbol (<i class="ph ph-copy" aria-hidden="true"></i>). Dies erstellt einen neuen Schritt basierend auf dem aktuellen und fügt ihn als nächsten Schritt hinzu. Verwenden Sie diese Option, um einen Schritt im selben Flow wiederzuverwenden.
* **Entfernen:** Zeigen Sie auf einen Schritt und klicken Sie auf das rote X. Dies entfernt den Schritt aus dem Flow (aber nicht dessen Inhalt).

> [!NOTE]
> Wenn Sie einen E-Mail-Schritt duplizieren, erstellt der Flow-Editor auch eine **Kopie des E-Mail-Inhalts**. Sie können dieses neue Flow-Element unabhängig vom E-Mail-Inhalt im duplizierten Schritt bearbeiten.
>
> Wenn Sie einen E-Mail-Schritt entfernen, wird nur der Schritt aus dem Flow entfernt. Der E-Mail-Inhalt wird nicht entfernt oder gelöscht.

## Flow löschen

[Siehe *Ausführen, pausieren und beenden des Flow*.][1]

## Fehlerbehebung

Beim Bearbeiten eines Flow nach dessen Ausführung gibt es einige Einschränkungen, um aktive Teilnehmer zu schützen (anders ausgedrückt: um zu verhindern, dass Sie ein Durcheinander machen).

### Flow kann nicht bearbeitet werden

* Sie können einen laufenden Flow nicht bearbeiten. Pausieren Sie den Flow und versuchen Sie es erneut.
* Wenn die **Bearbeiten**-Schaltfläche immer noch ausgegraut ist, haben Sie nicht die erforderliche funktionale Berechtigung 'Flow-Administrator'.

### Schritt kann nicht verschoben oder entfernt werden

* Sie können einen **Wartezeit**, **Auf Aktion warten** oder **Aufteilung**-Schritt nicht verschieben oder entfernen, wenn sich aktive Teilnehmer im Schritt befinden.

Gehen Sie zum Registerkarte **Teilnehmer** und überprüfen Sie die Spalte **Aktueller Schritt**, um einen geeigneten Zeitpunkt zum Anhalten und Aktualisieren des Ablaufsteuerungsschritts zu finden.

### Zweig kann nicht entfernt werden

* Sie können den Zweig **Alle anderen** nicht entfernen.
* Sie können einen Zweig nicht entfernen, wenn sich aktive Teilnehmer darauf befinden.

Gehen Sie zum Registerkarte **Flow**, um zu überprüfen, ob sich jemand im Zweig befindet. Wenn ja, gehen Sie zum Registerkarte **Teilnehmer** für Details. Wie Sie diese Teilnehmer behandeln, liegt bei Ihnen. Einige zu berücksichtigende Optionen:

* Fügen Sie die Teilnehmer zu einer statischen Selektion hinzu, um sie später nachzuverfolgen.
* Fügen Sie die Teilnehmer zur Ausschlussliste des Flow hinzu.
* Entfernen Sie die Teilnehmer aus dem Flow mit dem **Aufgabe**-Menü.
* Warten Sie darauf, dass der Zweig "abfließt". Möglicherweise müssen Sie die Bedingung des Zweigs aktualisieren, um zu verhindern, dass neue Teilnehmer eintreten.

<!-- Referenced links -->
[1]: run-pause-end.md
[2]: create.md
[3]: create.md#add-step
[4]: create.md#wait
[5]: split.md
[6]: step-settings.md
[7]: content.md
[8]: define-flow-actions.md#update
[9]: define-flow-actions.md#create
[10]: ../../forms/learn/create.md
[11]: ../../../search-options/selection/learn/create/tutorial.yml

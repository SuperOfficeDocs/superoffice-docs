---
uid: help-de-section-tabs-configure
title: Spaltenansicht ändern
description: Spaltenansicht ändern
keywords: Bereichsregisterkarte, Archiv, Spalte
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Spalten konfigurieren

Sie können die Listen in Bereichsregisterkarten anpassen, um genau die benötigten Informationen anzuzeigen. Sie können ändern, welche Spalten in welcher Reihenfolge und Breite angezeigt werden.

Durch die Konfiguration von Spalten können Sie die angezeigten Informationen anpassen und nach Ihrem Ermessen mit CRM-Daten arbeiten. Sehen Sie sich dieses Video an oder befolgen Sie die folgenden Schritte, um zu lernen, wie Sie Spalten konfigurieren:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IjlPSN-u0MA]

(Videolänge – 1:44)

## Spaltenreihenfolge ändern

Um die Reihenfolge der Spalten in einer Bereichsregisterkarte zu ändern, klicken Sie auf eine Spaltenüberschrift und ziehen sie an eine neue Position.

## Spalte hinzufügen oder entfernen

1. Wechseln Sie zu der Bereichsregisterkarte, die Sie bearbeiten möchten.
2. Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenüberschriften. Ein Dialogfeld wird angezeigt.
3. Aktivieren oder deaktivieren Sie die entsprechenden Spalten. Verwenden Sie die Felder **Spalten filtern**, um die angezeigten Spalten zu filtern.
4. Klicken Sie auf **OK**.

Klicken Sie auf **Zurücksetzen**, wenn Sie die Spalten auf die Standardansicht zurücksetzen möchten.

## <a id="calculate"></a>Spaltenberechnungen

Sie können Berechnungen wie Summe, Durchschnitt oder Min/Max für Datums- und Zahlenfelder durchführen.

1. Klicken Sie auf das Zahnradsymbol in der Bereichsregisterkarte, um die Einstellungen zu öffnen.

2. Gehen Sie im Dialogfeld auf den Reiter **∑ Summe**.

3. Wählen Sie die Spalten aus, die in die Berechnung einbezogen werden sollen. Optional können Sie **Gruppierung aktivieren**, um die Daten zu organisieren.

    ![Bereichsregisterkarte-Einstellungen - Summe der Beträge und Gruppierung aktivieren -screenshot][img2]

4. Wählen Sie die Berechnung aus, die auf jede Spalte angewendet werden soll. Die verfügbaren Optionen hängen vom Feldtyp ab.

**Ergebnis:**

![Verkaufsbereichsregisterkarte - Summe und Gruppierung von Beträgen -screenshot][img3]

> [!NOTE]
> Wenn Ihre Organisation mehrere Währungen verwendet, stellen Sie sicher, dass Sie mit konsistenten Werten in den Verkaufsberechnungen arbeiten. Verwenden Sie die **Basiswährungs**-Versionen der Felder **Betrag** und **Gewichteter Betrag**, um Genauigkeit zu gewährleisten.

![Verkaufsbereichsregisterkarte - Summe der Beträge für Basiswährung -screenshot][img5]

## Spaltenbreiten manuell anpassen

1. Positionieren Sie den Mauszeiger über der vertikalen Trennlinie vor oder hinter einem Spaltentitel. Der Mauszeiger wird zu einer vertikalen Doppellinie mit Pfeilen.

1. Halten Sie die Maustaste gedrückt, während Sie die Trennlinie in die gewünschte Richtung ziehen, die Spalte also entweder verschmälern oder verbreitern. Die Spalten behalten die von Ihnen festgelegte Breite beim nächsten Öffnen des Programms bei.

> [!NOTE]
> Sie können Spaltenbreiten nicht manuell anpassen, wenn **Spaltenbreite automatisch anpassen** aktiv ist.

## Spaltenbreiten automatisch anpassen

Sie können festlegen, dass die Spaltenbreiten automatisch an den Inhalt der Spalten angepasst werden. Wenn Spalten hinzugefügt oder entfernt werden, werden alle Spaltenbreiten optimal angepasst. Wenn die vorhandenen Spalten den verfügbaren Platz überschreiten, wird eine horizontale Bildlaufleiste angezeigt.

1. Wechseln Sie zu der Bereichsregisterkarte, die Sie bearbeiten möchten.
2. Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenüberschriften. Ein Dialogfeld wird angezeigt.
3. Wählen Sie **Spaltenbreite automatisch anpassen**.
4. Klicken Sie auf **OK**.

## Verwandte Themen

* [Gruppierte Listen][3]
* [Bereichsregisterkarten filtern][1]
* [Bereichsregisterkarten exportieren][2]

<!-- Referenced links -->
[1]: filter.md
[2]: export-archives.md
[3]: group.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/learn/section-tab-sum-amount.png
[img3]: ../../../media/loc/en/learn/group-sales-by-status.png
[img5]: ../../../media/loc/en/sale/currency-adjusted-sale-amount-calculation.png

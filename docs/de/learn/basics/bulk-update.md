---
uid: help-de-bulk-update
title: Massenabgleich
description: Massenabgleich
keywords: Massenabgleich
author: SuperOffice RnD
date: 02.11.2025
version: 10.5.2
topic: howto
language: de
---

# Mehrere Datensätze abgleichen (Massenabgleich)

Mit dem Massenabgleich können Sie Werte in mehreren Datensätzen desselben Typs ändern. Sie können den Massenabgleich für alle oder ausgewählte Datensätze in Bereichsregisterkarten (Archiven), Selektionen und in der Ansicht **Suchen** ausführen. Mit dieser Aufgabe können auch mehrere Datensätze gelöscht werden.

1. Öffnen Sie die Selektion, Bereichsregisterkarte (Archiv) oder Suchergebnisse (Ansicht **Suchen**) mit den abzugleichenden Datensätzen.

2. Selektionen: Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) und wählen Sie **Massenabgleich**.
    oder
    Wählen Sie die abzugleichenden Datensätze aus, klicken Sie mit der rechten Maustaste darauf und wählen Sie **Massenabgleich...**.
    Das Dialogfeld **Massenabgleich** wird geöffnet. Unten in diesem Dialogfeld werden der Datensatztyp und die Anzahl der abzugleichenden Datensätze angezeigt. Beispiel: Anzahl der Personen in Warteschlange für Massenabgleich: 7.

    > [!NOTE]
    > Wenn die Selektion Firmen und Personen enthält, gibt es zwei Registerkarten: **Firma** und **Person**.

3. Wählen Sie in der Spalte **Feld** ein Feld aus, das abgeglichen werden soll. Sie können auch den Namen in das Feld eingeben. Während Sie jeden Buchstaben eingeben, werden in der folgenden Liste alle Übereinstimmungen angezeigt, die für die ausgewählten Datensätze relevant sind.

4. Wählen Sie in der Spalte **Aktion** eine Aktion aus. Welche Aktionen verfügbar sind, hängt vom Typ des Felds ab, das Sie im vorherigen Schritt ausgewählt haben. Beispiele:

    * **Aktivieren**: Aktivieren oder deaktivieren Sie ein Kontrollkästchen.
    * **Umschalten**: Deaktivieren Sie ein aktiviertes Kontrollkästchen und umgekehrt.
    * **Suchen und ersetzen**: [Zeichenfolge suchen und ersetzen](#search-and-replace).
    * **Regex**: Feld mit der Option [reguläre Suchausdrücke](#regex) aktualisieren.
    * **Festlegen**: Wenden Sie einen neuen Wert auf das Feld an.
    * **Löschen**: Löschen Sie den Wert aus dem Feld.
    * Aktionen in Listen: Wählen oder löschen Sie einzelne oder mehrere Werte in Listenfeldern.
    * Aktionen für Aktivitätsverknüpfungen: Sie können Aktivitätsverknüpfungen hinzufügen, entfernen oder austauschen oder alle Aktivitätsverknüpfungen löschen.

5. Um weitere abzugleichende Felder hinzuzufügen, klicken Sie auf **Hinzufügen** und gehen erneut wie in Schritt 3 und 4 erläutert vor.

6. Achten Sie darauf, die Felder auszuwählen (<i class="ph ph-check" aria-hidden="true"></i>), die Sie abgleichen wollen, und die Auswahl der Felder, die Sie NICHT abgleichen wollen, aufzuheben.

7. Klicken Sie auf **Abgleichen**. Das Dialogfeld **Bestätigen** mit einer Zusammenfassung des Abgleichs wird geöffnet.

    > [!NOTE]
    > Nachdem ein Update angewendet wurde, kann es nicht mehr rückgängig gemacht werden.

8. Klicken Sie auf **Ja**, um die Änderungen auf die ausgewählten Datensätze anzuwenden.

    > [!NOTE]
    > Sobald ein Abgleich durchgeführt wurde, kann er nicht rückgängig gemacht werden. Sie können die Aktualisierung jedoch stoppen, solange sie noch läuft. Alle Datensätze, die noch nicht aktualisiert wurden, bleiben unverändert.

9. Klicken Sie auf **Protokoll**, um das Änderungsprotokoll anzuzeigen. Falls Datensätze nicht abgeglichen wurden, ist der Grund in der Spalte **Gründe hierfür** aufgeführt.

10. Klicken Sie auf **Schließen**.

## <a id="search-and-replace"></a>Suchen und ersetzen

Mit dem Aktionstyp **Suchen und ersetzen** können Sie eine bestimmte Zeichenfolge in einem Feld suchen und ersetzen.

1. Wählen Sie in der Spalte **Aktion** die Option **Suchen und ersetzen** aus.
2. Geben Sie den zu ersetzenden Text in das Feld **Suchen** ein.
3. Geben Sie den gewünschten Text in das Feld **Ersetzen mit** ein.
4. Optional: Klicken Sie auf **Optionen** und wählen Sie Einstellungen zum Umgang mit Groß- und Kleinschreibung und zur Suche des ganzen Worts oder eines Wortteils aus.

## <a id="regex"></a>Reguläre Suchausdrücke

Mit dem Aktionstyp **Regex** können Sie ein Feld anhand von regulären Ausdrücken abgleichen.

1. Wählen Sie in der Spalte **Aktion** die Option **Regex** aus.
2. Geben Sie den Ausdruck in das Feld **Ausdruck** ein.
3. Geben Sie den gewünschten Text in das Feld **Ersetzen mit** ein.
4. Optional: Klicken Sie auf **Optionen** und wählen Sie Einstellungen für den regulären Ausdruck aus.

## Beispiele

## Firmenkategorien abgleichen

Sie möchten Ihre Kunden nach Verkaufsumsätzen kategorisieren. Erstellen Sie in SuperOffice CRM Firmenkategorien mit den Namen "Kunde A", "Kunde B" und "Kunde C". Für "Kunde A" können Sie eine Selektion mit Firmen erstellen, mit denen im letzten Jahr Verkaufsumsätze von über EUR 50.000 erzielt wurden. Ordnen Sie mit **Massenabgleich** diese Kunden in die Kategorie "Kunde A" ein. Wiederholen Sie diesen Vorgang bei den anderen Firmen.

## Postleitzahl und Ort von Firmen abgleichen

Postleitzahlen und Postorte in Norwegen haben sich geändert. Gleichen Sie mit **Massenabgleich** die Adressen ab.

## Person aktualisieren

Sie haben festgestellt, dass das Feld **Position** für Personen selten verwendet wird. Um zumindest damit anzufangen, dieses Feld bei allen Personen auszufüllen, suchen Sie alle Personen mit dem Titel "Direktor". Erstellen Sie eine Selektion mit allen Personen, bei denen das Feld **Titel** das Wort "Direktor" enthält. Fügen Sie mit **Massenabgleich** den Begriff **Management** in das Feld **Position** ein.

## Projekt abgleichen

Sie möchten alle "alten" Projekte, die nicht als abgeschlossen gekennzeichnet sind, aufräumen. Erstellen Sie eine Selektion mit allen alten Projekten, beispielsweise allen Projekten, die vor mehr als 2 Jahren erstellt und im letzten Jahr nicht abgeglichen wurden. Stellen Sie mit **Massenabgleich** den Status **Abgeschlossen** bei diesen Projekten auf **Ja** ein.

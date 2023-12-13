---
uid: help-de-recurrence-set
title: Planen von regelmäßige Folgeaufgabe
description: Planen von regelmäßige Folgeaufgabe
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Wiederholen, Wiederkehren, regelmäßig, planen
so.topic: howto
language: de
---

# Planen von regelmäßige Folgeaufgabe

Die Einrichtung von Wiederholungen bedeutet, das Startdatum für Nachverfolgungen in einer Serie zu planen.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Schritte

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Öffnen oder erstellen Sie eine Folgeaufgabe][2].

2. Wählen Sie die Registerkarte **Details** und klicken Sie neben Feld **Wiederholung** auf **Nie**.

    Wenn Sie eine wiederkehrende Nachverfolgung aktualisieren, klicken Sie auf das zuvor festgelegte Muster, zum Beispiel, **Monatlich (23.09.2023 - 23.09.2024)**.

3. Unter **Häufigkeit** legen Sie fest, ob die Folgeaufgabe täglich, wöchentlich, monatlich, jährlich oder in benutzerdefinierten Intervallen wiederholt werden soll.

4. Wählen Sie danach weitere Informationen in Bezug auf [die Häufigkeit][4] aus. Die hier verfügbaren Optionen hängen davon ab, was Sie unter **Häufigkeit** ausgewählt haben.

    Wenn keines der Muster für Sie funktioniert, können Sie die benötigten Daten manuell eingeben.
    Wählen Sie **Benutzerdefiniert**. Wählen Sie dann ein Datum im Kalender aus und klicken Sie auf den Pfeil ![Symbol][img2], um es zur Liste der ausgewählten Daten hinzuzufügen. Wiederholen Sie dies, um weitere Daten hinzuzufügen. Um ein Datum zu entfernen, wählen Sie das Datum in der Liste aus und klicken Sie auf **Löschen**.

5. Legen Sie im Feld **Ende der regelmäßigen Folgeaufgaben** fest, ob die Folgeaufgabe nach einer bestimmen Anzahl von Wiederholungen oder an einem bestimmten Datum gestoppt werden soll.

6. Wenn zum Beispiel ein Konflikt vorliegt, können Sie optional mindestens ein Datum in der Liste der ausgewählten Daten manuell ändern.

    * **Um ein Datum zu verschieben,** wählen Sie das zu verschiebende Datum aus und klicken Sie auf **Später**, um die Folgeaufgabe um einen Tag nach hinten zu verschieben, oder auf **Früher**, um die Folgeaufgabe einen Tag vorzuverlegen.

    * **Um ein Datum hinzufügen,** klicken Sie unter der Liste auf die Schaltfläche **Hinzufügen**. Wählen Sie das gewünschte Datum aus und klicken Sie auf die Pfeilschaltfläche ![Symbol][img2] rechts neben dem Kalender, um das Datum zur Liste hinzuzufügen. Um zu einem anderen Monat zu wechseln, verwenden Sie die Pfeilschaltflächen auf beiden Seiten des Monatsnamens im Kalender.

    * **Um ein Datum löschen,** wählen Sie das Datum, das Sie löschen möchten, und klicken Sie unter der Liste auf die Schaltfläche **Löschen**. Das Datum wird aus der Liste der Datumsangaben entfernt.

7. Klicken Sie nach der Eingabe der Daten für die Folgeaufgabe auf **OK**, um die Datumsangaben zu speichern und das Dialogfeld zu schließen, oder klicken Sie auf **Abbrechen**, um das Dialogfeld zu schließen, ohne die Datumsangaben zu übernehmen.

    Im Dialogfeld zeigt der Text neben dem Feld **Wiederholung** an, welche Art der Wiederholung Sie für die Folgeaufgabe festgelegt haben, wie zum Beispiel **Monatlich (23.09.2016 - 23.09.2017)**.

8. Klicken Sie im Dialogfeld **Termin** auf **Speichern**, um die vorgenommenen Änderungen zu speichern.

![Screenshot des Dialogs für wiederkehrende Nachverfolgungen -screenshot][img6]

### [Neu (ab Version 10.2.11 Pilot)](#tab/fields-new)

1. [Öffnen oder erstellen Sie eine Nachverfolgung][2].

1. Klicken Sie auf das Wiederholungssymbol ![Symbol][img1] und wählen Sie eine der vorgeschlagenen Frequenzen aus. Wenn keines der Muster für Sie funktioniert, wählen Sie **Benutzerdefiniert**.

    ![Nachverfolgungsdialog, vorgeschlagene Wiederholung -screenshot][img8]

    Wenn Sie das Symbol nicht sehen, klicken Sie auf **Mehr anzeigen**.

1. Aktualisieren Sie das Startdatum bei Bedarf.

1. Wählen Sie eine Häufigkeit aus, zum Beispiel, wiederholen Sie alle 2 Wochen. Zusätzliche Optionen erscheinen, wenn Sie *Woche(n)*, *Monat(e)* oder *Jahr(e)* auswählen.

    ![Nachverfolgungsdialog, Wiederholung -screenshot][img7]

1. Entscheiden Sie, ob die Nachverfolgung nach einer bestimmten Anzahl von Malen oder nach einem bestimmten Datum enden soll.

1. Feinabstimmung der Liste der ausgewählten Daten ist optional, zum Beispiel, wenn es einen Konflikt gibt. Klicken Sie auf ein Datum und verwenden Sie dann die Schaltflächen unter der Liste, um dieses Datum zu entfernen oder zu verschieben.

1. Klicken Sie auf **OK**, um die Daten zu speichern und zu den Nachverfolgungsdetails zurückzukehren.

1. Klicken Sie in der **Nachverfolgungs**-Dialog auf **Speichern**, um alle Änderungen zu speichern.

***
<!-- markdownlint-restore -->

## Worüber würden Sie gern mehr erfahren?

* [Regelmäßige Folgeaufgaben bearbeiten][1]
* [Regelmäßige Folgeaufgaben stoppen][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[2]: ../create-follow-up.md
[3]: stop.md
[4]: index.md#frequency

<!-- Referenced images -->
[img1]: ../../../../../common/icons/refresh-icon.png
[img2]: ../../../../media/icons/arrow-right.png
[img6]: ../../../../media/loc/en/diary/recurrence-dialog.png
[img7]: ../../../../media/loc/en/diary/recurrence-selected-dates.png
[img8]: ../../../../media/loc/en/diary/suggested-pattern.png

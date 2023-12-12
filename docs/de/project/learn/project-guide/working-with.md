---
uid: help-de-project-guide-working-with
title: Mit Projektleitfäden arbeiten
description: Mit Projektleitfäden arbeiten
author: SuperOffice RnD
so.date: 07.04.2022
keywords: Projekt, Leitfaden
so.topic: howto
language: de
---

# Mit Projektleitfäden arbeiten

Wenn für einen Projekttyp, den Sie für ein Projekt angeben, ein Projektleitfaden definiert wurde, gilt Folgendes:

* Der erste Status im Projektleitfaden wird auf der Hauptkarte **Projekt** im Feld **Status** ausgewählt.

* Die Folgeaufgaben und/oder Dokumente für den Status werden auf der Bereichsregisterkarte **Projektleitfaden** aufgelistet.

## Schritte

1. Klicken Sie vor dem Namen der Folgeaufgabe/des Dokuments auf die Schaltfläche **Erstellen**.

   ![Bereichsregisterkarte Projektleitfaden mit Übersicht über den Status Geplant -screenshot][img1]

1. Erstellen Sie im daraufhin angezeigten [Dialogfeld die Folgeaufgabe][2] order [das Dokument][3] auf die übliche Art und Weise. Viele Felder sind bereits ausgefüllt. Sie können die Informationen jedoch ändern oder weitere Informationen hinzufügen.

    Sie können die Folgeaufgabe an Ihre Kollegen delegieren, indem Sie die Kollegen als Eigentümer der Folgeaufgabe festlegen. Falls in Einstellungen und Verwaltung für eine bestimmte Folgeaufgabe definiert, wird das Dialogfeld **Aufgabe zu Projektmitglied zuweisen** angezeigt, in dem Sie einen Kollegen als Eigentümer der Folgeaufgabe auswählen können.

1. Wenn Sie die Folgeaufgabe abgeschlossen haben, markieren Sie im entsprechenden Dialogfeld die Option **Abgeschlossen**, oder aktivieren Sie das entsprechende Kontrollkästchen vor dem Namen der Folgeaufgabe auf der Bereichsregisterkarte **Projektleitfaden**. Standardmäßig werden Dokumente als abgeschlossen gekennzeichnet.

    > [!TIP]
    > Um mehrere Folgeaufgaben desselben Typs zu erstellen, müssen mit der rechten Maustaste auf die Aktivität klicken **Weitere erstellen** auswählen.
    >
    > ![Weitere erstellen -screenshot][img2]

1. Nachdem alle erforderlichen Folgeaufgaben und Dokumente für einen Projektstatus abgeschlossen wurden, können Sie den nächsten Status aufrufen.

    > [!NOTE]
    > Sie können auch zum nächsten Status wechseln, ohne alle Folgeaufgaben/Dokumente in einem Status zu erstellen bzw. durchzuführen.

1. Wiederholen Sie die oben beschriebene Vorgehensweise für alle Folgeaufgaben/Dokumente in jedem Status des Projektleitfadens.

## <a id="move-to-next-status" />Zum nächsten Status verschieben

Sie haben zwei Möglichkeiten, das Projekt in den nächsten Status zu verschieben:

* So verschieben Sie das Projekt automatisch in den nächsten Status:

    Sie können in Einstellungen und Verwaltung definieren, dass der Projektleitfaden vorschlägt, das Projekt zum nächsten Status zu verschieben, sobald die letzte Folgeaufgabe in einem Status als abgeschlossen markiert wurde. Das Dialogfeld **Projektleitfaden – Projekt in den nächsten Status verschieben** wird geöffnet.

    Klicken Sie auf **Ja**, um das Projekt in den nächsten Status zu verschieben, oder klicken Sie auf **Nein**, um das Projekt innerhalb desselben Status weiter zu bearbeiten.

* So verschieben Sie das Projekt manuell in den nächsten Status:

    Klicken Sie für den nächsten Status mit der rechten Maustaste auf die Bereichsregisterkarte **Projektleitfaden** und wählen Sie die Option **Zu diesem Status wechseln**.

    Oder führen Sie einen der folgenden Schritte auf der Hauptkarte **Projekt** aus:

    1. Klicken Sie auf **Bearbeiten** auf der Hauptkarte **Projekt**.
    1. Klicken Sie auf den Pfeil neben dem Feld **Status**.
    1. Wählen Sie den gewünschten Status aus der angezeigten Liste aus. [!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Klicken Sie auf **Speichern**.

## Beispiel

Beachten Sie, dass Ihre Projektleitfäden in Einstellungen und Verwaltung anders konfiguriert sind.

### Ein neues Projekt eingeben und einen Projekttyp auswählen

Sie erfassen ein neues Projekt und wählen den Projekttyp **Konferenz**, der mit einem Projektleitfaden verknüpft ist. Der Projektleitfaden enthält die folgenden Statuswerte, Folgeaufgaben und Dokumente:

| Status | Folgeaufgaben | Dokumente |
|---|---|---|
| Geplant | Recherche (Meeting (intern)) | Konferenzprogramm (Memo) |
| In Bearbeitung | Liste mit Projektmitgliedern erstellen (Folgeaufgabe) | Konferenz (Meeting (extern)) |
| Wird beendet | Auswertungsmeeting (Meeting (intern)) |
| Auswertungsbericht (Memo) |

### Status Geplant

1. Sie haben einen Besprechungstermin festgelegt und möchten die Folgeaufgabe **Recherche** im Kalender eintragen sowie Teilnehmer einladen.

    1. Klicken Sie im Projektleitfaden auf **Erstellen** neben der Folgeaufgabe **Recherche**.
        Das Dialogfeld **Folgeaufgabe** wird geöffnet, in dem **Meeting (intern)** als Typ angegeben ist und der Name des Projekts bereits eingegeben ist.
    1. Vervollständigen Sie die Information und [laden Sie Teilnehmer ein][2].
    1. Klicken Sie auf **Speichern**.

1. Während der Besprechung beschließen Sie ein Konferenzprogramm (Zeitplan) und möchten ein Memo mit diesen Informationen erstellen.

    1. Klicken Sie neben dem Feld **Konferenzprogramm** auf **Erstellen**.
        Das Dialogfeld **Dokument** wird geöffnet, in dem **Memo** bereits als Dokumentvorlage ausgewählt und der Name des Projekts bereits eingegeben ist.
    1. Geben Sie die restlichen Informationen in die Felder des Dialogfelds **Dokument** ein.
    1. Klicken Sie auf die Schaltfläche **Erstellen**, um das Memo zu erstellen und zu speichern.

1. Nachdem die Konferenz stattgefunden hat und das Konferenzprogramm bereit ist, möchten Sie dies im Projektleitfaden bestätigen und zum nächsten Projektstatus wechseln.

    Aktivieren Sie im Projektleitfaden das Kontrollkästchen neben der Folgeaufgabe **Recherche**.

    > [!TIP]
    > Dies ist auch in der Aktivitätenliste, wie zum Beispiel in den Ansichten Kalender und Firma möglich.

    1. Das Dialogfeld **Projektleitfaden – Projekt in den nächsten Status verschieben** wird geöffnet.
    1. In diesem Dialogfeld können Sie das Projekt zum nächsten Status **In Bearbeitung** verschieben.
    1. Klicken Sie auf **Ja**, um das Projekt in den nächsten Status zu verschieben.

    > [!NOTE]
    > Der **Projektleitfaden – Projekt in den nächsten Status verschieben** wird geöffnet, weil dies für den Projekttyp in Einstellungen und Verwaltung definiert wurde.

### Status In Bearbeitung

1. Alle Folgeaufgaben und Dokumente im Status **Geplant** sind abgeschlossen und Sie haben das Projekt mithilfe des Dialogfelds **Projektleitfaden – Projekt in den nächsten Status verschieben** in den nächsten Status verschoben. Dieses Dialogfeld wird angezeigt, sobald die letzte Folgeaufgabe als abgeschlossen gekennzeichnet wurde. Die Folgeaufgaben und Dokumente für diesen neuen Status werden nun auf der Bereichsregisterkarte **Projektleitfaden** angezeigt.

    > [!NOTE]
    > Das Dialogfeld **Projektleitfaden – Projekt in den nächsten Status verschieben** wird nur angezeigt, wenn dieses Verhalten für den Projekttyp definiert wurde. Falls dies nicht definiert wurde, können Sie das [Projekt in den nächsten Status verschieben](#move-to-next-status).

1. Während der Besprechung der Recherche vereinbaren Sie, dass Ihr Kollege eine Liste mit Konferenzteilnehmern erstellt. Sie möchten eine Aufgabe in ihrem Kalender als Erinnerung erstellen.

    1. Klicken Sie auf **Erstellen** neben der Folgeaufgabe **Liste mit Projektmitgliedern erstellen**.
        Das Dialogfeld **Aufgabe zu Projektmitglied zuweisen** wird geöffnet.

    1. Wählen Sie in der Liste der Projektmitglieder die Person aus, der Sie die Folgeaufgabe zuweisen möchten, und klicken Sie auf **OK**.

    1. Geben Sie die erforderlichen Informationen ein und klicken Sie auf **Speichern**. (Auf der Registerkarte **Details** wird angezeigt, dass Ihr Kollege bereits als Eigentümer definiert ist.)

    1. Die Folgeaufgabe wird im Kalender Ihres Kollegen angezeigt und sobald er die Liste eingestellt hat, kennzeichnet er die Folgeaufgabe als **Abgeschlossen**.

        > [!NOTE]
        > Das Dialogfeld **Aufgabe zu Projektmitglied zuweisen** wird angezeigt, weil dieses in Einstellungen und Verwaltung definiert wurde.

1. Nun möchten Sie eine Einladung erstellen.

    Klicken Sie auf **Erstellen** neben dem Dokument **Konferenzeinladung** und auf [Dokument erstellen][3].

1. Schließlich findet die Konferenz statt. Sie erstellen die Besprechung **Konferenz**.

    1. Klicken Sie neben der Folgeaufgabe **Konferenz** auf **Erstellen**.
        Das Dialogfeld **Folgeaufgabe** wird geöffnet, in dem **Meeting (extern)** als Typ angegeben und der Name des Projekts bereits eingegeben ist.
    2. Geben Sie die erforderlichen Informationen ein, und laden Sie die Konferenzteilnehmer auf die übliche Weise ein.
    3. Klicken Sie auf **Speichern**.

### Status Wird beendet

1. Nachdem die Konferenz stattgefunden hat und alle relevanten Folgeaufgaben und Dokumente im Status **In Bearbeitung** abgeschlossen worden sind, müssen Sie zum letzten Status des Projektleitfadens **Wird beendet** gehen.

    * Klicken Sie im Dialogfeld **Projektleitfaden – Projekt in den nächsten Status verschieben** auf **Ja**.
        oder
    * Klicken Sie auf der Hauptkarte **Projekt** auf **Bearbeiten**. Klicken Sie dann auf den Pfeil rechts neben dem Feld **Status**, und wählen Sie **Wird beendet** aus der Liste aus. Klicken Sie anschließend auf **OK**.

1. Sie möchten eine interne Besprechung abhalten, um die Konferenz zusammenzufassen.

    1. Klicken Sie neben der Folgeaufgabe **Auswertungsmeeting** auf die Schaltfläche **Erstellen**, geben Sie die erforderlichen Informationen ein, und klicken Sie auf **Speichern**.
    2. Aktivieren Sie das Kontrollkästchen, nachdem der Termin abgeschlossen wurde.

1. Anschließend möchten Sie einen Auswertungsbericht erstellen, der das Auswertungsmeeting und die Konferenz zusammenfasst.

    Klicken Sie zum Erstellen des Dokuments auf **Erstellen** neben dem Dokument **Auswertungsbericht**.

Nachdem alle erforderlichen Folgeaufgaben und Dokumente für das Projekt abgeschlossen wurden, können Sie den Projektstatus auf abgeschlossen setzen.

## Verwandte Themen

* [Dialogfeld Dokument][1]
* [Dialogfeld Folgeaufgabe][2]
* [Projektleitfaden ist in Einstellungen und Verwaltung hinzufügen und bearbeiten][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png

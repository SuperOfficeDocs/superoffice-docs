---
uid: help-de-mailing-add-unsubscribe-link
title: Einen Abmeldelink hinzufügen
description: "Wenn Sie eine Kampagne versenden, müssen Sie den Empfängern die Möglichkeit geben, sich abzumelden. Erfahren Sie in dieser Anleitung, wie Sie Ihrer Kampagne einen Abmeldelink hinzufügen können."
author: SuperOffice RnD
so.date: 02.16.2023
keywords: Marketing
so.topic: howto
language: de
---

# Links für Abonnement hinzufügen

Wenn Sie beispielsweise Newsletter versenden, müssen Sie den Empfängern die Option bieten, sich davon abzumelden oder die Abonnementeinstellungen zu ändern. Fügen Sie hierzu einen Link ein, den die Empfänger lediglich anklicken müssen. Solche Links werden normalerweise am Ende einer Nachricht (in der Fußzeile) eingefügt.

Der Abmeldelink wird normalerweise am Ende einer Nachricht eingefügt. Wenn Sie eine unserer Kampagnenvorlagen verwenden, ist dieser Link bereits hinzugefügt.

Sie entscheiden, wo dieser Abmeldelink angezeigt und formuliert wird und was das Klicken auf diesen Link bewirkt. Sie können zum Beispiel den Betrachter einfach auf seine "Abmelde"-Seite leiten, wo er seine Einstellungen verwalten oder sich automatisch von all Ihren Kampagnen abmelden kann.

![Klicken Sie im Symbol Link einfügen/bearbeiten auf Speziallinks und fügen Sie Ihren Abmeldelink hinzu -screenshot][img4]

## Im Drag-and-Drop-Editor

1. Gehen Sie zu den Inhalten der Mitteilung, und klicken Sie auf den Bereich, in dem Sie den Link einfügen möchten.
    oder
    Wechseln Sie zum Bereich **Blöcke**, klicken auf eine Fußzeile und ziehen diese an den unteren Rand der Nachricht.

2. Geben Sie den Text ein auf den der Empfänger klicken soll und wählen ihn aus, z. B. "Klicken Sie hier, um das Abonnement zu beenden" oder "Klicken Sie hier, um Ihre Abonnements zu verwalten".

3. Klicken Sie in der Werkzeugleiste auf die Schaltfläche **Link einfügen/bearbeiten** (![Symbol][img3]).

4. Klicken Sie auf **Besondere Links** und wählen eine der folgenden Optionen aus:
    * **Abonnements verwalten**: Zum Einfügen eines Links auf einer Webseite, auf der die Empfänger auswählen können, welche Kampagnentypen sie erhalten wollen. Der Link ist standardmäßig 21 Tage gültig.
    * **Abonnement für diesen Kampagnentyp stornieren**: Zum Einfügen eines Links, über den das Abonnement für diesen Kampagnentyp storniert werden kann. Der Empfänger erhält weiterhin Kampagnen anderer Typen. Der Kampagnentyp wird im Schritt 1 ausgewählt: Einstellungen.

5. Klicken Sie auf **Speichern**. Der Link wird in die Nachricht eingefügt.

## Im alten Editor

1. Gehen Sie zum Inhalt der Nachricht und führen Sie dort die Option [Absatz bearbeiten][1] aus, um die Bearbeitungsansicht zu öffnen.
    Oder klicken Sie auf das ![Symbol][img1] der Schaltfläche **Neuen Abschnitt hinzufügen**, um unten einen Absatz hinzuzufügen.
2. Wählen Sie die Registerkarte **Text** aus.
3. Positionieren Sie den Mauszeiger an der Stelle, an der Sie den Link einfügen möchten.
4. Klicken Sie in der Werkzeugleiste auf das ![Symbol][img2] der Schaltfläche **Links für Abonnement**.
5. Ändern Sie gegebenenfalls den Text im Dialogfeld **Link zum Abonnement/zur Abmeldung hinzufügen** den Text im Feld **Link-Bezeichnung**, zum Beispiel in "Klicken Sie hier, um das Abonnement zu beenden" oder "Klicken Sie hier, um Ihre Abonnements zu verwalten".
6. Wählen Sie im Feld **Link für Abonnement/Abonnementkündigung hinzufügen** eine der folgenden Optionen:
    * **Abonnements verwalten**: Zum Einfügen eines Links auf einer Webseite, auf der die Empfänger auswählen können, welche Kampagnentypen sie erhalten wollen. Der Link ist standardmäßig 21 Tage gültig.
    * **Abonnement für diesen Kampagnentyp stornieren**: Zum Einfügen eines Links, über den das Abonnement für diesen Kampagnentyp storniert werden kann. Der Empfänger erhält weiterhin Kampagnen anderer Typen. Der Kampagnentyp wird im Schritt 1 ausgewählt: Einstellungen.
7. Klicken Sie auf **OK**. Der Link wird in die Nachricht eingefügt.

## Was geschieht jetzt?

Auf der Grundlage des Feedbacks von den Empfängern werden die Abonnementeinstellungen auf der Registerkarte **Interessen** auf der Personenkarte in SuperOffice CRM aktualisiert.

> [!NOTE]
> Dies bedeutet, dass der Kunde diesen Kampagnentyp von SuperOffice Marketing nicht mehr erhält, und zwar unabhängig davon, welche Empfängerliste für die Kampagne verwendet wird. Dies ist im Hinblick auf künftiges Marketing möglicherweise nicht wünschenswert. [Welche Alternativen gibt es?][2].
>
> Sie haben jedoch die Möglichkeit, die Einstellungen "Keine Einwilligung/Kein Abonnement" über **Optionen** im unteren Teil der Ansicht **Empfänger** zu umgehen (siehe Schritt 4: Empfänger).

## <a id="clear-interests" />Interessen löschen in SuperOffice CRM

In SuperOffice CRM können Sie Interessen (wie "Monatlicher Newsletter") zu Personen hinzufügen. Diese Interessen können als Grundlage für verschiedene Kampagnenarten verwendet werden. Anstatt einen Abmeldelink zu verwenden, können Sie ganz einfach einzelne Interessen von Personen löschen, beispielsweise wenn diese den monatlichen Newsletter nicht erhalten möchten.

Dafür erstellen Sie einen [Link, der das betroffene Interesse von den Empfängern löscht][4], die auf den Link klicken. Diese Methode können Sie auch anwenden, um Interessen hinzuzufügen.

<!-- Referenced links -->
[1]: ../../../learn/edit-paragraph.md
[2]: ../../../tracked-links/learn/examples.md
[4]: ../../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img3]: ../../../../../media/icons/marketing-and-forms/link.png
[img1]: ../../../../../media/icons/marketing-and-forms/new-para.jpg
[img2]: ../../../../../media/icons/marketing-and-forms/link.png
[img4]: ../../../../../media/loc/en/marketing/insert-edit-link-unsubscribe-mailing.png

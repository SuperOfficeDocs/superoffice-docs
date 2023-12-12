---
uid: help-de-video-meetings
title: Mit Videokonferenzen arbeiten
description: Lernen Sie hier, wie Sie eine Videokonferenz in SuperOffice erstellen und daran teilnehmen können.
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Besprechung, Videokonferenz, Einladung
so.topic: howto
language: de
---

# Mit Videokonferenzen arbeiten

Mit SuperOffice-Videokonferenzen können Sie Videokonferenzen direkt von Ihrem Kalender planen und an solchen teilnehmen. Sehen wir uns an, wie Sie eine Videokonferenz einrichten können.

> [!NOTE]
> Mit der Option [Administrator muss konfigurieren][1] müssen Sie Ihren bevorzugten Videokonferenzservice in SuperOffice Einstellungen und Verwaltung konfigurieren, bevor Sie diese Funktion verwenden.

## Verfügbare Videokonferenzanbieter

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (kostenlos, kein Abonnement erforderlich)

## Videokonferenz erstellen

Sie können ganz einfach eine Videokonferenz einrichten, wenn Sie eine Folgeaufgabe erstellen. Sehen Sie sich dieses Video an, um zu lernen, wie man eine Videokonferenz erstellt, oder befolgen Sie die folgenden Schritte (Videolänge – 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Schritte

1. Erstellen Sie einen neuen Termin und wählen Sie den Namen der Firma und der Person aus, mit der Sie sprechen wollen.

2. Um die URL für Videokonferenzen zu erstellen, müssen Sie auf das Symbol Videokonferenz ![Symbol][img1] klicken. Das Symbol wechselt zu ![Symbol][img2] und es wird ein Videokonferenzlink hinzugefügt. SuperOffice CRM erstellt und fügt die Videokonferenz-URL für den von Ihnen verwendeten Videoanbieter hinzu.

    ![Klicken Sie auf das Symbol Videokonferenz, um die URL für die Videokonferenz zu erstellen -screenshot][img5]

    > [!NOTE]
    > Wenn Sie zum ersten Mal das Videosymbol ![Symbol][img1] auswählen, müssen Sie sich einloggen, um sich als Benutzer in dem von Ihrem Administrator definierten Videokonferenzservice zu authentifizieren.
    >
    > Wenn das Symbol nicht angezeigt wird, wurde die Videokonferenzfunktion noch nicht konfiguriert. Wenden Sie sich an Ihren SuperOffice-Administrator, der die Verbindung zwischen Funktion und Videoanbieter einrichten kann.

3. Richten Sie optional einen Alarm ein, um vor Beginn der Besprechung durch ein Popup-Fenster benachrichtigt zu werden.

4. [Teilnehmer einladen][2].

    Wenn Sie alle gewünschten Teilnehmer an der Besprechung hinzugefügt haben, klicken Sie auf **Speichern**.

    Wenn Sie E-Mail-Einladungen für die Teilnehmer der Folgeaufgabe aktiviert haben, wird beim Speichern des Termins eine E-Mail mit einem Link zur Teilnahme an der Videokonferenz gesendet. Im Kalender werden Folgeaufgaben mit Videokonferenzen mit dem ![Symbol][img3] angezeigt.

> [!TIP]
> Klicken Sie auf das ![Symbol][img4], um den Link für die Videokonferenz zu kopieren. Sie können dann den Link in die Agenda / die Beschreibung des Termins einfügen oder per Direktnachricht an andere senden. Verwenden Sie die Vorlagenvariable {burl}, um den Videokonferenzen-Link zu Einladungsvorlagen hinzuzufügen.

## An Videokonferenzen teilnehmen

Sie können auf verschiedene Weisen an einer Videokonferenz in SuperOffice teilnehmen:

* Klicken Sie im Dialogfeld **Folgeaufgabe** auf **An Konferenz teilnehmen** (Besprechung).
* Klicken Sie in der Seitenleiste auf **An Konferenz teilnehmen**..
* Klicken Sie auf eine Browserbenachrichtigung (nur verfügbar, wenn die Option **Alarm** aktiviert wurde).
* Klicken Sie mit der rechten Maustaste auf eine Videokonferenz im Kalender und wählen Sie **An Konferenz teilnehmen**.

Sehen Sie sich dieses Video an oder führen Sie die folgenden Schritte aus (Videolänge - 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

### Schritte

#### Über den Benachrichtigungs-Popup

Wenn der Gastgeber des Meetings Benachrichtigungen für die Besprechung eingerichtet hat, warnt SuperOffice CRM Sie durch einen Benachrichtigungs-Popup, bevor Ihre Besprechung beginnt. Sie können auf die Schaltfläche **An Konferenz teilnehmen** klicken, um die Videokonferenz automatisch zu starten.

#### Während dem Besprechung

Sie können der Videokonferenz auch beitreten, indem Sie den Besprechung in Ihrem Kalender aufrufen und auf die Schaltfläche **An Konferenz teilnehmen** unten im Besprechung klicken. Wenn Sie auf den Link klicken, wird die Videokonferenz automatisch gestartet.

> [!TIP]
> Wenn Sie keine Videokonferenz-URL verwenden, aber eine andere Video-URL haben, müssen Sie einfach den Standort in das Feld Standort einfügen, damit alle Anwender von Mobile CRM einfach nur auf **Ort** klicken müssen, um sich unterwegs mit der Videokonferenz zu verbinden.

#### Auf der Seitenleiste Vorschau

Klicken Sie auf den Besprechung in Ihrem SuperOffice-Kalender, um dessen Details in der Seitenleiste anzuzeigen. (Geben Sie die Vorschau frei, indem Sie sie aus dem Dropdown-Menü oben in der Seitenleiste auswählen).

Um über die Anzeige Vorschau an der Videokonferenz teilzunehmen, müssen Sie nur auf die Schaltfläche **An Konferenz teilnehmen** klicken. Nachdem Sie sie angeklickt haben, wird die Videokonferenz automatisch gestartet.

<!-- Referenced links -->
[1]: ../../../en/video-meeting/howto/connect-provider.md
[2]: invitation/add-participant.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png

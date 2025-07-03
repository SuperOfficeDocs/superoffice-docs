---
uid: help-de-request-escalation
title: Eskalationsstufen
description: Eskalationsstufen
keywords: Eskalationsstufe, Eskalationsstufe hinzufügen, neue Stufe, eskalieren, Eskalationsstufen-Registerkarte, Anfragepriorität, Anfrage, Priorität
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/priority/escalation-levels
index: true
---

# Eskalationsstufen

Für jede **Priorität** einer Anfrage können eine oder mehrere Eskalationsstufen definiert werden. Das System leitet eine Anfrage automatisch weiter, wenn sie innerhalb eines bestimmten Zeitraums nicht gelesen oder bearbeitet wurde.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Wie man neue Eskalationsstufen definiert

1. Klicken Sie im Navigator auf **Anfragen** und wählen Sie die Registerkarte **Prioritäten**.

1. Wählen Sie die Priorität aus, für die Sie Eskalationsstufen erstellen möchten.

1. Wählen Sie die Registerkarte **Eskalationsstufen**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**, um die erste Eskalationsstufe zu erstellen.

1. Geben Sie folgende Informationen ein:

    * **Erreicht nach**
    * **Neu zuordnen an**
    * **Skript ausführen**

    Details zu den einzelnen Feldern finden Sie unten.

1. Unter **Antwortvorlage senden** können Sie festlegen, wer eine E-Mail oder SMS erhalten soll, wenn diese Eskalationsstufe ausgelöst wird.

    Aktivieren Sie die Kontrollkästchen für **E-Mail** oder **SMS** neben jedem Empfänger und wählen Sie die gewünschte Antwortvorlage aus. Falls Sie **Andere** auswählen, müssen Sie die entsprechenden E-Mail-Adressen (durch Komma getrennt) und Telefonnummern in die Felder unten eingeben.

    > [!NOTE]
    > Wenn die Registerkarte **Antwortvorlage per SMS senden an** nicht angezeigt wird, bedeutet dies, dass SMS für die verwendete Lizenz nicht aktiviert wurde. Wenden Sie sich an Ihren Systemadministrator, um weitere Informationen zu erhalten.

1. Klicken Sie auf **Speichern**.

1. Wiederholen Sie diese Schritte, um zusätzliche Eskalationsstufen zu erstellen.

1. Wenn Sie mehrere Eskalationsstufen erstellt haben, können Sie die Reihenfolge mithilfe der Pfeiltasten unterhalb der Liste festlegen.

## Eskalationseinstellungen

| Einstellung | Beschreibung |
|---|---|
| Priorität | Die Priorität, die Sie mit der Eskalationsstufe verknüpfen möchten. |
| Erreicht nach | Wie viel Zeit muss vergehen, bis diese Eskalationsstufe aktiviert wird. Wenn die Eskalation definiert wurde, um ihre Eskalation dem Zeitrahmen entspricht, hat dies Auswirkungen auf die hier eingegebene Zeitspanne. Eine Priorität mit einem Zeitrahmen von Montag bis Freitag 9.00 bis 17.00 Uhr, bei der die erste Eskalationsstufe nach 2 Stunden erreicht ist, wird am Montag um 10.00 Uhr eskaliert, wenn die Anfrage am vorangegangenen Freitag um 16.00 Uhr erfasst wurde. |
| Neu zuordnen an | Aktivieren Sie diese Option, wenn die Anfrage an einen anderen Benutzer weitergeleitet werden soll, sobald diese Eskalationsstufe erreicht ist. Dann wählen Sie den gewünschten Benutzer in der Liste aus. |
| Skript ausführen | Aktivieren Sie diese Option, wenn beim Erreichen dieser Eskalationsstufe ein Skript ausgeführt werden soll. Wählen Sie dann das gewünschte Skript in der Liste aus. |

## Einstellungen der Antwortvorlage

| Einstellung | Beschreibung |
|---|---|
| Person | Wenn diese Option aktiviert ist, wird die im Feld auf der rechten Seite angegebene Antwortvorlage an die Kontaktperson für die Anfrage gesendet, sobald diese Eskalationsstufe erreicht wird. Wählen Sie die gewünschte Antwortvorlage in der Liste. |
| Anfrageeigentümer | Wenn diese Option aktiviert ist, wird die im Feld auf der rechten Seite angegebene Antwortvorlage an den Eigentümer der Anfrage gesendet, sobald diese Eskalationsstufe erreicht wird. Wählen Sie die gewünschte Antwortvorlage in der Liste. |
| Kategorienadministrator | Wenn diese Option aktiviert ist, wird die im Feld auf der rechten Seite angegebene Antwortvorlage an den Kategorienadministrator gesendet, sobald diese Eskalationsstufe erreicht wird. Wählen Sie die gewünschte Antwortvorlage in der Liste. |
| Andere | Wenn diese Option aktiviert ist, wird die im Feld auf der rechten Seite angegebene Antwortvorlage an die im Feld unten angegebene(n) E-Mail-Adresse(n) gesendet. Wählen Sie die gewünschte Antwortvorlage in der Liste. |
| E-Mail-Adresse | Geben Sie hier die E-Mail-Adresse ein, an die die Antwortvorlage im Feld **Andere** gesendet werden soll. Sie können mehrere Adressen durch Komma getrennt eingeben. |

## Eskalationsstufe löschen

1. Wählen Sie die Eskalationsstufe aus, die Sie löschen möchten.
2. Klicken Sie unten in der Ansicht auf die Schaltfläche **Löschen**.

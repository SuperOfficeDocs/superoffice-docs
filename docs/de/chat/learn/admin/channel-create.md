---
uid: help-de-chat-channel-create
title: Chat-Kanal erstellen
description: Chat-Kanal erstellen
author: Bergfrid Dias
date: 03.24.2023
keywords: Chat
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Chat-Kanal erstellen

Sie können Chat-Kanäle für bestimmte Verwendungszwecke erstellen, z. B. für technischen Support, Produktanfragen und Vertriebsunterstützung, und jedem Kanal die entsprechenden Agenten zuweisen.

Sehen Sie sich dieses Video an, um zu lernen, wie Sie Ihr Chat-Widget einrichten und konfigurieren (Videolänge - 4:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/94uhmeP1Xig]

## Schritte

1. Klicken Sie im Navigator auf <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** .

2. Klicken Sie in der Liste der Chat-Kanäle unten auf **Hinzufügen**.

3. Geben Sie im Dialogfeld den Namen des Chat-Kanals ein. Dabei sollte es sich um einen eindeutigen Namen handeln, der Thema und Sprache erkennen lässt (z. B. *Tech Support Deutschland*). Der Name wird nur intern verwendet.

4. Füllen Sie die Felder in den Registerkarten wie unten erläutert aus.

    Die Änderungen werden automatisch gespeichert, wenn Sie zu einer anderen Registerkarte wechseln.

5. Klicken Sie, sobald Sie fertig sind, auf **Speichern**.

> [!NOTE]
> Felder mit rotem Rahmen sind Pflichtfelder. Registerkarten mit dem Symbol <i class="ph ph-warning-circle" aria-label="Warning icon"></i> enthalten leere Pflichtfelder.

## Eigenschaften

| Eigenschaft | Beschreibung |
|---|---|
| Sprache | Wählen Sie die Sprache für das Chat-Fenster aus. |
| Symbolbeschriftung | Geben Sie einen kurzen Text ein, der auf dem Chat-Symbol auf Ihrer Website angezeigt wird. |
| Beschreibung | Erklären Sie den Zweck dieses Chat-Kanals. Dieser Text wird nur intern angezeigt. |
| Warnung bei neuem Chat | Wenn in der festgelegten Zeitspanne kein Mitarbeiter auf einen neuen Chat antwortet, wird eine Benachrichtigung an Mitarbeiter mit dem Status **Anwesend** gesendet. Mitarbeiter müssen auch die Berechtigung für **Benachrichtigungen** in der Registerkarte **Mitarbeiter** aufweisen. |
| Managerwarnung zu neuem Chat | Wenn in der festgelegten Zeitspanne kein Mitarbeiter auf einen neuen Chat antwortet, wird eine Benachrichtigung an den bzw. die Manager gesendet. Diese Warnung wird nur gesendet, wenn Mitarbeiter mit dem Status **Anwesend** vorhanden sind. |
| Geschäftszeiten aktivieren | Aktivieren Sie diese Option, um die Geschäftszeiten für bestimmte Wochentage einzustellen. Sie können auch Ihre Zeitzone einstellen und Mittagspausen hinzufügen, in denen der Chat nicht verfügbar ist. Die Kunden sehen im Chat immer ihre Ortszeit. |

In der Vorschau auf der rechten Seite ist das Chat-Fenster mit den aktuellen Einstellungen zu sehen.

## Layout des Chat-Widgets

In der Registerkarte **Layout des Chat-Widgets** können Sie Layout und Text für das von den Kunden verwendete Chat-Fenster festlegen.

| Feld | Beschreibung |
|---|---|
| Design | Wählen Sie das Design für das Chat-Fenster aus. |
| Farbe | Wählen Sie die Grundfarbe der Chat-Fenster aus. Diese Einstellung überschreibt die im ausgewählten Design definierte Farbe. |
| Schrift | Wählen Sie die Schrift für die Chat-Fenster aus. Diese Einstellung hat Vorrang vor der im ausgewählten Design festgelegten Schrift. |
| Logo anzeigen | Wählen Sie diese Option, wenn in der Kopfzeile des Chat-Fensters ein Bild angezeigt werden soll. Zum Hinzufügen eines Bildes können Sie auf die Verknüpfung klicken oder eine Bilddatei ziehen und ablegen. |
| Foto des Mitarbeiters anzeigen | Wählen Sie diese Option, wenn ein Foto des Mitarbeiters im Chat-Fenster angezeigt werden soll. Nachdem ein Mitarbeiter auf einen neuen Chat geantwortet hat, werden das Kopfzeilen-Logo und der Kopfzeilen-Text durch das Foto und den Namen des Mitarbeiters ersetzt. |
| Kopfzeile | Geben Sie einen kurzen Begrüßungstext ein, der in der Kopfzeile des Chat-Fensters angezeigt wird. |
| Nachricht | Geben Sie eine kurze Nachricht ein, die unter der Kopfzeile angezeigt wird. |
| Benutzerdefinierte Warteschlangenmeldung verwenden | Geben Sie mit dieser Option eine benutzerdefinierte Nachricht für die Warteschlange ein. |

Sie können Variablen verwenden, um die Wartezeit und die Position in der Warteschlange anzugeben:

* {cque} = Eine Zahl, die die Position in der Warteschlange angibt
* {cavw} = Die durchschnittliche Wartezeit im Format hh:mm

In der Vorschau auf der rechten Seite ist das Chat-Fenster mit den aktuellen Einstellungen zu sehen.

## Mitarbeiter

In der Registerkarte **Mitarbeiter** können Sie Benutzern Zugriff auf einen Chat-Kanal geben und die Berechtigungen für den Chat festlegen.

### Mitarbeiter hinzufügen

1. Klicken Sie auf die Liste links neben der Schaltfläche **Hinzufügen** und wählen Sie einen Benutzer aus.
2. Klicken Sie auf **Hinzufügen**. Der Benutzer wird zur Liste der Mitarbeiter hinzugefügt und kann auf den ausgewählten Chat-Kanal zugreifen.
3. Wählen Sie eine oder mehrere der folgenden Berechtigungen aus:
    * **Kann antworten**: Der Mitarbeiter kann auf eingehende Chats in diesem Kanal antworten.
    * **Benachrichtigungen**: Der Mitarbeiter erhält Benachrichtigungen, wenn er anwesend ist.
    * **Kann mitlesen**: Der Mitarbeiter kann das laufende Chat-Gespräch eines anderen Mitarbeiters öffnen und kontrollieren.
    * **Manager**: Der Mitarbeiter erhält Managerwarnungen. Diese Berechtigung kann zum Beispiel für Teamleiter vergeben werden.
4. Gehen Sie für jeden Mitarbeiter, den Sie hinzufügen möchten, wie in Schritt 1-3 erläutert vor.

## <a id="chatbot"></a>ChatBot

Auf der Registerkarte **ChatBot** können Sie den Chatbot aktivieren. Wenn ein Chat auf einem Kanal mit aktivem Chat initiiert wird, wird das Skript "on-new-chat-message" ausgelöst und die Nachricht wird zur Verarbeitung an das Skript übergeben. Das Skript sendet die Nachricht zur Verarbeitung, empfängt die Nachricht, postet die Ergebnisse und markiert die Nachricht eventuell zur Übergabe an einen Mitarbeiter.

| Option | Beschreibung |
|---|---|
| Chatbot aktivieren | Mit dieser Option aktivieren Sie den Chatbot. |
| Chatbot CRMScript-Ordner | Wählen Sie den Ordner aus, der die Skripte für den Chatbot enthält. |
| Chatbot-Name | Wie möchten Sie den Chatbot benennen? |

## Offline-Formular

In der Registerkarte **Offline-Formular** können Sie eine Nachricht eingeben, die dem Kunden angezeigt wird, wenn keine Mitarbeiter anwesend sind (beispielsweise außerhalb der Geschäftszeiten). Zudem können Sie den Kunden eine Anfrage einreichen lassen.

| Feld | Beschreibung |
|---|---|
| Kopfzeile | Geben Sie einen kurzen Text ein, mit dem Sie den Kunden informieren, warum keine Mitarbeiter verfügbar sind. |
| Nachricht | Geben Sie eine Nachricht ein. Beispiele: "Unsere Geschäftszeiten sind von 8-18 Uhr" oder "Füllen Sie die Felder unten aus, wir melden uns baldmöglichst bei Ihnen". |
| Einreichen von Anfragen aktivieren | Wählen Sie diese Option, damit der Kunde eine Anfrage einreichen kann, wenn der Chat nicht verfügbar ist. |
| Anfragekategorie | Wählen Sie die Kategorie aus, die den Anfragen zugewiesen werden soll. |
| Priorität der Anfrage | Wählen Sie die Priorität aus, die den Anfragen zugewiesen werden soll. |
| Obligatorische Felder zum Einreichen der Anfrage erforderlich | Wählen Sie die Informationen aus, die der Kunde zum Einreichen einer Anfrage eingeben muss. |

In der Vorschau auf der rechten Seite ist das Chat-Fenster mit den aktuellen Einstellungen zu sehen.

## Formular vor Chat

In der Registerkarte **Formular vor Chat** können Sie festlegen, ob und wie Kunden sich im Chat identifizieren müssen. Darüber hinaus können Sie automatisierte FAQ-Vorschläge von SuperOffice aktivieren.

| Feld | Beschreibung |
|---|---|
| FAQ-Vorschläge vor Chat aktivieren | Wenn Sie FAQ-Vorschläge aktivieren, werden die Top 3 FAQs, die mit der Kundennachricht übereinstimmen, im Chatfenster vor dem Chat angezeigt. Der Kunde kann auf die FAQ-Links klicken, um die vollständigen FAQs im SuperOffice-Kundencenter anzuzeigen. Wenn die vorgeschlagenen FAQs die Fragen nicht beantworten, kann der Kunde den Chat starten. |
| FAQ-Ordner | Wählen Sie den Ordner aus, der die FAQs (und Unterordner mit FAQs) enthält, die den Kunden angezeigt werden sollen. Nur FAQs, die veröffentlicht wurden und für jedermann zugänglich sind (kein Login erforderlich), werden den Kunden angezeigt. |
| Formular vor Chat für anonyme Benutzer aktivieren | Wählen Sie diese Option, wenn sich die Kunden vor dem Starten des Chats identifizieren müssen. Wenn Sie diese Option nicht aktivieren, können die Kunden den Chat direkt starten. |
| Nachricht | Geben Sie eine Nachricht für den Kunden ein. Beispiel: "Teilen Sie uns Ihren Namen mit und wie wir Ihnen weiterhelfen können". |
| Erforderliche Felder zum Starten des Chats | Wählen Sie die Informationen aus, die der Kunde zum Starten des Chats eingeben muss. |

In der Vorschau auf der rechten Seite ist das Chat-Fenster mit den aktuellen Einstellungen zu sehen.

## Formular nach Chat

Wenn der Kunde oder Mitarbeiter den Chat beendet, können Sie nach dem Chat ein Formular mit weiteren Informationen und der Option zum Empfangen eines Chat-Transkripts anzeigen lassen.

| Feld | Beschreibung |
|---|---|
| Formular nach Chat aktivieren | Wählen Sie diese Option, damit dem Kunden nach Beendigung des Chats das entsprechende Formular angezeigt wird. |
| Kopfzeile | Geben Sie einen kurzen Kopfzeilentext ein. |
| Nachricht | Geben Sie eine kurze Nachricht für den Kunden ein. |
| Transkript aktivieren | Wählen Sie diese Option, um das Transkript zu aktivieren. Der Kunde kann eine E-Mail-Adresse eingeben, an die das Transkript gesendet werden soll. Die Antwortvorlage für das Transkript finden Sie in SuperOffice. |

In der Vorschau auf der rechten Seite ist das Chat-Fenster mit den aktuellen Einstellungen zu sehen.

## FAQ

### Kann ich einen Chat-Kanal löschen?

Ja, aber achten Sie darauf, dass der Chat-Kanal nicht auf einer Website verwendet wird. Ansonsten ist das Chatfenster zwar sichtbar, aber nicht funktionsfähig.

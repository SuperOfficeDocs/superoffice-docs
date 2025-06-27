---
uid: help-de-flow-content
title: Inhalt des Flows
description: Inhalt des Flows
keywords: Marketing, Flow, Flow-Inhalt, Inhalt des Flows, Inhalt, E-Mail, Verfassen
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
content_type: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Inhalt des Flows

Flow-Inhalt sind E-Mails (und Formulare), die in einem Flow verwendet werden.

Es spielt keine Rolle, ob Sie den Inhalt zuerst vorbereiten oder nachdem Sie den Flow entworfen haben. Auch, ob separate Benutzer mit der Inhalts- und Flow-Konfiguration arbeiten - oder ob derselbe Benutzer alles vorbereitet - liegt bei Ihnen.

## Schritte

Um den vorbereiteten Inhalt für einen bestimmten Flow anzuzeigen:

1. Gehen Sie zu **Marketing** > **Flows**.
1. Doppelklicken Sie, um einen Flow auszuwählen.
1. Wählen Sie die Registerkarte **Inhalt des Flows**.

![Inhalte des Willkommens-E-Mail-Flows -screenshot][img1]

## Neuen Inhalt erstellen

### E-Mail erstellen - als Flow-Editor

1. Auf der Registerkarte **Inhalt des Flows**, in der unteren linken Ecke, geben Sie eine Name für die neue E-Mail ein und klicken Sie auf **Erstellen**. Dies öffnet den E-Mail-Assistenten im Schritt **Vorlage**.

    ![Inhalt des Flows - Neue E-Mail erstellen -screenshot][img3]

1. Wählen Sie eine Vorlage aus und klicken Sie auf **Weiter**.

    ![Inhalt des Flows - Vorlage auswählen -screenshot][img4]

1. Verfassen Sie die E-Mail (wie bei einer klassischen E-Mail).

    ![Inhalt des Flows - Verfassen -screenshot][img5]

    * [Inhalt hinzufügen][3], [Absatz bearbeiten][4]
    * [Kundenbezogene Informationen einfügen][5]
    * [Tracking-Link einfügen][6]
    * [Abonnementlinks][8] hinzufügen, um DSGVO-konform zu sein
    * [Bilder zur Nachricht hinzufügen][2]

    > [!NOTE]
    > Wenn Sie auf Linkklicks reagieren möchten (z.B. als Auslöser, Aufteilung oder Wartebedingung), muss der Link überwachten werden.

1. Schließen Sie den E-Mail-Schritt und klicken Sie auf **Speichern**.

### E-Mail erstellen - als Flow-Administrator

1. Öffnen Sie den Flow-Editor und gehen Sie zum E-Mail-Schritt.

    ![Flow-Schritt - Neue E-Mail erstellen -screenshot][img6]

1. Wählen Sie eine Vorlage aus und verfassen Sie die E-Mail wie oben beschrieben (beginnend mit Schritt 2).

> [!NOTE]
> Sie können nicht auf **Bearbeiten** klicken, wenn der Flow ausgeführt wird. Wenn Sie den Flow nicht pausieren möchten, während Sie mehr Inhalt vorbereiten, können Sie ein neues Stück Inhalt in der Registerkarte **Inhalt des Flows** erstellen und vorbereiten.

### Formular erstellen

Gehen Sie zu **Marketing** > **Formulare**. Weitere Informationen finden Sie unter [Formular erstellen][1].

## Flow-Inhalt zum E-Mail-Schritt hinzufügen

1. Öffnen Sie den Flow-Editor.
1. Klicken Sie, um den E-Mail-Schritt auszuwählen, zu dem Sie Inhalt hinzufügen möchten.
1. Wählen Sie **Existierende E-Mail für diesen Schritt auswählen**. Klicken Sie, um eine vorbereitete E-Mail auszuwählen.
1. Wählen Sie bei Bedarf **Aufgabe** > **Bearbeiten** in der E-Mail-Vorschau, um den Inhalt zu aktualisieren.
1. Schließen Sie den E-Mail-Schritt und klicken Sie auf **Speichern**.

![E-Mail-Schritt mit Inhalt, Betreff und Anhang senden -screenshot][img2]

## Vorbereiteten Inhalt bearbeiten

> [!NOTE]
> Sie können Flow-Inhalte, die in einem Schritt enthalten sind, nicht bearbeiten, ohne den Flow pausieren.

**Als Flow-Editor:**

1. Auf der Registerkarte **Inhalt des Flows** klicken Sie auf das Menüsymbol auf der E-Mail, die Sie aktualisieren möchten, und wählen Sie **Bearbeiten**.

**Als Flow-Administrator:**

1. Öffnen Sie den Flow-Editor und gehen Sie zum E-Mail-Schritt.
1. In der E-Mail-Vorschau:
    * Wählen Sie **Aufgabe** > **Bearbeiten**, um den Inhalt zu ändern.
    * Wählen Sie **Aufgabe** > **Umbenennen**, um den Namen der E-Mail zu ändern.
    * Klicken Sie auf das rote X, um die E-Mail zu löschen (damit Sie sie durch eine andere ersetzen können).

<!-- Referenced links -->
[1]: ../../forms/learn/create.md
[2]: ../../editor/learn/insert-images-in-message.md
[3]: ../../editor/learn/add-content.md
[4]: ../../editor/learn/edit-paragraph.md
[5]: ../../editor/learn/add-merge-tag.md
[6]: ../../editor/learn/add-tracked-link-to-msg.md
[8]: ../../editor/learn/add-unsubscribe-link.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-flow-contents.png
[img2]: ../../../../media/loc/en/marketing/send-email-welcome-with-attachment.png
[img3]: ../../../../media/loc/en/marketing/create-new-email-in-flow.png
[img4]: ../../../../media/loc/en/marketing/choose-flow-email-template.png
[img5]: ../../../../media/loc/en/marketing/flow-email-content-compose.png
[img6]: ../../../../media/loc/en/marketing/flow-send-email-new.png

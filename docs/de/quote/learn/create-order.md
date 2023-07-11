---
uid: help-de-quote-create-order
title: Angebot für Auftrag erstellen
description: "In dieser Anleitung lernen Sie, wie Sie einen Auftrag erteilen."
author: SuperOffice RnD
so.date: 02.16.2023
keywords: Angebot
so.topic: howto
language: de
---

# Auftrag erteilen

Nachdem der Kunde das Angebot akzeptiert hat, können Sie einen Auftrag erteilen, damit dieser an die Verarbeitungsstelle oder das Lager weitergeleitet wird.

> [!TIP]
> Um einen Auftrag für eine archivierte Version des Angebots zu erteilen, müssen Sie diese Version im Feld **Version** auswählen und auf **Aktiv machen** klicken. Das archivierte Angebot wird dann kopiert und in die aktuelle Version umgewandelt. Vorherige Versionen des Angebots werden archiviert.

1. Klicken Sie auf **Auftrag erteilen** im Dialogfeld **Angebot bearbeiten**. Das Dialogfeld **Auftrag erstellen gemäß Angebotsversion** wird geöffnet. Der Titel des Dialogs zeigt die Angebotsversion an, auf der das Angebot basiert.

    > [!NOTE]
    > Sie können den Auftrag nicht erteilen, wenn die Warnung [Angebot wurde nicht genehmigt][1] oder das [Angebot enthält Fehler oder Warnungen][2] angezeigt wird.

1. Wenn das Angebot mehrere Alternativen enthält, wählen Sie diejenige aus, die Sie im Feld **Zu verwendende Alternative auswählen** platzieren möchten.
1. Um den Auftrag per E-Mail zu senden, müssen Sie das Kontrollkästchen **Auftragsbestätigung per E-Mail senden** aktivieren und die E-Mail-Vorlage und Sprache in den unten stehenden Listen auswählen.
1. Geben Sie die **PO-Nummer** (Auftragsnummer) des Kunden ein, falls vorhanden, und einen **Kommentar zum Auftrag**, falls gewünscht.
1. Aktivieren Sie das Kontrollkästchen **Verkauf als 'Verkauft' kennzeichnen (100 %)**, um den Status des Verkaufs zu ändern.
1. Klicken Sie auf **OK**.

    Falls Sie sich dazu entschieden haben, den Auftrag via E-Mail zu senden, wird das Dialogfeld **Neue E-Mail** geöffnet. Hier können Sie den Text bearbeiten und die Bestätigung an den Kunden senden.

Wenn SuperOffice CRM mit einem ERP-System verbunden ist (entweder über die integrierte Lösung in SuperOffice oder einen 3rd-Party-Konnektor), wird der Auftrag dort erfasst und automatisch verarbeitet. Wenn SuperOffice CRM nicht mit einem ERP-System verbunden ist, müssen Sie den Auftrag manuell im externen System erfassen.

<!-- Referenced links -->
[1]: approve.md
[2]: add-product.md#warning

<!-- Referenced images -->

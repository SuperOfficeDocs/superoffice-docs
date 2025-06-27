---
uid: help-de-quote-place-order
title: Auftrag erteilen
description: In dieser Anleitung erfahren Sie, wie Sie einen Auftrag auf Grundlage eines Angebots in SuperOffice CRM erstellen.
keywords: Auftrag erteilen, Bestellung, Angebot, Angebotsversion, SuperOffice Auftrag
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Auftrag erteilen

Nachdem der Kunde das Angebot akzeptiert hat, können Sie den Auftrag erstellen, damit dieser zur weiteren Bearbeitung an die Auftragsabwicklung oder ein Lager übermittelt wird.

> [!NOTE]
> Sie können den Auftrag nicht erteilen, wenn das Angebot [Fehler oder Warnungen enthält][2].

## Schritte

1. Klicken Sie im Dialogfeld **Angebot bearbeiten** auf **Auftrag erteilen**. Das Dialogfeld **Auftrag erstellen gemäß Angebotsversion** wird geöffnet. Der Titel zeigt die Angebotsversion, auf der der Auftrag basiert.

    Um einen Auftrag für eine archivierte Angebotsversion zu erstellen, wählen Sie diese Version im Feld **Version** und klicken Sie auf **Aktiv machen**. Das archivierte Angebot wird kopiert und zur aktuellen Version. Frühere Versionen werden archiviert.

1. Wenn das Angebot mehrere Alternativen enthält, wählen Sie im Feld **Alternative auswählen** die gewünschte Option.
1. Aktivieren Sie **Auftragsbestätigung per E-Mail senden**, um die Bestätigung per E-Mail zu verschicken. Wählen Sie dazu eine E-Mail-Vorlage und die Sprache aus.
1. Geben Sie die **PO-Nummer** (Auftragsnummer) des Kunden ein, falls vorhanden, sowie optional einen **Kommentar zum Auftrag**.
1. Aktivieren Sie **Verkauf als verkauft markieren (100 %)**, um den Status des Verkaufs zu aktualisieren.
1. Klicken Sie auf **OK**.

    Wenn Sie die Option gewählt haben, den Auftrag per E-Mail zu senden, öffnet sich das Dialogfeld **Neue E-Mail**, in dem Sie den Text bearbeiten und die Bestätigung an den Kunden senden können.

Wenn SuperOffice CRM mit einem ERP-System verbunden ist (über die integrierte Lösung oder einen 3rd-Party-Konnektor), wird der Auftrag dort automatisch registriert und weiterverarbeitet. Ohne ERP-Verbindung müssen Sie den Auftrag manuell im externen System erfassen.

<!-- Referenced links -->
[2]: create.md#warning

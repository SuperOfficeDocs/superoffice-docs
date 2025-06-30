---
uid: help-de-extra-field-display
title: Zusatzfeld im Tab Details anzeigen
description: Zusatzfeld im Tab Details anzeigen
keywords: extra field, custom field, request, layout, screen designer
author: Bergfrid Dias
date: 01.30.2024
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Zusatzfeld im Tab Details anzeigen

Szenario: Sie haben ein Zusatzfeld für Unternehmen (`contact` Tabelle) hinzugefügt, das angibt, ob ein Unternehmen einen Supportvertrag hat, und Sie möchten diese Informationen anzeigen, wenn Sie eine Anfrage anzeigen.

<!-- markdownlint-disable-file MD051 -->
## Schritte

### [In der neuen Anfragenansicht mit dem Ansichtsdesigner](#tab/screen-designer)

1. Gehen Sie zu **Einstellungen und Verwaltung** > **Ansichtsdesigner** und wählen Sie den Tab **Anfragen**.
1. Klicken Sie unten auf **Layout bearbeiten**.
1. Suchen Sie die Einstellung für **Felder**.
1. Wählen Sie Ihr Feld aus.
1. Wählen Sie optional die passenden Styling-Optionen aus.
1. Klicken Sie auf **Speichern**, um die Einstellungen zu speichern.

> [!TIP]
> Sie können auch Felder gruppieren, Überschriften für Gruppen hinzufügen und die Größe von Spalten ändern. [Erfahren Sie mehr über den Ansichtsdesigner][1].

### [Im klassischen Service](#tab/service)

Im Service müssen Sie ein gemeinsames Elementprofil erstellen.

1. Gehen Sie zu **Einstellungen und Verwaltung** > **Systemdesign** und wählen Sie den Tab **Profil**.

1. Wählen Sie **Systembildschirme**. Klicken Sie dann auf **Ticket anzeigen**, zeigen Sie mit dem Cursor auf **ticketinfo** und klicken Sie auf **Neues gemeinsames Profil**.

1. Geben Sie einen **Namen** für das neue Profil ein.

1. Klicken Sie auf die Schaltfläche **Kriterium hinzufügen** und führen Sie folgende Schritte aus:

    1. Geben Sie eine UI-Bezeichnung für das zusätzliche Feld ein.
    1. Wählen Sie das Feld in der Datenbank aus, von dem Sie Daten erhalten möchten.
    1. Klicken Sie auf **OK**. Das neue Kriterium wird unter den anderen hinzugefügt.
    1. Fügen Sie optional weitere Kriterien hinzu.

1. Klicken Sie auf **OK**. Das neue Profil ist erstellt.

1. Klicken Sie erneut auf das Hamburger-Menü und wählen Sie **Rollen**.

1. Wählen Sie eine Rolle aus (wer das Feld auf dem Ansicht **Anfrage** sehen darf).

1. Wählen Sie im Dialogfeld den Tab **Profil**.

1. Aus der Liste **Neues Elementprofil** wählen Sie das gerade erstellte Profil aus.

1. Klicken Sie auf **OK**, um die Einstellungen zu speichern.

Alle Benutzer mit dieser Rolle können jetzt das zusätzliche Feld auf dem Tab **Details** in allen ihren Anfragen sehen.

***

<!-- Referenced links -->
[1]: ../../../en/ui/screen-designer/configurable-screens/working-with-fields.md

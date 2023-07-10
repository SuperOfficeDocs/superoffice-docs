---
uid: help-de-erp-connection-add
title: ERP-Verbindung hinzufügen
description: ERP-Verbindung hinzufügen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Angebot, ERP, Connector
so.topic: howto
language: de
---

# ERP-Verbindung hinzufügen (Quote Connector)

Jeder Quote Connector muss über eine ERP-Verbindung mit Konfigurationsdaten verfügen, damit der Quote Connector mit SuperOffice verknüpft werden kann.

Wie man eine ERP-Verbindung für SuperOffice CRM for Web (Online) einrichtet?

[!include[How to set up ERP](includes/set-up-erp.md)]

## ERP-Verbindung hinzufügen

1. Gehen Sie in der Ansicht Angebot/Sync zur Registerkarte **ERP-Verbindungen**.

1. Klicken Sie unten in der **ERP-Verbindungen**-Liste auf **Hinzufügen**. Das Dialogfeld **Neue ERP-Verbindung definieren** erscheint.

1. Geben Sie den Namen der ERP-Verbindung in das Feld **Name** ein.

1. Wählen Sie den gewünschten **Quote Connector** in der Liste aus. Diese Liste stimmt mit **Verfügbare Quote Connectors** überein.

1. Wählen Sie einen **Umfang** aus:

    * **Alle**: Wählen Sie diese Option, wenn Sie wünschen, dass alle Benutzer Zugriff auf diese ERP-Verbindung haben und diese nutzen dürfen. Das bedeutet, dass sie die Preislisten verwenden können, die über diese Verbindung verfügbar sind.
    * **Spezifische Benutzer + Gruppen**: Klicken Sie auf **Benutzer und Gruppen auswählen**, um auszuwählen, welche Benutzergruppen und/oder Benutzer Zugriff auf diese ERP-Verbindung haben sollen.

1. Wählen Sie die ERP-Verbindung aus, um die Synchronisation ([Sync Connector][1]) im Feld **ERP-Verbindung** zu bearbeiten.

1. Konfigurieren Sie die erforderlichen Einstellungen unten im Dialogfeld. Der Inhalt dieser Liste ändert sich je nach ausgewähltem Quote Connector.

1. Geben Sie eine Beschreibung der ERP-Verbindung in das Feld unten in der Ansicht ein.

1. Klicken Sie auf **ERP-Verbindung testen**, um zu verifizieren, dass die Verbindung hergestellt werden kann.

1. Klicken Sie auf **OK**.

## Löschen und Wiederherstellen

Am Ende der Liste **ERP-Verbindungen** können Sie ERP-Verbindungen löschen, die nicht mehr verwendet werden.

Wie man eine gelöschte ERP-Verbindung wiederherstellt:

1. Setzen Sie ein Häkchen bei **Gelöscht**.
1. Wählen Sie die gelöschte Verbindung in der Liste aus.
1. Klicken Sie auf **Wiederherstellen**.

<!-- Referenced links -->
[1]:sync/index.md

<!-- Referenced images -->

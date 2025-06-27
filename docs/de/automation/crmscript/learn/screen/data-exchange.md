---
uid: help-de-data-exchange
title: Data Exchange
description: Data Exchange
author: SuperOffice RnD
date: 06.29.2022
keywords: Service, Data Exchange
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
language: de
envir: onsite
---

# Datenaustausch (nur ONSITE)

[!include[Requirement](../../../../learn/includes/req-expander-services.md)]

In diesem Bereich wird die Datenbankintegration zwischen dem System und anderen Datenquellen konfiguriert.

## Mitarbeiter

Diese Ansicht enthält eine Liste der vorhandenen Data Exchange (Datenbankintegrator) Agenten. SuperOffice Service kann mit einem oder mehreren Mitarbeitern verbunden werden, um eine Synchronisierung mit anderen Datenbanken durchzuführen.

| Element | Beschreibung |
|---|---|
| Neuer Mitarbeiter | Wird verwendet, um einen neuen Mitarbeiter zu erstellen. |
| Name | Gibt den Namen des Agenten an. |
| Protokoll | Das für die Verbindung mit dem Agenten verwendete Kommunikationsprotokoll. |

## Eigenschaften des Agenten

Diese Ansicht zeigt die Eigenschaften eines Data Exchange Agenten.

| Element | Beschreibung |
|---|---|
| Agent bearbeiten | Wird verwendet, um die Mitarbeitereigenschaften zu bearbeiten. |
| Neue Mitarbeiteraufgabe | Wird verwendet, um eine neue Mitarbeiteraufgabe zu erstellen. |
| Felder bearbeiten | Wird verwendet, um Felder anzugeben, die in SuperOffice Service schreibgeschützt sein sollen. |
| Agent | In diesem Bereich werden die Eigenschaften des Agenten angezeigt. |
| Name | Name des Data Exchange Agenten. |
| Protokoll | Wählen Sie das Protokoll aus, das für die Kommunikation mit dem Data Exchange Agenten verwendet werden soll. |
| Pfad/URL | Pfad oder Netzwerkadresse, der/die für die Kommunikation mit dem Data Exchange Agenten verwendet werden soll. |
| Parameter | Die von CRMScript oder dem Data Exchange Agenten verwendeten Parameter. |
| Aufgaben | Dieser Bereich enthält eine Übersicht über die Aufgaben des Agenten. Es wird auch der Status jeder Aufgabe angezeigt. Wenn Sie eine Aufgabe bearbeiten möchten, klicken Sie darauf. |
| Felder | Zeigt alle Felder in SuperOffice Service an, die nicht editierbar sind. Klicken Sie auf **Felder bearbeiten**, um ein neues Feld hinzuzufügen. |

## Agent bearbeiten

In diesem Bildschirm können Sie die Eigenschaften eines neuen oder vorhandenen Data Exchange Agenten bearbeiten. Sie können auch Zeitpläne erstellen, um den Mitarbeiter in bestimmten Intervallen zu aktivieren.

| Element | Beschreibung |
|---|---|
| Name | Name des Data Exchange Agenten. |
| Protokoll | Wählen Sie das Protokoll aus, das für die Kommunikation mit dem Data Exchange Agenten verwendet werden soll. |
| Pfad/URL | Pfad oder URL, der/die für die Kommunikation mit dem Data Exchange Agenten verwendet werden soll. |
| Parameter | Die von CRMScript oder dem Data Exchange Agenten verwendeten Parameter. |
| OK (Alt-O) | Klicken Sie auf diese Schaltfläche, um zu speichern. |
| Abbrechen | Klicken Sie auf diese Schaltfläche, um abzubrechen. |
| Löschen | Klicken Sie auf diese Schaltfläche, um zu löschen. |
| Übernehmen | Wählen Sie diese Option aus, um diese Einstellungen zu verwenden. |

## Eigenschaften des Mitarbeiterzeitplans

In diesem Bildschirm können Sie die Eigenschaften eines neuen oder vorhandenen Zeitplans eines Data Exchange Agenten bearbeiten. Hier können Sie auswählen, wie oft der Mitarbeiter mit SuperOffice synchronisiert werden soll.

| Element | Beschreibung |
|---|---|
| Name | Hier können Sie einen Namen für den Zeitplan eingeben. |
| ejScript/CRMScript | Hier können Sie das CRMScript auswählen, das den Zeitplan aktiviert. |
| Parameter | Die von CRMScript oder dem Data Exchange Agenten verwendeten Parameter. |
| OK (Alt-O) | Klicken Sie auf diese Schaltfläche, um zu speichern. |
| Abbrechen | Klicken Sie auf diese Schaltfläche, um abzubrechen. |
| Löschen | Klicken Sie auf diese Schaltfläche, um zu löschen. |
| Zurücksetzen | Wenn die Agentenaufgabe nicht angehalten wird, klicken Sie auf diese Schaltfläche, um sie zurückzusetzen. |
| Stopp | Klicken Sie auf diese Schaltfläche, um die Agentenaufgabe zu stoppen. |
| Übernehmen | Mit dieser Schaltfläche können Sie die Einstellungen übernehmen. |

## Eigenschaften des Agentenfeldes

In diesem Bildschirm können Sie die Eigenschaften eines Feldes bearbeiten, das mit einem Agenten verbunden ist. Die angezeigten Felder sind in SuperOffice Service schreibgeschützt.

| Element | Beschreibung |
|---|---|
| Feldnamen | Eine Liste von Datenbankfeldnamen, die in der Benutzeroberfläche schreibgeschützt sind, zum Beispiel 'cust-company.name'. |

<!-- Referenced links -->

<!-- Referenced images -->

---
uid: help-de-erp-admin
title: ERP-Synchronisierung verwalten
description: Einführung in die Konfiguration der Synchronisation zwischen SuperOffice CRM und externen ERP-Systemen.
keywords: ERP-Registerkarte, ERP-System, ERP-Akteur, Sync Connector, ERP-Verbindung, Synchronisation, Connector, Verbindung, Angebot/Sync-Bildschirm, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/quote/learn/admin/sync/index
index: true
---

# ERP-Synchronisierung verwalten

Die Registerkarte **Sync** im Bildschirm Angebot/Sync unter **Einstellungen und Verwaltung** listet Sync Connectors und ERP-Verbindungen auf, die die Integration zwischen SuperOffice CRM und externen ERP-Systemen ermöglichen.

[!include[Requirement](../../learn/includes/req-expander-services.md)]

## Begriffserklärungen

| Begriff | Beschreibung |
|---|---|
| **Sync Connector** | Die Integrationskomponente, die SuperOffice CRM mit einem externen ERP-System verbindet. Jeder Connector verweist auf ein bestimmtes ERP-System. |
| **ERP-Verbindung** | Eine Konfiguration, die einen Sync Connector verwendet, um festzulegen, was synchronisiert wird, wie die Authentifizierung erfolgt und welcher ERP-Client angesprochen wird. Pro Connector können mehrere Verbindungen bestehen. |
| **ERP-Akteur** | Ein Datensatz im ERP-System, der mit einem Element in SuperOffice CRM verknüpft werden kann. |
| **CRM-Element** | Ein Datensatz in SuperOffice CRM – typischerweise eine Firma, eine Person oder ein Projekt –, der mit einem ERP-Akteur verknüpft werden kann. |

Über die Registerkarte **Sync** können Sie Verbindungen hinzufügen, konfigurieren und priorisieren.

## Was mit der ERP-Synchronisierung möglich ist

Wenn die ERP-Integration korrekt eingerichtet ist, können Benutzer in SuperOffice CRM auf die Registerkarte **ERP** in den Ansichten **Firma**, **Person** und **Projekt** zugreifen.

In dieser Registerkarte können Benutzer:

* SuperOffice-Datensätze mit passenden Akteuren im ERP-System verknüpfen.
* Synchronisierte Felder und Werte aus dem ERP-System anzeigen.

Dies reduziert doppelte Dateneingaben und verbessert die Datenkonsistenz zwischen den Systemen.

> [!NOTE]
> Die Registerkarte **ERP** wird nur für Benutzer angezeigt, die über die erforderliche Lizenz und Zugriff auf eine aktive ERP-Verbindung verfügen.

## Verwandte Inhalte

* [Einen Sync Connector hinzufügen und eine ERP-Verbindung definieren][1]
* [Eine ERP-Verbindung bearbeiten][7]
* [Feldzuweisung und Standardwerte konfigurieren][4]
* [Synchronisierungspriorität festlegen][3]
* [Import aus dem ERP-System][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/learn/import-from-erp.md

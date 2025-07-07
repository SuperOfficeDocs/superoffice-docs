---
uid: help-de-automation-script-debug
title:  Debugsitzungen
description: Debugsitzungen
author: SuperOffice RnD
date: 06.29.2022
keywords: CRMScript
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Debugsitzungen

[!include[Requirement](../../../includes/req-dev-tools.md)]

Auf der Registerkarte **Debugsitzungen** wird eine Liste aller aktiven Debugsitzungen im System angezeigt. Klicken Sie in der Liste auf eine Sitzung, um sie im **Debugger** zu öffnen.

## Gehen Sie zur Registerkarte Sitzungen-Debugging

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicken Sie auf **CRMScript** und wählen Sie die Registerkarte **Sitzungen-Debugging** aus.

## Debugging-Sitzung starten

Sie können eine dieser Sitzungen starten, indem Sie ein Skript im Debugmodus über die Ansicht **Skript** ausführen oder indem Sie die Funktion "Void enableDebug(String key)" in einem CRMScript aufrufen.

Sie können auch auf **Ablaufverfolgungsskripte starten** klicken, um die [Ablaufverfolgung][2] der Skripte in der Liste zu starten.

## Debugger

Mit dem Debugger können Sie Fehler in Skripts und Makros problemlos ausfindig machen und beheben. Das Debuggen von Skripts und Makros kann in einer Produktionsumgebung erfolgen, ohne dass andere SuperOffice-Benutzer gestört werden. Die Prüfung von Skripts und Makros erfolgt in Echtzeit, also während sie ausgeführt werden. Sie können Skripts Schritt für Schritt ausführen lassen, Haltepunkte setzen und die Variablenwerte anzeigen lassen.

Zum Debuggen eines Skripts oder Makros öffnen Sie es auf der Registerkarte **Makros und Skripts** und klicken Sie dann auf <i class="ph ph-bug" aria-hidden="true"></i> **Skript debuggen**.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicken Sie auf **CRMScript** und wählen Sie die Registerkarte **Makros und Skripts** aus.

Sie können auch auf **Skript verfolgen** klicken, um die [Ablaufverfolgung eines Skripts][2] zu starten.

<!-- Referenced links -->
[2]: tracing.md

---
uid: help-de-screen-chooser
title: ScreenChoosers
description: ScreenChoosers
keywords: UI, ScreenChooser
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: concept
tier: core
language: de
---

# ScreenChoosers

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

Ein ScreenChooser ist ein Skript, das eine Umleitung vom Standardbildschirm zu einer anderen Ansicht bewirkt. In einem derartigen Skript wird die Standard-URL mithilfe der CRMScript-Funktion "setVariable("url", myUrl)" durch eine andere URL ersetzt. So kann beispielsweise von der Ansicht "Anfrage anzeigen" zu einem benutzerdefinierten Bildschirm umgeleitet werden und/oder vor der Anzeige der Ansicht noch Berechnungen im Skript ausgeführt werden. Die ScreenChooser werden als Ordner in einer hierarchischen Struktur angezeigt. Ihre Anordnung in der Struktur richtet sich nach der Position im System, an der sie ausgeführt werden.

## Eigenschaften des ScreenChooser

Hier können Sie ein Skript hinzufügen, das mithilfe der CRMScript-Funktion "setVariable("url", myUrl)" eine Umleitung zu einer anderen Ansicht bewirkt.

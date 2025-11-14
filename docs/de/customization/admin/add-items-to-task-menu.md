---
uid: help-de-task-menu-add
title: Objekte zur Liste Menü Aufgabe hinzufügen
description: Objekte zur Liste Menü Aufgabe hinzufügen
keywords: Aufgabenmenü
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
redirect_from: /de/admin/lists/learn/add-items-to-task-menu
language: de
---

# Objekte zur Liste Menü Aufgabe hinzufügen

## Schritte

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **Menü Aufgabe** aus dem Dropdown-Menü.

1. Klicken Sie unter der Liste Objekte auf die Schaltfläche **Hinzufügen**.

1. Geben Sie den Objektnamen in das Feld **Name** ein. *(Obligatorisch)*

1. Wählen Sie das Menü **Aufgabe** aus, das Sie mit dem Objekt verbinden möchten.

1. Wählen Sie den gewünschten Menütyp "Aufgabe" aus.

    * URL: Geben Sie die **URL-Adresse** in das URL-Feld ein und wählen Sie den gewünschten Typ der [URL-Verschlüsselung][4] aus.
    * [CRMScript][5]: Wählen Sie aus, welches **Skript** das Aufgabenmenü ausführen soll.
    * [SOProtocol][6]: Geben Sie die **SOProtocol** URL ein, zu der das Listenelement navigieren soll.

1. Wählen Sie die Kontrollkästchen für die Stelle an, an welcher im Menüpunkt "Aufgabe" angezeigt werden soll.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Objekt ein. Lesen Sie mehr über die [Übersetzung][7].

1. Klicken Sie auf **Speichern**, um die Änderungen zu speichern, oder auf **Abbrechen**, um sie zu verwerfen.

## Verwenden von Template-Variablen

Wenn Sie eine URL-Adresse hinzufügen, könnte es nützlich sein, Vorlagenvariablen für die aktive Firma zu verwenden, um zum Beispiel über eine URL Informationen von anderen Anwendungen abzurufen. Es müssen die URL-Adresse Parameter angegeben werden, wie in folgendem Beispiel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn ist die Vorlagenvariable für die Organisationsnummer, andere Variablen wie Firmenname &lt;name&gt;, Firmentelefonnummer &lt;cpho&gt; und Personenname &lt;attn&gt; können ebenfalls verwendet werden.

## Ist SuperOffice CRM for Web auf einer https-Seite installiert? (Vor Ort)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Verwandte Themen

* [Web-Bildschirm-Objekt hinzufügen][1]
* [Übersetzung hinzufügen][7]
* [Speziallisten][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[3]: ../../admin/lists/specialized-lists.md
[4]: ../web-panels/admin/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/ui/soprotocol/index.md
[7]: ../../../localization/learn/translate-fields.md

<!-- Referenced images -->

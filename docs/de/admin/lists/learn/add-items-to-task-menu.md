---
uid: help-de-task-menu-add
title: Objekte zur Liste Menü "Aufgabe" hinzufügen
description: Objekte zur Liste Menü "Aufgabe" hinzufügen
author: SuperOffice RnD
date: 01.11.2023
keywords: Einstellungen und Verwaltung
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Objekte zur Liste Menü "Aufgabe" hinzufügen

Wenn Sie ein Objekt zur Liste **Aufgabenmenü** in Einstellungen und Verwaltung hinzufügen, ist das Dialogfeld Listenobjekt bearbeiten nicht dasselbe, das unter [Objekte hinzufügen][2] beschrieben ist.

Füllen Sie wie folgt die Felder im Dialogfeld Listenobjekte bearbeiten für das Aufgabenmenü aus:

1. Klicken Sie unter der Liste Objekte auf die Schaltfläche Hinzufügen.
    > Möchten Sie ein Objekt zu einer spezialisierten Liste hinzufügen?
    Einige Listentypen sind spezialisierter als die in dieser Vorgehensweise beschriebenen Listen. [Speziallisten][3]

1. Geben Sie den Objektnamen in das Feld **Name** ein.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Wählen Sie das Menü "Aufgabe" aus, das Sie mit dem Objekt verbinden möchten.

1. Wählen Sie zwischen URL, CRMScript oder SOProtocol den gewünschten Menütyp "Aufgabe" aus.
    * URL
        * Geben Sie die **URL-Adresse** in das URL-Feld ein.
        * Wählen Sie den gewünschten Typ der **Verschlüsselung** aus.
        Wünschen Sie mehr Infos über die [URL-Verschlüsselung][4]?
    * CRMScript
        * Wählen Sie aus, welches **Skript** das Aufgabenmenü ausführen soll.
        Wünschen Sie mehr Infos über das [CRMScript][5]?
    * SOProtocol
        * Geben Sie die **SOProtocol** URL ein, zu der das Listenelement navigieren soll.
        Wünschen Sie mehr Infos über das [SOProtocol][6]?

1. Wählen Sie die Kontrollkästchen für die Stelle an, an welcher im Menüpunkt "Aufgabe" angezeigt werden soll.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Objekt ein. Lesen Sie mehr über die [Übersetzung][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Wenn Sie eine URL-Adresse hinzufügen, könnte es nützlich sein, Vorlagenvariablen für die aktive Firma zu verwenden, um zum Beispiel über eine URL Informationen von anderen Anwendungen abzurufen. Es müssen die URL-Adresse Parameter angegeben werden, wie in folgendem Beispiel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn ist die Vorlagenvariable für die Organisationsnummer, andere Variablen wie Firmenname &lt;name&gt;, Firmentelefonnummer &lt;cpho&gt; und Personenname &lt;attn&gt; können ebenfalls verwendet werden.

## Ist SuperOffice CRM for Web auf einer https-Seite installiert? (Vor Ort)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Verwandte Themen

* [Web-Bildschirm-Objekt hinzufügen][1]
* [Übersetzung hinzufügen][7]

<!-- Referenced links -->
[1]: ../../../customization/web-panels/admin/add-web-panel.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../customization/web-panels/admin/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/ui/soprotocol/index.md
[7]: ../../../localization/learn/translate-fields.md

<!-- Referenced images -->

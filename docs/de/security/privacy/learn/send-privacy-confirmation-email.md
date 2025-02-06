---
uid: help-de-send-privacy-confirmation-email
title: E-Mail zur Datenschutzbestätigung senden
description: E-Mail zur Datenschutzbestätigung senden
author: SuperOffice RnD
date: 02.21.2023
keywords: DSGVO, Einwilligung, E-Mail, Datenschutz
topic: howto
language: de
---

# E-Mail zur Datenschutzbestätigung senden

In der neuen DSGVO haben Einzelpersonen das "Recht auf Information". Das bedeutet, dass sie das Recht haben, entweder im Voraus oder innerhalb von 30 Tagen nach Erhebung ihrer Daten darüber informiert zu werden. Die DSGVO sieht vor, dass Einzelpersonen das Recht haben, darüber informiert zu werden, (a) dass eine Organisation beabsichtigt, ihre personenbezogenen Daten zu speichern, und (b) wofür die Organisation beabsichtigt, ihre Daten zu verwenden.

## Zustimmung im Voraus über Formulare einholen

Durch die Verwendung integrierter Formulare, die in Ihrer CRM-Lösung verfügbar sind, können Sie die Zustimmung einer Person einholen, während sie ein Web-Formular ausfüllt und Ihnen ihre persönlichen Daten mitteilt. Diese Einwilligung wird automatisch in SuperOffice CRM mit Hilfe der Einwilligungsmanagement-Funktionen dokumentiert.

Dieses Video zeigt Ihnen, wie Sie ein einfaches Web-Formular erstellen und zu Ihrer Webseite hinzufügen (Videolänge - 7:49):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

## Automatische E-Mail-Bestätigung senden

Mit SuperOffice CRM können Sie automatisch eine E-Mail für die Datenschutzbestätigung an Einzelpersonen senden, die in Ihrer Datenbank erfasst sind. Die E-Mail wird automatisch und ohne dass Sie etwas tun müssen an eine Person gesendet, wenn diese zum ersten Mal in SuperOffice erfasst wird.

Dies ist nicht nur eine höfliche Art, einen ersten Kontakt mit einem Kunden aufzunehmen, sondern bietet dieser Person auch eine einfache Möglichkeit, Fragen oder Einwände gegen Ihre Speicherung seiner Daten zu stellen bzw. vorzubringen.

Sie können das System mit einem Link konfigurieren, der zu einer persönlichen Abonnementseite führt. Unter diesem Link können Ihre Personen auswählen, welchen Art von Kommunikation sie erhalten möchten.

## Wie man erneut eine E-Mail als Datenschutzbestätigung sendet

Von der Ansicht Person können Sie einer Person erneut die E-Mail zur Datenschutzbestätigung senden.

[!include[Go to Contact screen](../../../learn/includes/goto-contact.md)]

1. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> und wählen Sie **E-Mail zur Datenschutzbestätigung senden**.

    ![Senden Sie eine Bestätigungs-E-Mail, um die Personen darüber zu informieren, dass ihre Informationen in Ihrer CRM-Datenbank gespeichert werden -screenshot][img2]

1. Im daraufhin angezeigten Dialogfeld füllen Sie die folgenden Felder aus:
    * **Senden an**: Verwenden Sie die Standard-E-Mail-Adresse oder wählen Sie eine andere Adresse aus.
    * **Vorlage verwenden**: Wählen Sie eine E-Mail-Vorlage aus.
    * **Sprache**: Wählen Sie die Standardsprache oder eine der verfügbaren Sprachen aus.
    * **Betreff**: Bearbeiten Sie gegebenenfalls den Standardbetreff der E-Mail.

1. Klicken Sie auf **Senden**.

Die Bestätigungs-E-Mail wird an die Person gesendet. Die E-Mail wird auf der Bereichsregisterkarte **Aktivitäten** archiviert.

## Was enthält diese E-Mail?

Die E-Mail zur Datenschutzbestätigung informiert die Person normalerweise über Folgendes:

* Ihre Daten wurden in SuperOffice gespeichert
* Welcher Typ von Informationen wurde gespeichert
* Wofür die Daten verwendet werden (Zweck)
* Möglichkeit zum Widerrufen der Einwilligung zu einem beliebigen Zeitpunkt
* Dass die Daten sicher gespeichert sind und nicht weitergegeben werden

Die E-Mail kann auch einen Link zu einem Kundenzentrum enthalten, wo die Person Abonnements und Einwilligung verwalten kann. Der Link ist standardmäßig 21 Tage gültig.

## Verwandt

* [Bearbeiten Sie die E-Mail der Datenschutzbestätigung unter Einstellungen und Verwaltung][1]

<!-- Referenced links -->
[1]: edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/security/confirmation-email.png
